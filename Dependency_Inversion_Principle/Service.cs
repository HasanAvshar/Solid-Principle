namespace Dependency_Inversion_Principle
{
    public class Service
    {
        private readonly IRepository _repository;

        public Service(IRepository repository)
        {
            _repository = repository;
        }

        public void DisplayData()
        {
            string data = _repository.GetData();
            Console.WriteLine(data);
        }
    }
}
