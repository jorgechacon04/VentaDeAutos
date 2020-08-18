using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Dto
{
    public class CarDto
    {
        public class Data
        {
            public class Id
            {
                [JsonProperty("$oid")]
                public string oid { get; set; }
            }

            public class User
            {
                [JsonProperty("$oid")]
                public string oid { get; set; }
            }

            public Id _id { get; set; }
            public User user { get; set; }
            public string brand { get; set; }
            public string color { get; set; }
            public string model { get; set; }
            public int km { get; set; }
            public string plate { get; set; }
            public int year { get; set; }
            public string transmission { get; set; }
            public string photos { get; set; }
        }

        public Data data { get; set; }
    }
}
