using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Chargify2.Configuration;
using Chargify2.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Deserializers;

namespace Chargify2
{
    public class Client : IClient
    {
        //string BaseUrl { get; set; }
        public bool UseChargifyV1 = false;
        readonly string _apiKeyV1;
        readonly string _apiKeyV2;
        readonly string _apiPasswordV2;
        readonly string _apiPasswordV1 = "x";
        readonly string _apiSecret;
        readonly Uri _proxy;

        public Client()
        {
            this._apiKeyV1 = ConfigurationManager.AppSettings["Chargify.v1.apiKey"];
            this._apiKeyV2 = ConfigurationManager.AppSettings["Chargify.v2.apiKey"];
            this._apiPasswordV2 = ConfigurationManager.AppSettings["Chargify.v2.apiPassword"];
            this._apiSecret = ConfigurationManager.AppSettings["Chargify.v2.secret"];
            //this._proxy = proxy;
        }

        public Client(string apiKey, string apiPassword, string apiSecret, Uri proxy)
        {
            this._apiKeyV2 = apiKey;
            this._apiPasswordV2 = apiPassword;
            this._apiSecret = apiSecret;
            this._proxy = proxy;
        }

        public Client(string apiKey, string apiPassword, string apiSecret)
            :this(apiKey, apiPassword, apiSecret, null)
        {
        }

        public Client(ChargifyAccountElement config)
            : this(config.ApiKey, config.ApiPassword, config.Secret, config.Proxy)
        {
        }

        private string _userAgent;
        private string UserAgent
        {
            get
            {
                if (_userAgent == null)
                {
                    _userAgent = String.Format("Chargify2 .NET Client v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
                }
                return _userAgent;
            }
        }

        public string BaseUrl
        {
            get
            {
                if (UseChargifyV1) return "https://krave-n-inc-test-site.chargify.com";
                else return "https://api.chargify.com/api/v2";
            }
        }

        public string ApiKey
        {
            get
            {
                if (UseChargifyV1) return this._apiKeyV1;
                return this._apiKeyV2;
            }
        }

        public string ApiPassword
        {
            get
            {
                if (UseChargifyV1) return this._apiPasswordV1;
                else return this._apiPasswordV2;
            }
        }

        public string ApiSecret
        {
            get
            {
                return this._apiSecret;
            }
        }

        public Uri Proxy
        {
            get
            {
                return this._proxy;
            }
        }

        /// <summary>
        /// Non-dynamic execute
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = BaseUrl;
            client.Authenticator = new HttpBasicAuthenticator(this.ApiKey, this.ApiPassword);
            client.AddHandler("application/json", new DynamicJsonDeserializer());
            client.UserAgent = UserAgent;
            if (this._proxy != null)
            {
                client.Proxy = new WebProxy(this._proxy);
            }

            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }

            return response.Data;
        }

        public Direct Direct
        {
            get
            {
                return new Direct(this);
            }
        }
    }

    public class DynamicJsonDeserializer : IDeserializer
    {
        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }

        public T Deserialize<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<dynamic>(response.Content);
        }
    }
}
