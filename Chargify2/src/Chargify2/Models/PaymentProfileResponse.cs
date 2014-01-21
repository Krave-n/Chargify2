using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class PaymentProfileResponse
    {
        public DateTime? updated_at { get; set; }
        public string current_vault { get; set; }
        public int? expiration_month { get; set; }
        public string billing_city { get; set; }
        public string customer_vault_token { get; set; }
        public int? customer_id { get; set; }
        public string vault_token { get; set; }
        public string first_name { get; set; }
        public string billing_address_2 { get; set; }
        public string billing_country { get; set; }
        public string billing_state { get; set; }
        public string card_type { get; set; }
        public string billing_address { get; set; }
        public string last_name { get; set; }
        public DateTime? created_at { get; set; }
        public int? id { get; set; }
        public string billing_zip { get; set; }
        public string masked_card_number { get; set; }
        public int? expiration_year { get; set; }
    }
}
