## ReportFactory

### Sobre o Projeto

Esta **API**, desenvolvida utilizando **.NET 8**, segue os princípios do **Domain-Driven Design (DDD)** para fornecer uma solução eficiente para a geração de relatórios. Os usuários podem solicitar diferentes tipos de relatórios, com os dados sendo processados e retornados em um formato estruturado.

A arquitetura da **API** é baseada em **REST**, utilizando métodos **HTTP** padrão para comunicação eficiente. Além disso, é complementada pela documentação **Swagger**, que fornece uma interface gráfica interativa para explorar e testar os endpoints.

### Design Patterns Utilizados

- **Factory Pattern**: Utilizado em `IReportFactory` e sua implementação `ReportFactory` para criar instâncias de relatórios com base no nome do relatório.
- **Strategy Pattern**: Utilizado na interface `IReports` e suas implementações (`ReportBMF` e `ReportBolsa`) para definir uma família de algoritmos, encapsular cada um e torná-los escaláveis, desacoplados e flexíveis.
- **Dependency Injection**: Utilizado em todo o projeto para injetar dependências como `IReportFactory`, `IReports`, `ReportBMF` e `ReportBolsa` em controladores e serviços.

### Princípios SOLID

- **Single Responsibility Principle (SRP)**: Cada classe tem uma única responsabilidade, como `ReportController` que lida com requisições HTTP e `ReportFactory` que cria instâncias de relatórios.
- **Open/Closed Principle (OCP)**: O sistema está aberto para extensão, mas fechado para modificação. Novos tipos de relatórios podem ser adicionados implementando a interface `IReports` sem modificar o código existente.
- **Liskov Substitution Principle (LSP)**: Objetos de uma superclasse devem ser substituíveis por objetos de uma subclasse sem afetar a funcionalidade. Isso é alcançado pelo uso de interfaces como `IReports`.
- **Interface Segregation Principle (ISP)**: Os clientes não devem ser forçados a depender de interfaces que não utilizam. A interface `IReports` é específica para a geração de relatórios.
- **Dependency Inversion Principle (DIP)**: Módulos de alto nível não devem depender de módulos de baixo nível, mas de abstrações. Isso é alcançado através da injeção de dependências de interfaces como `IReportFactory` e `IReports`.

### Características

- **Domain-Driven Design (DDD)**: Estrutura modular que facilita o entendimento e a manutenção do domínio da aplicação.
- **Geração de Relatórios**: Capacidade de gerar relatórios detalhados com base nas solicitações dos usuários.
- **API RESTful com Documentação Swagger**: Interface documentada que facilita a integração e o teste por parte dos desenvolvedores.

### Construído com

![badge-dot-net]
![badge-windows]
![badge-visual-studio]
![badge-swagger]

## Começando

Para obter uma cópia local em funcionamento, siga estes passos simples.

### Requisitos

* Visual Studio versão 2022+ ou Visual Studio Code
* Windows 10+ ou Linux/MacOS com [.NET SDK][dot-net-sdk] instalado

### Instalação

1. Clone o repositório:
    
    ```sh
    git clone https://github.com/camargotn/StudyCoding.git
    ```
    
2. Preencha as informações no arquivo `appsettings.Development.json`.
3. Execute a API e aproveite o seu teste :)

<!-- Links -->
[dot-net-sdk]: https://dotnet.microsoft.com/en-us/download/dotnet/8.0

<!-- Badges -->
[badge-dot-net]: https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=for-the-badge
[badge-windows]: https://img.shields.io/badge/Windows-0078D4?logo=windows&logoColor=fff&style=for-the-badge
[badge-visual-studio]: https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=fff&style=for-the-badge
[badge-swagger]: https://img.shields.io/badge/Swagger-85EA2D?logo=swagger&logoColor=000&style=for-the-badge

