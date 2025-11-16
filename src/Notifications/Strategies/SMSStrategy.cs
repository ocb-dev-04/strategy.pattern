using Notifications.Enums;
using Notifications.Models;

namespace Notifications.Strategies;

public sealed class SMSStrategy : INotificationStrategy
{
    public NotificationType SupportedType => NotificationType.SMS;

    public void ProcessNotifications(Notification model)
    {
        Console.WriteLine($"Sending SMS to {model.Recipient}");
        Console.WriteLine($"Message: {model.Message}");
    }
}
