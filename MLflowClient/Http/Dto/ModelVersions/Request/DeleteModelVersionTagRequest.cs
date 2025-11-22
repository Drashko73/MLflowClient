using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.ModelVersions.Request
{
    public class DeleteModelVersionTagRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
