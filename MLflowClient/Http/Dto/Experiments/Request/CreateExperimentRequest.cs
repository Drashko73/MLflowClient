using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.Experiments.Request
{
    public class CreateExperimentRequest
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("artifact_location")]
        public string? ArtifactLocation { get; set; }
        [JsonProperty("tags")]
        public List<ExperimentTag> Tags { get; set; } = new List<ExperimentTag>();
    }
}
