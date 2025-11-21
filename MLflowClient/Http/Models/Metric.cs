namespace MLflowClient.Http.Models
{
    public class Metric
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public long Timestamp { get; set; }
        public long Step { get; set; }
    }
}
