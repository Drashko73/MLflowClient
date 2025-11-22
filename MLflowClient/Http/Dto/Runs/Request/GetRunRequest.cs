using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Runs.Request
{
    public class GetRunRequest
    {
        [JsonProperty("run_id")]
        public string RunId { get; set; }
    }
}
