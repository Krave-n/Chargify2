using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class SignupRequest
    {
        public ProductRequest product { get; set; }
        public CustomerRequest customer { get; set; }
        public PaymentProfileRequest payment_profile { get; set; }
        public Dictionary<string, object> components { get; set; }
    }
}
