[Back to README](../README.md)

## Principais Tipos de Dados no .NET:
Os principais tipos de dados do C# são fundamentais para o desenvolvimento de aplicações, permitindo a escolha do tipo adequado para armazenar cada tipo de informação de forma eficiente.

![](img/data-types.jpg)

No **C#**, os tipos de dados são categorizados em **tipos de valor** e **tipos de referência**. Uma variável do tipo de valor 
armazena diretamente uma instância do dado, enquanto uma variável do tipo de referência armazena um ponteiro para a instância.

Por padrão, ao passar um argumento para um método ou retornar um resultado, os valores das variáveis são copiados. No caso de tipos de valor, a instância inteira é copiada, garantindo que a modificação dentro do método não afete a variável original.

Para exemplificar, imagine um sistema de cadastro de pessoas. Ao cadastrar um usuário, precisamos armazenar seu nome e idade. O nome será armazenado em um tipo específico para texto, enquanto a idade será armazenada em um tipo numérico apropriado. Esses tipos de dados são essenciais para garantir a estrutura correta das informações, e é isso que exploraremos agora.

### Tipos de Valor<br />
Armazenam dados diretamente e incluem:​

**Tipos de Dados Numéricos**<br />
Os tipos numéricos no C# são divididos em **números inteiros**, **números de ponto flutuante** e **números decimais**. 
Cada um tem seu próprio propósito e faixa de valores.

**Números Inteiros (Integral Types)**<br />
São usados para armazenar números sem casas decimais.
| Tipo   | Tamanho | Faixa de valores | Exemplo |
|--------|---------|------------------|---------|
|sbyte   | 8 bits	 | -128 a 127	      | sbyte idade = 25; |
|byte	   | 8 bits	 | 0 a 255	        | byte quantidade = 200; |
|short	 | 16 bits | -32.768 a 32.767	| short ano = 2024; |
|ushort	 | 16 bits |	0 a 65.535	    | ushort velocidade = 120; |
|int	   | 32 bits |	-2.147.483.648 a 2.147.483.647 | int populacao = 1500000; |
|uint	   | 32 bits |	0 a 4.294.967.295	| uint distancia = 300000; |
|long	   | 64 bits |	-9.223.372.036.854.775.808 a 9.223.372.036.854.775.807	| long galaxias = 1000000000000L; |
|ulong	 | 64 bits |	0 a 18.446.744.073.709.551.615	| ulong estrelas = 900000000000000UL; |

**Observação:**<br/> 
Use *int* na maioria dos casos, pois é o mais eficiente. Apenas utilize *long* ou *short* quando necessário.<br />

**Números de Ponto Flutuante (Floating-Point Types)**<br />
Armazenam números com casas decimais e são usados quando precisamos de valores **aproximados**, como cálculos científicos.
| Tipo   | Tamanho | Precisão | Exemplo |
|--------|---------|------------------|---------|
|float	 | 32 bits | 7 dígitos	      | float temperatura = 36.6f; |
|double	 |64 bits  | 15-16 dígitos	  | double pi = 3.14159265359; |

**Observação:**<br/> 
Prefira *double* na maioria dos casos, pois é mais preciso que *float*. <br />

**Tipo Decimal (Precision Numeric Type)** <br />
Projetado para cálculos financeiros e monetários, pois **evita erros de arredondamento**.
| Tipo   | Tamanho | Precisão | Exemplo |
|--------|---------|------------------|---------|
|decimal |128 bits | 28-29 dígitos	  | decimal preco = 99.99m; |

**Quando usar?**<br />
- Para cálculos financeiros (*decimal* é mais preciso do que *double* e *float*).
- Quando for necessário armazenar números com alta precisão, como valores monetários.

**Resumo** <br />
- Use int para números inteiros.
- Use double para cálculos gerais com casas decimais.
- Use decimal para cálculos financeiros que exigem alta precisão. <br />
  
### Tipos de Referência: <br />
No C#, os **tipos de referência** armazenam **endereços de memória** onde os dados reais estão armazenados, em vez de conter diretamente os valores (como ocorre com os **tipos de valor**).

**Características dos Tipos de Referência**<br />
- Armazenam **referências** para os dados na memória heap.
- Podem ser **null** (ao contrário dos tipos de valor).
- São passados por **referência** para métodos, e não copiados.

**Resumo Comparativo**<br/>

| Tipo     | Mutável | Suporta Herança  | Imutável | Armazena Referência  | Aplicação |
|----------|---------|------------------|----------|----------------------|-----------|					
|class	   |✅ Sim	  |✅ Sim	         |❌ Não	   |✅ Sim	              |Objetos complexos e herança |
|interface |❌ Não	  |✅ Sim	         |❌ Não	   |✅ Sim	              |Definir contratos para classes|
|struct	   |✅ Sim	  |❌ Não	         |❌ Não	   |❌ Não	              |Pequenos objetos imutáveis|
|object	   |✅ Sim	  |✅ Sim	         |❌ Não	   |✅ Sim	              |Qualquer tipo de dado|
|dynamic	 |✅ Sim	  |❌ Não	         |❌ Não	   |✅ Sim	              |Tipos desconhecidos em tempo de compilação|
|string	   |❌ Não	  |❌ Não	         |✅ Sim	   |✅ Sim	              |Armazenamento de texto|
|record	   |❌ Não	  |❌ Não	         |✅ Sim	   |✅ Sim	              |Dados imutáveis e estruturados|

1️⃣ class **(Classe)**<br /> 
As classes são o principal mecanismo para criar **objetos** no C#.<br />
✔ **Suportam herança e polimorfismo**.<br />
✔ São **imutáveis por referência**, ou seja, quando passadas para um método, o objeto original pode ser alterado. <br/>
📌 Uso recomendado: Quando precisamos de objetos mutáveis e herança.<br />

2️⃣ interface <br />
As **interfaces** definem um contrato, mas não implementam comportamento.<br />
✔ Permitem **herança múltipla**, pois uma classe pode implementar várias interfaces.<br />
✔ Muito usadas para **polimorfismo e inversão de dependência**.<br />

3️⃣ struct **(Estrutura)**<br />
O **struct** é um tipo de valor, mas se comporta semelhante a um tipo de referência em alguns casos.<br />
✔ É mais leve que uma classe.<br />
✔ Ideal para dados pequenos e imutáveis.<br />
✔ Não suporta herança.<br />
📌 Uso recomendado: Quando precisamos de objetos pequenos e imutáveis.<br />

4️⃣ object<br />
O **object** é a **superclasse de todos os tipos no C#**, incluindo tipos de valor e referência.<br />
✔ Permite armazenar **qualquer tipo de dado**.<br />
✔ Pode ser **convertido para qualquer outro tipo** através de *boxing/unboxing* (custo de desempenho).<br />

📌 **Uso recomendado:** Quando precisamos armazenar **qualquer tipo de dado**, mas evitar quando possível, pois pode causar erros de conversão.

5️⃣ dynamic<br />
O **dynamic** permite definir **objetos dinâmicos** cujo **tipo é determinado em tempo de execução**.<br />
✔ Evita verificações de tipo em tempo de compilação.<br />
✔ Muito útil para **integração com bibliotecas COM, JSON e Reflection**.<br />

📌 **Uso recomendado:** Quando o **tipo exato dos dados não é conhecido em tempo de compilação**, como ao consumir **APIs JSON ou XML**.

6️⃣ string<br />
O tipo **string** é **imutável** e representa **sequências de caracteres**.<br />
✔ Quando uma **string** é modificada, uma **nova instância é criada na memória**.<br />
✔ Pode ser manipulada com métodos como *.ToUpper()*, *.Substring()*, *.Replace()*.<br />
📌 **Uso recomendado:** Para armazenar **textos**, mas evitar concatenação excessiva (usar *StringBuilder*).<br />

7️⃣ record **(C# 9+)**<br />
O **record** é um **tipo de referência** que representa dados imutáveis.<br />
✔ Gera automaticamente **métodos** como *Equals* e *ToString*.<br />
✔ Usa **sintaxe mais concisa** que *class*.<br />

📌 **Uso recomendado:** Quando queremos objetos imutáveis com valores estruturados.<br />

📌 **Conclusão**<br />
✅ *class* → Para objetos complexos e que exigem herança.<br />
✅ *interface* → Para definir contratos e garantir implementação em diferentes classes.<br />
✅ *struct* → Para dados pequenos e imutáveis.<br />
✅ *object* → Para armazenar qualquer tipo de dado, mas com custo de conversão.<br />
✅ *dynamic* → Para dados desconhecidos em tempo de compilação, mas pode ser arriscado.<br />
✅ *string* → Para armazenamento de texto (imutável).<br />
✅ *record* → Para dados imutáveis estruturados (C# 9+).<br />

**Novidades no .NET 9 Relacionadas a Tipos de Dados:**
Embora os tipos fundamentais não tenham mudado, o .NET 9 introduziu aprimoramentos e novos tipos para atender a demandas específicas:​

- *UUID v7* Uma nova versão de identificadores únicos universais que facilita a ordenação temporal, útil para bancos de dados que requerem ordenação por tempo de criação. ​

**Tipos de Tensor:** 
Para aplicações de inteligência artificial, foram introduzidos novos tipos de tensores, como *TensorPrimitives* e *Tensor<T>*, que permitem manipulação eficiente de dados multidimensionais. ​

Para uma compreensão mais aprofundada, recomendo consultar a documentação oficial da Microsoft sobre os tipos de dados no .NET e as novidades específicas do .NET 9.

Não iremos nos aprofundar nesses tipos agora, pois teremos um módulo específico neste curso dedicado a explorá-los em detalhes.

Fizemos um breve overview sobre esses tipos de dados para que você tenha uma noção geral e saiba escolher o tipo mais adequado durante o desenvolvimento de aplicações.

<br/>
<div style="display: flex; justify-content: space-between;">  
  <a href="variables.md">Próxima: Operadores Aritiméticos .NET</a>
</div>

