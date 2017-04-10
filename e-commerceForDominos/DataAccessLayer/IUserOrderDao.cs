using e_commerceForDominos.NhibernateMappingFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerceForDominos.DataAccessLayer
{
    interface IUserOrderDao
    {
        void saveOrder(UserOrder o);

        void deleteOrder(UserOrder o);

        List<UserOrder> getOrders(UserOrder o);

    }
}
