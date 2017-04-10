using e_commerceForDominos.NhibernateMappingFile;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_commerceForDominos.DataAccessLayer
{
    public class FeatureDoaImpl : DaoProviderBase<Feature,  long>,IFeatureDao
    {


        public void saveFeature(Feature f) {

            //_currentNhibernateSession.SaveOrUpdate(f);
           

            IQuery q = _currentNhibernateSession.CreateSQLQuery("INSERT INTO Feature VALUES(?, ?)");
            q.SetString(0, f.USER_NAME).SetString(1, f.PASSWORD).ExecuteUpdate();
      

        }

        public List<Feature> login(string userName, string password)
        {
            //IQuery q = _currentNhibernateSession.CreateQuery("from Feature where USER_NAME = @username and PASSWORD = @password");
            //q.SetParameter("username", userName);
            //q.SetParameter("password", password);
            IQuery q = _currentNhibernateSession.CreateSQLQuery("select * from Feature where USER_NAME = '" + userName + "' and PASSWORD = '" + password + "'");
            Feature f = q.SetResultTransformer(Transformers.AliasToBean<Feature>()).UniqueResult<Feature>();

            //ICriteria c = _currentNhibernateSession.CreateCriteria<Feature>();
            //c.Add(Expression.Eq("USER_NAME", userName));
            // c.Add(Expression.Eq("PASSWORD", password));

            //Feature f= c.List<Feature>();


            List<Feature> list = new List<Feature>();
            if (f != null)
            {
                list.Add(f);
            }

            return list;


            //ICriteria c = session.CreateCriteria();
            //c.Add(Expression.Eq("Price", 500));
            //return c.UniqueResult<Product>();

        }





        public List<string> GetAllUs()
        {

            ICriteria searchCriteria = base._currentNhibernateSession.CreateCriteria(typeof(Feature));

            searchCriteria.SetProjection(Projections.Distinct(Projections.Property("USER_NAME")));

            var list = searchCriteria.List();

            return list.Cast<string>().ToList();
        }


        public List<string> GetCountiesByStateName()
        {
            return null;
        }


    }
}