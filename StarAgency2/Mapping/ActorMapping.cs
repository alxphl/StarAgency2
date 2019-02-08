using FluentNHibernate.Mapping;
using StarAgency2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarAgency2.Mapping
{
    public class ActorMapping : ClassMap<Actor>
    {
        public ActorMapping()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Biography);
            Map(x => x.Gender);
            HasMany(x => x.Files).KeyColumn("Id");
            HasMany(x => x.Movies).KeyColumn("Id");
            Table("Actor");
        }
    }
}