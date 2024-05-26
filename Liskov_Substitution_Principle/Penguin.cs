namespace Liskov_Substitution_Principle
{
    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new InvalidOperationException("Penguins cannot fly.");
        }
    }
}
