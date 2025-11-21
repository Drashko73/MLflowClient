using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto
{
    public class CreateExperimentRequest
    {
        public string Name { get; set; }

        public string? ArtifactLocation { get; set; }

        public List<ExperimentTag> Tags { get; set; } = new List<ExperimentTag>();
    }
}
