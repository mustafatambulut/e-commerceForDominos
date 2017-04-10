using e_commerceForDominos.NhibernateMappingFile;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_commerceForDominos.NHibernateHelpers
{
    public class NHibernateSessionHelper
    {
        public static ISessionFactory GetHibernateSessionFactory() {
            var configuration = new Configuration();
            configuration.DataBaseIntegration(config => {
                config.Dialect<NHibernate.Dialect.MsSql2008Dialect>();
                config.Driver<NHibernate.Driver.Sql2008ClientDriver>();
                config.ConnectionStringName = "featureSearchConnectionString";
                config.ConnectionProvider<NHibernate.Connection.DriverConnectionProvider>();

            });

            configuration.CurrentSessionContext<WebSessionContext>();

            configuration.AddAssembly(typeof(Feature).Assembly);

            return configuration.BuildSessionFactory();
        }
    }
}