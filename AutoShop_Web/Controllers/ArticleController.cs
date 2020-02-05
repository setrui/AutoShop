using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoShop_Shared.Models;
using AutoShop_Shared.Services;

namespace AutoShop_Web.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        public ArticleController(IArticleService a)
        {
            _articleService = a;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}