using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto.Experiments.Response
{
    public class SearchExperimentsResponse
    {
        [JsonProperty("experiments")]
        public List<Experiment> Experiments { get; set; } = new List<Experiment>();
        [JsonProperty("next_page_token")]
        public string NextPageToken { get; set; }
    }
}
