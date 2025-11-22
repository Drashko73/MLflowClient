using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Artifacts.Request
{
    public class ListArtifactsRequest
    {
        [JsonProperty("run_id")]
        public string RunId { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("page_token")]
        public string PageToken { get; set; }
    }
}
