using MLflowClient.Http.Dto;
using MLflowClient.Http.Dto.Artifacts.Request;
using MLflowClient.Http.Dto.Artifacts.Response;
using MLflowClient.Http.Dto.Experiments.Request;
using MLflowClient.Http.Dto.Experiments.Response;
using MLflowClient.Http.Dto.Runs.Request;
using MLflowClient.Http.Dto.Runs.Response;
using System.Threading.Tasks;

namespace MLflowClient.Interfaces
{
    public interface IMLflowHttpClient
    {
        // Experiment Management
        Task<CreateExperimentResponse> CreateExperiment(CreateExperimentRequest request);
        Task<SearchExperimentsResponse> SearchExperiments(SearchExperimentsRequest request);
        Task<GetExperimentResponse> GetExperiment(GetExperimentRequest request);
        Task<GetExperimentResponse> GetExperimentByName(GetExperimentByNameRequest request);
        void DeleteExperiment(DeleteExperimentRequest request);
        void RestoreExperiment(RestoreExperimentRequest request);
        void UpdateExperiment(UpdateExperimentRequest request);
        void SetExperimentTag(SetExperimentTagRequest request);

        // Run Management
        Task<CreateRunResponse> CreateRun(CreateRunRequest request);
        void DeleteRun(DeleteRunRequest request);
        void RestoreRun(RestoreRunRequest request);
        Task<GetRunResponse> GetRun(GetRunRequest request);
        Task<SearchRunsResponse> SearchRuns(SearchRunsRequest request);
        void LogRunMetric(LogRunMetricRequest request);
        void LogRunBatch(LogRunBatchRequest request);
        void SetRunTag(SetRunTagRequest request);
        void DeleteRunTag(DeleteRunTagRequest request);
        void LogRunParam(LogRunParamRequest request);
        Task<UpdateRunResponse> UpdateRun(UpdateRunRequest request);

        // Metric Management
        Task<MetricHistoryResponse> GetMetricHistory(MetricHistoryRequest request);

        // Artifact Management
        Task<ListArtifactsResponse> ListArtifacts(ListArtifactsRequest request);

        // Registered Model Management

        // Model Version Management
    }
}