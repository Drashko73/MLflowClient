using MLflowClient.Http.Models;
using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Runs.Response
{
    public class CreateRunResponse
    {
        [JsonProperty("run")]
        public Run Run { get; set; }
    }
}
