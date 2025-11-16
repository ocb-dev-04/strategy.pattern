using Notifications.Enums;
using Notifications.Models;

namespace Notifications.Strategies;

public sealed class EmailStrategy : INotificationStrategy
{
    public NotificationType SupportedType => NotificationType.Email;

    public void ProcessNotifications(Notification model)
    {
        Console.WriteLine($"Sending EMAIL to {model.Recipient}");
        Console.WriteLine($"Subject: {model.Subject}");
        Console.WriteLine($"Message: {model.Message}");
    }
}
