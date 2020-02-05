using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoShop_Shared.Models;
using Newtonsoft.Json;




namespace AutoShop_Shared.Services
{
    public class ArticleService
    {
        private readonly IRepository<Article> _repository;
        public ArticleService(IRepository<Article> repo)
        {
            //Ma variable privée = instance de k'injection de dépendance
            _repository = repo;
        }
        public List<Article> GetArticles()
        {
            List<Article> articles = _repository.GetItems(@"C:\Users\campus\Source\Repos\AutoShop\AutoShop_Web\Files\article.json");
            return articles;
        }

        public List<Article> GetBadge(string nom)
        {
            List<Article> articles = GetArticles();
            List<Article> resarticles = articles.Where(q => q.Nom.Equals(nom)).ToList();
            return resarticles;
        }
    }
}
