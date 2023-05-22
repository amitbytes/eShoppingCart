using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShoppingCart.Domain
{
    public enum AddressTypeEnum
    {
        [Description("House")]
        House = 1,
        [Description("Apartment/Building/Flat")]
        Apartment = 2,
        [Description("Business/Office")]
        Business = 3,
        [Description("Other")]
        Other = 4
    }
}
