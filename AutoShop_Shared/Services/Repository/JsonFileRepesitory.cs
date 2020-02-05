using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AutoShop_Shared.Models;


namespace AutoShop_Shared.Services
{
    public class JsonFileRepesitory<T> : IRepository<T>
    {
        public List<T> GetItems(AppSettings settings)
        {
            AppSettings appSettings = settings.CurrentValue;
            string result = System.IO.File.ReadAllText(appSettings.filepath);
            List<T> items = JsonConvert.DeserializeObject<List<T>>(result);
            return items;
        }
    }
}
