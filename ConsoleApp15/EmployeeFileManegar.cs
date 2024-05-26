namespace Single_Responsibility_Principle
{
    public class EmployeeFileManager
    {
        public void SaveToFile(Employee employee, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(employee.Name);
                    writer.WriteLine(employee.Position);
                }
                Console.WriteLine("Employee data saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving employee data: {ex.Message}");
            }
        }

        public void LoadFromFile(Employee employee, string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    employee.Name = reader.ReadLine();
                    employee.Position = reader.ReadLine();
                }
                Console.WriteLine("Employee data loaded successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading employee data: {ex.Message}");
            }
        }
    }

}
