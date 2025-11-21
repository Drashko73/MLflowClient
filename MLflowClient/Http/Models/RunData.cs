using System.Collections.Generic;

namespace MLflowClient.Http.Models
{
    public class RunData
    {
        public List<Metric> Metrics { get; set; } = new List<Metric>();
        public List<Param> Params { get; set; } = new List<Param>();
        public List<RunTag> Tags { get; set; } = new List<RunTag>();
    }
}
