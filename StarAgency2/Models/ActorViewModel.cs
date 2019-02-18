using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarAgency2.Models
{
    public class ActorViewModel
    {
        public string Name { get; set; }
        public string Biography { get; set; }
        public IList<Movie> Movies { get; set; }
        public IList<Photo> Files { get; set; }
    }
}