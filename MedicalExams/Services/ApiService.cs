using MedicalExams.Models;
using System.Text.Json;

namespace MedicalExams.Services
{
    public class ApiService
    {
        public HttpClient _httpClient;
        public JsonSerializerOptions options = new(JsonSerializerDefaults.Web);

        public ApiService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<Process>> GetProcessesAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("/Process");
            List<Process> processes = new List<Process>();

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;

                processes = JsonSerializer.Deserialize<List<Process>>(data, options);
            }

            return processes;
        }

        public async Task<Process> PostProcessAsync(Process process)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("/Process", process, options);

            Process addedProcess = new Process();

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;

                addedProcess = JsonSerializer.Deserialize<Process>(data, options);
            }

            return addedProcess;
        }


    }
}
