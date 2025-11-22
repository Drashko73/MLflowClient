using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace MLflowClient.Http.Dto.Runs.Response
{
    public class UpdateRunResponse
    {
        [JsonProperty("run_info")]
        public RunInfo RunInfo { get; set; }
    }
}
