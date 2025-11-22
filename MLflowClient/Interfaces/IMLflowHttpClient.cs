using MLflowClient.Http.Dto;
using MLflowClient.Http.Dto.Artifacts.Request;
using MLflowClient.Http.Dto.Artifacts.Response;
using MLflowClient.Http.Dto.Experiments.Request;
using MLflowClient.Http.Dto.Experiments.Response;
using MLflowClient.Http.Dto.RegisteredModels.Request;
using MLflowClient.Http.Dto.RegisteredModels.Response;
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
        Task DeleteExperiment(DeleteExperimentRequest request);
        Task RestoreExperiment(RestoreExperimentRequest request);
        Task UpdateExperiment(UpdateExperimentRequest request);
        Task SetExperimentTag(SetExperimentTagRequest request);

        // Run Management
        Task<CreateRunResponse> CreateRun(CreateRunRequest request);
        Task DeleteRun(DeleteRunRequest request);
        Task RestoreRun(RestoreRunRequest request);
        Task<GetRunResponse> GetRun(GetRunRequest request);
        Task<SearchRunsResponse> SearchRuns(SearchRunsRequest request);
        Task LogRunMetric(LogRunMetricRequest request);
        Task LogRunBatch(LogRunBatchRequest request);
        Task SetRunTag(SetRunTagRequest request);
        Task DeleteRunTag(DeleteRunTagRequest request);
        Task LogRunParam(LogRunParamRequest request);
        Task<UpdateRunResponse> UpdateRun(UpdateRunRequest request);

        // Metric Management
        Task<MetricHistoryResponse> GetMetricHistory(MetricHistoryRequest request);

        // Artifact Management
        Task<ListArtifactsResponse> ListArtifacts(ListArtifactsRequest request);

        // Registered Model Management
        Task<CreateRegisteredModelResponse> CreateRegisteredModel(CreateRegisteredModelRequest request);
        Task<GetRegisteredModelResponse> GetRegisteredModel(GetRegisteredModelRequest request);
        Task<RenameRegisteredModelResponse> RenameRegisteredModel(RenameRegisteredModelRequest request);
        Task<UpdateRegisteredModelResponse> UpdateRegisteredModel(UpdateRegisteredModelRequest request);
        Task DeleteRegisteredModel(DeleteRegisteredModelRequest request);
        Task<GetLatestRegisteredModelVersionsResponse> GetLatestRegisteredModelVersions(GetLatestRegisteredModelVersionsRequest request);
        Task<SearchRegisteredModelsResponse> SearchRegisteredModels(SearchRegisteredModelsRequest request);
        Task SetRegisteredModelTag(SetRegisteredModelTagRequest request);
        Task DeleteRegisteredModelTag(DeleteRegisteredModelTagRequest request);
        Task DeleteRegisteredModelAlias(DeleteRegisteredModelAliasRequest request);
        Task<GetRegisteredModelVersionByAliasResponse> GetRegisteredModelVersionByAlias(GetRegisteredModelVersionByAliasRequest request);
        Task SetRegisteredModelAlias(SetRegisteredModelAliasRequest request);

        // Model Version Management
    }
}