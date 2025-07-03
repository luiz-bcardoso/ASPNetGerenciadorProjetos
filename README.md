# Sistema de Gerenciamento de Projetos e Tarefas

![Status](https://img.shields.io/badge/Status-Em%20Desenvolvimento-yellow)

Aplicação web desenvolvida como trabalho final de disciplina, utilizando **ASP.NET Core MVC** e **Entity Framework Core**. O sistema permite o controle completo de Projetos e suas respectivas Tarefas, demonstrando a aplicação prática dos conceitos de desenvolvimento web com a stack .NET.

## Descrição do Projeto

O foco principal é a construção de uma aplicação web completa, seguindo as boas práticas do padrão **MVC (Model-View-Controller)**. A aplicação gerencia duas entidades principais, `Projeto` e `Tarefa`, com um relacionamento de um-para-muitos (1:N), onde um projeto pode conter múltiplas tarefas.

## Funcionalidades

A aplicação permite a execução das seguintes operações (CRUD):

* **Projetos:**
    * Cadastro de novos projetos.
    * Listagem de todos os projetos existentes.
    * Edição de informações de um projeto.
    * Exclusão de um projeto.
* **Tarefas:**
    * Cadastro de novas tarefas, sempre associadas a um projeto específico.
    * Listagem, edição e exclusão de tarefas.
    * Visualização de todas as tarefas ao detalhar um projeto.

## Tecnologias Utilizadas

* **Framework:** .NET 9.0
* **Plataforma Web:** ASP.NET Core MVC
* **ORM:** Entity Framework Core
* **Banco de Dados:** SQLite
* **Ambiente de Desenvolvimento:** Visual Studio 2022
* **Containerização:** Docker

## Modelagem de Dados

Foram criadas duas entidades principais para representar o domínio da aplicação:

* **Projeto**:
    * `Id` (Chave Primária)
    * `Nome`
    * `Cliente`
    * `DataInicio`
    * `DataTermino` (Opcional)
    * `Tarefas` (Propriedade de navegação para a coleção de Tarefas)

* **Tarefa**:
    * `Id` (Chave Primária)
    * `Titulo`
    * `Descricao`
    * `Status`
    * `ProjetoId` (Chave Estrangeira para `Projeto`)
    * `Projeto` (Propriedade de navegação para o Projeto vinculado)

## Como Executar o Projeto com Docker

Para construir e executar a aplicação em um ambiente containerizado, siga os passos abaixo.

### Pré-requisitos

* [Git](https://git-scm.com/) instalado.
* [Docker Desktop](https://www.docker.com/products/docker-desktop/) instalado e em execução.

### Passos

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/luiz-bcardoso/ASPNetGerenciadorProjetos.git
    ```

2.  **Navegue até o diretório do projeto:**
    ```bash
    cd ASPNetGerenciadorProjetos
    ```

3.  **Construa a imagem Docker:**
    O `Dockerfile` na raiz do projeto contém todas as instruções necessárias. Execute o comando abaixo para construir a imagem.
    ```bash
    docker build -t gestor-projetos-app .
    ```

4.  **Execute o container Docker:**
    Este comando irá iniciar um container a partir da imagem criada, mapeando a porta 8080 do seu computador para a porta 8080 do container.
    ```bash
    docker run -p 8080:8080 gestor-projetos-app
    ```
    *Observação: O Entity Framework Core com SQLite irá criar automaticamente o arquivo de banco de dados (`database.db`) dentro do container na primeira execução que necessitar de acesso aos dados.*

5.  **Acesse a aplicação:**
    Abra seu navegador e acesse o endereço:
    `http://localhost:8080`

## Estrutura do Projeto

O código-fonte está organizado seguindo o padrão **ASP.NET Core MVC**:

* `/Models`: Contém as classes de entidade (`Projeto.cs`, `Tarefa.cs`) e o `DbContext`.
* `/Views`: Contém os arquivos `.cshtml` que renderizam a interface do usuário, organizados por controller.
* `/Controllers`: Contém as classes que gerenciam as requisições HTTP e a lógica de negócio.
* `/wwwroot`: Contém os arquivos estáticos (CSS, JS, imagens).
* `Dockerfile`: Arquivo de configuração para a containerização da aplicação.

---
## 🇺🇸 Project and Task Management System

### About The Project

A web application developed to manage projects and their associated tasks. This project was built as a final assignment for an academic course, focusing on the practical application of the **ASP.NET Core MVC** framework and **Entity Framework Core** for data persistence.

### Key Features

* Full **CRUD** (Create, Read, Update, Delete) operations for **Projects**.
* Full **CRUD** operations for **Tasks**, which are linked to projects.
* Implements a **one-to-many relationship**: one Project can have multiple Tasks.
* When viewing a project's details, all associated tasks are displayed.
* Clear navigation and user-friendly interface.

### Tech Stack

* **.NET 9.0**
* **ASP.NET Core MVC**
* **Entity Framework Core**
* **Database:** SQLite
* **IDE:** Visual Studio 2022
* **Containerization:** Docker
