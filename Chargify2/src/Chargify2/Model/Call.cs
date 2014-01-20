﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargify2.Model
{
    /// <summary>
    /// Generated with http://json2csharp.com/ based on the return of a single call
    /// </summary>
    #region Json2Class Generated

    public class Product
    {
        public string id { get; set; }
        public string handle { get; set; }
    }

    public class PaymentProfile
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

    public class Customer
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string organization { get; set; }
        public string reference { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zip { get; set; }
    }

    public class Signup
    {
        public Product product { get; set; }
        public Customer customer { get; set; }
        public PaymentProfile payment_profile { get; set; }
        public Dictionary<string, object> components { get; set; }
    }

    public class Secure
    {
        public string api_id { get; set; }
        public string nonce { get; set; }
        public string signature { get; set; }
        public string mirror { get; set; }
        public string data { get; set; }
        public string timestamp { get; set; }
    }

    public class Request
    {
        public Signup signup { get; set; }
        public Secure secure { get; set; }
    }

    public class Result
    {
        public string result_code { get; set; }
        public string status_code { get; set; }
        public List<Error> errors { get; set; }
    }

    public class Error
    {
        public string attribute { get; set; }
        public string message { get; set; }
    }

    public class Subscription
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

    public class Product2
    {
        public DateTime? updated_at { get; set; }
        public string name { get; set; }
        public string trial_interval_unit { get; set; }
        public string description { get; set; }
        public string expiration_interval { get; set; }
        public int? product_family_id { get; set; }
        public string handle { get; set; }
        public DateTime? archived_at { get; set; }
        public string return_params { get; set; }
        public int? initial_charge_in_cents { get; set; }
        public string accounting_code { get; set; }
        public string interval_unit { get; set; }
        public DateTime? created_at { get; set; }
        public int? id { get; set; }
        public string return_url { get; set; }
        public int? trial_interval { get; set; }
        public bool require_credit_card { get; set; }
        public bool request_credit_card { get; set; }
        public string expiration_interval_unit { get; set; }
        public int? interval { get; set; }
        public int? price_in_cents { get; set; }
        public int? trial_price_in_cents { get; set; }
    }

    public class PaymentProfile2
    {
        public DateTime? updated_at { get; set; }
        public string current_vault { get; set; }
        public int? expiration_month { get; set; }
        public string billing_city { get; set; }
        public string customer_vault_token { get; set; }
        public int? customer_id { get; set; }
        public string vault_token { get; set; }
        public string first_name { get; set; }
        public string billing_address_2 { get; set; }
        public string billing_country { get; set; }
        public string billing_state { get; set; }
        public string card_type { get; set; }
        public string billing_address { get; set; }
        public string last_name { get; set; }
        public DateTime? created_at { get; set; }
        public int? id { get; set; }
        public string billing_zip { get; set; }
        public string masked_card_number { get; set; }
        public int? expiration_year { get; set; }
    }

    public class LineItem
    {
        public int? amount_in_cents { get; set; }
        public string kind { get; set; }
        public int? discount_amount_in_cents { get; set; }
        public int? taxable_amount_in_cents { get; set; }
        public string memo { get; set; }
        public string transaction_type { get; set; }
        public int? component_id { get; set; }
    }

    public class NextBillingManifest
    {
        public string period_type { get; set; }
        public int? subtotal_in_cents { get; set; }
        public int? total_tax_in_cents { get; set; }
        public int? total_in_cents { get; set; }
        public List<LineItem> line_items { get; set; }
        public string end_date { get; set; }
        public string start_date { get; set; }
        public int? total_discount_in_cents { get; set; }
    }

    public class Customer2
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

    public class Signup2
    {
        public Subscription subscription { get; set; }
        public Customer2 customer { get; set; }
        public Product2 product { get; set; }
        public PaymentProfile2 payment_profile { get; set; }
        public NextBillingManifest next_billing_manifest { get; set; }
    }

    public class Meta
    {
        public string result_code { get; set; }
        public string status_code { get; set; }
        public List<Error> errors { get; set; }
    }

    public class Response
    {
        public Result result { get; set; }
        public Signup2 signup { get; set; }
        public Meta meta { get; set; }
    }

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
    #endregion
}
