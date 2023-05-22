using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShoppingCart.Domain
{
    public class Payment : EntityBase
    {
        public Payment()
        {
            Order = new Order();
        }
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public decimal OrderAmount { get; set; }
    }
}
