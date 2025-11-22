using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Runs.Request
{
    public class DeleteRunTagRequest
    {
        [JsonProperty("run_id")]
        public string RunId { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
