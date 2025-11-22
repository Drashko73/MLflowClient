using Newtonsoft.Json;

namespace MLflowClient.Http.Dto
{
    public class MetricHistoryRequest
    {
        [JsonProperty("run_id")]
        public string RunId { get; set; }
        [JsonProperty("metric_key")]
        public string MetricKey { get; set; }
        [JsonProperty("page_token")]
        public string PageToken { get; set; }
        [JsonProperty("max_results")]
        public int MaxResults { get; set; }
    }
}
