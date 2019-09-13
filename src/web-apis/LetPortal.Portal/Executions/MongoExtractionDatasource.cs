﻿using LetPortal.Core.Persistences;
using LetPortal.Core.Utils;
using LetPortal.Portal.Entities.Databases;
using LetPortal.Portal.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetPortal.Portal.Executions
{
    public class MongoExtractionDatasource : IExtractionDatasource
    {
        public ConnectionType ConnectionType => ConnectionType.MongoDB;

        public async Task<List<DatasourceModel>> ExtractionDatasource(
            DatabaseConnection databaseConnection,
            string formattedQueryString,
            string outputProjection)
        {

            List<DatasourceModel> datasourceModels = null;
            JObject parsingObject = JObject.Parse(formattedQueryString);

            var collectionName = parsingObject.Properties().Select(a => a.Name).First();

            var mongoCollection = new MongoClient(databaseConnection.ConnectionString).GetDatabase(databaseConnection.DataSource).GetCollection<BsonDocument>(collectionName);

            string collectionQuery = parsingObject[collectionName].ToString(Newtonsoft.Json.Formatting.Indented);

            FilterDefinition<BsonDocument> collectionQueryBson = BsonDocument.Parse(collectionQuery);

            // For ex: the datasource json body should contain the WHERE clause, and returned value will be projected by OutputProjection
            // "apps" : { "id": "a" }
            // OutputProjection: "name=id;value=displayname 
            // Result: { "name": a, "value": "1234" }

            IAggregateFluent<BsonDocument> aggregateFluent = mongoCollection.Aggregate();
            aggregateFluent = aggregateFluent.Match(collectionQueryBson);

            bool hasProjection = !string.IsNullOrEmpty(outputProjection);
            if(hasProjection)
            {
                var outputSplitted =
                hasProjection ?
                    outputProjection.Split(";") : new string[] { };
                BsonDocument projectDoc = new BsonDocument();
                foreach(var split in outputSplitted)
                {
                    var arrays = split.Split("=");
                    projectDoc.Add(new BsonElement(arrays[0], "$" + arrays[1]));
                }

                aggregateFluent = aggregateFluent.Project(projectDoc);
            }
            using(IAsyncCursor<BsonDocument> executingCursor = await aggregateFluent.ToCursorAsync())
            {
                while(executingCursor.MoveNext())
                {
                    IEnumerable<BsonDocument> currentDocument = executingCursor.Current;

                    datasourceModels = ConvertUtil.DeserializeObject<List<DatasourceModel>>(currentDocument.ToJson());
                }
            }

            return datasourceModels;
        }
    }
}
