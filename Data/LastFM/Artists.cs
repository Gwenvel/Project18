using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
 
namespace Project18.Data.LastFM
{
    [DataContract(Name = "artists")]
    public class Artists
        {
            public Artists()
            {
                ArtistList = new List<Artist>();
            }
 
            [DataMember(Name = "artist")]
            public List<Artist> ArtistList { get; set; }
        }
}