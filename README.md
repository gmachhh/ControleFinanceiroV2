# 💰 ControleFinanceiro | Sistema de Controle Financeiro

Sistema web de **controle financeiro pessoal**, desenvolvido para facilitar o gerenciamento de receitas, despesas, categorias e movimentações financeiras através de uma interface moderna, organizada e intuitiva.

O projeto foi desenvolvido utilizando **C#, ASP.NET Core MVC, Entity Framework Core e MySQL**, com dashboard financeiro, gráficos, filtros, gerenciamento de transações e categorias.

---

## 🎯 Visão Geral

Uma aplicação completa para **organização e acompanhamento financeiro**, permitindo registrar movimentações, categorizar gastos e visualizar de forma clara como o dinheiro está sendo utilizado.

O sistema foi desenvolvido com foco em **usabilidade, organização, visualização de dados e boas práticas de desenvolvimento**, utilizando uma arquitetura MVC com separação entre Controllers, Models, Services e Views.

### ✨ Destaques

- **Dashboard Financeiro**: Visão geral das principais informações financeiras
- **Controle de Transações**: Cadastro, edição, consulta e exclusão de receitas e despesas
- **Categorias**: Organização das movimentações por categorias
- **Filtros Avançados**: Pesquisa por descrição, tipo, categoria e período
- **Gráficos Financeiros**: Visualização de receitas, despesas e distribuição dos gastos
- **Cálculo Automático**: Atualização do saldo conforme as movimentações
- **Tema Claro/Escuro**: Alternância entre diferentes temas da aplicação
- **Interface Responsiva**: Adaptada para diferentes tamanhos de tela
- **Validação de Dados**: Regras para manter as informações consistentes
- **Banco de Dados**: Persistência utilizando MySQL e Entity Framework Core

---

## 🛠️ Stack Tecnológico

### Backend

- **C#** - Linguagem principal
- **ASP.NET Core MVC** - Framework para desenvolvimento web
- **.NET 10** - Plataforma de execução da aplicação
- **Entity Framework Core 8** - ORM para acesso ao banco de dados
- **LINQ** - Consultas e manipulação de dados
- **Dependency Injection** - Gerenciamento de dependências
- **Async/Await** - Operações assíncronas

### Banco de Dados

- **MySQL** - Banco de dados relacional
- **Pomelo.EntityFrameworkCore.MySql** - Integração entre EF Core e MySQL
- **Entity Framework Migrations** - Controle da estrutura do banco

### Frontend

- **Razor** - Renderização das páginas
- **HTML5** - Estrutura das páginas
- **CSS3** - Estilização da aplicação
- **JavaScript** - Interatividade e funcionalidades
- **Bootstrap** - Componentes e responsividade
- **Chart.js** - Gráficos e visualização de dados
- **Font Awesome** - Ícones da interface

### Ferramentas

- **Visual Studio / Visual Studio Code** - Desenvolvimento
- **Git / GitHub** - Controle de versão
- **.NET CLI** - Execução e gerenciamento do projeto
- **Entity Framework CLI** - Gerenciamento das migrations

---

## 🚀 Funcionalidades

### Dashboard

1. **Resumo Financeiro** - Visualização das principais informações
2. **Receitas** - Total de entradas financeiras
3. **Despesas** - Total de gastos
4. **Saldo** - Resultado entre receitas e despesas
5. **Transações Recentes** - Acompanhamento das últimas movimentações
6. **Receitas x Despesas** - Comparação visual dos valores
7. **Despesas por Categoria** - Distribuição dos gastos
8. **Histórico Mensal** - Acompanhamento da evolução financeira

### Gerenciamento de Transações

- ✅ Cadastro de receitas
- ✅ Cadastro de despesas
- ✅ Edição de movimentações
- ✅ Exclusão de movimentações
- ✅ Listagem de transações
- ✅ Pesquisa por descrição
- ✅ Filtro por tipo
- ✅ Filtro por categoria
- ✅ Filtro por período
- ✅ Associação com categorias
- ✅ Validação dos dados

### Gerenciamento de Categorias

- ✅ Cadastro de categorias
- ✅ Listagem de categorias
- ✅ Edição de categorias
- ✅ Exclusão de categorias
- ✅ Validação de nomes
- ✅ Organização das movimentações
- ✅ Proteção contra exclusão de categorias utilizadas

### Relatórios

- 📊 Comparação entre receitas e despesas
- 📈 Visualização dos dados financeiros
- 🍩 Distribuição das despesas por categoria
- 📅 Análise das movimentações

### Configurações

- 🎨 Alternância de tema
- ☀️ Tema claro
- 🌙 Tema escuro
- 🔔 Área de configurações de notificações
- ℹ️ Informações do sistema

---

## 📋 Como Rodar Localmente

### Pré-requisitos

- .NET SDK
- MySQL
- Git
- Visual Studio, Visual Studio Code ou Rider

### Instalação

```bash
# Clone o repositório
git clone https://github.com/gmachhh/ControleFinanceiroV2.git
cd ControleFinanceiroV2

# Acesse a pasta da aplicação
cd ControleFinanceiro

# Restaure as dependências
dotnet restore

# Configure o banco de dados através do appsettings.json

# Aplique as migrations
dotnet ef database update

# Execute o projeto
dotnet run
