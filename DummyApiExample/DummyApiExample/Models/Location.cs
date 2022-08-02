using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DummyApiExample.Models
{
    public class Location
    {
        public string Street { get; set; }
        public string   State { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Timezone { get; set; }


        /* street: string(length: 5-100)
city: string(length: 2-30)
state: string(length: 2-30)
country: string(length: 2-30)
timezone: string(Valid timezone value ex. +7:00, -1:00)
        */
    }
}