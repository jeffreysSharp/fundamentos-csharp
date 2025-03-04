[Back to README](../README.md)

# Principais Tipos de Dados no .NET:


- **Tipos de Valor** 
Armazenam dados diretamente e incluem:​

- **Inteiros:**
  - *byte* (8 bits, 0 a 255)
  - *sbyte* (8 bits, -128 a 127)
  - *short* (16 bits, -32.768 a 32.767)
  - *ushort* (16 bits, 0 a 65.535)
  - *int* (32 bits, -2.147.483.648 a 2.147.483.647)
  - *uint* (32 bits, 0 a 4.294.967.295)
  - *long* (64 bits, -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807)
  - *ulong* (64 bits, 0 a 18.446.744.073.709.551.615)

- **Ponto Flutuante:**
  - *float* (32 bits, ±1,5 x 10^−45 a ±3,4 x 10^38)
  - *double* (64 bits, ±5,0 x 10^−324 a ±1,7 x 10^308)
  - *decimal* (128 bits, adequado para cálculos financeiros e monetários)
  
- **Outros:**
  - *bool* (verdadeiro ou falso)
  - *char* (16 bits, caractere Unicode)
  - *struct* (estrutura definida pelo usuário)
  - *enum* (enumeração)
  
**Tipos de Referência:** 
Armazenam referências a dados e incluem:​

- *object* Tipo base de todos os tipos no .NET.​
- *string* Sequência de caracteres Unicode.​
- *class* e *interfaces* definidas pelo usuário.
- *Arrays*

**Novidades no .NET 9 Relacionadas a Tipos de Dados:**
Embora os tipos fundamentais não tenham mudado, o .NET 9 introduziu aprimoramentos e novos tipos para atender a demandas específicas:​

- *UUID v7* Uma nova versão de identificadores únicos universais que facilita a ordenação temporal, útil para bancos de dados que requerem ordenação por tempo de criação. ​

**Tipos de Tensor:** 
Para aplicações de inteligência artificial, foram introduzidos novos tipos de tensores, como *TensorPrimitives* e *Tensor<T>*, que permitem manipulação eficiente de dados multidimensionais. ​

Para uma compreensão mais aprofundada, recomendo consultar a documentação oficial da Microsoft sobre os tipos de dados no .NET e as novidades específicas do .NET 9.
