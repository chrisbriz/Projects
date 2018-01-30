using CoolBooksFinal.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace CoolBooks.Controllers
{
    public class HomeController : Controller
    {
        private CoolBooksModel db = new CoolBooksModel();

        public ActionResult Index()
        {

            var books = db.Books.OrderBy(b => Guid.NewGuid()).FirstOrDefault();
            ViewData["booklist"] = books;
            if (books != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Register", "Account");
            }
            

            
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

        public ActionResult Books()
        {
            return View();
        }
    }
}