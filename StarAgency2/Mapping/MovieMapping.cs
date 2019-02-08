using FluentNHibernate.Mapping;
using StarAgency2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarAgency2.Mapping
{
    public class MovieMapping : ClassMap<Movie>
    {
        public MovieMapping()
        {
            Id(x => x.Id);
            Map(x => x.Link);
            Map(x => x.Year);
            Map(x => x.Name);
            References(x => x.ActorId).Column("ActorId").Cascade.All();
            Table("Movie");
        }
    }
}