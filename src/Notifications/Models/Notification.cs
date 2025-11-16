using Notifications.Enums;

namespace Notifications.Models;

public sealed record Notification(
    NotificationType Type,
    string Recipient,
    string Subject,
    string Message
);