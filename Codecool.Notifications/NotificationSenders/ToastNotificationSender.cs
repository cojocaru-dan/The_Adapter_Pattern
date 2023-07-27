namespace Codecool.Notifications.NotificationSenders;

public class ToastNotificationSender
{
    public void SendToastNotification(string username, string message)
    {
        Console.WriteLine($"Sending toast notification to {username} with message: {message}");
    }
}