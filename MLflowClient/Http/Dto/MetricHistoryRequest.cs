using Newtonsoft.Json;

namespace MLflowClient.Http.Dto
{
    public class MetricHistoryRequest
    {
        public string RunId { get; set; }
        public string MetricKey { get; set; }
        public string PageToken { get; set; }
        public int MaxResults { get; set; }
    }
}
