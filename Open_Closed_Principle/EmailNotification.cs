namespace Open_Closed_Principle
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }
}
