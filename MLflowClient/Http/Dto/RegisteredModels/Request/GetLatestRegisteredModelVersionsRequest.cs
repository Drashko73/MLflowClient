using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class GetLatestRegisteredModelVersionsRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("stages")]
        public List<string> Stages { get; set; } = new();
    }
}
