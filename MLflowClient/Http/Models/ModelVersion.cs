using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Models
{
    public class ModelVersion
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("creation_timestamp")]
        public long CreationTimestamp { get; set; }
        [JsonProperty("last_updated_timestamp")]
        public long LastUpdatedTimestamp { get; set; }
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("current_stage")]
        public string CurrentStage { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("run_id")]
        public string RunId { get; set; }
        [JsonProperty("status")]
        public ModelVersionStatus Status { get; set; }
        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }
        [JsonProperty("tags")]
        public List<ModelVersionTag> Tags { get; set; } = new List<ModelVersionTag>();
        [JsonProperty("run_link")]
        public string RunLink { get; set; }
        [JsonProperty("aliases")]
        public List<string> Aliases { get; set; } = new List<string>();
    }
}
