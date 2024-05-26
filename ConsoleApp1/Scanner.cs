namespace Interface_Segregation_Principle
{
    public class Scanner : IScanner
    {
        public void Scan()
        {
            Console.WriteLine("Scanning document.");
        }
    }
}
