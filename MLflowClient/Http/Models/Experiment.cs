using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Models
{
    public class Experiment
    {
        [JsonProperty("experiment_id")]
        public string ExperimentId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("artifact_location")]
        public string ArtifactLocation { get; set; }
        [JsonProperty("lifecycle_stage")]
        public string LifecycleStage { get; set; }
        [JsonProperty("last_update_time")]
        public long LastUpdateTime { get; set; }
        [JsonProperty("creation_time")]
        public long CreationTime { get; set; }
        [JsonProperty("tags")]
        public List<ExperimentTag> Tags { get; set; } = new List<ExperimentTag>();
    }
}
