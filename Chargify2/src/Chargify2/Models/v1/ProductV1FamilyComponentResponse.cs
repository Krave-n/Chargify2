using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class ProductV1FamilyComponentResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string unit_name { get; set; }
        public double? unit_price { get; set; }
        public string pricing_scheme { get; set; }
        public List<PriceV1> prices { get; set; }
        public int product_family_id { get; set; }
        public string kind { get; set; } //should Type
        //public int? price_per_unit_in_cents { get; set; } //Deprecated
        public bool archived { get; set; }
    }
}

