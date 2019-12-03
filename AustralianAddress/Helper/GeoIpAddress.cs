using AustralianAddress.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace AustralianAddress.Helper
{
    public class GeoIpAddress
    {
        public IEnumerable<AddressSearchModel> GetAllAddress()
        {
            IEnumerable<AddressSearchModel> allAddress = null;

            using (var client = new HttpClient())
            {

                //client.BaseAddress = new Uri("https://localhost:44335/api/GeoIpAddress?type=json");
                ////HTTP GET
                //var responseTask = client.GetAsync("allAddress"); 
                //responseTask.Wait();
                var url = $"https://localhost:44335/api/GeoIpAddress?type=json";
                var result = client.GetAsync(url).Result;               
                if (result.StatusCode==HttpStatusCode.OK)
                {
                    var readTask = result.Content.ReadAsAsync<IList<AddressSearchModel>>();
                    readTask.Wait();

                    allAddress = readTask.Result;
                    return allAddress;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    allAddress = Enumerable.Empty<AddressSearchModel>();
                    return allAddress;
                }
            }
        }

        public IEnumerable<AddressSearchModel> GetFilterAddress(string key)
        {
            IEnumerable<AddressSearchModel> allAddress = null;

            using (var client = new HttpClient())
            {                
                var url = $"https://localhost:44335/api/GeoIpAddress?key={key}&type=json";
                var result = client.GetAsync(url).Result;
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var readTask = result.Content.ReadAsAsync<IList<AddressSearchModel>>();
                    readTask.Wait();

                    allAddress = readTask.Result;
                    return allAddress;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    allAddress = Enumerable.Empty<AddressSearchModel>();
                    return allAddress;
                }
            }
        }

    }
}