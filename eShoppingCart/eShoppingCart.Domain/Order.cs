using eShoppingCart.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShoppingCart.Domain
{
    public class Order : EntityBase
    {
        public Order()
        {
            Customer = new Customer();
            Payment = new Payment();
        }
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueDate { get; set; }
        public OrderTypeEnum OrderType { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public decimal SubTotal { get; set; }
        public decimal OrderDiscount { get; set; }
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
