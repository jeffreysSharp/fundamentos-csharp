# Fundamentos do C#
[![Prject Skills](https://skillicons.dev/icons?i=dotnet,cs)](https://skillicons.dev)

## Aprenda desde os conceitos fundamentais até o desenvolvimento completo de uma aplicação em C#

O **.NET** está mais relevante do que nunca, e o **C#** continua sendo a linguagem mais popular e recomendada para trabalhar com essa 
plataforma, figurando entre as cinco linguagens mais utilizadas no mundo.

Aqui você aprenderá desde a configuração do ambiente até a sintaxe e os principais recursos da linguagem, 
adquirindo uma base sólida para o desenvolvimento com **C#**.

Com esses conhecimentos, você estará preparado para avançar para tópicos mais complexos, como **ASP.NET**, **Windows Forms**, **MAUI** 
e muito mais.

Todos os exemplos aqui foram desenvolvidos com o **.NET Core 9.0** *(última versão disponível)*.

### O que é lógica de programação?
![](.doc/img/1-raciocinio-logico.jpg)

**Lógica de programação** é a base do pensamento computacional e se refere ao conjunto de regras e técnicas utilizadas para estruturar e 
organizar instruções que um computador pode entender e executar.

Ela envolve a capacidade de analisar problemas, identificar padrões e criar sequências lógicas para resolvê-los por meio de algoritmos. 
Esses algoritmos são conjuntos de passos ordenados que permitem a execução de tarefas específicas dentro de um programa.

**Principais conceitos da lógica de programação:**
- **Algoritmos:** Sequência lógica de instruções para resolver um problema;
- **Variáveis e Constantes:** Armazenamento de valores que podem ou não mudar durante a execução do programa;
- **Estruturas Condicionais:** Decisões baseadas em condições *(ex: if...else)*;
- **Estruturas de Repetição:** Laços que executam blocos de código várias vezes *(ex: for, while)*;
- **Funções e Procedimentos:** Blocos de código reutilizáveis que realizam tarefas específicas.

A lógica de programação é essencial para qualquer linguagem de programação, pois define a forma como os códigos são organizados 
para que um software funcione corretamente.

### O que é linguagem de programação?
Uma **linguagem de programação** é um conjunto de regras, símbolos e instruções que permite a comunicação entre humanos e computadores. 
Ela é usada para escrever códigos que controlam o comportamento de sistemas computacionais, permitindo o desenvolvimento de softwares, 
aplicativos, sites, jogos e muito mais.

**Principais características de uma linguagem de programação:**
- **Sintaxe:** Conjunto de regras que define como os comandos devem ser escritos;
- **Semântica:** O significado das instruções dentro da linguagem;
- **Paradigma:** Estilo de programação adotado, como procedural, orientado a objetos ou funcional.

**Tipos de linguagens de programação:**
- **Baixo nível:** Mais próximas da linguagem da máquina *(ex: Assembly)*;
- **Alto nível:** Mais próximas da linguagem humana e fáceis de entender *(ex: Python, Java, C#)*;
- **Compiladas:** Precisam ser convertidas para código de máquina antes de rodar *(ex: C, C++)*;
- **Interpretadas:** Executadas linha por linha sem necessidade de compilação *(ex: JavaScript, Python)*.

Linguagens de programação são fundamentais para o desenvolvimento de tecnologia, permitindo que programadores 
criem soluções inovadoras para diversas áreas.

### O que é .NET?
**.NET** é uma plataforma de desenvolvimento criada pela Microsoft que permite a criação de diversos tipos de aplicações, 
como **web**, **desktop**, **mobile**, **cloud**, **jogos**, **IoT** e muito mais. Ele oferece um conjunto de ferramentas, 
bibliotecas e linguagens de programação para facilitar o desenvolvimento de software.

**Principais características do .NET:**
**Multiplataforma:** Pode ser executado no **Windows**, **Linux** e **macOS**;
- **Código aberto:** O **.NET Core** e o **.NET 5+** são open-source, permitindo a contribuição da comunidade;
- **Suporte a várias linguagens:** Compatível com **C#**, **F#**, **VB.NET**, entre outras;
- **Alto desempenho:** Projetado para eficiência e rapidez;
- **Amplo ecossistema:** Inclui suporte para **APIs**, **bancos de dados**, **microsserviços**, **inteligência artificial**, e muito mais.

**Principais componentes do .NET:**
- .**NET Runtime:** Responsável pela execução dos aplicativos, incluindo o gerenciamento de memória e segurança;
- **ASP.NET Core:** Framework para desenvolvimento de aplicações **web** e **APIs REST**;
- **Entity Framework Core:** ORM para facilitar o acesso a bancos de dados;
- **Blazor:** Permite criar aplicações web usando **C#** em vez de **JavaScript**;
- **MAUI:** Framework para desenvolvimento de aplicativos mobile e desktop com **C#**.

**Evolução do .NET:**
- **.NET Framework (2002):** Versão original, compatível apenas com Windows;
- **.NET Core (2016):** Versão open-source e multiplataforma;
- **.NET 5+ (2020 em diante):** Unificação do **.NET Framework** e **.NET Core**, com suporte contínuo e melhorias.

O .NET é uma plataforma poderosa e flexível, amplamente usada para desenvolver aplicações escaláveis e de alto desempenho.

### O que é CLR (Common Language Runtime)?
**CLR (Common Language Runtime)** é o componente principal do **.NET**, responsável por executar os aplicativos 
desenvolvidos na plataforma. Ele funciona como uma máquina virtual, gerenciando a execução do código, memória, segurança e 
outros aspectos importantes para o funcionamento das aplicações **.NET**.

**Principais funções do CLR:**
- **Compilação Just-In-Time (JIT):** Converte o código intermediário **(IL - Intermediate Language)** para código de máquina no momento
 da execução;
- **Gerenciamento de Memória:** Inclui o **Garbage Collector (GC)**, que libera automaticamente a memória ocupada por objetos não utilizados;
- **Segurança e Controle de Acesso:** Garante que o código seja executado de forma segura e protege contra acessos indevidos;
- **Tratamento de Exceções:** Gerencia erros durante a execução do programa;
- **Interoperabilidade:** Permite a integração com código nativo **(C, C++)** e componentes **COM**.

**Fluxo de Execução no CLR:**
1. O código-fonte *(ex: C#)* é compilado para **IL (Intermediate Language)**;
2. O **IL** é armazenado em um arquivo *.dll* ou *.exe* junto com os metadados do programa;
3. Quando o programa é executado, o **JIT Compiler** converte o **IL** em código de máquina;
4. O **CLR** gerencia a execução do código, otimizando desempenho e garantindo segurança.

**Benefícios do CLR:**
- **Portabilidade:** O código **IL** pode ser executado em qualquer sistema que tenha o **.NET** instalado;
- **Segurança:** Protege contra código malicioso e vulnerabilidades;
- **Eficiência:** O **JIT Compiler** otimiza o código durante a execução;
- **Facilidade de Desenvolvimento:** Automatiza o gerenciamento de memória e exceções.

O **CLR** é um dos pilares que tornam o **.NET** uma plataforma robusta e confiável para o desenvolvimento de 
aplicações escaláveis e seguras.

### O que é um projeto .NET?
Um projeto **.NET** é uma estrutura organizada de arquivos e configurações usada para desenvolver aplicações na plataforma **.NET**. 
Ele contém o código-fonte, dependências, bibliotecas e metadados necessários para compilar e executar um aplicativo.


**Principais tipos de projetos .NET**
Na plataforma **.NET**, é possível criar diversos tipos de projetos, incluindo:

- **Aplicações Web:** Criadas com **ASP.NET Core**, podendo incluir **APIs REST**, aplicações **MVC** e **Blazor**;
- **Aplicações Desktop:** Utilizando Windows Forms **(WinForms)** ou **WPF (Windows Presentation Foundation)**;
- **Aplicações Mobile:** Desenvolvidas com **.NET MAUI (Multi-platform App UI)**;
- **APIs e Microsserviços:** Criadas com **ASP.NET Core** para fornecer serviços e endpoints;
- **Bibliotecas e SDKs:** Projetos de classes **(Class Library)** que servem como dependências para outras aplicações;
- **Jogos:** Desenvolvidos com **Unity** usando **C#**;
- **Sistemas embarcados e IoT:** Aplicações para dispositivos embarcados, como sensores e microcontroladores.

**Estrutura básica de um projeto .NET**
Ao criar um projeto, ele contém arquivos essenciais, como:
<p>
📂 /src - Código-fonte do projeto<br />
📂 /tests – Testes automatizados, unitários e de integração<br />
📂 /wwwroot – Arquivos estáticos (CSS, JS, imagens) em aplicações **Web**<br />
📄 Program.cs – Arquivo principal que inicia a aplicação<br />
📄 Startup.cs – Configuração de serviços e middlewares (em projetos **ASP.NET Core**)<br />
📄 appsettings.json – Arquivo de configuração da aplicação<br />
📄 csproj – Arquivo de configuração do projeto que define dependências e propriedades<br />
</p>

**Como criar um projeto .NET?**
Você pode criar um novo projeto usando o **CLI** do **.NET** ou o **Visual Studio**.

**No terminal:**
```
dotnet new webapi -n MeuProjeto
cd MeuProjeto
dotnet run
```

**No Visual Studio**
1. Abrir o Visual Studio;
2. Selecionar "Criar um novo projeto";
3. Escolher o tipo de aplicação **(Web API, Console App, Blazor, etc.)**;
4. Selecionar o diretório onde quer criar o projeto;
5. Criar e iniciar o desenvolvimento.

**Conclusão**
Um projeto **.NET** fornece uma estrutura organizada para desenvolver diferentes tipos de aplicações. 
Ele permite criar desde **web apps** e **APIs** até **aplicações móveis**, **desktop** e **jogos**, utilizando a linguagem **C#**, **F#** ou **VB.NET**.



