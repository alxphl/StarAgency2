using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarAgency2.Models
{
    public class Actor
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Biography { get; set; }
        public virtual string Gender { get; set; }
        public virtual IList<Photo> Files { get; set; }
        public virtual IList<Movie> Movies { get; set; }

   
    }
}