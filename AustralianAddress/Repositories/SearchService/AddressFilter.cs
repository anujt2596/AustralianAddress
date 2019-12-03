using AustralianAddress.Helper;
using AustralianAddress.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AustralianAddress.Repositories.SearchService
{
    public class AddressFilter: IAddressServiceSearchFactory
    {

       public  IEnumerable<AddressSearchModel> FilterByKey(string key)
        {  
            GeoIpAddress getAll = new GeoIpAddress();
            var allResult = getAll.GetFilterAddress(key);
            if(allResult.Any())
            {               
                return allResult;
            }
            return null;
        }
    }
}