using Codecool.Notifications.NotificationAdapters;
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
        var smsAdapter = new SmsAdapter();
        var emailAdapter = new EmailAdapter();
        var toastNotificationAdapter = new ToastNotificationAdapter();

        foreach (var user in users)
        {
            smsAdapter.SendInfoTo(user);
            emailAdapter.SendInfoTo(user);
            toastNotificationAdapter.SendInfoTo(user);
        }
        
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}