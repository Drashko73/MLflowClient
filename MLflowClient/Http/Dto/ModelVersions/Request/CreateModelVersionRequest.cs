using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto.ModelVersions.Request
{
    public class CreateModelVersionRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("run_id")]
        public string RunId { get; set; }
        [JsonProperty("tags")]
        public List<ModelVersionTag> Tags { get; set; } = new();
        [JsonProperty("run_link")]
        public string RunLink { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
