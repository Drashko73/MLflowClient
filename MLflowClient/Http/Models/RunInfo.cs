using Newtonsoft.Json;

namespace MLflowClient.Http.Models
{
    public class RunInfo
    {
        [JsonProperty("run_id")]
        public string RunId { get; set; }
        [JsonProperty("run_uuid")]
        public string RunUuid { get; set; } // Deprecated, use RunId instead
        [JsonProperty("run_name")]
        public string RunName { get; set; }
        [JsonProperty("experiment_id")]
        public string ExperimentId { get; set; }
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("status")]
        public RunStatus Status { get; set; }
        [JsonProperty("start_time")]
        public long StartTime { get; set; }
        [JsonProperty("end_time")]
        public long EndTime { get; set; }
        [JsonProperty("artifact_uri")]
        public string ArtifactUri { get; set; }
        [JsonProperty("lifecycle_stage")]
        public string LifecycleStage { get; set; }
    }
}
