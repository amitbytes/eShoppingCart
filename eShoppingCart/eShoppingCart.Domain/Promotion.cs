using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShoppingCart.Domain
{
    public class Promotion
    {
        public int PromotionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal PromotionDiscount { get; set; }
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public ICollection<ProductCategory> ProductCategories { get; set; } = new HashSet<ProductCategory>();
    }
}
