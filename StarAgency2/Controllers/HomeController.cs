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
                /*  IQuery query = session.CreateQuery(
                      "SELECT File.Id,File.Path"
                      + "Actor.Id,Actor.Name" +
                      "FROM Actor actor"+

                      "ORDER BY actor.Name, file.Path"
                  );
                  var lst = query.List<Object[]>();*/
                var actor = session.Query<Actor>().ToList();
                var files = session.Query<File>();
                ViewBag.Files = files;

                return View(actor);

            }



    



        }

        public ActionResult Actors()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (session.BeginTransaction())
            {
                var actor = session.Query<Actor>().Where(x=>x.Gender=="m").ToList();
                var files = session.Query<File>();
                ViewBag.Files = files;

                return View(actor);
            }



        }

        public ActionResult Actress()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (session.BeginTransaction())
            {
                var actor = session.Query<Actor>().Where(x => x.Gender == "f").ToList();
                var files = session.Query<File>();
                ViewBag.Files = files;

                return View(actor);
            }


        }

        public ActionResult Contact()
        {
            return View();

        }
    }
}