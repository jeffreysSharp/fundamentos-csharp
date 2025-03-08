## Documentação Completa sobre Programação Orientada a Objetos (POO)
<p>
Aqui, exploraremos **classes, interfaces, classes abstratas e classes seladas**. Para compreender esses conceitos de forma eficiente, é essencial uma breve introdução à Programação Orientada a Objetos (POO), pois ela serve como base para todos esses elementos.
</p>
<p>
O termo Programação Orientada a Objetos (POO) foi criado por Alan Kay, o mesmo criador da linguagem Smalltalk. Embora esse paradigma tenha sido desenvolvido anteriormente, sua popularização ocorreu principalmente na década de 1990, consolidando-se como um dos modelos mais utilizados no desenvolvimento de software.
A **Programação Orientada a Objetos** é um paradigma essencial no desenvolvimento de Software moderno. Ela permite organizer o código de forma mais intuitiva, reutilizável e escalável. No C# a POO é amplamente utilizada para desenvolver aplicações robustas e modulares.
</p>


### 1️⃣ O que é Programação Orientada a Objetos?
<p>
A **POO (Programação Orientada a objetos)** é um paradigma baseado no conceito de **objetos**, que são instancias de **classes** contendo dados (atributos) e **comportamentos** (métodos). A idéia principal da POO é **modelar o mundo real dentro do Software**.
</p>

📌 **Principais Benefícios da POO:**<br>

✅ **Reutilização de Código** – Evita repetição desnecessária através da herança.<br>
✅ **Facilidade de Manutenção** – Código modular e bem organizado.<br>
✅ **Escalabilidade** – Facilita o crescimento e expansão do software.<br>
✅ **Encapsulamento** – Protege os dados e evita acesso indevido.<br>

### 2️⃣ Os Quatro Pilares da POO

A POO se baseia em quatro princípios fundamentais:

| Pilar                  | Descrição                                                                                                     |
|------------------------|---------------------------------------------------------------------------------------------------------------|
| Encapsulamento         | Restringe o acesso aos detalhes internos de um objeto, expondo apenas o necessário                            |
| Herança                | Permite que uma classe derive características e comportamento de outra                                        |  
| Polimorfismo           | Objetos podem ter múltiplas formas, permitindo reuso e flexibilidade                                          |
| Abstração              | Oculta detalhes complexos, fornecendo apenas a interface necessária                                      |        

**Vamos entender cada um deles com exemplos!**

### 3️⃣ Classes e Objetos

- Classe → É um molde ou um modelo para criar objetos.
- Objeto → É uma instância de uma classe, ou seja, uma entidade real baseada no modelo da classe.

✅ **Exemplo de Classe e Objeto em C#:**

```
public class Car
{
    public string Model { get; set; }
    public int Year { get; set; }

    public void Drive()
    {
        Console.WriteLine($"Dirigindo o {Model} - {Year}");
    }
}

// Criando um objeto
Car myCar = new Car { Model = "Tesla Model S", Year = 2022 };
myCar.Drive();

```

📌 **Saída:** *Dirigindo o Tesla Model S - 2022*
 
 ### 4️⃣ Encapsulamento

 O **encapsulamento** restringe o acesso a partes do código, protegendo os dados dentro de uma classe.

 ✅ Exemplo de Encapsulamento com **private** e **public**<br />

 ```

public class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}

// Criando conta bancária
BankAccount account = new BankAccount();
account.Deposit(1000);
Console.WriteLine(account.GetBalance());

 ```
📌 **Saída:** *1000*

### 5️⃣ Herança

A **herança** permite que uma classe derive de outra, herdando seus atributos e métodos.

✅ **Exemplo de Herança em C#**

```
public class Animal
{
    public string Name { get; set; }
    public void MakeSound()
    {
        Console.WriteLine("Som genérico de animal");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

Dog dog = new Dog { Name = "Rex" };
dog.MakeSound(); // Som genérico de animal
dog.Bark(); // Woof! Woof!

```

### 6️⃣ Polimorfismo

O polimorfismo permite que métodos tenham comportamentos diferentes dependendo do contexto.<br />

✅ **Exemplo de Polimorfismo com Sobrescrita (override)**

```
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Som genérico de animal");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

Animal myCat = new Cat();
myCat.MakeSound(); // Meow!

```

### 7️⃣ Abstração

A abstração oculta detalhes complexos, expindo apenas o necessário

```
public abstract class Vehicle
{
    public abstract void Move();
}

public class Bicycle : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Pedalando a bicicleta!");
    }
}

Vehicle bike = new Bicycle();
bike.Move(); // Pedalando a bicicleta!

```

🎯 ***Conclusão***<br />

🚀 Agora você tem um guia completo sobre Programação Orientada a Objetos em C#!<br />
✅ Aprendeu sobre classes, objetos, encapsulamento, herança, polimorfismo e abstração.<br />
✅ Viu exemplos práticos para cada pilar da POO.<br />

































![](/img/oop.JPG)

Aqui iremos conhecer o que são classes, interfaces, classes abstratas e seladas, sendo assim é de extrema importância eu fazer uma pequena introdução do que é programação orientada a Objetos.

Até o módulo anterior estavamos focados nos conceitos básicos da linguagem C#, mas a partir desse momento iremos nos aprofundar um pouco mais no C# e a Programação Orientada a Objetos    e como podemos utilizar no nosso dia a dia.

A Programação Orientada a Objetos é um paradigma da programação.

Vamos começar aqui com um pouco da história:

Esse termo Programação Orientada a Objetos foi criada por Alan Kay, que é ninguém mais que o criador da linguagem SmallTalk, e apesar de ser um paradigma um pouco antigo, ele foi mais difundido por volta dos anos 90.

A Programação Orientada a Objetos é o quie você vai encontrar de mais próximo do mundo real e o mundo virtual  e é formado por quatro pilares.

![](/img/oop-4pilares.JPG)

E tudo isso você irá aprender nesse módulo.

Vamos pegar um exemplo prático de onde podemos aplicar a Programação Orientada a Objetos.

Quando eu falei que é um paradigma mais próximo da vida real, eu quiz me referir o seguinte: 
Imagine um cenário onde você está em uma loja virtual e faz o seu cadastro, loja captura os seus dados.

![](/img/oop-exemplo-loja.JPG)

Então cria um objeto para representar você.

![](/img/oop-objeto-pessoa.JPG)

Esse objeto contém todos atributos, como dito anteriormente, com seu nome, endereço, cidade, estado, CEP e demais informações sobre você, isso é uma das maravilhas da Programação Orientada a objetos.

Vamos nos aprofundar um pouco mais sobre esses conceitos de forma bem prática e simples.















<br/>
<div style="display: flex; justify-content: space-between;">  
   <a href="control-structure.md">Voltar: Documentação Completa sobre Estruturas de Controle no C#</a>  
</div>





