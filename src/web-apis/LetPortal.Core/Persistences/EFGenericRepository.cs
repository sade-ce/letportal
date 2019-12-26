﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LetPortal.Core.Persistences
{
    public class EFGenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        private readonly DbContext _context;

        public EFGenericRepository(DbContext context)
        {
            _context = context;
        }

        public Task AddAsync(T entity)
        {
            entity.Check();
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task AddBulkAsync(IEnumerable<T> entities)
        {
            foreach(var entity in entities)
            {
                entity.Check();
            }
            _context.Set<T>().AddRange(entities);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task<ComparisonResult> Compare(T comparedEntity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            var entity = _context.Set<T>().Where(a => a.Id == id).First();
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task DeleteBulkAsync(IEnumerable<string> ids)
        {
            var dbSet = _context.Set<T>();
            var entities = dbSet.Where(a => ids.Contains(a.Id));
            foreach(var entity in entities)
            {
                dbSet.Remove(entity);
            }
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task ForceUpdateAsync(string id, T forceEntity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null, bool isRequiredDiscriminator = false)
        {
            if(expression != null)
            {
                var entities = _context.Set<T>().Where(expression);
                return Task.FromResult(entities.AsEnumerable());
            }
            else
            {
                var entities = _context.Set<T>();
                return Task.FromResult(entities.AsEnumerable());
            }
        }

        public Task<IEnumerable<T>> GetAllByIdsAsync(IEnumerable<string> ids)
        {
            if(ids != null || ids.Any())
            {
                var entities = _context.Set<T>().Where(a => ids.Contains(a.Id));
                return Task.FromResult(entities.AsEnumerable());
            }
            return null;
        }

        public IQueryable<T> GetAsQueryable()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public Task<T> GetOneAsync(string id)
        {
            return Task.FromResult(_context.Set<T>().First(a => a.Id == id));
        }

        public Task<bool> IsExistAsync(Expression<Func<T, bool>> expression)
        {
            // We still got a problem EF Core for MySQL when using Any()
            // So that we keep using FirstOrDefault() for checking
            return Task.FromResult(_context.Set<T>().FirstOrDefault(expression) != null);
        }

        public Task UpdateAsync(string id, T entity)
        {
            entity.Check();
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
