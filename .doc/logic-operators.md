## Documentação Completa sobre Operadores Lógicos no C#

Os operadores lógicos são usados para combinar ou inverter expressões booleanas (true ou false). Eles são amplamente utilizados em estruturas condicionais (if, while, for) e em operações de lógica booleana.

1️⃣ **Lista de Operadores Lógicos**<br />
Os operadores lógicos disponíveis no C# são:

| Operador   | Nome          | Descrição                                                    | Exemplo        | Retorno      |
|------------|---------------|--------------------------------------------------------------|----------------|--------------|
|&&	         |  E (AND)	     | Retorna true se ambas as expressões forem verdadeiras	    |(true && false) |	false       |
|`			 |               | `                                                            | OU (OR)        | Retorna true se pelo menos uma das expressões for verdadeira|
|!	         |  NÃO (NOT)	 | Inverte o valor de uma expressão booleana	                | !true	false    |  false       |


📌 **Observação:**
- && (AND) → Ambos os valores precisam ser true para o resultado ser true.
- || (OR) → Basta um dos valores ser true para o resultado ser true.
- ! (NOT) → Inverte o valor (true se torna false, e vice-versa).

2️⃣ **Exemplos de Uso**<br />
📌 **Uso de && (E lógico)** <br />

```
bool condicao1 = true;
bool condicao2 = false;

Console.WriteLine(condicao1 && condicao2); // false
Console.WriteLine(true && true);  // true
Console.WriteLine(false && true); // false
Console.WriteLine(false && false);// false

```

✔ O resultado só será true se ambas as condições forem verdadeiras.<br />

📌 **Uso de || (OU lógico)**

```
bool condicao1 = true;
bool condicao2 = false;

Console.WriteLine(condicao1 || condicao2); // true
Console.WriteLine(true || true);  // true
Console.WriteLine(false || true); // true
Console.WriteLine(false || false);// false

```

📌 **Uso de ! (NÃO lógico)**
```
bool condicao = true;
Console.WriteLine(!condicao); // false

Console.WriteLine(!false); // true
Console.WriteLine(!true);  // false

```
✔ O operador ! inverte o valor da variável booleana. <br />

3️⃣ **Operadores Lógicos em Estruturas Condicionais**<br />
Os operadores lógicos são amplamente usados em estruturas condicionais para tomar decisões mais complexas.<br />

📌 **Exemplo 1:** Verificação Múltipla com &&<br/>

```
int idade = 25;
bool temHabilitacao = true;

if (idade >= 18 && temHabilitacao)
{
    Console.WriteLine("Pode dirigir.");
}
else
{
    Console.WriteLine("Não pode dirigir.");
}

```
✔ O motorista só pode dirigir se tiver 18 anos ou mais E possuir habilitação.<br/>

📌 **Exemplo 2:** Verificação com ||<br />

```
bool temConvite = false;
bool estaNaListaVip = true;

if (temConvite || estaNaListaVip)
{
    Console.WriteLine("Pode entrar na festa.");
}
else
{
    Console.WriteLine("Acesso negado.");
}

```
✔ O visitante pode entrar se tiver um convite OU estiver na lista VIP.<br />

📌 **Exemplo 3:** Negação com !<br />
```
bool estaChovendo = true;

if (!estaChovendo)
{
    Console.WriteLine("Vamos ao parque!");
}
else
{
    Console.WriteLine("Melhor ficar em casa.");
}

```
✔ A condicional if (!estaChovendo) verifica se NÃO está chovendo. <br />

4️⃣ **Curto-Circuito (&& e ||)**<br />
O C# possui um mecanismo de curto-circuito, o que significa que a avaliação pode parar antes de verificar todas as condições.<br />

📌 **Exemplo com && (Curto-Circuito)**

```
bool Teste1()
{
    Console.WriteLine("Executando Teste1...");
    return false;
}

bool Teste2()
{
    Console.WriteLine("Executando Teste2...");
    return true;
}

Console.WriteLine(Teste1() && Teste2()); 

```
🔹 **Saída:**

```
Executando Teste1...
False

```

📌 **Explicação:** Como Teste1() retorna false, o && não avalia Teste2(), pois o resultado final já será false. <br />
✔ Isso melhora a eficiência do código, evitando verificações desnecessárias.<br />

5️⃣ **Operações Lógicas em Expressões Complexas** <br />
Os operadores lógicos podem ser combinados em expressões complexas.<br />

📌 **Exemplo 1:** Autenticação de Usuário

```
string usuario = "admin";
string senha = "12345";

if (usuario == "admin" && senha == "12345")
{
    Console.WriteLine("Login bem-sucedido!");
}
else
{
    Console.WriteLine("Usuário ou senha incorretos.");
}

```
✔ O usuário só será autenticado se o nome de usuário for "admin" E a senha estiver correta.<br />

📌 **Exemplo 2:** Aprovação de Aluno

```
double nota1 = 7.5;
double nota2 = 8.0;
double media = (nota1 + nota2) / 2;
bool temFrequenciaSuficiente = true;

if (media >= 7.0 && temFrequenciaSuficiente)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno reprovado.");
}

```
✔ O aluno será aprovado se a média for 7.0 ou mais E tiver presença suficiente.<br />

📌 **Exemplo 3:** Sistema de Segurança<br />

```
bool portaAberta = false;
bool janelaAberta = true;
bool alarmeAtivado = true;

if ((portaAberta || janelaAberta) && alarmeAtivado)
{
    Console.WriteLine("Alerta! Possível invasão detectada!");
}
else
{
    Console.WriteLine("Sistema seguro.");
}

```
✔ O alarme será disparado se uma porta ou janela estiver aberta E o alarme estiver ativado.<br />

📌 **Conclusão** <br />
✅ Os operadores lógicos combinam expressões booleanas (true ou false). <br />
✅ && (E) → Retorna true se ambas as condições forem verdadeiras. <br />
✅ || (OU) → Retorna true se pelo menos uma condição for verdadeira. <br />
✅ ! (NÃO) → Inverte um valor booleano (true ↔ false). <br />
✅ Curto-circuito otimiza a execução (&& e || param a avaliação quando possível). <br />
✅ Essenciais para controle de fluxo, autenticação e lógica condicional. <br />

<br/>
<div style="display: flex; justify-content: space-between;">  
   <a href="relational-operators.md">Voltar: Documentação Completa sobre Operadores Relacionais no C#</a><br />  
   <a href="ternary-operator.md">Avançar: Documentação Completa sobre o Operador Ternário (?:) no C#</a>  
</div>



