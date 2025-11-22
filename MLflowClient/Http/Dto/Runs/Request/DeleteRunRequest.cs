using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Runs.Request
{
    public class DeleteRunRequest
    {
        [JsonProperty("run_id")]
        public string RunId { get; set; }
    }
}
