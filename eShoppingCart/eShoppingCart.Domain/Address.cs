using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShoppingCart.Domain
{
    public class Address : EntityBase
    {
        public int AddressId { get; set; }
        public string FullName { get; set; }
        public string MobileNumber { get; set; }
        public int PinCode { get; set; }
        public string HouseDetail { get; set; }
        public string AreaDetail { get; set; }
        public string LandMarkDetail { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public bool IsDefaultAddress { get; set; }
        public AddressTypeEnum AddressType { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
