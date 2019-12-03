using AustralianAddress.Models.API;
using AustralianAddress.Repositories.GeoIpService;
using AustralianAddress.Repositories.SearchService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace AustralianAddress.Controllers.API
{
    public class GeoIpAddressController : ApiController
    {
         
        public IHttpActionResult Get()
        {
            GetAddress getAllItem = new GetAddress();
            var results = getAllItem.GetAllAddress();
            if (results.Any())
            {
                return Ok(results);
            }
            return NotFound();
        }
        public IHttpActionResult Get(string key)
        {
            IEnumerable<AddressSearchModel> filterItem = null;
            GetAddress getAllItem = new GetAddress();
            var results = getAllItem.GetAllAddress();
            if (results!=null && results.Any())
            {   if(!string.IsNullOrEmpty(key))
                {
                    key = key.ToLower();
                    filterItem = results.Where(x => x.City.ToLower().Contains(key) || x.State.ToLower().Contains(key) || x.PostalCode.ToLower().Contains(key));
                    filterItem = filterItem.OrderBy(x => x.Distance).Take(5);
                    return Ok(filterItem);
                }             
            }
            return NotFound();
        }

    }
}
