using MLflowClient.Api;
using MLflowClient.Http;
using MLflowClient.Http.Dto;
using MLflowClient.Http.Dto.Artifacts.Request;
using MLflowClient.Http.Dto.Artifacts.Response;
using MLflowClient.Http.Dto.Experiments.Request;
using MLflowClient.Http.Dto.Experiments.Response;
using MLflowClient.Http.Dto.RegisteredModels.Request;
using MLflowClient.Http.Dto.RegisteredModels.Response;
using MLflowClient.Http.Dto.Runs.Request;
using MLflowClient.Http.Dto.Runs.Response;
using MLflowClient.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MLflowClient
{
    public class MLflowHttpClient : IMLflowHttpClient
    {
        private readonly ApiClient _apiClient;

        public MLflowHttpClient(HttpClient httpClient)
        {
            _apiClient = new ApiClient(httpClient);
        }

        public MLflowHttpClient(string baseUrl) : this(new Uri(baseUrl))
        {
        }

        public MLflowHttpClient(Uri baseUri)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = baseUri
            };
            _apiClient = new ApiClient(httpClient);
        }

        // Experiments
        public async Task<CreateExperimentResponse> CreateExperiment(CreateExperimentRequest request) => await _apiClient.Post<CreateExperimentRequest, CreateExperimentResponse>(MLflowApi.ExperimentsCreate, request);
        public async Task<SearchExperimentsResponse> SearchExperiments(SearchExperimentsRequest request) => await _apiClient.Post<SearchExperimentsRequest, SearchExperimentsResponse>(MLflowApi.ExperimentsSearch, request);
        public async Task<GetExperimentResponse> GetExperiment(GetExperimentRequest request) => await _apiClient.GetWithBody<GetExperimentRequest, GetExperimentResponse>(MLflowApi.ExperimentsGet, request);
        public async Task<GetExperimentResponse> GetExperimentByName(GetExperimentByNameRequest request) => await _apiClient.GetWithBody<GetExperimentByNameRequest, GetExperimentResponse>(MLflowApi.ExperimentsGetByName, request);
        public async Task DeleteExperiment(DeleteExperimentRequest request) => await _apiClient.Post(MLflowApi.ExperimentsDelete, request);
        public async Task RestoreExperiment(RestoreExperimentRequest request) => await _apiClient.Post(MLflowApi.ExperimentsRestore, request);
        public async Task UpdateExperiment(UpdateExperimentRequest request) => await _apiClient.Post(MLflowApi.ExperimentsUpdate, request);
        public async Task SetExperimentTag(SetExperimentTagRequest request) => await _apiClient.Post(MLflowApi.ExperimentsSetTag, request);

        // Runs
        public async Task<CreateRunResponse> CreateRun(CreateRunRequest request) => await _apiClient.Post<CreateRunRequest, CreateRunResponse>(MLflowApi.RunsCreate, request);
        public async Task DeleteRun(DeleteRunRequest request) => await _apiClient.Post(MLflowApi.RunsDelete, request);
        public async Task RestoreRun(RestoreRunRequest request) => await _apiClient.Post(MLflowApi.RunsRestore, request);
        public async Task<SearchRunsResponse> SearchRuns(SearchRunsRequest request) => await _apiClient.Post<SearchRunsRequest, SearchRunsResponse>(MLflowApi.RunsSearch, request);
        public async Task<GetRunResponse> GetRun(GetRunRequest request) => await _apiClient.GetWithBody<GetRunRequest, GetRunResponse>(MLflowApi.RunsGet, request);
        public async Task LogRunMetric(LogRunMetricRequest request) => await _apiClient.Post(MLflowApi.RunsLogMetric, request);
        public async Task LogRunBatch(LogRunBatchRequest request) => await _apiClient.Post(MLflowApi.RunsLogBatch, request);
        public async Task SetRunTag(SetRunTagRequest request) => await _apiClient.Post(MLflowApi.RunsSetTag, request);
        public async Task DeleteRunTag(DeleteRunTagRequest request) => await _apiClient.Post(MLflowApi.RunsDeleteTag, request);
        public async Task LogRunParam(LogRunParamRequest request) => await _apiClient.Post(MLflowApi.RunsLogParam, request);
        public async Task<UpdateRunResponse> UpdateRun(UpdateRunRequest request) => await _apiClient.Post<UpdateRunRequest, UpdateRunResponse>(MLflowApi.RunsUpdate, request);

        // Metrics
        public async Task<MetricHistoryResponse> GetMetricHistory(MetricHistoryRequest request) => await _apiClient.GetWithBody<MetricHistoryRequest, MetricHistoryResponse>(MLflowApi.MetricsGetHistory, request);

        // Artifacts
        public async Task<ListArtifactsResponse> ListArtifacts(ListArtifactsRequest request) => await _apiClient.GetWithBody<ListArtifactsRequest, ListArtifactsResponse>(MLflowApi.ArtifactsList, request);

        // Registered Models
        public async Task<CreateRegisteredModelResponse> CreateRegisteredModel(CreateRegisteredModelRequest request) => await _apiClient.Post<CreateRegisteredModelRequest, CreateRegisteredModelResponse>(MLflowApi.RegisteredModelsCreate, request);
        public async Task<GetRegisteredModelResponse> GetRegisteredModel(GetRegisteredModelRequest request) => await _apiClient.GetWithBody<GetRegisteredModelRequest, GetRegisteredModelResponse>(MLflowApi.RegisteredModelsGet, request);
        public async Task<RenameRegisteredModelResponse> RenameRegisteredModel(RenameRegisteredModelRequest request) => await _apiClient.Post<RenameRegisteredModelRequest, RenameRegisteredModelResponse>(MLflowApi.RegisteredModelsRename, request);
        public async Task<UpdateRegisteredModelResponse> UpdateRegisteredModel(UpdateRegisteredModelRequest request) => await _apiClient.Patch<UpdateRegisteredModelRequest, UpdateRegisteredModelResponse>(MLflowApi.RegisteredModelsUpdate, request);
        public async Task DeleteRegisteredModel(DeleteRegisteredModelRequest request) => await _apiClient.Delete(MLflowApi.RegisteredModelsDelete, request);
        public async Task<GetLatestRegisteredModelVersionsResponse> GetLatestRegisteredModelVersions(GetLatestRegisteredModelVersionsRequest request) => await _apiClient.Post<GetLatestRegisteredModelVersionsRequest, GetLatestRegisteredModelVersionsResponse>(MLflowApi.RegisteredModelsGetLatestVersions, request);
        public async Task<SearchRegisteredModelsResponse> SearchRegisteredModels(SearchRegisteredModelsRequest request) => await _apiClient.GetWithBody<SearchRegisteredModelsRequest, SearchRegisteredModelsResponse>(MLflowApi.RegisteredModelsSearch, request);
        public async Task SetRegisteredModelTag(SetRegisteredModelTagRequest request) => await _apiClient.Post(MLflowApi.RegisteredModelsSetTag, request);
        public async Task DeleteRegisteredModelTag(DeleteRegisteredModelTagRequest request) => await _apiClient.Delete(MLflowApi.RegisteredModelsDeleteTag, request);
        public async Task DeleteRegisteredModelAlias(DeleteRegisteredModelAliasRequest request) => await _apiClient.Delete(MLflowApi.RegisteredModelsDeleteAlias, request);
        public async Task<GetRegisteredModelVersionByAliasResponse> GetRegisteredModelVersionByAlias(GetRegisteredModelVersionByAliasRequest request) => await _apiClient.GetWithBody<GetRegisteredModelVersionByAliasRequest, GetRegisteredModelVersionByAliasResponse>(MLflowApi.RegisteredModelsGetModelVersionByAlias, request);
        public async Task SetRegisteredModelAlias(SetRegisteredModelAliasRequest request) => await _apiClient.Post(MLflowApi.RegisteredModelsSetAlias, request);

        // Model Versions
    }
}
