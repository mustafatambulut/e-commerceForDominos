using e_commerceForDominos.DataAccessLayer;
using e_commerceForDominos.NhibernateMappingFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e_commerceForDominos.Controllers
{
    public class UserOrderController : Controller
    {
        // GET: UserOrder
        public ActionResult Index()
        {
            return View();
        }



        private IUserOrderDao userOrderDao;

        public UserOrderController()
        {
            userOrderDao = new UserOrderDaoImpl();
        }


        public void saveOrder(int user_id,int product_id,float order_amount)
        {
            UserOrder o = new UserOrder();
            o.USER_ID = user_id;
            o.PRODUCT_ID = product_id;
            o.ORDER_AMOUNT = order_amount;
            userOrderDao.saveOrder(o);
        }

        public void deleteOrder(int user_id)
        {
            UserOrder o = new UserOrder();
            o.USER_ORDER_ID = user_id;

            userOrderDao.deleteOrder(o);
        }

        public List<UserOrder> getOrders(int user_id)
        {
            UserOrder o = new UserOrder();
            o.USER_ID = user_id;

            return userOrderDao.getOrders(o);
        }

        public JsonResult countOrder(int user_id)
        {
            UserOrder o = new UserOrder();
            o.USER_ID = user_id;
            List<UserOrder> count = userOrderDao.getOrders(o);
            return Json(count, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getOrderView(int user_id) {

            UserOrder o = new UserOrder();
            o.USER_ID = user_id;
            List<UserOrder> order = userOrderDao.getOrders(o);

            return Json(order, JsonRequestBehavior.AllowGet);

        }




    }
}