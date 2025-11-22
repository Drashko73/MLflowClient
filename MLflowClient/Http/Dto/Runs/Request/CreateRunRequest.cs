using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto.Runs.Request
{
    public class CreateRunRequest
    {
        [JsonProperty("experiment_id")]
        public string ExperimentId { get; set; }
        [JsonProperty("user_id")]
        public string? UserId { get; set; }
        [JsonProperty("run_name")]
        public string RunName { get; set; }
        [JsonProperty("start_time")]
        public long StartTime { get; set; }
        [JsonProperty("tags")]
        public List<RunTag> Tags { get; set; } = new List<RunTag>();
    }
}
