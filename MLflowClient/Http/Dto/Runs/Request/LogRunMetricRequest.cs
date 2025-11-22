using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Runs.Request
{
    public class LogRunMetricRequest
    {
        [JsonProperty("run_id")]
        public string RunId { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("value")]
        public double Value { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
        [JsonProperty("step")]
        public long Step { get; set; }
    }
}
