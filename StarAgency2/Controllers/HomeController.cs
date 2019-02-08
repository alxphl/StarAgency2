using NHibernate;
using StarAgency2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate.Mapping;
using NHibernate.Cfg;


namespace StarAgency2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


           

            return View();



        }

        public ActionResult Actors()
        {
            return View();

        }

        public ActionResult Actress()
        {
            return View();

        }
     
        public ActionResult Contact()
        {
            return View();

        }
    }
}