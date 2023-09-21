using Codecool.Notifications;
namespace Codecool.Notifications.NotificationAdapters;
public interface INotificationAdapter
{
    void SendInfoTo(User user);
}