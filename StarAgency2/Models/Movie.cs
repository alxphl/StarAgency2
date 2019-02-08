using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarAgency2.Models
{
    public class Movie
    {
        public virtual int Id { get; set; }
        public virtual string Link { get; set; }
        public virtual Actor ActorId { get; set; }
        public virtual int Year { get; set; }
        public virtual string Name { get; set; }
    }
}