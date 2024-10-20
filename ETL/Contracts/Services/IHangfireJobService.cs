using ETL.Models;

namespace ETL.Contracts.Services;

public interface IHangfireJobService
{
    Task<ObservableCollection<HangfireJobs>> GetJobsAsync();
    Task<ObservableCollection<HangfireQueuedJobs>> GetQueuedJobsAsync();
    Task<ObservableCollection<HangfireProcessingJobs>> GetProcessingJobsAsync();
    Task<ObservableCollection<HangfireSucceededJobs>> GetSucceededJobsAsync();
    Task<ObservableCollection<HangfireFailedJobs>> GetFailedJobsAsync();
    Task<ObservableCollection<HangfireDeletedJobs>> GetDeletedJobsAsync();
    Task<ObservableCollection<HangfireScheduledJobs>> GetScheduledJobsAsync();
}
