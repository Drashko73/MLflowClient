using MLflowClient.Http.Models;
using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.ModelVersions.Response
{
    public class TransitionModelVersionStageResponse
    {
        [JsonProperty("model_version")]
        public ModelVersion ModelVersion { get; set; }
    }
}
