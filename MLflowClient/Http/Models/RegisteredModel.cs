using System.Collections.Generic;

namespace MLflowClient.Http.Models
{
    public class RegisteredModel
    {
        public string Name { get; set; }
        public long CreationTimestamp { get; set; }
        public long LastUpdatedTimestamp { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public List<ModelVersion> LatestVersions { get; set; } = new List<ModelVersion>();
        public List<RegisteredModelTag> Tags { get; set; } = new List<RegisteredModelTag>();
        public List<RegisteredModelAlias> Aliases { get; set; } = new List<RegisteredModelAlias>();
    }
}
