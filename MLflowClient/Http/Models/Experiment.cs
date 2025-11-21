using System.Collections.Generic;

namespace MLflowClient.Http.Models
{
    public class Experiment
    {
        public string ExperimentId { get; set; }
        public string Name { get; set; }
        public string ArtifactLocation { get; set; }
        public string LifecycleStage { get; set; }
        public long LastUpdateTime { get; set; }
        public long CreationTime { get; set; }
        public List<ExperimentTag> Tags { get; set; } = new List<ExperimentTag>();
    }
}
