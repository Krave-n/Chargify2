using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class ProductResponse
    {
        public DateTime? updated_at { get; set; }
        public string name { get; set; }
        public string trial_interval_unit { get; set; }
        public string description { get; set; }
        public string expiration_interval { get; set; }
        public int? product_family_id { get; set; }
        public string handle { get; set; }
        public DateTime? archived_at { get; set; }
        public string return_params { get; set; }
        public int? initial_charge_in_cents { get; set; }
        public string accounting_code { get; set; }
        public string interval_unit { get; set; }
        public DateTime? created_at { get; set; }
        public int? id { get; set; }
        public string return_url { get; set; }
        public int? trial_interval { get; set; }
        public bool require_credit_card { get; set; }
        public bool request_credit_card { get; set; }
        public string expiration_interval_unit { get; set; }
        public int? interval { get; set; }
        public int? price_in_cents { get; set; }
        public int? trial_price_in_cents { get; set; }
    }
}
