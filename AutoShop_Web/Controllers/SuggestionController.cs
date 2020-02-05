using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoShop_Shared.Models;

namespace AutoShop_Web.Controllers
{
    public class SuggestionController : Controller
    {
        public ActionResult Index()
        {
            Suggestion s = new Suggestion();
            s.Title = "Suggestion 1";
            Suggestion s2 = new Suggestion();
            s2.Title = "Suggestion 2";
            Suggestion s3 = new Suggestion();
            s3.Title = "Suggestion 3";

            List<Suggestion> liste = new List<Suggestion>();
            liste.Add(s);
            liste.Add(s2);
            liste.Add(s3);
            return View(liste);
        }
    }
}
