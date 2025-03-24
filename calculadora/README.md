# Calculadora

## Descrição
Este projeto implementa uma calculadora simples em Java utilizando o padrão de projeto Factory Method. A calculadora é capaz de realizar operações básicas de matemática como soma, subtração, multiplicação e divisão.

## Estrutura do Projeto
O projeto está organizado da seguinte forma:

```
calculadora/
├── src/
│   ├── Main.java                 # Classe principal com método main
│   ├── factory/
│   │   └── Factory.java          # Implementação do Factory Method
│   └── model/
│       ├── Operacao.java         # Interface para operações
│       ├── Soma.java             # Implementação da operação de soma
│       ├── Subtracao.java        # Implementação da operação de subtração
│       ├── Multiplicacao.java    # Implementação da operação de multiplicação
│       └── Divisao.java          # Implementação da operação de divisão
```

## Funcionamento
O projeto utiliza:
- Uma interface `Operacao` que define o contrato para todas as operações matemáticas
- Classes concretas que implementam cada operação específica
- Uma Factory que cria instâncias das operações de forma dinâmica usando reflection

## Como Usar
1. Clone o repositório para sua máquina local
2. Abra o projeto em sua IDE de preferência (IntelliJ IDEA, Eclipse, NetBeans, etc.)
3. Execute a classe `Main` para ver o funcionamento básico

## Exemplo de Código
```java
// Criar uma operação de soma
Operacao calc = new Factory().factory("Soma");
float resultado = calc.operacao(5, 3); // Retorna 8

// Criar uma operação de divisão
calc = new Factory().factory("Divisao");
resultado = calc.operacao(10, 2); // Retorna 5
```

## Padrões de Projeto Utilizados
- **Factory Method**: Permite criar objetos de diferentes classes que implementam a mesma interface sem especificar explicitamente suas classes concretas. Neste projeto, a classe `Factory` cria instâncias de diferentes tipos de operações matemáticas.

## Requisitos
- Java JDK 23 ou superior

## Contribuição
Sinta-se à vontade para contribuir com o projeto adicionando novas operações matemáticas ou melhorando o código existente. Basta criar um fork do projeto, implementar suas alterações e enviar um pull request.

## Licença
Este projeto está disponível como código aberto sob os termos da licença [MIT](https://opensource.org/licenses/MIT).
