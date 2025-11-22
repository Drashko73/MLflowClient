using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto
{
    public class SearchRunsResponse
    {
        [JsonProperty("runs")]
        public List<Run> Runs { get; set; } = new List<Run>();
        [JsonProperty("next_page_token")]
        public string NextPageToken { get; set; }
    }
}
