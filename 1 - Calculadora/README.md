# Calculadora Java

Uma calculadora simples implementada em Java utilizando o padrão de arquitetura MVC (Model-View-Controller) e outros padrões de design.

## 📋 Descrição

Este projeto implementa uma calculadora básica com operações de soma, subtração, multiplicação e divisão. A aplicação foi desenvolvida utilizando boas práticas de programação orientada a objetos, incluindo:

- Padrão MVC (Model-View-Controller)
- Padrão Factory para criação de operações
- Uso de interfaces para promover baixo acoplamento
- Tratamento de exceções
- Data Transfer Objects (DTOs) para transferência de dados

## 🚀 Funcionalidades

- Soma de dois números
- Subtração de dois números
- Multiplicação de dois números
- Divisão de dois números (com tratamento para divisão por zero)

## 🔧 Estrutura do Projeto

```
1 - Calculadora/
├── src/
│   ├── application/
│   │   └── Main.java
│   ├── controller/
│   │   └── ControllerCalc.java
│   ├── model/
│   │   ├── calculators/
│   │   │   ├── Calculator.java
│   │   │   └── ICalculator.java
│   │   ├── dto/
│   │   │   ├── RequestDTO.java
│   │   │   └── ResponseDTO.java
│   │   ├── exception/
│   │   │   ├── DivisionByZeroException.java
│   │   │   ├── InvalidFactoryException.java
│   │   │   └── InvalidOperationException.java
│   │   ├── factories/
│   │   │   ├── AbstractFactory.java
│   │   │   ├── IFactory.java
│   │   │   └── OperationFactory.java
│   │   └── operations/
│   │       ├── Addition.java
│   │       ├── Division.java
│   │       ├── IOperation.java
│   │       ├── Multiplication.java
│   │       └── Subtraction.java
│   └── view/
│       └── Menu.java
```

## 📝 Padrões de Design Utilizados

### MVC (Model-View-Controller)
- **Model**: Contém a lógica de negócios e operações matemáticas
- **View**: Menu para interação com o usuário
- **Controller**: Coordena as interações entre Model e View

### Factory Method
Implementado com a classe `OperationFactory` que cria objetos de operação específicos usando reflexão.

### Abstract Factory
Utilizado com a classe `AbstractFactory` que fornece uma interface genérica para criar famílias de objetos relacionados.

### Interface-Based Programming
Interfaces como `IOperation` e `ICalculator` são utilizadas para promover baixo acoplamento entre componentes.

## 🏃‍♂️ Como Executar

1. Clone este repositório
2. Abra o projeto na sua IDE preferida que suporte Java
3. Execute a classe `Main.java`
4. Siga as instruções no console para realizar operações

## 🛡️ Tratamento de Exceções

O projeto inclui tratamento de exceções para:
- Divisão por zero (`DivisionByZeroException`)
- Operação inválida (`InvalidOperationException`)
- Erro na criação de instâncias via Factory (`InvalidFactoryException`)

## 🧩 Extensibilidade

O projeto foi projetado para ser facilmente extensível:
- Para adicionar novas operações, basta criar uma nova classe que implemente a interface `IOperation`
- O sistema de Factory utilizando reflexão permitirá que a nova operação seja descoberta automaticamente

## 🔍 Requisitos

- Java JDK 23 ou superior
- IDE Java (IntelliJ IDEA, Eclipse, NetBeans, etc.)

## 📜 Licença

[MIT](https://choosealicense.com/licenses/mit/)
