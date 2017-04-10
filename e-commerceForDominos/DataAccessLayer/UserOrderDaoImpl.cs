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
    public class UserOrderDaoImpl : DaoProviderBase<UserOrder, long>, IUserOrderDao
    {
        public void deleteOrder(UserOrder o)
        {
            //IQuery q = _currentNhibernateSession.CreateSQLQuery("INSERT INTO Feature VALUES(?, ?)");
            //q.SetString(0, f.USER_NAME).SetString(1, f.PASSWORD).ExecuteUpdate();
            IQuery q = _currentNhibernateSession.CreateSQLQuery("DELETE FROM USERORDER WHERE USER_ORDER_ID = ?");
            q.SetInt64(0, o.USER_ORDER_ID).ExecuteUpdate();

        }

        public List<UserOrder> getOrders(UserOrder o)
        {
            //ISQLQuery q = _currentNhibernateSession.CreateSQLQuery("SELECT * FROM USERORDER WHERE USER_ID = " + o.USER_ID + " AND STATE = 0");
            //UserOrder f = q.SetResultTransformer(Transformers.AliasToBean<UserOrder>()).UniqueResult<UserOrder>();


            ISQLQuery query = _currentNhibernateSession.CreateSQLQuery("SELECT * FROM USERORDER WHERE USER_ID = " + o.USER_ID + " AND STATE = 0");
            List<UserOrder> f = (List<UserOrder>)query.SetResultTransformer(Transformers.AliasToBean<UserOrder>()).List<UserOrder>();
        

        /*
        ICriteria c = _currentNhibernateSession.CreateCriteria<UserOrder>();
        c.Add(Expression.Eq("Price", 500));
        return c.UniqueResult<UserOrder>();
        */


        //List<UserOrder> list = new List<UserOrder>();
        //    if (f != null)
        //    {
        //        list.Add(f);
        //    }

            return f;
        }

        public void saveOrder(UserOrder o)
        {
            IQuery q = _currentNhibernateSession.CreateSQLQuery("INSERT INTO USERORDER VALUES(?, ?, 0, Round(?,2))");
            q.SetInt64(0, o.USER_ID).SetInt64(1, o.PRODUCT_ID).SetDouble(2, o.ORDER_AMOUNT).ExecuteUpdate();
            //throw new NotImplementedException();
        }
    }
}