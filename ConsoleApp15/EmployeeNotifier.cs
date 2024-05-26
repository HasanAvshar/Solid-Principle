namespace Single_Responsibility_Principle
{
    public class EmployeeNotifier
    {
        public void SendNotification(Employee employee, string message)
        {
            Console.WriteLine($"Notification sent to {employee.Name}: {message}");
        }
    }
}
