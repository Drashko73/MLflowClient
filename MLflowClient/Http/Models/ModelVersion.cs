using System.Collections.Generic;

namespace MLflowClient.Http.Models
{
    public class ModelVersion
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public long CreationTimestamp { get; set; }
        public long LastUpdatedTimestamp { get; set; }
        public string UserId { get; set; }
        public string CurrentStage { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public string RunId { get; set; }
        public ModelVersionStatus Status { get; set; }
        public string StatusMessage { get; set; }
        public List<ModelVersionTag> Tags { get; set; } = new List<ModelVersionTag>();
        public string RunLink { get; set; }
        public List<string> Aliases { get; set; } = new List<string>();
    }
}
