using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Models
{
    public class RegisteredModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("creation_timestamp")]
        public long CreationTimestamp { get; set; }
        [JsonProperty("last_updated_timestamp")]
        public long LastUpdatedTimestamp { get; set; }
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("latest_versions")]
        public List<ModelVersion> LatestVersions { get; set; } = new List<ModelVersion>();
        [JsonProperty("tags")]
        public List<RegisteredModelTag> Tags { get; set; } = new List<RegisteredModelTag>();
        [JsonProperty("aliases")]
        public List<RegisteredModelAlias> Aliases { get; set; } = new List<RegisteredModelAlias>();
    }
}
