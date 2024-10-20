using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using ETL.Contracts.ViewModels;
using ETL.Contracts.Services;
using System.Threading.Tasks;
using ETL.Models;

namespace ETL.ViewModels;

public partial class HangFireResultsViewModel : ObservableRecipient, INavigationAware
{
    private readonly IHangfireJobService _hangfireJobService;

    [ObservableProperty]
    private object? selected;

    [ObservableProperty]
    private ObservableCollection<HangfireJobs> jobItems = new();

    [ObservableProperty]
    private ObservableCollection<HangfireQueuedJobs> queuedJobItems = new();

    [ObservableProperty]
    private ObservableCollection<HangfireProcessingJobs> processingJobItems = new();

    [ObservableProperty]
    private ObservableCollection<HangfireSucceededJobs> succeededJobItems = new();

    [ObservableProperty]
    private ObservableCollection<HangfireFailedJobs> failedJobItems = new();

    [ObservableProperty]
    private ObservableCollection<HangfireDeletedJobs> deletedJobItems = new();

    [ObservableProperty]
    private ObservableCollection<HangfireScheduledJobs> scheduledJobItems = new();


    public HangFireResultsViewModel(IHangfireJobService hangfireJobService)
    {
        _hangfireJobService = hangfireJobService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        //await RefreshAllJobsItemsAsync();
    }

    [RelayCommand]
    private async Task RefreshAllJobsItems()
    {
        await RefreshAllJobsItemsAsync();
    }
    public async Task RefreshAllJobsItemsAsync()
    {
        // 调用 HangfireJobService 获取数据
        var data = await _hangfireJobService.GetJobsAsync();
        JobItems = data;
        
    }

    [RelayCommand]
    private async Task RefreshQueuedJobsItems()
    {
        await RefreshQueuedJobsItemsAsync();
    }

    public async Task RefreshQueuedJobsItemsAsync()
    {
        // 调用 HangfireJobService 获取数据
        var data = await _hangfireJobService.GetQueuedJobsAsync();
        QueuedJobItems = data;
    }

    [RelayCommand]
    private async Task RefreshProcessingJobsItems()
    {
        await RefreshProcessingJobsItemsAsync();
    }

    public async Task RefreshProcessingJobsItemsAsync()
    {
        // 调用 HangfireJobService 获取数据
        var data = await _hangfireJobService.GetProcessingJobsAsync();
        ProcessingJobItems = data;
    }

    [RelayCommand]
    private async Task RefreshSucceededJobsItems()
    {
        await RefreshSucceededJobsItemsAsync();
    }

    public async Task RefreshSucceededJobsItemsAsync()
    {
        // 调用 HangfireJobService 获取数据
        var data = await _hangfireJobService.GetSucceededJobsAsync();
        SucceededJobItems = data;
    }

    [RelayCommand]
    private async Task RefreshFailedJobsItems()
    {
        await RefreshFailedJobsItemsAsync();
    }

    public async Task RefreshFailedJobsItemsAsync()
    {
        // 调用 HangfireJobService 获取数据
        var data = await _hangfireJobService.GetFailedJobsAsync();
        FailedJobItems = data;
    }

    [RelayCommand]
    private async Task RefreshDeletedJobsItems()
    {
        await RefreshDeletedJobsItemsAsync();
    }

    public async Task RefreshDeletedJobsItemsAsync()
    {
        // 调用 HangfireJobService 获取数据
        var data = await _hangfireJobService.GetDeletedJobsAsync();
        DeletedJobItems = data;
    }

    [RelayCommand]
    private async Task RefreshScheduledJobsItems()
    {
        await RefreshScheduledJobsItemsAsync();
    }

    public async Task RefreshScheduledJobsItemsAsync()
    {
        // 调用 HangfireJobService 获取数据
        var data = await _hangfireJobService.GetScheduledJobsAsync();
        ScheduledJobItems = data;
    }
    public void OnNavigatedFrom()
    {
    }

}
