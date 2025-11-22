using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class GetLatestRegisteredModelVersionsRequest
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("stages")]
        public List<string> Stages { get; set; } = new();
    }
}
