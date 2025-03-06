## Documentação Completa sobre o Operador Ternário (?:) no C#

O operador ternário (?:) é uma alternativa compacta ao if-else, permitindo escrever expressões condicionais em uma única linha.

1️⃣ **O que é o Operador Ternário?**<br />
O operador ternário (?:) é um operador condicional que avalia uma expressão e retorna um dos dois valores possíveis com base no resultado da avaliação.

📌 **Sintaxe Geral:**<br />
```
condição ? valor_se_verdadeiro : valor_se_falso;

```

🔹 Se a condição for true, retorna valor_se_verdadeiro. <br />
🔹 Se a condição for false, retorna valor_se_falso. <br />

2️⃣ **Exemplo Básico** <br />
```
int idade = 18;
string mensagem = (idade >= 18) ? "Maior de idade" : "Menor de idade";
Console.WriteLine(mensagem);

```
📌 **Explicação:**<br />
✔ Se idade >= 18, retorna "Maior de idade".
✔ Caso contrário, retorna "Menor de idade".

3️⃣ **Diferença entre if-else e o Operador Ternário**<br />
Podemos reescrever o mesmo código utilizando if-else:
```
if (idade >= 18)
    mensagem = "Maior de idade";
else
    mensagem = "Menor de idade";

```

📌 **Vantagens do operador ternário:**<br />
✅ Código mais compacto e legível quando há apenas uma única instrução condicional.<br />
✅ Melhora a clareza em atribuições diretas.<br />

4️⃣ **Exemplo de Uso com Tipos Diferentes**<br />
O operador ternário pode ser usado para definir valores numéricos, strings, objetos ou até chamadas de métodos.<br />

📌 **Exemplo com Números** <br />

```
int numero = 10;
int resultado = (numero % 2 == 0) ? 100 : 200;
Console.WriteLine(resultado); // 100

```
✔ Se numero for par, resultado = 100, senão resultado = 200.<br />

📌 **Exemplo com bool**<br />
```
bool estaChovendo = true;
string acao = estaChovendo ? "Levar guarda-chuva" : "Ir sem guarda-chuva";
Console.WriteLine(acao);

```
✔ Se estaChovendo == true, retorna "Levar guarda-chuva", senão "Ir sem guarda-chuva".<br />

📌 **Exemplo com Objetos**<br />
```
class Pessoa
{
    public string Nome { get; set; }
}

Pessoa pessoa = null;
string nomePessoa = (pessoa != null) ? pessoa.Nome : "Nome não disponível";
Console.WriteLine(nomePessoa);

```
✔ Evita NullReferenceException ao acessar pessoa.Nome.<br />

5️⃣ **Operador Ternário Aninhado**<br />
Podemos aninhar operadores ternários para criar múltiplas verificações.<br />

```
int nota = 85;
string desempenho = (nota >= 90) ? "Excelente"
                 : (nota >= 75) ? "Bom"
                 : (nota >= 50) ? "Regular"
                 : "Insuficiente";

Console.WriteLine(desempenho);

```

📌 **Explicação:**<br />
✔ Se nota >= 90, retorna "Excelente".<br />
✔ Se nota >= 75, retorna "Bom".<br />
✔ Se nota >= 50, retorna "Regular".<br />
✔ Caso contrário, retorna "Insuficiente".<br />

6️⃣ **Operador Ternário vs if-else**<br />

| Característica         | if-else                         | Operador Ternário                |
|------------------------|---------------------------------|----------------------------------|
| Legibilidade	         | Melhor para condições complexas |Melhor para expressões simples    |
| Performance	         | Sem diferença significativa	   |Sem diferença significativa       |
| Facilidade de Leitura	 | Melhor para múltiplas condições |Compacto para atribuições simples |
| Uso recomendado	     | Controle de fluxo mais extenso  |Expressões curtas e diretas       |

7️⃣ **Boas Práticas**<br />
✔ Usar o operador ternário para expressões simples e diretas.<br />
✔ Evitar operadores ternários aninhados, pois podem comprometer a legibilidade.<br />
✔ Usar if-else para condições complexas ou que exijam várias operações.<br />

📌 **Evite isso:**
```
string resultado = (idade >= 18) ? 
                   ((idade >= 65) ? "Idoso" : "Adulto") : 
                   ((idade >= 12) ? "Adolescente" : "Criança");

```

📌 **Prefira isso:** <br />
```
string resultado;
if (idade >= 65)
    resultado = "Idoso";
else if (idade >= 18)
    resultado = "Adulto";
else if (idade >= 12)
    resultado = "Adolescente";
else
    resultado = "Criança";

```

✔ Melhor legibilidade!<br />


8️⃣ **Resumo do Operador Ternário**<br />

| Operador         | Nome                         | Descrição                | Exemplo | Retorno |
|------------------|------------------------------|--------------------------|---------|---------|
| ?:               | Operador Ternário            | Avalia uma condição e retorna um dos dois valores                          | (idade >= 18) ? "Maior" : "Menor"        |   "Maior" ou "Menor"  |  


📌 **Conclusão**<br />
✅ O operador ternário (?:) é uma alternativa compacta ao if-else.<br />
✅ Permite expressões condicionais curtas e diretas.<br />
✅ Melhora a legibilidade em atribuições simples.<br />
✅ Evitar aninhamento excessivo para manter o código claro.<br />

<br/>
<div style="display: flex; justify-content: space-between;">  
   <a href="logic-operator.md">Voltar: Documentação Completa sobre Operadores Lógicos no C#</a>  <br />
     <a href="functions.md">Avançar: Documentação Completa sobre Funções no .NET (C#)</a>  
</div>





