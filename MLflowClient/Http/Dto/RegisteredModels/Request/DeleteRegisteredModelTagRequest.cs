using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class DeleteRegisteredModelTagRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
