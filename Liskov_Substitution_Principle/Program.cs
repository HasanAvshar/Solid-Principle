using Liskov_Substitution_Principle;

Bird eagle = new Eagle();
Bird penguin = new Penguin();

eagle.Fly(); 
try
{
    penguin.Fly();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message); 
}
   