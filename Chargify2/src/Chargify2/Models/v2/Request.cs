using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class Request
    {
        public SignupRequest signup { get; set; }
        public SecureParameters secure { get; set; }
    }
}
