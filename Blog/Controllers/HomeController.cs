using System;
using Blog.Models;
using Blog.ViewModels;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        BDbContainer Db = new BDbContainer(); 
        public ActionResult Index()
        {       
            var model = new HomeIndex();
            model.Articles = Db.Article.Take(6).ToList();
            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Gallery()
        {
            var model = new Gallery ();
            model.Photos = Db.Photos.ToList();
            return View(model);
        }
        [HttpGet]
        public ActionResult Articles()
        {
            var model = new HomeArticles();
            model.Articles = Db.Article.ToList();
            return View(model);
        }

    }
}