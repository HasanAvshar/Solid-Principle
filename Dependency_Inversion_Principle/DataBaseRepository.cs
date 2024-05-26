namespace Dependency_Inversion_Principle
{
    public class DatabaseRepository : IRepository
    {
        public string GetData()
        { 
            return "Database data";
        }
    }
}
