using Microsoft.AspNetCore.Mvc;
using ETLiteAPI.Repositories.Service;

namespace ETLiteAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HangfireJobsController : ControllerBase
{
    private readonly IHangfireJobsService _hangfireJobsService;

    public HangfireJobsController(IHangfireJobsService hangfireJobsService)
    {
        _hangfireJobsService = hangfireJobsService;
    }

    [HttpGet("jobs")]
    public IActionResult GetJobs()
    {
        var jobList = _hangfireJobsService.GetJobs();
        return Ok(jobList);
    }

    [HttpGet("jobs/queued")]
    public IActionResult GetQueuedJobs()
    {
        var jobList = _hangfireJobsService.GetQueuedJobs();
        return Ok(jobList);
    }

    [HttpGet("jobs/processing")]
    public IActionResult GetProcessingJobs()
    {
        var jobList = _hangfireJobsService.GetProcessingJobs();
        return Ok(jobList);
    }

    [HttpGet("jobs/succeeded")]
    public IActionResult GetSucceededJobs()
    {
        var jobList = _hangfireJobsService.GetSucceededJobs();
        return Ok(jobList);
    }

    [HttpGet("jobs/failed")]
    public IActionResult GetFailedJobs()
    {
        var jobList = _hangfireJobsService.GetFailedJobs();
        return Ok(jobList);
    }

    [HttpGet("jobs/deleted")]
    public IActionResult GetDeletedJobs()
    {
        var jobList = _hangfireJobsService.GetDeletedJobs();
        return Ok(jobList);
    }

    [HttpGet("jobs/scheduled")]
    public IActionResult GetScheduledJobs()
    {
        var jobList = _hangfireJobsService.GetScheduledJobs();
        return Ok(jobList);
    }
}
