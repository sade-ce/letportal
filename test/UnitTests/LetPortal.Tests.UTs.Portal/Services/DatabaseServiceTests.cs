using LetPortal.Portal.Executions;
using LetPortal.Portal.Models;
using LetPortal.Portal.Models.Databases;
using LetPortal.Portal.Services.Databases;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace LetPortal.Tests.UTs.Portal.Services
{
    public class DatabaseServiceTests
    {
        [Fact]
        public async Task Execute_Dynamic_Command_In_Mongo_Test()
        {
            // Arrange
            var mongoExecutionDatabaseMock = new Mock<IExecutionDatabase>();
            mongoExecutionDatabaseMock.Setup(a => a.ConnectionType).Returns(Core.Persistences.ConnectionType.MongoDB);
            mongoExecutionDatabaseMock
                .Setup(a => a.Execute(It.IsAny<object>(), It.IsAny<string>()))
                .Returns(Task.FromResult(new ExecuteDynamicResultModel
                {
                    IsSuccess = true,
                    Result = "A"
                }));

            var databaseService = new DatabaseService(new IExecutionDatabase[] { mongoExecutionDatabaseMock.Object }, null);

            // Act
            var result = await databaseService.ExecuteDynamic(new LetPortal.Portal.Entities.Databases.DatabaseConnection
            {
                ConnectionString = "mongodb://localhost:27017",
                DatabaseConnectionType = "mongodb",
                DataSource = "letportal"
            }, "");

            // Assert
            Assert.True(result.IsSuccess);
        }

        [Fact]
        public async Task Extract_Columns_In_Mongo_Test()
        {
            // Arrange
            var mongoExtractionDatabaseMock = new Mock<IExtractionDatabase>();
            mongoExtractionDatabaseMock.Setup(a => a.ConnectionType).Returns(Core.Persistences.ConnectionType.MongoDB);
            mongoExtractionDatabaseMock
                .Setup(a => a.Extract(It.IsAny<object>(), It.IsAny<string>()))
                .Returns(Task.FromResult(new ExtractingSchemaQueryModel
                {
                    ColumnFields = new System.Collections.Generic.List<LetPortal.Portal.Models.Shared.ColumnField>
                    {
                        new LetPortal.Portal.Models.Shared.ColumnField
                        {
                            Name = "A",
                            DisplayName = "A",
                            FieldType ="a"
                        }
                    }
                }));

            var databaseService = new DatabaseService(null, new IExtractionDatabase[] { mongoExtractionDatabaseMock.Object });

            // Act
            var result = await databaseService.ExtractColumnSchema(new LetPortal.Portal.Entities.Databases.DatabaseConnection
            {
                ConnectionString = "mongodb://localhost:27017",
                DatabaseConnectionType = "mongodb",
                DataSource = "letportal"
            }, "");

            // Assert
            Assert.True(result.ColumnFields.Count > 0);
        }
    }
}
