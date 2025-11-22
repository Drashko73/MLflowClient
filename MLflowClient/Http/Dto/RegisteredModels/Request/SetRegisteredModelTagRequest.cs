using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class SetRegisteredModelTagRequest
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
        [Required]
        [JsonProperty("key")]
        public string Key { get; set; }
        [Required]
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
