using Notifications.Enums;
using Notifications.Models;

namespace Notifications.Strategies;

public sealed class PushStrategy : INotificationStrategy
{
    public NotificationType SupportedType => NotificationType.Push;

    public void ProcessNotifications(Notification model)
    {
        Console.WriteLine($"Sending PUSH notification to device {model.Recipient}");
        Console.WriteLine($"Title: {model.Subject}");
        Console.WriteLine($"Body: {model.Message}");
    }
}
