using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Poutinio.Core.Models
{
    public class Get__RssResponse
    {
        [JsonPropertyName("feed")]
        public RssFeed Feed { get; set; }
    }
}
