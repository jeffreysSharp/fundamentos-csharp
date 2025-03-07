## Documentação Completa sobre Funções no (C#)

As **funções** são um dos principais conceitos da programação em C#, permitindo **modularizar o código**, **reutilizar lógica e melhorar a organização do projeto**. No .NET, funções são métodos definidos dentro de classes, podendo ser chamados e reutilizados de diferentes maneiras.

1️⃣ **O que são Funções em C#?**<br />
Uma **função (método)** é um bloco de código que executa uma operação específica. Em C#, todas as funções devem ser definidas dentro de uma classe ou struct.

📌 **Sintaxe básica de uma função em C#:**<br />
```
[ModificadorDeAcesso] [TipoDeRetorno] NomeDaFuncao([Parâmetros])
{
    // Corpo da função
    return valor; // (Opcional, se houver retorno)
}

```
📌 **Exemplo de uma função que retorna um número inteiro:**<br />

```
public int Somar(int a, int b)
{
    return a + b;
}

```

✅ **Explicação:** <br/>
✔ public → Modificador de acesso (a função pode ser acessada de fora da classe).<br/>
✔ int → Tipo de retorno da função (neste caso, retorna um número inteiro).<br/>
✔ Somar(int a, int b) → Nome da função e parâmetros que ela recebe.<br/>
✔ return a + b; → Retorna o resultado da soma.<br/>

2️⃣ **Tipos de Funções em C#** <br />
As funções podem ser classificadas de diversas formas, dependendo de sua **assinatura, escopo e comportamento.**<br />

📌 **2.1. Funções com e sem Retorno**<br />
🔹 **Função com retorno** (retorna um valor específico):<br />
```
public double CalcularDesconto(double valor, double porcentagem)
{
    return valor - (valor * (porcentagem / 100));
}

```

🔹 **Função sem retorno**(void não retorna nada, apenas executa ações):<br />

📌 **2.2. Funções com Diferentes Modificadores de Acesso**<br />
Os modificadores de acesso determinam **quem pode chamar a função**.<br />

| Modificador         | Descrição                                                                   |
|---------------------|-----------------------------------------------------------------------------|
|public	              |Pode ser chamado de qualquer lugar.                                          |
|private	          |Pode ser chamado apenas dentro da classe onde foi definida.                  |
|protected	          |Pode ser chamado dentro da própria classe e em classes derivadas (herança).  |
|internal	          |Pode ser chamado dentro do mesmo projeto (assembly).                         |
|protected internal	  |Pode ser acessado dentro do mesmo assembly e por classes derivadas.          |
|private protected	  |Pode ser acessado apenas em classes derivadas dentro do mesmo assembly.      |

📌 **Exemplo de função privada (private):** <br />

```
private void ExibirMensagemSecreta()
{
    Console.WriteLine("Esta mensagem só pode ser vista dentro desta classe.");
}

```

📌 **2.3. Funções Estáticas (static)** <br />
As funções estáticas pertencem à classe e não a uma instância específica.

📌 **Exemplo de uma função estática:**
```
public static int Multiplicar(int a, int b)
{
    return a * b;
}

```
✅ **Não precisa criar uma instância da classe para chamar uma função estática:**<br />

```
int resultado = MinhaClasse.Multiplicar(5, 3);

```

📌 **2.4. Funções Assíncronas (async)** <br/>
O C# permite a criação de funções assíncronas, que são úteis para operações que podem levar tempo (como chamadas de API ou acesso a banco de dados).<br />

📌 **Exemplo de uma função assíncrona (async e await):**<br />
```
public async Task<string> ObterDadosAsync()
{
    await Task.Delay(2000); // Simula um atraso de 2 segundos
    return "Dados carregados!";
}

```
✅ **Chamada de uma função assíncrona:**<br />
```
string resultado = await ObterDadosAsync();
Console.WriteLine(resultado);

```

📌 **2.5. Funções Anônimas (Lambda e Delegates)** <br />
O C# permite criar **funções anônimas** sem precisar definir um método explicitamente.<br />

🔹 **Exemplo de função anônima com delegate:** <br/>
```
Func<int, int, int> somar = (a, b) => a + b;
Console.WriteLine(somar(3, 5)); // Retorna 8

```

✅ **Explicação:**<br />
✔ Func<int, int, int> → Define uma função que recebe dois inteiros e retorna um inteiro.<br />
✔ (a, b) => a + b; → Expressão Lambda que executa a soma.<br />

📌 **2.6. Sobrecarga de Funções (Method Overloading)**<br/>
C# permite criar **múltiplas funções com o mesmo nome, mas com parâmetros diferentes**.

📌 **Exemplo de sobrecarga de métodos (Method Overloading):**
```
public int Somar(int a, int b) => a + b;
public double Somar(double a, double b) => a + b;
public int Somar(int a, int b, int c) => a + b + c;

```
✅ **O compilador escolhe automaticamente a função correta dependendo dos parâmetros.**<br />

```
Console.WriteLine(Somar(5, 10));     // Usa a versão int
Console.WriteLine(Somar(5.5, 2.3));  // Usa a versão double
Console.WriteLine(Somar(1, 2, 3));   // Usa a versão com 3 parâmetros

```

3️⃣ **Passagem de Parâmetros em Funções**<br />

O C# permite diferentes formas de passar parâmetros para funções.

📌 **3.1. Parâmetros Opcionais**<br />
Os parâmetros opcionais permitem definir valores padrão, caso não sejam informados na chamada.

```
public void ExibirMensagem(string mensagem = "Olá, Mundo!")
{
    Console.WriteLine(mensagem);
}

ExibirMensagem(); // Saída: Olá, Mundo!
ExibirMensagem("Bem-vindo!"); // Saída: Bem-vindo!

```

📌 **3.2. Parâmetros Nomeados**<br />
Podemos chamar funções informando explicitamente o nome do parâmetro.<br />
```
public void ConfigurarUsuario(string nome, int idade)
{
    Console.WriteLine($"Nome: {nome}, Idade: {idade}");
}

// Chamando com parâmetros nomeados
ConfigurarUsuario(idade: 30, nome: "João");

```

📌 **3.3. Parâmetros ref e out** <br />
🔹 ref permite modificar o valor original de uma variável passada como argumento.<br />
🔹 out força a função a inicializar a variável antes de retornar.<br />

📌 **Exemplo de ref:**<br />
```
public void DobrarNumero(ref int numero)
{
    numero *= 2;
}

int valor = 5;
DobrarNumero(ref valor);
Console.WriteLine(valor); // Saída: 10

```

📌 **Exemplo de out:**<br />

```
public void GerarNumero(out int numero)
{
    numero = new Random().Next(1, 100);
}

int resultado;
GerarNumero(out resultado);
Console.WriteLine(resultado); // Saída: Número aleatório

```

📌 **Conclusão**<br />
✅ Funções são métodos definidos dentro de classes para modularizar o código.<br />
✅ Podem ser públicas, privadas, estáticas, assíncronas e anônimas.<br />
✅ Suportam parâmetros opcionais, nomeados e passados por referência.<br />
✅ O C# permite sobrecarga de funções e uso de async/await para programação assíncrona.<br />


<br/>
<div style="display: flex; justify-content: space-between;">  
   <a href="ternary-operator.md">Voltar: Documentação Completa sobre o Operador Ternário (?:) no C#</a><br /> 
     <a href="data-structure.md">Avançar: Documentação Completa sobre Estruturas de Dados no C#</a>   
</div>





