using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class LineItem
    {
        public int? amount_in_cents { get; set; }
        public string kind { get; set; }
        public int? discount_amount_in_cents { get; set; }
        public int? taxable_amount_in_cents { get; set; }
        public string memo { get; set; }
        public string transaction_type { get; set; }
        public int? component_id { get; set; }
    }
}
