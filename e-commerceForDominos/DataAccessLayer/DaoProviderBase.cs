using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_commerceForDominos.DataAccessLayer
{
    public abstract class DaoProviderBase<T, V> : IDaoProvider<T, V> where T : new ()
                                         where V : struct
    {
        protected readonly ISession _currentNhibernateSession;
        protected DaoProviderBase() {
            _currentNhibernateSession = e_commerceForDominos.MvcApplication.NHibernateSessionFactory.GetCurrentSession();
        }
        public T Create<T>(T t)
        {
            using (ITransaction transaction = this._currentNhibernateSession.BeginTransaction()) {
                this._currentNhibernateSession.Save(t);
                transaction.Commit();
            }

            return t;
        }

        public T[] GetAll<T>() {
            var icriteria = this._currentNhibernateSession.CreateCriteria(typeof(T));

            return icriteria.List<T>().ToArray();
        }

        public T GetObjectById(V v)
        {
            return (T) this._currentNhibernateSession.Load(typeof(T), v);
        }

        public void Update(T t)
        {
            using (ITransaction transaction = this._currentNhibernateSession.BeginTransaction())
            {
                this._currentNhibernateSession.SaveOrUpdate(t);
                transaction.Commit();
            }
        }
    }
}