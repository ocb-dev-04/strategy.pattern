using Notifications.Enums;
using Notifications.Models;

namespace Notifications.Strategies;

public interface INotificationStrategy
{
    NotificationType SupportedType { get; }
    void ProcessNotifications(Notification model);
}
