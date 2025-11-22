using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto.RegisteredModels.Response
{
    public class GetLatestRegisteredModelVersionsResponse
    {
        [JsonProperty("model_versions")]
        public List<ModelVersion> ModelVersions { get; set; } = new();
    }
}
