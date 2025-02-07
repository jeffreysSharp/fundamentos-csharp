# Fundamentos do C#

Aprenda desde os fundamentos até a criação de uma aplicação em C#

## Conceitos Básicos

1. O que é lógica de programação?
<p>Podemos resumiur de forma bem simples, a lógica de programação é como uma sequência de passos (algoritmo) para executar um programa.
    <br />
Algoritimo é o passo a passo para executar algo como chupar uma bala: Pegar a bala > Desembalar > Colocar na boca > Chupar.

**Exemplo:** Vá até o supermercado e compre um litro de leite, se tiver refrigerante traz três, como havia refrigerante  eu comprei três leites. Pareço estar confuso, mas existe uma condicional, exemplo:

```python
ComprarLeite()
{
    int quantidade = 1;
    bool temRefrigerante = true;

    if(temRefrigerante)
       quantidade = 3;
}
```

2. O que é linguagem de programação?
<p>è uma forma de escrever instruções que o computador possa interpretar e executar todo o conjunto de intruções que escrevemos, é chamado de código fonte e esse código pode ser compilado ou interpretado</p>

3. O que é o .NET?
<p>
  O .NET é uma plataforma de código aberto, ou seja roda no Windows, Linux e macOS, criada pela Microsoft para contrução de diferentes tipos de aplicações, como por exemplo:
</p>

![](/.doc/img/1-tipos-aplicacoes.JPG)

<p>
 A plataforma .NET fornece um conjunto de bibliotecas otimizadas para acelerar o desenvolvimento, além da possibilidade de desenvolver aplicações em diversas linguagens, como por exemplo:
</p>

- *C#*
- *VB.NET*
- *F#*
- *C++*

<p>
 A evolução do .NET
</p>
![](/.doc/img/2-evulucao-dotnet.JPG)
<p>
 Para visualizar a timeline em alta resolução acesse: <br />
  <a href="https://time.graphics/pt/editor/291016" target="blank">time.graphics</a>
</p>
<p>
 O .NET Framework foi criado em 2002 somente era possivel desenvolver aplicações para o sistema operacional Windows, em 2014 a Microsoft apresentou a primeira versão do .NET Core capaz de desenvolver aplicações para  Windows, Linux e macOS. Em 2020 a Microsoft toda a plataforma alterando o nome novamente para .NET, para não gerar confusão entre as versçoes antigas.
</p>

4. O que é CLR?
<p>
 *CLR* Common Language Runtime é a base principal do .NET, sendo o responsável por executar sua aplicação e se comunicar com o Hardeware. <br/>
 Vamos entender como funciona o processo de compilação:
</p>

<p>Esse é um assunto bastante avançado, mas é de extrema importância abordar esse assunto, para que você possa compreender de fato como funciona a sua aplicação através do *.NET*, desde a compilação do código até a execução da sua aplicação <br/> 

Durante a nossa evolução como desenvolvedor, iremos desenvolver habilidades para fazer um bom uso de harware quando estamos escrevendo nossos códigos, ou seja, conforme vamos desenvolvendo nossas habilidades vamos entendendo como podemos contruir códigos melhores para fazer um bom uso do harware e utilizar por exemplo menos recursos da *CPU* e menos memória, com isso teremos uma aplicação muito mais performática. <br />

O *CLR* já é capaz de fazer um bom gerenciamento de memória de forma bem eficiente, você irá aprender mais adiante o que são variáveis e objetos. <br />

Para fazer uma pequena observação para você entender um pouco melhor sobre o que eu falei de gerenciamento de memória, imagine um cenário, onde você tem um cadastro de pessoas e você precisa, por exemplo carregar um determinado registro para exibir para o usuário final, então o *CLR* possui um conjunto de recursos, que um deles é o *GC* Garbage Collector (Coletor de lixo) que faz o seguinte, quando ele entende que essa informação que você carregou para a memória não está mais sendo utilizada, automaticamente ele vai na memória e remove essa informação, liberando mais espaço na memória, então isso significa que em partes ele assume a responsabilidade de otimizar os recursos que estão sendo utilizados na máquina, basicamente de forma bem simples, esse é um dos recursos que o *CLR* nos oferece.<br />

Agora vamos entender de fato como funciona o processo de compilação e execução. <br />
Então vamos analizar a seguinte imagem: <br />
</p>
 
 ![](/.doc/img/3-processo-compilacao.JPG)
<p>
 O primeiro passo é escrever a aplicação utilizando a linguagem de preferência. </br>
 O compilador gera um assembly do tipo .exe ou uma .dll, isso vai depender da configuração do tipo de projeto que você criou, isso você vai aprender mais a frente.<br />
 Esse arquivo vai passar por um outro processo, quando esse compilador pega o código ele transforma em uma oulinguagem *IL* (Linguagem Intermediária) essa linguagem intermediária foi criada para que o .NET fornecesse a capacidade de desenvolvermos em outras linguagens e que o core, o motor pricipal fosse capaz de ler apenas uma linguagem que é o *IL* então o compilador do *C#* vai gerar o código executável ou uma .dll, que contenha essas intruções em código *IL*, então ele transforma o código do *C#* para essa *IL*, e o que acontece é que em tempo de execução, ou seja, a hora que você vai executar a sua aplicação o .NET vai utilizar os recursos do *CLR*, é onde o *CLR* entra em ação de fato.<br />

 Um dos recursos do CLR, além do *GC* (Garbage Collector) é o RyuJIT, um outro compilador em tempo de execução, então aconte que o compilador vai pegar esse código *IL* e transformar em um código nativo da máquina que você está utilizando e aí sim vai executar a sua aplicação, então vai transformar para um código de máquina de fato, que é onde a sua aplicação será executada.
 </p>

5. O que é um projeto?
6. O que é uma solução?


