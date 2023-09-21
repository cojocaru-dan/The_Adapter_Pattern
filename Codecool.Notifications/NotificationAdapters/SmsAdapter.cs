using Codecool.Notifications.NotificationSenders;

namespace Codecool.Notifications.NotificationAdapters;
public class SmsAdapter : INotificationAdapter
{
    private SmsSender _smsSender = new SmsSender();
    public void SendInfoTo(User user)
    {
        _smsSender.SendSms(user.PhoneNumber, "Hello!");
    }
}