[Back to README](../README.md)

## Documentação Completa sobre Variáveis no C#

1️⃣ **O que é uma variável?**<br />
Uma variável é um espaço na memória do computador utilizado para armazenar valores que podem ser alterados durante a execução do programa.

✅ **Características das Variáveis**<br />
✔ Possuem um **tipo de dado** que define o que pode ser armazenado.<br />
✔ Possuem um **nome único** dentro do escopo.<br />
✔ Podem armazenar valores diferentes ao longo da execução.<br />

2️⃣ **Declarando Variáveis**<br />
📌 **Sintaxe Básica** <br />
```
<tipo> <nome> = <valor>;

```

📌 **Exemplos** <br />
```
int idade = 25;       // Armazena um número inteiro
string nome = "Lucas"; // Armazena um texto
bool ativo = true;     // Armazena um valor verdadeiro ou falso

```

🔹 Uma variável precisa ser **declarada com um tipo**, um **nome** e, opcionalmente, um **valor inicial**. <br />

3️⃣ **Regras de Nomeação de Variáveis** <br />
O C# segue algumas regras para nomear variáveis corretamente: <br />
✔ **Deve começar com uma letra** (não pode começar com número). <br />
✔ Pode conter letras, números e *_* (underline). <br />
✔ **Não pode conter espaços**. <br />
✔ **Não pode usar palavras reservadas do C#** (exemplo: *int*, *class*, *return*). <br />
✔ Seguir convenções de nomenclatura (camelCase para variáveis). <br />

✅ Exemplos de Nome Válidos<br />

```
int idadeUsuario;
string nomeCompleto;
bool estaAtivo;

```
❌ Exemplos de Nome Inválidos<br />

```
int 2idade;        // Começa com número ❌
string nome completo; // Contém espaço ❌
bool int;          // Usa palavra reservada ❌

```

4️⃣ **Tipos de Variáveis no C#**<br />
As variáveis no C# podem ser de **tipos primitivos**, **tipos de referência** e **tipos implícitos**.<br />

📌 **Tipos Primitivos (Tipos de Valor)**<br />
São armazenados diretamente na memória **stack**.<br />
| Tipo     | Tamanho  | Faixa de Valores                 | Exemplo                     |
|----------|----------|----------------------------------|-----------------------------|			
|sbyte	   | 8 bits	  |  -128 a 127	                     | sbyte x = -100;             |
|byte	     | 8 bits	  |  0 a 255	                       | byte x = 255;               |
|short	   | 16 bits  |	 -32.768 a 32.767	               | short x = 30000;            |
|ushort	   | 16 bits  |	 0 a 65.535	                     | ushort x = 50000;           |
|int	     | 32 bits  |	 -2.147.483.648 a 2.147.483.647  | int idade = 25;             |
|uint	     | 32 bits  |	 0 a 4.294.967.295	             | uint x = 100000;            |
|long	     | 64 bits  |	 -9 quintilhões a 9 quintilhões  | long x = 9000000000;        |
|ulong	   | 64 bits  |	 0 a 18 quintilhões	             | ulong x = 18000000000000;   |
|float	   | 32 bits  |	 ~7 dígitos de precisão	float    | altura = 1.75f;             |
|double	   | 64 bits  |	 ~15-16 dígitos de precisão	     | double preco = 10.99;       |
|decimal	 | 128 bits |	 ~28-29 dígitos de precisão	     | decimal saldo = 9999.99m;   |
|bool	     | 1 bit	  |  true ou false	bool             | ativo = true;               |
|char	     | 16 bits  |	 Qualquer caractere Unicode	     | char letra = 'A';           |


📌 **Tipos de Referência**<br />
São armazenados na **heap**, e as variáveis contêm referências ao valor. <br />
| Tipo     | Descrição                         | Exemplo                           |
|----------|-----------------------------------|-----------------------------------|
|string	   | Texto imutável	                   | string nome = "João";             |
|object	   | Base de todos os tipos	           | object obj = 42;                  |
|dynamic	 | Determinado em tempo de execução	 | dynamic valor = "Texto";          |
|class	   | Representa objetos complexos	     | class Pessoa { string Nome; }     |
|interface | Define contratos para classes	   | interface IAnimal { void Som(); } |

📌 **Tipo Implícito (var)**<br />
✔ O *var* permite inferência de tipo **durante a compilação**.<br />
✔ **O tipo é definido automaticamente pelo valor atribuído**.<br />
✔ **Não pode ser usada sem inicializar a variável**.<br />

📌 **Exemplo** <br />
```
var idade = 25;     // Tipo inferido como int
var nome = "Lucas"; // Tipo inferido como string
var ativo = true;   // Tipo inferido como bool

```
📌 Uso recomendado: Quando o tipo já é óbvio pelo contexto. Evitar quando o código perde clareza. <br />

5️⃣ **Modificadores de Variáveis**<br />
Podemos modificar o comportamento de variáveis usando palavras-chave.

📌 *const* (Constantes) <br />
✔ Não podem ser alteradas após a atribuição. <br />
✔ O valor deve ser definido no momento da declaração. <br />

📌 **Exemplo** <br />
```
const double PI = 3.14159;
Console.WriteLine(PI); // 3.14159

```

📌 readonly **(Somente leitura)**<br />
✔ Pode ser atribuído **apenas no construtor** de uma classe.

📌 **Exemplo**
```
class Config
{
    public readonly string Versao = "1.0.0";
}

```
📌 static **(Variável de Classe)**<br />
✔ O valor pertence à classe, não a instâncias específicas.<br />

📌 **Exemplo** <br />

```
class Config
{
    public static int Contador = 0;
}
```
6️⃣ **Escopo de Variáveis** <br />
O escopo define **onde a variável pode ser acessada**.
| Tipo     | Visível em                                    | Exemplo                          |
|----------|-----------------------------------------------|----------------------------------|
|Local 	   |  Dentro de um método	                         | void Exemplo() { int x = 10; }   |
|Global	   |  Dentro de uma classe	                       | class Teste { int valor; }       |
|Parâmetro |  Apenas dentro do método que o recebe	       | void Metodo(int x) { }           |
|Bloco	   |  Apenas dentro do bloco { } onde foi declarada| if (true) { int y = 20; }        |

7️⃣ **Exemplos Práticos** <br />
📌 **Exemplo: Trabalhando com Variáveis** <br />

```
class Program
{
    static void Main()
    {
        int idade = 25;
        double altura = 1.75;
        string nome = "Lucas";
        bool ativo = true;

        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura}, Ativo: {ativo}");
    }
}
```

📌 **Exemplo: Variáveis em Métodos** <br />
```
static void Apresentar(string nome, int idade)
{
    Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
}

Apresentar("Lucas", 25);

```

📌 **Conclusão** <br />
✅ **Variáveis armazenam valores que podem ser alterados durante a execução**. <br />
✅ **Cada variável tem um tipo de dado específico**. <br />
✅ **Existem variáveis de valor** (*int*, *double*) e **referência** (*string*, *object*). <br />
✅ **Devemos seguir boas práticas de nomeação e escopo**. <br />



<br/>
<div style="display: flex; justify-content: space-between;">  
  <a href="arithmetic-operators.md">Próxima: Operadores Aritiméticos .NET</a>
</div>

