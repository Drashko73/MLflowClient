using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.ModelVersions.Request
{
    public class TransitionModelVersionStageRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("stage")]
        public string Stage { get; set; }
        [JsonProperty("archive_existing_versions")]
        public bool ArchiveExistingVersions { get; set; }
    }
}
