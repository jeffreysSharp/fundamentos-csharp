using CSharp.Fundamentals.POO.Models;

// Criando um Objeto
Car myCar = new Car
{
    Model = "Tesla Model S",
    Year = 2022
};

myCar.Drvive();


// Encapsulamento
BanckAccount account = new BanckAccount();
account.Deposit(1000);
Console.WriteLine("===============================");
Console.WriteLine();
Console.WriteLine("  Exemplo de Ecapsulamento:");
Console.WriteLine();
Console.WriteLine($"  Saldo: {account.GetBalance()}");
Console.WriteLine();
Console.WriteLine("===============================");


// Herança
Dog dog = new Dog { Name = "Rex" };
Console.WriteLine("===============================");
Console.WriteLine();
Console.WriteLine("  Exemplo de Herança:");
Console.WriteLine();
dog.MakeSound();
Console.WriteLine($"  Cachorro: ");
dog.Bark();
Console.WriteLine();
Console.WriteLine("===============================");

// Polimorfismo
Animal myCat = new Cat();
Console.WriteLine("===============================");
Console.WriteLine();
Console.WriteLine("  Exemplo de Polimorfismo:");
Console.WriteLine();
Console.WriteLine($"  Gato: ");
myCat.MakeSound();
Console.WriteLine();
Console.WriteLine("===============================");

// Abstração
Vehicle bike = new Bicyle();
Console.WriteLine("===============================");
Console.WriteLine();
Console.WriteLine("  Exemplo de Abstração:");
bike.Move();
Console.WriteLine();
Console.WriteLine("===============================");


