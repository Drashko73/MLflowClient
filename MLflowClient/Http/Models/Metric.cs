using Newtonsoft.Json;

namespace MLflowClient.Http.Models
{
    public class Metric
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
        [JsonProperty("step")]
        public long Step { get; set; }
    }
}
