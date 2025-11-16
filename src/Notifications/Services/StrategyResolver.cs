using Notifications.Enums;
using Notifications.Strategies;

namespace Notifications.Services;

public sealed class StrategyResolver
{
    private readonly IEnumerable<INotificationStrategy> _notificationStrategies;
    public StrategyResolver(IEnumerable<INotificationStrategy> instances)
        => _notificationStrategies = instances ?? throw new ArgumentNullException(nameof(instances));

    public INotificationStrategy Resolve(NotificationType notificationType)
    {
        INotificationStrategy? found = _notificationStrategies.FirstOrDefault(f => f.SupportedType.Equals(notificationType));
        if (found is null)
            throw new ApplicationException("Unsupported notification type");

        return found;
    }
}
