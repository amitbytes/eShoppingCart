using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShoppingCart.Domain
{
    public class ProductCategory : EntityBase
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public int PromotionId { get; set; }
        public Promotion Promotion { get; set; }
    }
}
