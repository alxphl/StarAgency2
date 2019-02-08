using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarAgency2.Models
{
    public class NHibernateHelper
    {
        public static ISession OpenSession()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                    .ConnectionString(@"Data Source=ALP-WS;Initial Catalog=StarAgency2;Integrated Security=True")
                    .ShowSql()
                )
                .Mappings(m =>
                    m.FluentMappings
                        .AddFromAssemblyOf<Actor>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                    .Create(false, false))
                .BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}