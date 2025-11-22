using MLflowClient.Http.Models;
using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.RegisteredModels.Response
{
    public class RenameRegisteredModelResponse
    {
        [JsonProperty("registered_model")]
        public RegisteredModel RegisteredModel { get; set; }
    }
}
