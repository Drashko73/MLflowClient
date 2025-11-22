using MLflowClient.Http.Models;
using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.RegisteredModels.Response
{
    public class UpdateRegisteredModelResponse
    {
        [JsonProperty("registered_model")]
        public RegisteredModel RegisteredModel { get; set; }
    }
}
