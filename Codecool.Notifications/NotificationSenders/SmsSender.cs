namespace Codecool.Notifications.NotificationSenders;

public class SmsSender
{
    public void SendSms(string toNumber, string message)
    {
        Console.WriteLine($"Sending SMS to {toNumber} with message: {message}");
    }
}