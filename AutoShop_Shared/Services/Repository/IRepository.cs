using AutoShop_Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop_Shared.Services
{
    public interface IRepository<T>
    {
        public List<T> GetItems(AppSettings settings);
    }
}
