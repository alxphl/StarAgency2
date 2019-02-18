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
            using (var session = NHibernateHelper.OpenSession())
            using (session.BeginTransaction())
            {
                var actor = session.Query<Actor>().ToList();
                return View(actor);
            }
        }

        public ActionResult Actors()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (session.BeginTransaction())
            {
                var actor = session.Query<Actor>().Where(x=>x.Gender=="m").ToList();
                return View(actor);
            }
        }

        public ActionResult Actress()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (session.BeginTransaction())
            {
                var actor = session.Query<Actor>().Where(x => x.Gender == "f").ToList();
                return View(actor);
            }

        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}