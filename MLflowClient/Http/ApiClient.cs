using MLflowClient.Exceptions;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MLflowClient.Http
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TResponse> Post<TRequest, TResponse>(string endpoint, TRequest data)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, endpoint);
            var json = JsonConvert.SerializeObject(data, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new MLflowException(response.StatusCode, errorContent);
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(responseContent);
        }

        public async Task Post<TRequest>(string endpoint, TRequest data)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, endpoint);
            var json = JsonConvert.SerializeObject(data, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new MLflowException(response.StatusCode, errorContent);
            }
        }

        public async Task<TResponse> Get<TResponse>(string endpoint)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new MLflowException(response.StatusCode, errorContent);
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(responseContent);
        }

        public async Task<TResponse> GetWithBody<TRequest, TResponse>(string endpoint, TRequest data)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            var json = JsonConvert.SerializeObject(data, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.SendAsync(request);
            
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new MLflowException(response.StatusCode, errorContent);
            }
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(responseContent);
        }
    }
}
