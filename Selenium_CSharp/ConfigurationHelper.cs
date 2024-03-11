using Microsoft.Extensions.Configuration;
using System;

public static class ConfigurationHelper
{
    public static IConfigurationRoot Configuration { get; set; }

    static ConfigurationHelper()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json");

        Configuration = builder.Build();
    }

    public static string GetAppSetting(string key)
    {
        return Configuration[key];
    }
}