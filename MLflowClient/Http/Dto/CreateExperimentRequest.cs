using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto
{
    public class CreateExperimentRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("artifact_location")]
        public string? ArtifactLocation { get; set; }
        [JsonProperty("tags")]
        public List<ExperimentTag> Tags { get; set; } = new List<ExperimentTag>();
    }
}
