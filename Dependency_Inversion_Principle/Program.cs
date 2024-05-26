using Dependency_Inversion_Principle;

IRepository repository = new DatabaseRepository();
Service service = new Service(repository);

service.DisplayData();