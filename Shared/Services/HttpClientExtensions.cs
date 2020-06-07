using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Beceps.Shared.Services
{
    public static class HttpClientExtensions
    {
        public static string AccessToken = "eyJhbGciOiJIUzI1NiJ9.eyJzdWIiOiIxIiwibmJmIjoxNTgxNjA0MTIyLCJyb2xlcyI6W10sImlzcyI6ImJlY2VwcyIsImV4cCI6MTcwNTA2MDkxMSwiaWF0IjoxNTgxNjA0MTIyfQ.0yeeiEcn8Z1KMm48sf0FZUvKIibatQFgyA1SFWk9xlk";
        public static async Task<T> Get<T>(this HttpClient httpClient, string url, bool setAuthenticationHeader = true)
        {
            httpClient.DefaultRequestHeaders
              .Accept
              .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var request = GetDefaultHttpRequestMessage(url, setAuthenticationHeader);

            request.Method = new HttpMethod("GET");

            var response = await httpClient.SendAsync(request);
            var responseBytes = await response.Content.ReadAsByteArrayAsync();
            request.Dispose();
            return JsonSerializer.Deserialize<T>(responseBytes, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public static async Task<T> Post<T>(this HttpClient httpClient, string url, object content, bool setAuthenticationHeader = true)
        {
            httpClient.DefaultRequestHeaders
              .Accept
              .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var request = GetDefaultHttpRequestMessage(url, setAuthenticationHeader);

            request.Method = new HttpMethod("POST");

            request.Content = SerializeContent(content);

            var response = await httpClient.SendAsync(request);
            var responseBytes = await response.Content.ReadAsByteArrayAsync();
            request.Dispose();
            return JsonSerializer.Deserialize<T>(responseBytes, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public static async Task<T> Put<T>(this HttpClient httpClient, string url, object content, bool setAuthenticationHeader = true)
        {
            httpClient.DefaultRequestHeaders
              .Accept
              .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var request = GetDefaultHttpRequestMessage(url, setAuthenticationHeader);

            request.Method = new HttpMethod("PUT");
            request.Content = SerializeContent(content);

            var response = await httpClient.SendAsync(request);
            var responseBytes = await response.Content.ReadAsByteArrayAsync();
            request.Dispose();
            return JsonSerializer.Deserialize<T>(responseBytes, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public static async Task<T> Delete<T>(this HttpClient httpClient, string url, object content, bool setAuthenticationHeader = true)
        {
            httpClient.DefaultRequestHeaders
              .Accept
              .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var request = GetDefaultHttpRequestMessage(url, setAuthenticationHeader);

            request.Method = new HttpMethod("DELETE");
            request.Content = SerializeContent(content);

            var response = await httpClient.SendAsync(request);
            var responseBytes = await response.Content.ReadAsByteArrayAsync();
            request.Dispose();
            return JsonSerializer.Deserialize<T>(responseBytes, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        private static HttpRequestMessage GetDefaultHttpRequestMessage(string url, bool setAuthenticationHeader = true)
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
            };

            if (setAuthenticationHeader)
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
            }

            return request;
        }

        private static HttpContent SerializeContent(object content)
        {
            return new StringContent(JsonSerializer.Serialize(content, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }),
                                    Encoding.UTF8,
                                    "application/json");
        }
    }
}
