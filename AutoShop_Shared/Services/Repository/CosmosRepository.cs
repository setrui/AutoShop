using System;
using System.Collections.Generic;
using System.Text;
using AutoShop_Shared.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Options;

namespace AutoShop_Shared.Services
{
    public class CosmosRepository<T> : IRepository<T>
    {
        private readonly Container _container;

        public CosmosRepository(IOptionsMonitor<AppSettings> settings)
        {
            AppSettings appSettings = settings.CurrentValue;
            CosmosClient client = new
                CosmosClient(appSettings.CosmosDBUrl, appSettings.CosmosDBKey);
            Database database = client.GetDatabase(appSettings.CosmosDatabase);
            _container = database.GetContainer(appSettings.CosmosContainer);

        }

        public List<T> GetItems(AppSettings settings)
        {
            string sqlQueryText = settings.QuerySelect + " " +settings.QueryWhere ;
            QueryDefinition queryDef = new QueryDefinition(sqlQueryText);

            FeedIterator<T> queryResult = _container.GetItemQueryIterator<T>(queryDef);
            List<T> results = new List<T>();
            while (queryResult.HasMoreResults)
            {
                FeedResponse<T> currentResultSet = queryResult.ReadNextAsync().GetAwaiter().GetResult();
                foreach (T item in currentResultSet)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
