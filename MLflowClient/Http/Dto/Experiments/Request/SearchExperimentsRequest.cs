using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto.Experiments.Request
{
    public class SearchExperimentsRequest
    {
        [JsonProperty("max_results")]
        public long? MaxResults { get; set; }
        [JsonProperty("page_token")]
        public string? PageToken { get; set; }
        [JsonProperty("filter")]
        public string? Filter { get; set; }
        [JsonProperty("order_by")]
        public List<string> OrderBy { get; set; } = new();
        [JsonProperty("view_type")]
        public ViewType? ViewType { get; set; }
    }
}
