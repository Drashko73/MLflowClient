using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto.RegisteredModels.Response
{
    public class SearchRegisteredModelsResponse
    {
        [JsonProperty("registered_models")]
        public List<RegisteredModel> RegisteredModels { get; set; } = new();
        [JsonProperty("next_page_token")]
        public string? NextPageToken { get; set; }
    }
}
