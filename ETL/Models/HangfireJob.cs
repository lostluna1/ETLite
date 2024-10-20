namespace ETL.Models;

public class HangfireJobs
{
    public string? Id
    {
        get; set;
    }
    public string? Name
    {
        get; set;
    }
    public IReadOnlyList<object>? Args
    {
        get; set;
    }
    public DateTime? LastExecution
    {
        get; set;
    }
    public DateTime? NextExecution
    {
        get; set;
    }
    public string? LastJobState
    {
        get; set;
    }
}

public class HangfireQueuedJobs
{
    public string? Key
    {
        get; set;
    }
    public string? Name
    {
        get; set;
    }
    public DateTime? EnqueuedAt
    {
        get; set;
    }
    public string? Arguments
    {
        get; set;
    }
}

public class HangfireProcessingJobs
{
    public string? Key
    {
        get; set;
    }
    public string? Name
    {
        get; set;
    }
    public DateTime? StartedAt
    {
        get; set;
    }
}

public class HangfireSucceededJobs
{
    public string? Key
    {
        get; set;
    }
    public string? Name
    {
        get; set;
    }
    public DateTime? SucceededAt
    {
        get; set;
    }
    public long? TotalDuration
    {
        get; set;
    }
    public string? Arguments
    {
        get; set;
    }
}

public class HangfireFailedJobs
{
    public string? Key
    {
        get; set;
    }
    public string? Name
    {
        get; set;
    }
    public DateTime? FailedAt
    {
        get; set;
    }
    public string? ExceptionMessage
    {
        get; set;
    }

    public string? Arguments
    {
        get; set;
    }
}

public class HangfireDeletedJobs
{
    public string? Key
    {
        get; set;
    }
    public string? Name
    {
        get; set;
    }
    public DateTime? DeletedAt
    {
        get; set;
    }
    public string? Arguments
    {
        get; set;
    }
}

public class HangfireScheduledJobs
{
    public string? Key
    {
        get; set;
    }
    public string? Name
    {
        get; set;
    }
    public DateTime? EnqueueAt
    {
        get; set;
    }
    public string? Arguments
    {
        get; set;
    }
}