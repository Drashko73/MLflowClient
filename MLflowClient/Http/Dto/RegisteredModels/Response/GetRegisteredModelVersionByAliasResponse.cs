using MLflowClient.Http.Models;
using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.RegisteredModels.Response
{
    public class GetRegisteredModelVersionByAliasResponse
    {
        [JsonProperty("model_version")]
        public ModelVersion ModelVersion { get; set; }
    }
}
