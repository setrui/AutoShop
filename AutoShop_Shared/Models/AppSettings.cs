using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop_Shared.Models
{
    public class AppSettings
    {
        public string Filepath { get; set; }
        public string CosmosDBUrl { get; internal set; }
        public CosmosClientOptions CosmosDBKey { get; internal set; }
        public string CosmosDatabase { get; internal set; }
        public string CosmosContainer { get; internal set; }
        public string QuerySelect { get; internal set; }
        public string QueryWhere { get; internal set; }
    }
}
