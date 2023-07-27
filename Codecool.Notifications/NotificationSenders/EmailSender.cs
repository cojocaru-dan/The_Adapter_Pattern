namespace Codecool.Notifications.NotificationSenders;

public class EmailSender
{
    public void SendEmail(string toEmail, string fromEmail, string subject, string body)
    {
        Console.WriteLine($"Sending email to {toEmail} from {fromEmail} with subject {subject}. Message: {body}");
    }
}