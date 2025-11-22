using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class RenameRegisteredModelRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("new_name")]
        public string NewName { get; set; }
    }
}
