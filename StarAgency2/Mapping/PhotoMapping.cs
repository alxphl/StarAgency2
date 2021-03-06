﻿using FluentNHibernate.Mapping;
using StarAgency2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarAgency2.Mapping
{
    public class PhotoMapping : ClassMap<Photo>
    {
        public PhotoMapping()
        {
            Id(x => x.Id);
            Map(x => x.Path);
            References(x => x.ActorId).Column("ActorId").Cascade.All();
            Table("Photo");
        }
    }
}