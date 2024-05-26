namespace Open_Closed_Principle
{
    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }
}
