using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Runs.Request
{
    public class LogRunModelRequest
    {
        [JsonProperty("run_id")]
        public string RunId { get; set; }
        [JsonProperty("model_json")]
        public string ModelJson { get; set; }
    }
}
