namespace Interface_Segregation_Principle
{
    public class Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing document.");
        }
    }
}
