using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarAgency2.Models
{
    public class File
    {
        public virtual int Id { get; set; }
        public virtual string Path { get; set; }
        public virtual Actor ActorId { get; set; }
    }
}