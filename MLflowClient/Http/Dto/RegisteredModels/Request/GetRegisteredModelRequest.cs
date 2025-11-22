using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class GetRegisteredModelRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
