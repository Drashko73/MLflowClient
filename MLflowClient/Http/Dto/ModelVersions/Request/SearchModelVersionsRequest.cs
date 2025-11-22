using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto.ModelVersions.Request
{
    public class SearchModelVersionsRequest
    {
        [JsonProperty("filter")]
        public string? Filter { get; set; }
        [JsonProperty("max_results")]
        public long? MaxResults { get; set; }
        [JsonProperty("order_by")]
        public List<string> OrderBy { get; set; } = new();
        [JsonProperty("page_token")]
        public string? PageToken { get; set; }
    }
}
