using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Project18.Data.LastFM
{
    [DataContract(Name = "artist")]
    public class Artist
    {
        public Artist()
        {
            ImageList = new List<Image>();
        }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "playcount")]
        public string Playcount { get; set; }

        [DataMember(Name = "listeners")]
        public string Listeners { get; set; }

        [DataMember(Name = "mbid")]
        public string Mbid { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "streamable")]
        public string Streamable { get; set; }

        [DataMember(Name = "image")]
        public List<Image> ImageList { get; set; }
    }
}