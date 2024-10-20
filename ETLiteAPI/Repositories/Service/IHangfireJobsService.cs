using System.Collections.Generic;

namespace ETLiteAPI.Repositories.Service;

public interface IHangfireJobsService
{
    /// <summary>
    /// 获取所有定时任务的信息
    /// </summary>
    /// <returns></returns>
    List<object> GetJobs();
    List<object> GetQueuedJobs();
    List<object> GetProcessingJobs();
    List<object> GetSucceededJobs();
    List<object> GetFailedJobs();
    List<object> GetDeletedJobs();

    /// <summary>
    /// 获取等待中的任务信息
    /// </summary>
    /// <returns></returns>
    List<object> GetScheduledJobs();
}
