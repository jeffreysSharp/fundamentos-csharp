# Fundamentos do C#

## Aprenda desde os fundamentos até a criação de uma aplicação em C#

### Conceitos Básicos

#### O que é lógica de programação?
<p>Podemos resumir de forma bem simples, a lógica de programação é uma sequência de passos (**Algoritmo**) para executar algumas tarefas de um programa.<br />

**Exemplo de Algoritimo:** Chupar uma bala: <br /> 
1. Pegar a bala;
2. Desembalar a bala;
3. Colocar na boca;
4. Chupar a bala.

**Exemplo de lógica de programação:** Minha esposa diz: <br />
Vai até a padaria e compre um litro de leite, se lá tiver refrigerante traga três.<br/> 
Chegando na padaria, logo vi que havia refrigerante, então eu comprei três leites.<br/> 
Pareço ter feito confusão, mas existe uma condicional que cérebro de desenvolvedor entende,iremos ver operadores mais à frente em operadores e expressões.<br /> 

**Exemplo de operador condicional:**

```python
ComprarLeite()
{
    int quantidade = 1;
    bool temRefrigerante = true;

    if(temRefrigerante)
       quantidade = 3;
}
```

#### O que é linguagem de programação?
<p>Lógica de programação é uma forma de escrever instruções que o computador possa interpretar e executar todo o conjunto de intruções que escrevemos, é chamado de código fonte e esse código pode ser compilado ou interpretado
</p>

#### O que é o .NET?
<p>
  O **.NET** é uma plataforma de código aberto, ou seja roda no Windows, Linux e macOS, criada pela Microsoft para construção de diferentes tipos de aplicações, como por exemplo:
</p>

![](/.doc/img/1-tipos-aplicacoes.JPG)

<p>
 A plataforma **.NET** fornece um conjunto de bibliotecas otimizadas para acelerar o desenvolvimento, além da possibilidade de desenvolver aplicações em diversas , como.  
</p>

- **C#**
- **F#**
- **Visual Basic**

**Isso é Interoperabilidade com .NET**
<p>
 O **COM** (Component Object Model) permite que um objeto exponha sua funcionalidade à outros componentes e aplicativos host em plataformas Windows. Para ajudar a permitir que os usuários executem a interoperação com as bases de código existente.
</p>

<p>
** A evolução do .NET**
</p>

![](/.doc/img/2-evulucao-dotnet.JPG)

<p>
 Para visualizar a timeline em alta resolução acesse: <br />
  <a href="https://time.graphics/pt/editor/291016" target="_blank">time.graphics</a>
</p>

<p>
 O .NET Framework foi criado em 2002, somente era possivel desenvolver aplicações para o Sistema Operacional Windows, em 2014 a Microsoft apresentou a primeira versão do .NET Core,  capaz de desenvolver aplicações para  Windows, Linux e macOS. Em 2020 a Microsoft reescreveu toda a plataforma alterando até o nome novamente para .NET para não gerar confusão entre as versçoes antigas.
</p>

#### O que é CLR?
<p>
 **CLR** Common Language Runtime é a base principal do .NET, sendo o responsável por executar sua aplicação e se comunicar com o Hardeware. <br/>
 Vamos entender como funciona o processo de compilação:
</p>

<p>Esse é um assunto bastante avançado, mas é de extrema importância abordar esse assunto, para que você possa compreender de fato como funciona a sua aplicação através do .NET, desde a compilação do código fonte até a execução da aplicação <br/> 

Durante a nossa evolução como desenvolvedor, iremos desenvolver habilidades para fazer um bom uso de harware, quando estamos escrevendo nosso código fonte, ou seja, conforme vamos desenvolvendo nossas habilidades vamos entendendo como podemos contruir códigos melhores para fazer um bom uso do harware e utilizar menos recursos da CPU e menos memória, com isso teremos uma aplicação muito mais performática.<br />

O CLR já é capaz de fazer um bom gerenciamento de memória de forma bem eficiente, você irá aprender mais adiante o que são variáveis e objetos. <br />

Para fazer uma pequena observação para você entender um pouco melhor sobre o que eu falei de gerenciamento de memória, imagine um cenário, onde você tem um cadastro de pessoas e você precisa, por exemplo carregar um determinado registro para exibir para o usuário final, então o CLR possui um conjunto de recursos, um deles é o GC Garbage Collector (Coletor de lixo) que faz o seguinte, quando ele entende que essa informação que você carregou para a memória não está mais sendo utilizada, automaticamente ele vai na memória e remove essa informação, liberando mais espaço na memória, então isso significa que em partes que ele assume a responsabilidade de otimizar os recursos que estão sendo utilizados na máquina.<br />

Agora vamos entender de fato como funciona o processo de compilação e execução. <br />
Então vamos analizar a seguinte imagem: <br />
</p>
 
 ![](/.doc/img/3-processo-compilacao.JPG)

<p>
 O primeiro passo é escrever a aplicação utilizando a linguagem de preferência. Quando queremos executar esse código, precisamos compilar a nossa aplicação, o compilador gera um assembly do tipo .exe ou uma .dll e isso vai depender da configuração do tipo de projeto que você criou, isso você vai aprender mais a frente.<br />

 Esse arquivo vai passar por um outro processo, o compilador pega o código fontee o transforma em uma outra linguagem IL (Linguagem Intermediária) essa linguagem intermediária foi criada para que o .NET fornecesse a capacidade de desenvolvermos em outras linguagens e que o core, o motor pricipal fosse capaz de ler apenas uma linguagem que é o IL então o compilador do C# vai gerar o código executável em uma .dll ou .exe, que contenha essas intruções em código IL, então ele transforma o código do C# para essa IL, e o que acontece é que em tempo de execução, ou seja, a hora que você vai executar a sua aplicação o .NET vai utilizar os recursos do CLR, é onde o CLR entra em ação de fato.<br />

 Mais um importante dos recursos do CLR, é o RyuJIT, um outro compilador em tempo de execução, que o compilador vai pegar esse código IL e transformar em um código nativo da máquina que você está utilizando e aí sim vai executar a sua aplicação.
 </p>

#### O que é um projeto?
<p>
Mais á frente iremos criar um projeto na prática. <br /> 
Esse módulo tem como objetivo fazer um pequeno overview do que é um projeto. Quando estamos criando nossas aplicações em .NET.<br />

Um projeto é uma forma de você organizar todo código fonte da sua aplicação, seja por arquivos
ou até mesmo por pastas, no projeto é onde fica todos os arquivos que serão compilados, além disso você pode adicionar informações sobre sua aplicação, como por exemplo o nome de sua aplicação, versão da sua aplicação, porque a cada alteração que você fizer no seu código fonte e compilar sua aplicação novamente voê pode querer gerar uma nova versão e é exatamente no projeto que você informa a versão. Você pode também informar a versão do .NET. Como a Microsoft tem evoluído bastante o .NET e tem lançado várias versões, é no projeto que você vai setar e informar qual é a versão do .NET que você irá utilizar no projeto. <br />
Basicamente é essa a estrutura de um projeto:
</p>

![](/.doc/img/4-estrutura-projeto.JPG)

<p>
 Sendo assim, quando for compilar a nossa aplicação o compilador <a href="https://github.com/dotnet/roslyn">roslyn</a> irá analizar a estrutura do projeto e vai compilar a aplicação usando as configurações adicionas no arquivo do projeto. De forma resumida é isso, o projeto é utilizado para organizar a estrutura do código fonte da aplicação e configurar informações que são relevantes para a aplicação, mais a frete criaremos uma projeto totalmente do zero e você irá compreender melhor a estrutura de um projeto.
</p>

#### O que é uma solução?
<p>
Apesar de o nome ser um pouco confuso (Solution ou Solução) não está relacionado a resolução de algum tipo de problema. Quando estamos desenvolvendo uma aplicação em .NET precisamos criar projetos para organizar o código fonte, conforme falado  no módulo anterior. <br/>

Uma solução é uma forma de agrupar diversos projetos, e no momento de compilar a aplicação ao invés de você compilar projeto por projeto você compila a solução e os binários de cada projeto serão gerados individualmente de uma única vez.<br/>
Basicamente é essa a estrutura de uma solução:
</p>

![](.doc/img/5-estrutura-solucao.JPG)

<p>
 Um exemplo é quando você está desenvolvendo um ERP deve sere dividido em vários módulos, como por exemplo, módulo de cadastro, módulo financeito, módulo de compras, etc...<br />

 Então você cria uma solução com o nome da aplicação.
</p>

<hr />

### Preparando o ambiente

1. Instalando o .NET SDK 
<p>
 Entre na página <a href="https://dot.net/">dot.net</a>, faça o download do SDK para seu Sistema Operacional. 
</p>

2. Conhecendo IDE's de desenvolvimento
<p>
Durante o ciclo de desenvolvimento de um Sofware você precisa de uma IDE 
(Integrated Development Environment ou Ambiente de Desenvolvimento Integrado). 
O objetivo principal da IDE é acelerar o desenvolvimento da sua aplicação, dado que nos fornece 
ferramentas como Intelicense (Um recurso que ajuda a preencher o código) para ajudar no processo de desenvolvimento do código. 
Você pode até utilizar o notepad para escrever seu código e compilar a sua aplicação em um prompt de comando,
mas as IDE1s são muito mais produtivas. <br />
Vamos conhecer três IDE's que são as mais utilizadas no mundo, quando falamos em desenvolvimento de Software.<br />
</p>

![](/.doc/img//6-principais-ides.JPG)

##### Visual Studio Code
<p>
 O Visual Studio Code é uma das IDE's mais utilizadas no mundo, isso porque a Microsoft teve
 como objetivo desenvolver essa IDE sendo multiplataforma, isso significa que você pode 
 utilizar tanto no Windows, Linux e macOS. É uma IDE open source, isso significa que é de código aberto,
 você pode ir até o github e fazer contribuições para o projeto, é multilinguagem e por isso você pode 
 utilizar para desenvolver em diversas linguagens de programação.
</p>

#### Visual Studio
<p>
Temos o VIsual Studio que para mim é a melhor IDE para desenvolvimento para .NET, porém existe
algumas limitações, por exemplo ele só pode ser instalado em Sistema Operacional Windows. Temos o
Visual Studio Free, que é o Community Only, isso significa que você pode utilizart ele de forma
Free, mas você nçao pode desenvolver Sistemas que são comerciais, aquele Sistema que você vai cobrar 
por ele. E temos as versões Professional e Enterprise, que são as versões de fato pagas.
</p>

#### Jetbrains Rider
<p>
Temos também uma outra excelente IDE que é da Jetbrains Rider, é uma IDE que é multiplataforma,
então você pode utilizar para desenvolver aplicações tanto no Windows, Linux e macOS, mas ela não é Free,
ou seja, você precisa adquirir uma licença dessa IDE.
</p>

#### Vamos utilizar o Vuisual Studio Code

<p>
 Após a instalação do Visual Studio code precisaremos:
</p>

 ##### Instalar uma extensão

 <p>
  Dado cenário que vamos trabalhar com a linguagem C#, utilizando essa IDE. Com o Visual Studio Code é 
  possível desenvolver em diversas linguagens de programação, mas para isso é necessário instalar 
  alguma extenção.<br />
  Iremos instalar a extenção C# oficial da Microsoft.
 </p>

![](/.doc/img/7-extencao-csharp-vscode.JPG)
