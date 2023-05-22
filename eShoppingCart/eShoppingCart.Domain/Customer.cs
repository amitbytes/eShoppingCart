using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShoppingCart.Domain
{
    public class Customer : EntityBase
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
