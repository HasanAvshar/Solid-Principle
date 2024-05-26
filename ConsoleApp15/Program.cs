using Single_Responsibility_Principle;

Employee employee = new Employee
{
    Name = "John Nazimli",
    Position = "Developer"
};

EmployeeFileManager fileManager = new EmployeeFileManager();
string filePath = "employee.txt";

fileManager.SaveToFile(employee, filePath);
fileManager.LoadFromFile(employee, filePath);

EmployeeNotifier notifier = new EmployeeNotifier();
notifier.SendNotification(employee, "Welcome to the company");