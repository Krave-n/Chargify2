using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class SignupResponse
    {
        public SubscriptionResponse subscription { get; set; }
        public CustomerResponse customer { get; set; }
        public ProductResponse product { get; set; }
        public PaymentProfileResponse payment_profile { get; set; }
        public NextBillingManifest next_billing_manifest { get; set; }
    }
}
