using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class UpdateRegisteredModelRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
