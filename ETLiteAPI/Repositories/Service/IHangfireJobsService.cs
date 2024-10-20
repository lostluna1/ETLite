using System.Collections.Generic;

namespace ETLiteAPI.Repositories.Service;

public interface IHangfireJobsService
{
    /// <summary>
    /// ��ȡ���ж�ʱ�������Ϣ
    /// </summary>
    /// <returns></returns>
    List<object> GetJobs();
    List<object> GetQueuedJobs();
    List<object> GetProcessingJobs();
    List<object> GetSucceededJobs();
    List<object> GetFailedJobs();
    List<object> GetDeletedJobs();

    /// <summary>
    /// ��ȡ�ȴ��е�������Ϣ
    /// </summary>
    /// <returns></returns>
    List<object> GetScheduledJobs();
}
