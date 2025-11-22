using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto.ModelVersions.Response
{
    public class SearchModelVersionsResponse
    {
        [JsonProperty("model_versions")]
        public List<ModelVersion> ModelVersions { get; set; } = new();
        [JsonProperty("next_page_token")]
        public string? NextPageToken { get; set; }
    }
}
