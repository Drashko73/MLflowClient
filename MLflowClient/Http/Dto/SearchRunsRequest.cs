using MLflowClient.Http.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto
{
    public class SearchRunsRequest
    {
        [JsonProperty("experiment_ids")]
        public IEnumerable<string> ExperimentIds { get; set; } = Array.Empty<string>();

        [JsonProperty("filter")]
        public string? Filter { get; set; }
        
        [JsonProperty("run_view_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ViewType? RunViewType { get; set; }
        
        [JsonProperty("max_results")]
        public int? MaxResults { get; set; }
        
        [JsonProperty("order_by")]
        public List<string>? OrderBy { get; set; } = new List<string>();
        
        [JsonProperty("page_token")]
        public string? PageToken { get; set; }
    }
}
