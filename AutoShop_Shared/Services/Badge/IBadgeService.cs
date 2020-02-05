using System;
using System.Collections.Generic;
using System.Text;
using AutoShop_Shared.Models;


namespace AutoShop_Shared.Services
{
    public interface IBadgeService
    {
        public List<Badge> GetBadges();
        public List<Badge> GetBadge(string title);
    }
}
