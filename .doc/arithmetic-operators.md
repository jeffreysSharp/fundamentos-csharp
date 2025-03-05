## Documentação Completa sobre Operadores Aritméticos no C#

Os **operadores aritméticos** no C# são utilizados para realizar operações matemáticas, como soma, subtração, multiplicação e divisão. Esses operadores podem ser aplicados a **tipos numéricos** como *int*, *double*, *decimal*, entre outros.


1️⃣ **Lista de Operadores Aritméticos**<br />
O C# fornece os seguintes operadores aritméticos:
| Operador   | Descrição                            |Exemplo | Resultado |
|------------|--------------------------------------|--------|-----------|
|+	         | Adição	                            |10 + 5	 | 15        |
|-	         | Subtração	                        |10 - 5	 | 5         |
|*	         | Multiplicação	                    |10 * 5	 | 50        |
|/	         | Divisão	                            |10 / 5	 | 2         |
|%	         | Módulo (Resto da divisão)            |10 % 3	 | 1         |
|++	         | Incremento	x++ (pós-incremento)    |x = x + | 1         |
|--	         | Decremento	x-- (pós-decremento)    |x = x - | 1         |

📌 **Observação:**<br />
- A divisão entre inteiros (*int*) retorna apenas a parte inteira (exemplo: 5 / 2 = 2).
- O operador % retorna o resto da divisão.

2️⃣ **Exemplos de Uso** <br />
Abaixo estão exemplos práticos de cada operador:<br />

📌 **Operações Básicas** 
```
int a = 10;
int b = 5;

Console.WriteLine($"Soma: {a + b}");          // 15
Console.WriteLine($"Subtração: {a - b}");     // 5
Console.WriteLine($"Multiplicação: {a * b}"); // 50
Console.WriteLine($"Divisão: {a / b}");       // 2
Console.WriteLine($"Módulo: {a % 3}");        // 1

```
📌 **Divisão entre inteiros descarta a parte decimal.** <br />
Para um resultado mais preciso, devemos usar *double* ou *float*:

```
double x = 10;
double y = 3;
double resultado = x / y;

Console.WriteLine($"Divisão com double: {resultado}"); // 3.3333

```

📌 **Incremento e Decremento**<br />
Os operadores **++** e **--** aumentam ou diminuem um valor **em 1 unidade**.
```
int num = 5;
num++;  // Equivalente a: num = num + 1;
Console.WriteLine(num); // 6

num--;  // Equivalente a: num = num - 1;
Console.WriteLine(num); // 5

```

📌 **Pré e Pós-Incremento**<br />
```
int valor = 5;
Console.WriteLine(valor++); // Exibe 5, depois incrementa para 6
Console.WriteLine(valor);   // Agora valor = 6

int outroValor = 5;
Console.WriteLine(++outroValor); // Incrementa antes, exibe 6

```

🔹 **x++** (pós-incremento) → Primeiro usa o valor, depois incrementa.<br />
🔹 **++x** (pré-incremento) → Primeiro incrementa, depois usa o valor.<br />

3️⃣ **Precedência e Associatividade** <br />
A **precedência dos operadores** define a **ordem de execução das operações**.<br />

| Ordem   | Operador|Descrição                        |
|---------|---------|---------------------------------|
|1º	      |++ --	| Incremento e Decremento         |
|2º	      |* / %	| Multiplicação, Divisão e Módulo |
|3º	      |+ -	    | Soma e Subtração                | 

**Exemplo:**<br />
```
int resultado = 10 + 5 * 2; // Multiplicação ocorre primeiro
Console.WriteLine(resultado); // 20

```

🔹 **Para mudar a ordem, usamos parênteses ():**<br />
```
int resultado = (10 + 5) * 2;
Console.WriteLine(resultado); // 30

```
📌 **Regra geral:** <br />
- Multiplicação, divisão e módulo têm maior prioridade que soma e subtração.
- Operações dentro de parênteses são executadas primeiro.

4️⃣ **Operadores de Atribuição Aritmética**<br />
Podemos combinar operadores aritméticos com a atribuição = para simplificar expressões.

| Operador   | Equivalente a |Exemplo          |
|------------|---------------|-----------------|
|+=	         |x = x + y	     |x += 5;          |
|-=	         |x = x - y	     |x -= 5;          |
|*=	         |x = x * y	     |x *= 5;          |
|/=	         |x = x / y	     |x /= 5;          |
|%=	         |x = x % y	     |x %= 5;          |


📌 **Exemplo** <br />
```
int num = 10;
num += 5;  // num = num + 5 (15)
num -= 3;  // num = num - 3 (12)
num *= 2;  // num = num * 2 (24)
num /= 4;  // num = num / 4 (6)
num %= 5;  // num = num % 5 (1)

Console.WriteLine(num); // 1

```
📌 **Benefícios:** Torna o código mais limpo e eficiente.<br />

5️⃣ **Aplicações Reais**<br />
📌 **Exemplo 1:** Cálculo de Média<br />

```
double nota1 = 7.5;
double nota2 = 8.0;
double nota3 = 6.5;

double media = (nota1 + nota2 + nota3) / 3;
Console.WriteLine($"Média: {media}");

```

📌 **Exemplo 2:** Cálculo de Juros Compostos<br />

```
double capital = 1000;
double taxa = 0.05; // 5%
int meses = 12;

double montante = capital * Math.Pow(1 + taxa, meses);
Console.WriteLine($"Montante final: {montante:C}");

```

🔹 Utilizamos Math.Pow(base, expoente) para calcular a potência.<br />

📌 **Exemplo 3:** Contagem Regressiva

```
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("Feliz Ano Novo!");

```
🔹 O operador -- decrementa a variável no loop. <br/>

6️⃣ **Resumo dos Operadores**<br />

| Operador   | Função                         |Exemplo          |
|------------|--------------------------------|-----------------|
| +	         | Soma	                          |x + y            |
| -	         | Subtração	                  |x - y            |
| *	         | Multiplicação	              |x * y            |
| /	         | Divisão	                      |x / y            |
| %	         | Módulo	                      |x % y            |
| ++         | Incremento	                  |x++ ou ++x       | 
| --         | Decremento	                  |x-- ou --x       | 
| +=         | Atribuição com soma            |x += 5;          |
| -=         | Atribuição com subtração	      |x -= 5;          |
| *=         | Atribuição com multiplicação	  |x *= 5;          |
| /=         | Atribuição com divisão	      |x /= 5;          |
| %=         | Atribuição com módulo	      |x %= 5;          |


📌 **Conclusão**<br />
✅ Operadores aritméticos realizam operações matemáticas básicas.<br />
✅ A precedência define a ordem das operações.<br />
✅ Atribuições compostas (+=, -=) tornam o código mais eficiente.<br />
✅ Podemos aplicar operadores para cálculos financeiros, estatísticos e loops.<br />

<br/>
<div style="display: flex; justify-content: space-between;">  
   <a href="variables.md">Voltar: Documentação Completa sobre Variáveis no C#</a><br />  
   <a href="relational-operators.md">Avançar:  Documentação Completa sobre Operadores Relacionais no C#</a>  
</div>





