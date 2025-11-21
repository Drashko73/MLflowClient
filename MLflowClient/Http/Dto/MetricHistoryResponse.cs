using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto
{
    public class MetricHistoryResponse
    {
        public List<Metric> Metrics { get; set; } = new List<Metric>();
        public string NextPageToken { get; set; }
    }
}
