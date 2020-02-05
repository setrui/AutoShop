using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoShop_Shared.Models;
using AutoShop_Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_Web.Controllers
{
    public class UserController : Controller
    {

        List<Badge> badges = new List<Badge>();
        List<User> users = new List<User>();

        private readonly IUserService _userService;
        private readonly IBadgeService _badgeService;

        public UserController(IUserService u, IBadgeService b)
        {
            _userService = u;
            _badgeService = b;
        }

        public IActionResult Index()
        {
           
            List<User> users = _userService.GetUsers(25);
            //Chercher le contenu de l'objet badge de l'atribut ActiveBadge
            foreach (User user in users)
            {
                if (user.ActiveBadge != null)
                {
                    Badge bb = _badgeService.GetBadge(user.ActiveBadge.Title.ToString()).First();
                    user.ActiveBadge = bb;
                }
            }
            ViewData["title"] = "Titre de la page";
            return View(users);
        }
        public IActionResult Details(string id)
        {
            User user = _userService.GetUser(id);
            return View("Details",user);
        }
        public IActionResult Edit(string id)
        {
            User user = _userService.GetUser(id);
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            User user = _userService.GetUser(id);
            return View(user);
        }
    }
}