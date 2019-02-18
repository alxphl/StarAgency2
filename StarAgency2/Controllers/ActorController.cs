using StarAgency2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using Remotion.Linq.Clauses;

namespace StarAgency2.Controllers
{
    public class ActorController : Controller
    {
     

 
        public ActionResult Details(int id)
        { 
            using (var session = NHibernateHelper.OpenSession())
            using (session.BeginTransaction())
            {
                var actor = session.Query<Actor>().Where(x=>x.Id==id).ToList();
                var movies = session.Query<Movie>().Where(x => x.ActorId.Id == id).OrderByDescending(x=>x.Year).ToList();
                var files = session.Query<Photo>().Where(x => x.ActorId.Id == id).ToList();
                ActorViewModel avm = new ActorViewModel();
                avm.Name = actor[0].Name;
                avm.Biography = actor[0].Biography;
                avm.Movies = session.Query<Movie>().Where(x => x.ActorId.Id == id).OrderByDescending(x => x.Year).ToList();
                avm.Files = files;
                return View(avm);
            };
        }
    
     

        public ActionResult Search(string name)
        {
                using (var session = NHibernateHelper.OpenSession())
                using (session.BeginTransaction())
                {
                    var actor = session.Query<Actor>().Where(x => x.Name == name).ToList();
                    var movies = session.Query<Movie>().Where(x => x.ActorId == actor[0]).OrderByDescending(x => x.Year).ToList();
                    ActorViewModel avm = new ActorViewModel();
                    avm.Name = actor[0].Name;
                    avm.Biography = actor[0].Biography;
                    avm.Movies = movies;
                    avm.Files = session.Query<Photo>().Where(x => x.ActorId.Id == actor[0].Id).ToList();
                    return View(avm);
                }
        }
    }
}
