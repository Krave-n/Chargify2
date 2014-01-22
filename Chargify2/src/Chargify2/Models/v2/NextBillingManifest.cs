using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class NextBillingManifest
    {
        public string period_type { get; set; }
        public int? subtotal_in_cents { get; set; }
        public int? total_tax_in_cents { get; set; }
        public int? total_in_cents { get; set; }
        public List<LineItem> line_items { get; set; }
        public string end_date { get; set; }
        public string start_date { get; set; }
        public int? total_discount_in_cents { get; set; }
    }
}
