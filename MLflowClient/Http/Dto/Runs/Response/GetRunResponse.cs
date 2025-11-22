using MLflowClient.Http.Models;
using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Runs.Response
{
    public class GetRunResponse
    {
        [JsonProperty("run")]
        public Run Run { get; set; }
    }
}
