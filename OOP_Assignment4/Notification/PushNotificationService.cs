namespace OOP_Assignment4.Notification
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Push notification sent to {recipient}: {message}");
        }
    }
}
