using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.services.Baseresults
{
    public class BaseResultModel<T>
    {
        [JsonProperty("Results")]
        public List<T> Results { get; set; }
        [JsonProperty("Success")]
        public bool Success { get; set; }
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage { get; set; }
    }
}
