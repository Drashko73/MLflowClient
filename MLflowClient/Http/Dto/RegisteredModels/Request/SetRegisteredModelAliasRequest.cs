using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class SetRegisteredModelAliasRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
