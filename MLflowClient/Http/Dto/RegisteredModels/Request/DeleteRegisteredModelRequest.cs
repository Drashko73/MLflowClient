using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class DeleteRegisteredModelRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
