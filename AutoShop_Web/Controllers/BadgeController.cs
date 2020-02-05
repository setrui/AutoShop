using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoShop_Shared.Models;
using AutoShop_Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_Web.Controllers
{
    public class BadgeController : Controller
    {
        List<Badge> badges = new List<Badge>();

        private readonly IBadgeService _badgeService;

        public BadgeController(IBadgeService b)
        {
            _badgeService = b;
        }

        public IActionResult Index()
        {
            List<Badge> badges = _badgeService.GetBadges();
            //Badge badge = new Badge
            //{
            //    Title = "Over archivement",
            //    Label = "Overload these lasts times : 10x more products bought than usual !!!",
            //    Picture = "OverArchivement.png"
            //};
            //badges.Add(badge);
            //badge = new Badge
            //{
            //    Title = "Gost",
            //    Label = "Long time not seen, you moron è_é",
            //    Picture = "gost.png"
            //};
            //badges.Add(badge);
            //badge = new Badge
            //{
            //    Title = "Hardware Buyer",
            //    Label = "What are you gonna do with all these mics ?",
            //    Picture = "hardwareBuyer.png"
            //};
            //badges.Add(badge);


            return View(badges);
        }
    }
}