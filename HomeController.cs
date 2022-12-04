using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ado.netmvcAssignment.Models;

namespace Ado.netmvcAssignment.Controllers
{
    public class HomeController : Controller
    {
        MyDbContext context=new MyDbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(context.FootBallLeague);
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult AddMatchResult(FootballLeague a)
        {
            context.FootBallLeague.Add(a);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}