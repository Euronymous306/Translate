using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate
{
    public class ResponseData
    {
        public string translatedText { get; set; }
        public double match { get; set; }
    }

    public class Match
    {
        public string id { get; set; }
        public string segment { get; set; }
        public string translation { get; set; }
        public string quality { get; set; }
        public object reference { get; set; }

        [JsonProperty("__invalid_name__usage-count")]
        public double __invalid_name__usage_count { get; set; }

        public string subject { get; set; }

        [JsonProperty("__invalid_name__created-by")]
        public string __invalid_name__created_by { get; set; }

        [JsonProperty("__invalid_name__last-updated-by")]
        public string __invalid_name__last_updated_by { get; set; }

        [JsonProperty("__invalid_name__create-date")]
        public string __invalid_name__create_date { get; set; }

        [JsonProperty("__invalid_name__last-update-date")]
        public string __invalid_name__last_update_date { get; set; }

        public double match { get; set; }
    }

    public class RootObject
    {
        public ResponseData responseData { get; set; }
        public bool quotaFinished { get; set; }
        public object mtLangSupported { get; set; }
        public string responseDetails { get; set; }
        public double responseStatus { get; set; }
        public string responderId { get; set; }
        public object exception_code { get; set; }
        public List<Match> matches { get; set; }
    }

}
