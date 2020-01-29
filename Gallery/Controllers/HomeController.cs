using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gallery.Models;
using Gallery.DAL;

namespace Gallery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (MyContext context = new MyContext())
            {
                ViewBag.Photoes = context.Photoes.ToList();
                context.SaveChanges();
            }

            Console.WriteLine(ViewBag.Photoes.Count);
            Console.ReadLine();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Show()
        {
            Photo ph = new Photo("Clouds", @"https://i.artfile.me/wallpaper/06-10-2017/1920x1080/priroda-oblaka-clouds-nebo-sky-1244838.jpg");
            Photo ph0 = new Photo("Clouds", @"https://www.tokkoro.com/picsup/5767333-clouds-wallpapers.jpg");
            using (MyContext context = new MyContext())
            {
                context.Photoes.Add(ph);
                context.Photoes.Add(ph0);
                context.SaveChanges();
            }
            return View("Show", ph);
        }
    }
}