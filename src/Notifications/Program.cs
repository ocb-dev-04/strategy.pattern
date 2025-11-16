using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Notifications.Services;
using Notifications.Strategies;
using Notifications.Workers;

await Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddSingleton<INotificationStrategy, EmailStrategy>();
        services.AddSingleton<INotificationStrategy, SMSStrategy>();
        services.AddSingleton<INotificationStrategy, PushStrategy>();
        services.AddSingleton<INotificationStrategy, SlackStrategy>();

        services.AddSingleton<StrategyResolver>();
        services.AddSingleton<NotificationService>();

        services.AddHostedService<NotificationWorker>();
    })
    .Build()
    .RunAsync();
