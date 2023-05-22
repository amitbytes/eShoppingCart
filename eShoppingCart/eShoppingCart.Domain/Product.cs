using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShoppingCart.Domain
{
    public class Product : EntityBase
    {
        public int ProductId { get; set; }
        public string ProductNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal UnitPrice { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime SellEndDate { get; set; }
        public DateTime DiscontinueDate { get; set; }
        public string ProductPhoto { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public int PromotionId { get; set; }
        public Promotion Promotion { get; set; }
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
