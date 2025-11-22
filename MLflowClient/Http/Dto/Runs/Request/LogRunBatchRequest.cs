using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto.Runs.Request
{
    public class LogRunBatchRequest
    {
        [JsonProperty("run_id")]
        public string RunId { get; set; }
        [JsonProperty("metrics")]
        public List<Metric> Metrics { get; set; } = new();
        [JsonProperty("params")]
        public List<Param> Params { get; set; } = new();
        [JsonProperty("tags")]
        public List<RunTag> Tags { get; set; } = new();
    }
}
