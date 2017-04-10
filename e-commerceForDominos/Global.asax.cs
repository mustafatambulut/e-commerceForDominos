using e_commerceForDominos.NHibernateHelpers;
using NHibernate;
using NHibernate.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace e_commerceForDominos
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static ISessionFactory NHibernateSessionFactory;
        public override void Init()
        {
            this.BeginRequest += (sender, e) =>
            {
                var session = NHibernateSessionFactory.OpenSession();
                CurrentSessionContext.Bind(session);
            };

            this.EndRequest += (sender, e) =>
            {
                var session = CurrentSessionContext.Unbind(NHibernateSessionFactory);

                session.Dispose();
            };
            base.Init();
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            NHibernateSessionFactory = NHibernateHelpers.NHibernateSessionHelper.GetHibernateSessionFactory();
        }
    }
}
