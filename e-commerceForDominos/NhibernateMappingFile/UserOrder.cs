using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_commerceForDominos.NhibernateMappingFile
{
    public class UserOrder
    {
        public virtual Int64 USER_ORDER_ID { get; set; }
        public virtual Int64 USER_ID { get; set; }
        public virtual Int64 PRODUCT_ID { get; set; }
        public virtual Int64 STATE { get; set; }
        public virtual double ORDER_AMOUNT { get; set; }

    }
}