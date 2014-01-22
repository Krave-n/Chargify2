using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class PaymentProfileRequest
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string card_number { get; set; }
        public string expiration_month { get; set; }
        public string expiration_year { get; set; }
        public string cvv { get; set; }
        public string billing_address { get; set; }
        public string billing_address_2 { get; set; }
        public string billing_city { get; set; }
        public string billing_state { get; set; }
        public string billing_country { get; set; }
        public string billing_zip { get; set; }
    }
}
