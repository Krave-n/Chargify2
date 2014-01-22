using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class PriceV1
    {
        public int? starting_quantity { get; set; }
        public int? ending_quantity { get; set; }
        public double? unit_price { get; set; }
    }
}
