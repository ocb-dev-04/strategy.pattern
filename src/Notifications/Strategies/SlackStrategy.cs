using Notifications.Enums;
using Notifications.Models;

namespace Notifications.Strategies;

public sealed class SlackStrategy : INotificationStrategy
{
    public NotificationType SupportedType => NotificationType.Push;

    public void ProcessNotifications(Notification model)
    {
        Console.WriteLine($"Posting to Slack channel {model.Recipient}");
        Console.WriteLine($"Message: {model.Subject} - {model.Message}");
    }
}