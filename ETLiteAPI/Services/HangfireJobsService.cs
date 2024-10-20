using Hangfire;
using Hangfire.Storage;
using ETLiteAPI.Repositories.Service;
namespace ETLiteAPI.Services;

public class HangfireJobsService : IHangfireJobsService
{
    public List<object> GetJobs()
    {
        var jobList = new List<object>();

        using (var connection = JobStorage.Current.GetConnection())
        {
            var recurringJobs = connection.GetRecurringJobs();
            foreach (var job in recurringJobs)
            {
                jobList.Add(new
                {
                    job.Id,
                    job.Job.Method.Name,
                    job.LastExecution,
                    job.NextExecution,
                    job.LastJobState,
                    job.Job.Args

                });
            }
        }

        return jobList;
    }

    public List<object> GetQueuedJobs()
    {
        var monitoringApi = JobStorage.Current.GetMonitoringApi();
        var queues = monitoringApi.Queues();
        var queuedJobs = new List<object>();

        foreach (var queue in queues)
        {
            var jobs = monitoringApi.EnqueuedJobs(queue.Name, 0, 100);
            foreach (var job in jobs)
            {
                queuedJobs.Add(new
                {
                    job.Key,
                    job.Value.Job.Method.Name,
                    job.Value.EnqueuedAt,
                    job.Value.InvocationData.Arguments

                });
            }
        }

        return queuedJobs;
    }

    public List<object> GetProcessingJobs()
    {
        var monitoringApi = JobStorage.Current.GetMonitoringApi();
        var processingJobs = monitoringApi.ProcessingJobs(0, 100);
        var jobList = new List<object>();

        foreach (var job in processingJobs)
        {
            jobList.Add(new
            {
                job.Key,
                job.Value.Job.Method.Name,
                job.Value.StartedAt
            });
        }

        return jobList;
    }

    public List<object> GetSucceededJobs()
    {
        var monitoringApi = JobStorage.Current.GetMonitoringApi();
        var succeededJobs = monitoringApi.SucceededJobs(0, 100);
        var jobList = new List<object>();

        foreach (var job in succeededJobs)
        {
            jobList.Add(new
            {
                job.Key,
                job.Value.Job.Method.Name,
                job.Value.SucceededAt,
                job.Value.TotalDuration,
                job.Value.InvocationData.Arguments
            });
        }

        return jobList;
    }

    public List<object> GetFailedJobs()
    {
        var monitoringApi = JobStorage.Current.GetMonitoringApi();
        var failedJobs = monitoringApi.FailedJobs(0, 100);
        var jobList = new List<object>();

        foreach (var job in failedJobs)
        {
            jobList.Add(new
            {
                job.Key,
                job.Value.Job.Method.Name,
                job.Value.FailedAt,
                job.Value.ExceptionMessage,
                job.Value.InvocationData.Arguments

            });
        }

        return jobList;
    }

    public List<object> GetDeletedJobs()
    {
        var monitoringApi = JobStorage.Current.GetMonitoringApi();
        var deletedJobs = monitoringApi.DeletedJobs(0, 100);
        var jobList = new List<object>();

        foreach (var job in deletedJobs)
        {
            jobList.Add(new
            {
                job.Key,
                job.Value.Job.Method.Name,
                job.Value.DeletedAt,
                job.Value.InvocationData.Arguments

            });
        }

        return jobList;
    }

    public List<object> GetScheduledJobs()
    {
        var monitoringApi = JobStorage.Current.GetMonitoringApi();
        var scheduledJobs = monitoringApi.ScheduledJobs(0, 100);
        var jobList = new List<object>();

        foreach (var job in scheduledJobs)
        {
            jobList.Add(new
            {
                job.Key,
                job.Value.Job.Method.Name,
                job.Value.EnqueueAt,
                job.Value.InvocationData.Arguments

            });
        }

        return jobList;
    }
}
