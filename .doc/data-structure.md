## Documentação Completa sobre Estruturas de Dados em C#

As estruturas de dados são fundamentais para a organização, armazenamento e manipulação eficiente de dados em qualquer aplicação. No .NET (C#), há diversas estruturas disponíveis, desde arrays e listas até filas, pilhas e dicionários, cada uma com características e usos específicos.

1️⃣ O que são Estruturas de Dados?<br />
Uma estrutura de dados é uma maneira organizada de armazenar e gerenciar informações, permitindo acessar e modificar os dados de forma eficiente.<br />

📌 **Classificação das Estruturas de Dados**<br />
Podemos classificar as estruturas de dados em dois grupos principais:<br />

| Tipo                           | Descrição                                                                                   |
|--------------------------------|---------------------------------------------------------------------------------------------|
|Estruturas de Dados Estáticas   | O tamanho é definido na criação e não pode ser alterado durante a execução. Exemplo: Array.
|Estruturas de Dados Dinâmicas   | Podem crescer ou diminuir dinamicamente conforme a necessidade. Exemplo: List<T>, Queue<T>, Stack<T>, Dictionary<TK, TV>. |

2️⃣ **Principais Estruturas de Dados em C#**<br />
Aqui estão as principais estruturas de dados disponíveis no .NET:<br />

🔹 **1. Arrays (Array)**<br />
Os arrays são estruturas estáticas que armazenam elementos do mesmo tipo em posições contínuas na memória.<br />

📌 **Exemplo de uso de Array em C#:**<br />

```
int[] numbers = new int[5] { 10, 20, 30, 40, 50 };

Console.WriteLine(numbers[2]); // Saída: 30

```

✅ **Características:**<br />
✔ Acesso rápido por índice (O(1)).<br />
✔ Tamanho fixo, não pode crescer ou diminuir dinamicamente. <br/>

🔹 **2. Lista Genérica (List<T>)** <br />
A List<T> é uma estrutura dinâmica, permitindo adicionar e remover elementos.<br />

📌 **Exemplo de List<T>:** <br />

```
List<string> names = new List<string>() { "Alice", "Bob", "Charlie" };

names.Add("David"); // Adiciona um novo elemento
names.Remove("Bob"); // Remove um elemento

Console.WriteLine(names.Count); // Saída: 3

```

✅ **Características:** <br />
✔ Cresce e diminui dinamicamente.<br />
✔ Acesso rápido por índice (O(1)).<br />
✔ Operações de inserção e remoção podem ser custosas (O(n) para remoção).<br />

🔹 **3. Pilha (Stack<T>)**<br />
A pilha (Stack<T>) segue o princípio LIFO (Last In, First Out) – o último item inserido é o primeiro a ser removido.<br />

📌 **Exemplo de Stack<T>:**<br />
```
Stack<int> stack = new Stack<int>();

stack.Push(10);
stack.Push(20);
stack.Push(30);

Console.WriteLine(stack.Pop()); // Saída: 30 (último elemento inserido)
Console.WriteLine(stack.Peek()); // Saída: 20 (próximo a ser removido)

```

✅ **Características:** <br />
✔ Operações Push e Pop são rápidas (O(1)).<br />
✔ Útil para recursão, navegação em páginas, e controle de chamadas.<br />

🔹 **4. Fila (Queue<T>)**<br />
A fila (Queue<T>) segue o princípio FIFO (First In, First Out) – o primeiro item inserido é o primeiro a ser removido.<br />

📌 **Exemplo de Queue<T>:**<br />
```
Queue<string> queue = new Queue<string>();

queue.Enqueue("Cliente 1");
queue.Enqueue("Cliente 2");
queue.Enqueue("Cliente 3");

Console.WriteLine(queue.Dequeue()); // Saída: Cliente 1 (primeiro a ser inserido)
Console.WriteLine(queue.Peek()); // Saída: Cliente 2 (próximo a sair)

```
✅ **Características:** <br />
✔ Enqueue e Dequeue são rápidas (O(1)). <br />
✔ Usada em sistemas de filas, processamento de tarefas e mensagens assíncronas. <br />

🔹 **5. Dicionário (Dictionary<TKey, TValue>)**<br />
O Dictionary<TKey, TValue> permite armazenar pares chave-valor, sendo altamente eficiente para buscas rápidas.<br />

📌 **Exemplo de Dictionary<TKey, TValue>:**<br />
```
Dictionary<string, int> ages = new Dictionary<string, int>
{
    { "Alice", 25 },
    { "Bob", 30 }
};

Console.WriteLine(ages["Alice"]); // Saída: 25

if (ages.ContainsKey("Charlie"))
{
    Console.WriteLine(ages["Charlie"]);
}
else
{
    Console.WriteLine("Charlie não encontrado.");
}

```
✅ **Características:**<br />
✔ Acesso extremamente rápido (O(1) para busca por chave).<br />
✔ Chaves devem ser únicas.<br />
✔ Muito usado para indexação e armazenamento de pares chave-valor.<br />

3️⃣ **Comparação das Estruturas de Dados**<br />

| Estrutura                 | Acesso (O(1))  | Inserção/Remoção | Busca (O(n))  | Características                                   |
|---------------------------|----------------|------------------|----------------| -----------------------------------------        |
|Array                      |✅             | ❌               |🔶             | Estático, rápido para acesso.                                                  |
|List<T>                    |✅             | 🔶               |🔶             | Dinâmico, flexível.                                                  |      
|Stack<T>                   |❌             | ✅               |🔶             | LIFO (último entra, primeiro sai).                                                  |
|Queue<T>                   |❌             | ✅               |🔶             | FIFO (primeiro entra, primeiro sai).                                                  |
|Dictionary<TKey, TValue>   |✅             | ✅               |❌             | Chave-valor, acesso muito rápido.                  |


4️⃣ **Quando Usar Cada Estrutura de Dados?**<br />
✅ Escolha a estrutura certa para cada necessidade:<br />
Array → Quando o número de elementos é fixo e acessos rápidos são essenciais.<br />
List<T> → Quando precisa de crescimento dinâmico e acesso rápido por índice.<br />
Stack<T> → Quando a ordem de processamento segue o conceito LIFO (Ex: histórico de navegação).<br />
Queue<T> → Quando a ordem segue o conceito FIFO (Ex: filas de processamento).<br />
Dictionary<TKey, TValue> → Quando precisa de busca rápida por chave única.<br />

5️⃣ **Conclusão**<br />
🚀 Agora você tem um guia completo sobre Estruturas de Dados em C#!
✅ Entendeu o conceito e a aplicação de cada estrutura.
✅ Viu exemplos práticos com código funcional.
✅ Sabe escolher a melhor estrutura para cada situação.

## **Interfaces de Coleções no .NET (C#)** <br />
Além das estruturas básicas como Array, List, Stack, Queue e Dictionary, o .NET fornece interfaces genéricas e não genéricas para manipulação de coleções de forma mais flexível e abstrata.<br />

1️⃣ **Interfaces Principais de Coleções**<br />

| Interface                     | Descrição                                                    | Uso Principal             | 
|-------------------------------|--------------------------------------------------------------|---------------------------|
| IEnumerable<T>                | Permite iterar sobre uma coleção (usando foreach). Somente leitura.                                                             | Leitura sequencial sem acesso direto.| Manipulação de coleções. 
| ICollection<T>                | Extende IEnumerable<T>, permitindo adicionar, remover e contar elementos.                                                              |                           | 
| IList<T>                      | Extende ICollection<T>, adicionando acesso por índice (this[int index]).                                                             |  Lista ordenada e modificável.                         | 
| IReadOnlyCollection<T>        | Apenas leitura (Count disponível, mas sem Add ou Remove).                                                             |  Segurança de imutabilidade.                         | 
| IReadOnlyList<T>              | Similar a IReadOnlyCollection<T>, mas permite acesso por índice (this[int index]).                                                            | Listas imutáveis.                          | 
| IDictionary<TKey, TValue>     | Coleção de pares chave-valor.                                                             | Busca rápida por chave.                          | 








<br/>
<div style="display: flex; justify-content: space-between;">  
   <a href="functions.md">Voltar: Documentação Completa sobre Funções no .NET (C#)</a>  
</div>





