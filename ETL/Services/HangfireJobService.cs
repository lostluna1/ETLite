using System.Net.Http.Json;
using ETL.Contracts.Services;
using ETL.Models;

namespace ETL.Services;

public class HangfireJobService : IHangfireJobService
{
    private readonly HttpClient _httpClient;
    private readonly string apiUrlHead = "https://localhost:7220/api/HangfireJobs/";
    public HangfireJobService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ObservableCollection<HangfireJobs>> GetJobsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<ObservableCollection<HangfireJobs>>(apiUrlHead + "jobs");
        return response ?? new ObservableCollection<HangfireJobs>();
    }

    public async Task<ObservableCollection<HangfireQueuedJobs>> GetQueuedJobsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<ObservableCollection<HangfireQueuedJobs>>(apiUrlHead + "jobs/queued");
        return response ?? new ObservableCollection<HangfireQueuedJobs>();
    }

    public async Task<ObservableCollection<HangfireProcessingJobs>> GetProcessingJobsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<ObservableCollection<HangfireProcessingJobs>>(apiUrlHead + "jobs/processing");
        return response ?? new ObservableCollection<HangfireProcessingJobs>();
    }

    public async Task<ObservableCollection<HangfireSucceededJobs>> GetSucceededJobsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<ObservableCollection<HangfireSucceededJobs>>(apiUrlHead + "jobs/succeeded");
        return response ?? new ObservableCollection<HangfireSucceededJobs>();
    }

    public async Task<ObservableCollection<HangfireFailedJobs>> GetFailedJobsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<ObservableCollection<HangfireFailedJobs>>(apiUrlHead + "jobs/failed");
        return response ?? new ObservableCollection<HangfireFailedJobs>();
    }

    public async Task<ObservableCollection<HangfireDeletedJobs>> GetDeletedJobsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<ObservableCollection<HangfireDeletedJobs>>(apiUrlHead + "jobs/deleted");
        return response ?? new ObservableCollection<HangfireDeletedJobs>();
    }

    public async Task<ObservableCollection<HangfireScheduledJobs>> GetScheduledJobsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<ObservableCollection<HangfireScheduledJobs>>(apiUrlHead + "jobs/scheduled");
        return response ?? new ObservableCollection<HangfireScheduledJobs>();
    }
}

