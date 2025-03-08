namespace CSharp.Fundamentals.POO.Models
{
    public class Car
    {
        public required string Model { get; set; }
        public int Year { get; set; }

        public void Drvive()
        {
            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("  Exemplo de classe:");
            Console.WriteLine();

            Console.WriteLine($" Dirigindo o {Model} - {Year}");
            Console.WriteLine();
            Console.WriteLine("===============================");
            
        }
    }
}
