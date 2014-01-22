using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Chargify2.Model;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Chargify2
{
    public static class ChargifyData
    {
        public static string CalculateSignature(this string message, string secret)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secret);
            HMACSHA1 hmacsha1 = new HMACSHA1(keyByte);
            byte[] messageBytes = encoding.GetBytes(message);
            byte[] hashMessage = hmacsha1.ComputeHash(messageBytes);
            string hexaHash = "";
            foreach (byte b in hashMessage) { hexaHash += String.Format("{0:x2}", b); }
            return hexaHash;
        }

        public static string ToQueryString(this Hashtable hashtable)
        {
            string tmp = "";
            IDictionaryEnumerator myEnumerator = hashtable.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                if (tmp.Length > 0) tmp += "&";
                tmp += myEnumerator.Key + "=" + myEnumerator.Value;
            }
            return tmp;
        }

        public static IEnumerable<U> Map<T, U>(this IEnumerable<T> s, Func<T, U> f)
        {
            foreach (var item in s)
                yield return f(item);
        }

        public static Call GetCall(this Client client, string callId)
        {
            var request = new RestRequest();
            request.Resource = "calls/{callId}";
            request.RootElement = "call";
            request.AddParameter("callId", callId, ParameterType.UrlSegment);
            return client.Execute<JObject>(request)["call"].ToObject<Call>();
        }

        public static Response PostSignUp(this Client client, Request signupRequest)
        {
            var request = new RestRequest();
            request.Resource = "signups";
            request.Method = Method.POST;
            request.RootElement = "request";
            request.RequestFormat = DataFormat.Json;
            request.AddBody(signupRequest);
            return client.Execute<JObject>(request).ToObject<Response>();
        }

        public static List<ProductV1Response> GetProductList(this Client client)
        {
            client.UseChargifyV1 = true;
            var request = new RestRequest();
            request.Resource = "products.json";
            //request.RootElement = "product";

            //ProductV1Response list = client.Execute<JObject>(request)["product"].ToObject<ProductV1Response>();
            List<ProductV1ResponseWrapper> list = client.Execute<JArray>(request).ToObject<List<ProductV1ResponseWrapper>>();
            List<ProductV1Response> realList = new List<ProductV1Response>();
            foreach (ProductV1ResponseWrapper p in list) realList.Add(p.product);

            return realList;
        }

        public static ProductV1Response GetProduct(this Client client, int productId)
        {
            client.UseChargifyV1 = true;
            var request = new RestRequest();
            request.Resource = "products/{productId}.json";
            request.RootElement = "product";
            request.AddParameter("productId", productId, ParameterType.UrlSegment);
            ProductV1Response p = client.Execute<JObject>(request)["product"].ToObject<ProductV1Response>();
            return p;
        }

        public static List<ProductV1FamilyComponentResponse> GetProductFamilyComponents(this Client client, int productFamilyId)
        {
            client.UseChargifyV1 = true;
            var request = new RestRequest();
            request.Resource = "product_families/{productFamilyId}/components.json";
            request.AddParameter("productFamilyId", productFamilyId, ParameterType.UrlSegment);
            List<ProductV1FamilyComponentResponseWrapper> list = client.Execute<JArray>(request).ToObject<List<ProductV1FamilyComponentResponseWrapper>>();
            List<ProductV1FamilyComponentResponse> realList = new List<ProductV1FamilyComponentResponse>();
            foreach (ProductV1FamilyComponentResponseWrapper pComponent in list) realList.Add(pComponent.component);
            return realList;
        }

        public static ProductV1FamilyComponentResponse GetProductFamilyComponent(this Client client, int productFamilyId, int componentId)
        {
            client.UseChargifyV1 = true;
            var request = new RestRequest();
            request.Resource = "product_families/{productFamilyId}/components/{componentId}.json";
            request.RootElement = "component";
            request.AddParameter("productFamilyId", productFamilyId, ParameterType.UrlSegment);
            request.AddParameter("componentId", componentId, ParameterType.UrlSegment);
            ProductV1FamilyComponentResponse c = client.Execute<JObject>(request)["component"].ToObject<ProductV1FamilyComponentResponse>();
            return c;

        }
    }
}
