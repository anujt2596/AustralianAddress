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
                    Distance=29,
                    City="Hill Street",
                    State="East Tamworth NSW",
                    PostalCode="2340"
                },
                new AddressSearchModel
                {
                    Distance=10,
                    City="The Oaks",
                    State="Hillside VIC",
                    PostalCode="3037"
                },
                new AddressSearchModel
                {
                    Distance=12,
                    City="Archibald Street",
                    State="Lockington VIC",
                    PostalCode="3563"
                },
                new AddressSearchModel
                {
                    Distance=114,
                    City="Everton Street",
                    State="Hamilton NSW",
                    PostalCode="2303"
                },
                new AddressSearchModel
                {
                    Distance=7,
                    City="Oddfellows St",
                    State="Toodyay WA",
                    PostalCode="6566"
                },
                new AddressSearchModel
                {
                    Distance=42,
                    City="Carrington Street",
                    State="South Kalgoorlie WA",
                    PostalCode="6430"
                },
                new AddressSearchModel
                {
                    Distance=26,
                    City="Curtis Avenue",
                    State="Taren Point NSW",
                    PostalCode="2229"
                },
                new AddressSearchModel
                {
                    Distance=19,
                    City="Allawah Street",
                    State="Blacktown NSW",
                    PostalCode="2148"
                },
                new AddressSearchModel
                {
                    Distance=86,
                    City="Castlereagh Street",
                    State="Tahmoor NSW",
                    PostalCode="2573"
                },
                new AddressSearchModel
                {
                    Distance=11,
                    City="Oliver Parade",
                    State="Nowra NSW",
                    PostalCode="2541"
                },
                new AddressSearchModel
                {
                    Distance=3,
                    City="Woodgates Road",
                    State="Buchan VIC",
                    PostalCode="3885"
                }
                ,
                new AddressSearchModel
                {
                    Distance=75,
                    City="Old Waratah Road",
                    State="Fish Creek VIC",
                    PostalCode="3959"
                },
                new AddressSearchModel
                {
                    Distance=28,
                    City="McLeod Street",
                    State="Yarrawonga VIC",
                    PostalCode="3730"
                },
                new AddressSearchModel
                {
                    Distance=2,
                    City="Olympic Street",
                    State="Mansfield VIC",
                    PostalCode="3722"
                },
                new AddressSearchModel
                {
                    Distance=50,
                    City="Opal Street",
                    State="Lightning Ridge NSW",
                    PostalCode="2834"
                },
                new AddressSearchModel
                {
                    Distance=29,
                    City="Eyre Street",
                    State="Charleville QLD",
                    PostalCode="4470"
                },
                new AddressSearchModel
                {
                    Distance=61,
                    City="Edington Street",
                    State="Berserker QLD",
                    PostalCode="4701"
                },
                new AddressSearchModel
                {
                    Distance=7,
                    City="Romeo Street",
                    State="Mackay QLD",
                    PostalCode="4740"
                },
                new AddressSearchModel
                {
                    Distance=200,
                    City="Reynolds Street",
                    State="Nebo QLD",
                    PostalCode="4742"
                },
                new AddressSearchModel
                {
                    Distance=41,
                    City="Bellevue Drive",
                    State="Port Macquarie NSW",
                    PostalCode="2444"
                },
                new AddressSearchModel
                {
                    Distance=74,
                    City="Severn Street",
                    State="Deepwater NSW",
                    PostalCode="2371"
                },
                new AddressSearchModel
                {
                    Distance=27,
                    City="Bangalow Crescent",
                    State="Raceview QLD",
                    PostalCode="4305"
                },
                new AddressSearchModel
                {
                    Distance=71,
                    City="Akonna Street",
                    State="Wynnum QLD",
                    PostalCode="4178"
                },
                new AddressSearchModel
                {
                    Distance=4,
                    City="Wesleyn Ct",
                    State="Logan Village QLD",
                    PostalCode="4207"
                },
                new AddressSearchModel
                {
                    Distance=18,
                    City="Godfrey Street",
                    State="Glenmorgan QLD",
                    PostalCode="4423"
                },
                new AddressSearchModel
                {
                    Distance=76,
                    City="Yappar Street",
                    State="Karumba QLD",
                    PostalCode="4891"
                },
                new AddressSearchModel
                {
                    Distance=14,
                    City="Lorna Lim Terrace",
                    State="Driver NT",
                    PostalCode="0830"
                },
                new AddressSearchModel
                {
                    Distance=31,
                    City="Cockatiel Road",
                    State="Lloyd Creek NT",
                    PostalCode="0822"
                },
                new AddressSearchModel
                {
                    Distance=5,
                    City="Kintore St",
                    State="Katherine South NT",
                    PostalCode="0850"
                },
                new AddressSearchModel
                {
                    Distance=68,
                    City="Hartley Street",
                    State="Alice Springs NT",
                    PostalCode="0870"
                },
                new AddressSearchModel
                {
                    Distance=17,
                    City="Eyre Street",
                    State="Coober Pedy SA",
                    PostalCode="5723"
                },
                new AddressSearchModel
                {
                    Distance=62,
                    City="Angove Street",
                    State="Norseman WA",
                    PostalCode="6443"
                },
                new AddressSearchModel
                {
                    Distance=4,
                    City="Breaksea Cres",
                    State="Collingwood Heights WA",
                    PostalCode="6330"
                },
                new AddressSearchModel
                {
                    Distance=28,
                    City="Osborne Street",
                    State="Gracetown WA",
                    PostalCode="6284"
                },
                new AddressSearchModel
                {
                    Distance=94,
                    City="Wittenoom St",
                    State="Collie WA",
                    PostalCode="6225"
                },
                new AddressSearchModel
                {
                    Distance=92,
                    City="Cawana Parkway",
                    State="Lakelands WA",
                    PostalCode="6180"
                },
                new AddressSearchModel
                {
                    Distance=41,
                    City="Norman Rd",
                    State="Roleystone WA",
                    PostalCode="6111"
                },
                new AddressSearchModel
                {
                    Distance=48,
                    City="Lennon Street",
                    State="Wiluna WA",
                    PostalCode="6646"
                },
                new AddressSearchModel
                {
                    Distance=24,
                    City="French Street",
                    State="Coral Bay WA",
                    PostalCode="6701"
                },
                new AddressSearchModel
                {
                    Distance=45,
                    City="Padbury Way",
                    State="Bulgarra WA",
                    PostalCode="6714"
                },
                new AddressSearchModel
                {
                    Distance=35,
                    City="Slattery St",
                    State="Werribee VIC",
                    PostalCode="3030"
                },
                new AddressSearchModel
                {
                    Distance=5,
                    City="Sadler Place",
                    State="Fitzroy Crossing WA",
                    PostalCode="6765"
                },
                new AddressSearchModel
                {
                    Distance=66,
                    City="Adelaide St",
                    State="Birdsville QLD",
                    PostalCode="4482"
                },
                new AddressSearchModel
                {
                    Distance=32,
                    City="Hopetoun Road",
                    State="Warrnambool VIC",
                    PostalCode="3280"
                },
                new AddressSearchModel
                {
                    Distance=142,
                    City="Mountjoy Parade",
                    State="Lorne VIC",
                    PostalCode="3232"
                },
                new AddressSearchModel
                {
                    Distance=4,
                    City="8 Pine Avenue",
                    State="Elwood VIC",
                    PostalCode="3185"
                },
                new AddressSearchModel
                {
                    Distance=8,
                    City="Cavanagh St",
                    State="Augathella QLD",
                    PostalCode="4477"
                },
                new AddressSearchModel
                {
                    Distance=11,
                    City="First Avenue",
                    State="Stuarts Point NSW",
                    PostalCode="2441"
                },
                new AddressSearchModel
                {
                    Distance=30,
                    City="Wallace St",
                    State="Scotts Head NSW",
                    PostalCode="2447"
                },
                new AddressSearchModel
                {
                    Distance=51,
                    City="George St",
                    State="Inglewood QLD",
                    PostalCode="4387"
                },
                new AddressSearchModel
                {
                    Distance=51,
                    City="Unit 2/8-10 Arwen St",
                    State="Maroochydore QLD",
                    PostalCode="4558"
                }
            };
            return AllAddress;
        }    
    }
}