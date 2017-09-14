using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Project18.Data.LastFM
{
    [DataContract(Name = "image")]
    public class Image
    {
        [DataMember(Name = "#text")]
        public string Text { get; set; }

        [DataMember(Name = "size")]
        public string Size { get; set; }
    }

}