namespace MLflowClient.Http.Models
{
    public class RunInfo
    {
        public string RunId { get; set; }
        public string RunUuid { get; set; } // Deprecated, use RunId instead
        public string RunName { get; set; }
        public string ExperimentId { get; set; }
        public string UserId { get; set; }
        public RunStatus Status { get; set; }
        public long StartTime { get; set; }
        public long EndTime { get; set; }
        public string ArtifactUri { get; set; }
        public string LifecycleStage { get; set; }
    }
}
