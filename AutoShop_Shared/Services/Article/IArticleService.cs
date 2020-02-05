using System;
using System.Collections.Generic;
using System.Text;
using AutoShop_Shared.Models;

namespace AutoShop_Shared.Services
{
    public interface IArticleService
    {
        public List<Article> GetArticles();
        public List<Article> GetBadge(string nom);
    }
}
