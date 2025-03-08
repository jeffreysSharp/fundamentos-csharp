namespace CSharp.Fundamentals.POO.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("  Som genérico de animal");
        }
    }
}   

