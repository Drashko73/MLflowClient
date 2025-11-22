using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto
{
    public class MetricHistoryResponse
    {
        [JsonProperty("metrics")]
        public List<Metric> Metrics { get; set; } = new List<Metric>();
        [JsonProperty("next_page_token")]
        public string NextPageToken { get; set; }
    }
}
