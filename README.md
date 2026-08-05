💰 ControleFinanceiro | Sistema de Controle Financeiro

Sistema web de controle financeiro pessoal desenvolvido em C# com ASP.NET Core MVC, com integração ao MySQL através do Entity Framework Core e uma interface moderna para gerenciamento de receitas, despesas, categorias e acompanhamento da vida financeira.

O projeto foi desenvolvido com foco em organização, usabilidade, separação de responsabilidades e visualização clara dos dados, reunindo as principais operações financeiras em um único sistema.

🎯 Visão Geral

O ControleFinanceiro permite registrar e acompanhar movimentações financeiras de forma simples e organizada.

A aplicação centraliza informações de receitas e despesas e transforma esses dados em indicadores e gráficos para facilitar a análise financeira.

✨ Destaques

Dashboard Financeiro: visão geral das principais informações financeiras

Controle de Transações: cadastro, edição, consulta e exclusão de movimentações

Categorias: organização das transações por categorias

Filtros: pesquisa por descrição, tipo, categoria e período

Gráficos: visualização de receitas, despesas e distribuição por categoria

Saldo Automático: cálculo baseado nas movimentações cadastradas

Tema Claro/Escuro: alternância de aparência da aplicação

Interface Responsiva: adaptação para diferentes tamanhos de tela

Validações: regras para manter os dados consistentes

Banco de Dados: persistência utilizando MySQL e Entity Framework Core

Arquitetura MVC: organização entre Models, Views e Controllers

🛠️ Stack Tecnológico

Backend

C# — Linguagem principal

ASP.NET Core MVC — Framework para desenvolvimento web

Entity Framework Core — ORM para acesso ao banco de dados

LINQ — Consultas e manipulação de dados

Dependency Injection — Injeção de dependências

Async/Await — Operações assíncronas

Data Annotations — Validação dos modelos

Banco de Dados

MySQL — Banco de dados relacional

Pomelo.EntityFrameworkCore.MySql — Provedor MySQL para Entity Framework Core

EF Core Migrations — Controle da estrutura do banco

Frontend

HTML5

CSS3

JavaScript

Razor Views

Bootstrap

Font Awesome

Chart.js

Ferramentas

Visual Studio / Visual Studio Code

Git

GitHub

.NET CLI

Entity Framework CLI

🚀 Funcionalidades

📊 Dashboard

O dashboard é o centro de acompanhamento financeiro da aplicação.

Indicadores

💵 Total de Receitas

💸 Total de Despesas

💰 Saldo

🧾 Quantidade de Transações

🕐 Transações Recentes

Visualizações

📊 Comparativo entre receitas e despesas

🍩 Distribuição de despesas por categoria

📅 Evolução financeira mensal

📈 Histórico das movimentações

Os indicadores são calculados a partir dos dados armazenados no banco de dados.

💵 Controle de Receitas

Permite registrar diferentes tipos de entradas financeiras.

Exemplos:

Salário

Freelance

Vendas

Investimentos

Rendimentos

Outros recebimentos

Cada movimentação pode conter:

Descrição

Valor

Data

Tipo

Categoria

💸 Controle de Despesas

Permite registrar e organizar os gastos realizados.

Exemplos:

Alimentação

Transporte

Moradia

Educação

Saúde

Lazer

Compras

Contas

Outros gastos

As despesas cadastradas são utilizadas automaticamente nos cálculos do dashboard e nas visualizações financeiras.

🧾 Gerenciamento de Transações

O módulo de transações permite administrar todas as movimentações financeiras.

Operações disponíveis

➕ Criar transação

📋 Listar transações

🔎 Consultar movimentações

✏️ Editar transação

🗑️ Excluir transação

🏷️ Associar categoria

💵 Definir tipo da movimentação

📅 Definir data e valor

O módulo trabalha com operações completas de CRUD.

C → Create  → Criar
R → Read    → Consultar
U → Update  → Atualizar
D → Delete  → Excluir

🔎 Sistema de Filtros

A tela de transações possui filtros para facilitar a localização de movimentações.

🔤 Descrição

Pesquisa transações através da descrição cadastrada.

💵 Tipo

Permite filtrar por:

Todas

Receitas

Despesas

🏷️ Categoria

Permite visualizar somente as transações pertencentes a uma categoria específica.

📅 Período

Permite informar:

Data inicial

Data final

Os filtros podem ser combinados para realizar consultas mais específicas.

🏷️ Gerenciamento de Categorias

O sistema possui um módulo específico para criação e organização das categorias.

Funcionalidades

➕ Criar categoria

📋 Listar categorias

✏️ Editar categoria

🗑️ Excluir categoria

🚫 Validação de categorias duplicadas

🔒 Proteção de categorias utilizadas

Uma categoria que possui transações associadas não deve ser removida, preservando a integridade dos dados relacionados.

📈 Gráficos e Visualização de Dados

O sistema utiliza Chart.js para transformar os dados financeiros em informações visuais.

📊 Receitas x Despesas

Permite comparar a evolução das receitas e despesas ao longo dos meses.

🍩 Despesas por Categoria

Apresenta a distribuição dos gastos entre as categorias cadastradas.

📅 Histórico Mensal

Permite acompanhar a movimentação financeira ao longo dos últimos meses.

Essas visualizações facilitam a identificação de padrões de gastos e evolução financeira.

💰 Cálculo Automático do Saldo

O saldo é calculado automaticamente a partir das movimentações.

Saldo = Total de Receitas - Total de Despesas

Exemplo

Receitas:  R$ 3.000,00
Despesas:  R$ 2.000,00
----------------------
Saldo:     R$ 1.000,00

O resultado é atualizado conforme as transações são cadastradas, editadas ou excluídas.

🌙 Tema Claro e Escuro

A aplicação possui suporte para diferentes temas visuais.

☀️ Tema Claro

Interface com aparência clara para utilização durante o dia.

🌙 Tema Escuro

Interface com aparência escura para uma experiência visual mais confortável em ambientes com pouca iluminação.

A preferência do usuário é armazenada no navegador utilizando:

localStorage

📑 Relatórios

O projeto possui uma área dedicada à visualização de informações financeiras.

Entre os recursos apresentados estão:

📊 Comparação de receitas e despesas

🍩 Distribuição de despesas por categoria

📅 Análise por período

📄 Interface preparada para exportação

Nota: os recursos de exportação para PDF e Excel estão presentes na interface como parte da evolução planejada do projeto.

⚙️ Configurações

A aplicação possui uma área de configurações para centralizar preferências do sistema.

Recursos

🎨 Configuração de aparência

☀️ Tema claro

🌙 Tema escuro

🔔 Área de notificações

🛠️ Informações do sistema

A estrutura permite que novas configurações sejam adicionadas futuramente.

🏗️ Arquitetura

O projeto utiliza o padrão arquitetural MVC (Model-View-Controller).

                   ┌──────────────┐
                   │     View     │
                   └──────┬───────┘
                          │
                          ▼
                   ┌──────────────┐
                   │  Controller  │
                   └──────┬───────┘
                          │
                          ▼
                   ┌──────────────┐
                   │   Service    │
                   └──────┬───────┘
                          │
                          ▼
                   ┌──────────────┐
                   │     Data     │
                   └──────┬───────┘
                          │
                          ▼
                   ┌──────────────┐
                   │    MySQL     │
                   └──────────────┘

Models

Representam as entidades do sistema.

Principais modelos:

Categoria
Transacao
TipoTransacao
ErrorViewModel

Controllers

Responsáveis por receber as requisições e controlar o fluxo da aplicação.

HomeController
TransacoesController
CategoriasController
RelatoriosController
ConfiguracoesController

Services

Concentram regras e processamento específicos da aplicação.

DashboardService

O serviço é utilizado para preparar os dados apresentados no dashboard.

ViewModels

Responsáveis por transportar dados específicos entre Controllers e Views.

DashboardViewModel
TransacaoFiltroViewModel

🗂️ Estrutura do Projeto

ControleFinanceiro/
│
├── Controllers/
│   ├── CategoriasController.cs
│   ├── ConfiguracoesController.cs
│   ├── HomeController.cs
│   ├── RelatoriosController.cs
│   └── TransacoesController.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Interfaces/
│   └── IDashboardService.cs
│
├── Migrations/
│
├── Models/
│   ├── Categoria.cs
│   ├── ErrorViewModel.cs
│   ├── TipoTransacao.cs
│   └── Transacao.cs
│
├── Services/
│   └── DashboardService.cs
│
├── ViewModels/
│   ├── DashboardViewModel.cs
│   └── TransacaoFiltroViewModel.cs
│
├── Views/
│   ├── Categorias/
│   ├── Configuracoes/
│   ├── Home/
│   ├── Relatorios/
│   ├── Shared/
│   └── Transacoes/
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
│
├── Program.cs
├── appsettings.json
└── ControleFinanceiro.csproj

🗄️ Banco de Dados

O projeto utiliza MySQL para armazenamento persistente dos dados.

A comunicação com o banco é feita através do Entity Framework Core.

Contexto

AppDbContext

Principais entidades

Categoria
    │
    └──────── 1:N ────────> Transacao

Uma categoria pode estar associada a várias transações.

A transação utiliza uma referência para a categoria através de:

CategoriaId

Essa estrutura mantém o relacionamento entre as entidades e ajuda a preservar a integridade dos dados.

🛡️ Validações

O sistema possui validações para evitar dados inválidos.

Transações

Descrição obrigatória

Limite de caracteres

Valor obrigatório

Valor maior que zero

Data obrigatória

Tipo obrigatório

Categoria obrigatória

Categorias

Nome obrigatório

Limite de caracteres

Validação de duplicidade

Proteção contra exclusão quando existem relacionamentos

🔐 Segurança

A aplicação utiliza recursos de segurança disponíveis no ASP.NET Core.

Entre eles:

HTTPS

HTTPS Redirection

HSTS em produção

Anti-forgery tokens

Validação de ModelState

Validação de relacionamentos

Controle de concorrência

Os formulários protegidos utilizam:

[ValidateAntiForgeryToken]

📱 Interface Responsiva

A interface foi estruturada para funcionar em diferentes tamanhos de tela.

O projeto possui estilos específicos para:

wwwroot/css/

├── base.css
├── components.css
├── dashboard.css
├── forms.css
├── layout.css
├── responsive.css
└── site.css

A aplicação busca manter uma experiência consistente em:

📱 Smartphones

📱 Tablets

💻 Notebooks

🖥️ Desktops

⚡ JavaScript

Os scripts frontend são organizados por responsabilidade.

wwwroot/js/

├── charts.js
├── dashboard.js
├── site.js
├── theme.js
└── transacoes.js

charts.js

Responsável pelos gráficos financeiros.

dashboard.js

Comportamentos relacionados ao dashboard.

theme.js

Gerenciamento do tema claro/escuro.

transacoes.js

Comportamentos da área de transações.

site.js

Funcionalidades gerais da aplicação.

🧠 Conceitos Aplicados

O projeto demonstra a aplicação prática de diversos conceitos de desenvolvimento.

Backend

Programação Orientada a Objetos

MVC

CRUD

Controllers

Services

Interfaces

ViewModels

Dependency Injection

LINQ

Async/Await

Data Annotations

Banco de Dados

Modelagem relacional

Chaves primárias

Chaves estrangeiras

Relacionamentos 1

Constraints

Migrations

Integridade referencial

Frontend

HTML5

CSS3

JavaScript

Razor

Bootstrap

Responsividade

Manipulação de dados

Gráficos interativos

📋 Como Rodar Localmente

Pré-requisitos

Antes de executar o projeto, certifique-se de possuir:

.NET SDK

MySQL

Git

Visual Studio, Visual Studio Code ou Rider

1. Clone o repositório

git clone https://github.com/gmachhh/ControleFinanceiroV2.git
cd ControleFinanceiroV2

2. Configure o banco de dados

Abra:

ControleFinanceiro/appsettings.json

Configure a sua connection string.

Exemplo:

{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;database=ControleFinanceiro;user=root;password=SUA_SENHA"
  }
}

⚠️ Não publique senhas ou credenciais reais no repositório.

3. Restaure as dependências

dotnet restore

4. Configure o Entity Framework

Caso ainda não possua o EF CLI instalado:

dotnet tool install --global dotnet-ef

Depois execute as migrations:

dotnet ef database update

5. Compile o projeto

dotnet build

6. Execute

dotnet run

Depois acesse o endereço informado pelo terminal.

🔨 Comandos Disponíveis

# Restaurar dependências
dotnet restore

# Compilar o projeto
dotnet build

# Executar em desenvolvimento
dotnet run

# Aplicar migrations
dotnet ef database update

# Criar uma nova migration
dotnet ef migrations add NomeDaMigration

🔄 Fluxo de Utilização

           Início
             │
             ▼
       Criar Categorias
             │
             ▼
    Cadastrar Transações
             │
       ┌─────┴─────┐
       ▼           ▼
   Receitas     Despesas
       │           │
       └─────┬─────┘
             ▼
          Dashboard
             │
       ┌─────┼─────┐
       ▼     ▼     ▼
    Saldo  Gráficos  Filtros
             │
             ▼
         Relatórios

📌 Status do Projeto

🚧 Em desenvolvimento

✅ Atualmente disponível

Dashboard financeiro

Cadastro de receitas

Cadastro de despesas

CRUD de transações

CRUD de categorias

Filtros de transações

Cálculo automático de saldo

Gráficos financeiros

Histórico mensal

Tema claro/escuro

Interface responsiva

Validações

MySQL

Entity Framework Core

Migrations

Área de configurações

Área de relatórios

🚧 Em evolução

Exportação de relatórios em PDF

Exportação de relatórios em Excel

Sistema completo de notificações

Autenticação e usuários

Contas bancárias

Cartões de crédito

Metas financeiras

Orçamento mensal

🔮 Próximas Evoluções

O projeto possui espaço para crescer e receber novas funcionalidades.

👤 Usuários

Cadastro

Login

Logout

Recuperação de senha

Dados financeiros individuais

💳 Contas e Cartões

Contas bancárias

Cartões de crédito

Limites

Faturas

Parcelamentos

🎯 Planejamento Financeiro

Metas

Orçamento mensal

Limites por categoria

Acompanhamento de objetivos

🔔 Notificações

Alertas de vencimento

Alertas de gastos

Avisos de orçamento

Lembretes financeiros

📊 Dashboard Avançado

Comparação entre períodos

Novos indicadores

Evolução patrimonial

Análises personalizadas

Previsões financeiras

👨‍💻 Desenvolvedor

Desenvolvido por gmachhh.

Projeto criado com foco em aprendizado, prática de desenvolvimento de software e construção de uma aplicação web real, aplicando conceitos de backend, frontend, banco de dados, arquitetura MVC e visualização de informações.

📄 Licença

Este projeto está licenciado sob a Apache License 2.0.

Consulte o arquivo LICENSE.txt para mais informações.

🙏 Agradecimentos

Projeto desenvolvido com foco em:

🧠 Aprendizado contínuo

🏗️ Boas práticas de arquitetura

💻 Desenvolvimento web

🗄️ Banco de dados

🎨 Experiência do usuário

📊 Visualização de dados

🚀 Evolução profissional

💡 ControleFinanceiro

Organize suas finanças. Visualize seus gastos. Tenha mais controle sobre seu dinheiro.
