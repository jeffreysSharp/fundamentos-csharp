## Documentação Completa sobre Estruturas de Controle no C#

As estruturas de controle são essenciais para definir o fluxo de execução de um programa, permitindo tomada de decisões, repetição de ações e manipulação do fluxo da aplicação.

No C#, existem diversas estruturas de controle, classificadas em:<br/>

📌 **Classificação das Estruturas de Controle**<br />

| Categoria              | Descrição                                                                                                     |
|------------------------|---------------------------------------------------------------------------------------------------------------|
| Laços de Repetição     | Permitem a execução de blocos de código com base em condições. Exemplo: if, switch.                           |
| Controle de Fluxo      | Executam blocos de código repetidamente. Exemplo: for, foreach, while, do-while.                              |
| Tratamento de Exceções | Manipulam a execução do programa, interrompendo ou desviando o fluxo. Exemplo: break, continue, return, goto. |

1️⃣ **O que são Estruturas de Controle?**<br />

As estruturas de controle definem o caminho que o código seguirá com base em condições, repetições ou manipulação do fluxo.<br />

✅ **Condicionais:** controlam decisões lógicas no código.<br />
✅ **Loops:** repetem instruções enquanto a condição for verdadeira.<br />
✅ **Fluxo de execução:** permite interromper ou redirecionar o código.<br />
✅ **Tratamento de erros:** evita falhas inesperadas no sistema.<br />

Agora, vamos explorar cada uma dessas estruturas em detalhes! 🚀<br />

2️⃣ **Estruturas Condicionais** <br />

🔹 **1. if, else if, else**<br />
As estruturas if, else if e else permitem executar diferentes blocos de código conforme uma condição booleana.<br />

```


int idade = 20;

if (idade >= 18)
{
    Console.WriteLine("Maior de idade.");
}
else if (idade >= 16)
{
    Console.WriteLine("Pode votar, mas não pode dirigir.");
}
else
{
    Console.WriteLine("Menor de idade.");
}

```


🔹 **2. switch**<br />
📌 **Exemplo de uso:** <br />

```

char nota = 'B';

switch (nota)
{
    case 'A':
        Console.WriteLine("Excelente!");
        break;
    case 'B':
        Console.WriteLine("Bom trabalho!");
        break;
    case 'C':
        Console.WriteLine("Você pode melhorar.");
        break;
    default:
        Console.WriteLine("Nota inválida.");
        break;
}

```

📌 **Switch Expression (C# 8+)**

```

string mensagem = nota switch
{
    'A' => "Excelente!",
    'B' => "Bom trabalho!",
    'C' => "Você pode melhorar.",
    _   => "Nota inválida."
};

Console.WriteLine(mensagem);

```


3️⃣ **Laços de Repetição (Loops)** <br />

Os loops permitem executar um bloco de código repetidamente enquanto uma condição for verdadeira.<br />

📌 **Tabela de Estruturas de Repetição:** <br />

| Estrutura              | Descrição                                                                                                     |
|------------------------|---------------------------------------------------------------------------------------------------------------|
| for                    | Iteração sobre coleções                                                                                       |
| foreach                | Iteração sobre coleções                                                                                       |
| while                  | Execução baseada em condição                                                                                  |
| do-while               | Executa pelo menos uma vez                                                                                    |

**🔹 1. for**<br />

📌 **Exemplo de uso:**

````

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Iteração {i}");
}

````

🔹 **2. foreach**<br />

📌 **Exemplo de uso:**

```

string[] frutas = { "Maçã", "Banana", "Laranja" };

foreach (var fruta in frutas)
{
    Console.WriteLine(fruta);
}

```

🔹 **3. while**<br />

📌 **Exemplo de uso:**<br />

````

int contador = 0;
while (contador < 3)
{
    Console.WriteLine($"Contagem: {contador}");
    contador++;
}

````

🔹 **4. do-while**<br />

📌 **Exemplo de uso:**<br />

````

int numero;
do
{
    Console.WriteLine("Digite um número positivo:");
    numero = Convert.ToInt32(Console.ReadLine());
} while (numero < 0);

````

4️⃣ **Controle de Fluxo**<br />

| Comando                | Descrição                                                                                                     |
|------------------------|---------------------------------------------------------------------------------------------------------------|
| break                  | Sai do loop imediatamente                                                                                     |
| continue               | Pula para a próxima iteração                                                                                  |
| return                 | Finaliza um método e retorna um valor                                                                         |
| goto                   | Salta para um rótulo específico                                                                               |

📌 **Exemplo de break e continue:** <br />

```

for (int i = 0; i < 10; i++)
{
    if (i == 5) break; // Sai do loop
    if (i % 2 == 0) continue; // Pula números pares
    Console.WriteLine(i);
}

```

5️⃣ **Tratamento de Exceções** <br />

📌 **Exemplo de try-catch-finally:**<br />

```

try
{
    int divisor = 0;
    int resultado = 10 / divisor;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
finally
{
    Console.WriteLine("Execução finalizada.");
}

```

🎯 **Conclusão**

🚀 Agora você tem um guia completo sobre Estruturas de Controle no C#!<br />
✅ Aprendeu como funcionam as estruturas condicionais.<br />
✅ Viu como utilizar loops e controle de fluxo corretamente.<br />
✅ Entendeu a importância do tratamento de exceções.<br />

**Utilizando essas técnicas, seu código será mais organizado, eficiente e seguro!**

<br/>
<div style="display: flex; justify-content: space-between;">  
   <a href="data-structure.md">Voltar: Documentação Completa sobre Estruturas de Dados no C#</a><br />
   <a href="oop.md">Avançar: Documentação Completa sobre Programação Orientada a Objetos (POO)</a>    
</div>





