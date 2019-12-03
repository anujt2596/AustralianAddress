using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AustralianAddress.Models.API
{
    public class AddressSearchModel
    {
        public decimal Distance { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }
    }
}