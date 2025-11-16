using Notifications.Enums;
using Notifications.Models;

namespace Notifications.Services;

public sealed class NotificationService
{
    private readonly StrategyResolver _strategyResolver;

    public NotificationService(StrategyResolver strategyResolver)
        => _strategyResolver = strategyResolver ?? throw new ArgumentNullException(nameof(strategyResolver));

    public void SendNotification(Notification notification)
    {
        var instance = _strategyResolver.Resolve(notification.Type);
        instance.ProcessNotifications(notification);
    }
}