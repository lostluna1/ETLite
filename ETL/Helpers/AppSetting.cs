using Microsoft.Extensions.Configuration;

namespace ETL.Helpers;
public static class AppSetting
{
    public static readonly IConfigurationRoot Configuration;

    static AppSetting()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        Configuration = builder.Build();
    }

    public static string ShareFolderRootPath => Configuration["ShareFolderRootPath"];
    public static string ShareFolderEnv => Configuration["ShareFolderEnv"];
    public static string ShareFolderReurnUrl => Configuration["ShareFolderReurnUrl"];
}
