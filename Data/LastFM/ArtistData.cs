using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Project18.Data.LastFM
{
    [DataContract(Name = "ArtistData")]
    public class ArtistData
    {
        [DataMember(Name = "artists")]
        public Artists Artists { get; set; }
    }

}