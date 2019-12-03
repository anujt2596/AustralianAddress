using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AustralianAddress.Models.API;

namespace AustralianAddress.Repositories.SearchService
{
   public interface IAddressServiceSearchFactory
    {
        IEnumerable<AddressSearchModel> FilterByKey(string key);
    }
}
