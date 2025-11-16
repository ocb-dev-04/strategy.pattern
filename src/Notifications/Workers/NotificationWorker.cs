using Notifications.Enums;
using Notifications.Models;
using Notifications.Services;
using Microsoft.Extensions.Hosting;

namespace Notifications.Workers;

internal class NotificationWorker : BackgroundService
{
    private readonly NotificationService _notificationService;

    public NotificationWorker(NotificationService notificationService)
        => _notificationService = notificationService ?? throw new ArgumentNullException(nameof(notificationService));

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Notification notification = CreateEmailNotification();
        _notificationService.SendNotification(notification);

        await Task.CompletedTask;
    }

    private Notification CreateEmailNotification()
        => new Notification(
            NotificationType.Email,
            "user@example.com",
            "Welcome",
            "Welcome to our platform!"
        );
}
