using Codecool.Notifications.NotificationSenders;

namespace Codecool.Notifications;

class Program
{
    private static IEnumerable<User> GenerateRandomUsers()
    {
        Random random = new Random();
        string[] names = { "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Heidi", "Ivan", "Judy" };
        string[] domains = { "gmail.com", "yahoo.com", "hotmail.com", "outlook.com", "aol.com" };

        for (int i = 0; i < 10; i++)
        {
            string name = names[random.Next(names.Length)];
            string domain = domains[random.Next(domains.Length)];
            string email = $"{name}@{domain}";
            string phone = $"({random.Next(100, 1000)}) {random.Next(100, 1000)}-{random.Next(1000, 10000)}";
            yield return new User(name, email, phone);
        }
    }
    
    private static void Main(string[] args)
    {
        var users = GenerateRandomUsers();
        var smsSender = new SmsSender();
        var emailSender = new EmailSender();
        var toastNotificationSender = new ToastNotificationSender();

        foreach (var user in users)
        {
            smsSender.SendSms(user.PhoneNumber, "Hello!");
            emailSender.SendEmail(user.Email, "Codecool", "Notification", "Hello!");
            toastNotificationSender.SendToastNotification(user.UserName, "Hello!");
        }
        
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}