using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Runs.Request
{
    public class SetRunTagRequest
    {
        [JsonProperty("run_id")]
        public string RunId { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
