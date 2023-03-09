using System.Net.Http.Json;

namespace OpenAI_HttpClient
{
    public class Http_Client
    {
        static HttpClient client = new HttpClient();

        public static async Task<OpenAPIResponse> Post(string question)
        {
            using HttpResponseMessage response = await client.PostAsJsonAsync("https://localhost:7055/OpenApi", new { question });
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadFromJsonAsync<OpenAPIResponse>();

            return responseBody;
        }
    }
}