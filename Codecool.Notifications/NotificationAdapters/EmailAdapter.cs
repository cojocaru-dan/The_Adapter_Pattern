using Codecool.Notifications.NotificationSenders;

namespace Codecool.Notifications.NotificationAdapters;
public class EmailAdapter : INotificationAdapter
{
    private EmailSender _emailSender = new EmailSender();
    public void SendInfoTo(User user)
    {
        _emailSender.SendEmail(user.Email, "Codecool", "Notification", "Hello!");
    }
}
