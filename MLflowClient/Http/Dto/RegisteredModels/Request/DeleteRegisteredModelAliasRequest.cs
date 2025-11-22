using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class DeleteRegisteredModelAliasRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("alias")]
        public string Alias { get; set; }
    }
}
