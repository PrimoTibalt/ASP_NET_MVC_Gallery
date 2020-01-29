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

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Show()
        {
            return View("Show");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Show(Photo ph)
        {
            using (MyContext context = new MyContext())
            {
                context.Photoes.Add(ph);
                context.SaveChanges();
            }

            this.Index();
            return View("Index");
        }
    }
}