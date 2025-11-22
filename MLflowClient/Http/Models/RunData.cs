using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Models
{
    public class RunData
    {
        [JsonProperty("metrics")]
        public List<Metric> Metrics { get; set; } = new List<Metric>();
        [JsonProperty("params")]
        public List<Param> Params { get; set; } = new List<Param>();
        [JsonProperty("tags")]
        public List<RunTag> Tags { get; set; } = new List<RunTag>();
    }
}
