## Documentação Completa sobre Operadores Relacionais no C#

Os **operadores relacionais** no C# são usados para comparar dois valores e retornam um resultado **booleano** (*true* ou *false*). Eles são fundamentais para expressões condicionais, como em estruturas de controle (if, while, for).

1️⃣ **Lista de Operadores Relacionais**<br />
Os operadores relacionais disponíveis no C# são:

| Operador   | Descrição          |Exemplo    | Retorno |
|------------|--------------------|-----------|---------|
| ==         | 	Igualdade	      | 5 == 5	  |true     |
| !=         | 	Diferente	      | 5 != 3	  |true     |
| >	         |  Maior que	      | 10 > 5	  |true     |
| <	         |  Menor que	      | 5 < 10	  |true     |
| >=         | 	Maior ou igual	  | 10 >= 10  |true     |
| <=         | 	Menor ou igual	  | 5 <= 10   |true     |

📌 **Importante:** <br />
O resultado de uma comparação sempre será true ou false.
Os operadores podem ser usados para comparar tipos numéricos, char, bool, e string.

2️⃣ **Exemplos de Uso**<br />
📌 **Comparação Simples**

```
int a = 10;
int b = 5;

Console.WriteLine(a == b);  // false
Console.WriteLine(a != b);  // true
Console.WriteLine(a > b);   // true
Console.WriteLine(a < b);   // false
Console.WriteLine(a >= 10); // true
Console.WriteLine(b <= 3);  // false

```

📌 **Comparação entre char**
O C# permite comparar char, pois internamente são representados por **valores numéricos Unicode**.<br />

```
char letra1 = 'A';
char letra2 = 'B';

Console.WriteLine(letra1 < letra2); // true ('A' vem antes de 'B' na tabela Unicode)

```

📌 **Comparação entre string**<br />
As strings podem ser comparadas usando == e !=, mas a comparação é case-sensitive.<br />

```
string nome1 = "Lucas";
string nome2 = "lucas";

Console.WriteLine(nome1 == nome2);  // false (C# diferencia maiúsculas de minúsculas)
Console.WriteLine(nome1 != nome2);  // true

```

📌 **Para comparar ignorando maiúsculas/minúsculas**, usamos *Equals* com *StringComparison.OrdinalIgnoreCase*:<br />
```
Console.WriteLine(nome1.Equals(nome2, StringComparison.OrdinalIgnoreCase)); // true

```

3️⃣ **Operadores Relacionais em Estruturas Condicionais**<br />
Os operadores relacionais são muito usados para tomadas de decisão.

📌 **Exemplo 1:** Uso com if

```
int idade = 18;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}

```

📌 **Exemplo 2:** Comparação em while

```
int contador = 0;

while (contador < 5)
{
    Console.WriteLine($"Contador: {contador}");
    contador++;
}

```
🔹 O loop continua enquanto contador < 5 for verdadeiro.<br />

📌 **Exemplo 3:** Uso em for <br/>

```
for (int i = 10; i > 0; i--)
{
    Console.WriteLine($"Contagem regressiva: {i}");
}

Console.WriteLine("Feliz Ano Novo!");

```

4️⃣ **Comparação entre Tipos Diferentes**<br />
O C# permite comparar diferentes tipos numéricos (int, double, float), mas pode haver conversão implícita.<br />

```
int inteiro = 10;
double decimalNum = 10.0;

Console.WriteLine(inteiro == decimalNum); // true (10 == 10.0)

```

📌 Cuidado com comparações entre float e double, pois podem ocorrer imprecisões.


5️⃣ **Aplicações Práticas** <br />
📌 **Exemplo 1:** Validação de Entrada do Usuário <br />

```
Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Você pode dirigir.");
}
else
{
    Console.WriteLine("Você ainda não pode dirigir.");
}

```
📌 **Exemplo 2:** Comparação em Regras de Descontos<br />

```
double preco = 120.0;

if (preco > 100)
{
    Console.WriteLine("Você ganhou um desconto de 10%!");
}

```

6️⃣ **Diferença entre = e ==** <br />
Um erro comum é confundir = (atribuição) com == (comparação).<br />

```
int x = 10;  // Atribuição
if (x == 10) // Comparação
{
    Console.WriteLine("X é igual a 10.");
}

```
📌 **Erro comum:** <br />

```
if (x = 10) // ERRO! `=` não pode ser usado para comparação

```

7️⃣ **Resumo dos Operadores Relacionais** <br />

| Operador   | Descrição          | Exemplo    | Retorno      |
|------------|--------------------|------------|--------------|
|==          |Igual	              | x == y	   |true ou false |
|!=          |Diferente	          | x != y	   |true ou false |
|>	         |Maior que	          | x > y	   |true ou false |
|<	         |Menor que	          | x < y	   |true ou false |
|>=          |Maior ou igual	  | x >= y	   |true ou false |
|<=          |Menor ou igual	  | x <= y	   |true ou false |

📌 **Conclusão**<br />
✅ Operadores relacionais são usados para comparar valores e retornam true ou false.<br />
✅ Podem ser aplicados a números, char, string e outros tipos.<br />
✅ São essenciais para tomadas de decisão em if, while, for.<br />
✅ Evitar confundir = (atribuição) com == (comparação).<br />


<br/>
<div style="display: flex; justify-content: space-between;">  
   <a href="arithmetic-operators.md">Voltar: Documentação Completa sobre Operadores Aritméticos no C#</a>  
</div>





