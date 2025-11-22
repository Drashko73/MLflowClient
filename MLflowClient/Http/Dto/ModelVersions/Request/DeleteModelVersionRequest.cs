using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.ModelVersions.Request
{
    public class DeleteModelVersionRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
