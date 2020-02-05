using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoShop_Shared.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace AutoShop_Shared.Services
{
    public class BadgeService : IBadgeService
    {
        private readonly IRepository<Badge> _repository;
        private readonly AppSettings _settings;
        public BadgeService(IRepository<Badge> repo, IOptionsMonitor<AppSettings> settings)
        {
            //Ma variable privée = instance de k'injection de dépendance
            _repository = repo;
            _settings = settings.CurrentValue;
        }
        /// <summary>
        /// Renvoie tous les badges existants
        /// </summary>
        /// <returns></returns>
        public List<Badge> GetBadges()
        {
            List<Badge> badges = _repository.GetItems($"{_settings.Filepath}badge.json");
            return badges;
        }
        /// <summary>
        /// renvoie les badges filtres par title
        /// </summary>
        /// <param name="title">Titre du badge</param>
        /// <returns></returns>
        public List<Badge> GetBadge(string title)
        {
            List<Badge> badges = GetBadges();
            List<Badge> resbadges = badges.Where(q => q.Title.Equals(title)).ToList();
            return resbadges;
        }

        
    }
}
