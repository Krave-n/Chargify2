using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class Call
    {
        public string api_id { get; set; }
        public int? timestamp { get; set; }
        public bool success { get; set; }
        public Request request { get; set; }
        public Response response { get; set; }
        public string nonce { get; set; }
        public string id { get; set; }

        public bool isSuccessful
        {
            get { return this.response.result.status_code == "200"; }
        }

        public List<Error> Errors
        {
            get
            {
                return response.result.errors;
            }
        }
    }
}
