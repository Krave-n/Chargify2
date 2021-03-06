﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class CustomerResponse
    {
        public string organization { get; set; }
        public string updated_at { get; set; }
        public string address_2 { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string city { get; set; }
        public string first_name { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string last_name { get; set; }
        public DateTime? created_at { get; set; }
        public string phone { get; set; }
        public int? id { get; set; }
        public string reference { get; set; }
        public string zip { get; set; }
    }
}
