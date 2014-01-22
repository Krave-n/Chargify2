using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class Result
    {
        public string result_code { get; set; }
        public string status_code { get; set; }
        public List<Error> errors { get; set; }
    }
}
