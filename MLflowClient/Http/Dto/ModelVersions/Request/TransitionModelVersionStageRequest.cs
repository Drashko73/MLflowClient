using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.ModelVersions.Request
{
    public class TransitionModelVersionStageRequest
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
        [Required]
        [JsonProperty("version")]
        public string Version { get; set; }
        [Required]
        [JsonProperty("stage")]
        public string Stage { get; set; }
        [Required]
        [JsonProperty("archive_existing_versions")]
        public bool ArchiveExistingVersions { get; set; }
    }
}
