using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class Response
    {
        public Result result { get; set; }
        public SignupResponse signup { get; set; }
        public Meta meta { get; set; }
    }
}
