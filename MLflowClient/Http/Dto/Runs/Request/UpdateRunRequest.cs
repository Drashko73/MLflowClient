using MLflowClient.Http.Models;
using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Runs.Request
{
    public class UpdateRunRequest
    {
        [JsonProperty("run_id")]
        public string RunId { get; set; }
        [JsonProperty("status")]
        public RunStatus Status { get; set; }
        [JsonProperty("end_time")]
        public long EndTime { get; set; }
        [JsonProperty("run_name")]
        public string RunName { get; set; }
    }
}
