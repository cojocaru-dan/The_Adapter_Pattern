using Codecool.Notifications.NotificationSenders;

namespace Codecool.Notifications.NotificationAdapters;
public class ToastNotificationAdapter : INotificationAdapter
{
    private ToastNotificationSender _toastNotificationSender = new ToastNotificationSender();
    public void SendInfoTo(User user)
    {
        _toastNotificationSender.SendToastNotification(user.UserName, "Hello!");
    }
}