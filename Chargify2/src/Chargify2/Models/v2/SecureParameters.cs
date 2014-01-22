using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class SecureParameters
    {
        public string api_id { get; set; }
        public string nonce { get; set; }
        public string signature { get; set; }
        public string mirror { get; set; }
        public string data { get; set; }
        public string timestamp { get; set; }
    }
}
