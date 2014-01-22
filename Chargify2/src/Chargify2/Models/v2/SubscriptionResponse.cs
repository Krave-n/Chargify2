using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    public class SubscriptionResponse
    {
        public DateTime? updated_at { get; set; }
        public int? signup_payment_id { get; set; }
        public int? customer_id { get; set; }
        public DateTime? expires_at { get; set; }
        public bool? cancel_at_end_of_period { get; set; }
        public DateTime? activated_at { get; set; }
        public DateTime? trial_started_at { get; set; }
        public int? balance_in_cents { get; set; }
        public string previous_state { get; set; }
        public DateTime? current_period_ends_at { get; set; }
        public string cancellation_message { get; set; }
        public int? payment_profile_id { get; set; }
        public DateTime? delayed_cancel_at { get; set; }
        public string state { get; set; }
        public DateTime? trial_ended_at { get; set; }
        public DateTime? next_assessment_at { get; set; }
        public DateTime? created_at { get; set; }
        public int? id { get; set; }
        public DateTime? canceled_at { get; set; }
        public int? product_id { get; set; }
        public string signup_revenue { get; set; }
        public DateTime? current_period_started_at { get; set; }
    }
}
