using MLflowClient.Http.Models;
using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.RegisteredModels.Response
{
    public class GetRegisteredModelResponse
    {
        [JsonProperty("registered_model")]
        public RegisteredModel RegisteredModel { get; set; }
    }
}
