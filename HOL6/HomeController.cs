using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HandsOnLab6.Models;

namespace HandsOnLab6.Controllers
{
    public class HomeController : Controller
    {
        static List<User> users = new List<User>();
        public ActionResult GetAllUsers()
        {
            return PartialView(users);
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetServerTime()
        {
            System.Threading.Thread.Sleep(5000);
            return PartialView();
        }
        public ActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUser(User u)
        {
            users.Add(u);
            return RedirectToAction("GetAllUsers");
        }



    }
}