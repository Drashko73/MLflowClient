using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.ModelVersions.Request
{
    public class GetModelVersionRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
