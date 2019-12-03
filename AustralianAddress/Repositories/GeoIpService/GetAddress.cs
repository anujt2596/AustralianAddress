using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AustralianAddress.Models.API;
using AustralianAddress.Repositories.SearchService;

namespace AustralianAddress.Repositories.GeoIpService
{
    public class GetAddress: IAddressSearchService
    {
        public GetAddress()
        {
            this.GetAllAddress();
        }
        public IEnumerable<AddressSearchModel> GetAllAddress()
        {
            List<AddressSearchModel> AllAddress = new List<AddressSearchModel>()
            {
                new AddressSearchModel
                {  
                    Distance=37,
                    City="Sharp Street",
                    State="Newtown VIC",
                    PostalCode="3220"
                },
                new AddressSearchModel
                {
                      
                    Distance=55,
                    City="Bank Street",
                    State="Traralgon VIC",
                    PostalCode="3844"
                },
                new AddressSearchModel
                { 
                    Distance=2,
                    City="The Causeway",
                    State="Kingston ACT",
                    PostalCode="2604"
                },
                new AddressSearchModel
                {
                    Distance=15,
                    City="Brockhoff Drive",
                    State="Burwood VIC",
                    PostalCode="3125"
                },
                new AddressSearchModel
                {
                    Distance=101,
                    City="Crozier Avenue",
                    State="Melrose Park SA",
                    PostalCode="5039"
                },
                new AddressSearchModel
                {
                    Distance=15,
                    City="Sixth Street",
                    State="Dublin SA",
                    PostalCode="5501"
                },
                new AddressSearchModel
                {
                    Distance=11,
                    City="Cunningham Street",
                    State="Tullamore NSW",
                    PostalCode="2874"
                },
                new AddressSearchModel
                {
                    Distance=13,
                    City="John Monash Blvd",
                    State="Mildura VIC",
                    PostalCode="3500"
                },
                new AddressSearchModel
                {
                    Distance=16,
                    City="Elder Terrace",
                    State="Hawker SA",
                    PostalCode="5434"
                },
                new AddressSearchModel
                {
                    Distance=12,
                    City="",
                    State="",
                    PostalCode=""
                },
                new AddressSearchModel
                {
                    Distance=12,
                    City="",
                    State="",
                    PostalCode=""
                },
                new AddressSearchModel
                {
                    Distance=12,
                    City="",
                    State="",
                    PostalCode=""
                },
                new AddressSearchModel
                {
                    Distance=12,
                    City="",
                    State="",
                    PostalCode=""
                },
                new AddressSearchModel
                {
                    Distance=12,
                    City="",
                    State="",
                    PostalCode=""
                },
                new AddressSearchModel
                {
                    Distance=12,
                    City="",
                    State="",
                    PostalCode=""
                },
                new AddressSearchModel
                {
                    Distance=12,
                    City="",
                    State="",
                    PostalCode=""
                },
                new AddressSearchModel
                {
                    Distance=12,
                    City="",
                    State="",
                    PostalCode=""
                },
                new AddressSearchModel
                {
                    Distance=12,
                    City="",
                    State="",
                    PostalCode=""
                },
                new AddressSearchModel
                {
                    Distance=12,
                    City="",
                    State="",
                    PostalCode=""
                },
                new AddressSearchModel
                {
                    Distance=12,
                    City="",
                    State="",
                    PostalCode=""
                }
            };
            return AllAddress;
        }    
    }
}