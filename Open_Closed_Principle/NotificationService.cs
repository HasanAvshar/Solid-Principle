namespace Open_Closed_Principle
{
    public class NotificationService
    {
        private readonly List<INotification> _notifications;

        public NotificationService()
        {
            _notifications = new List<INotification>();
        }

        public void AddNotification(INotification notification)
        {
            _notifications.Add(notification);
        }

        public void NotifyAll(string message)
        {
            foreach (var notification in _notifications)
            {
                notification.Send(message);
            }
        }
    }

}
