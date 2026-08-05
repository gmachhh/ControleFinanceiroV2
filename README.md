💰 ControleFinanceiro

Sistema web para gerenciamento de finanças pessoais, desenvolvido com ASP.NET Core MVC, Entity Framework Core e MySQL.



📌 Sobre o projeto

O ControleFinanceiro é uma aplicação web criada para facilitar o gerenciamento de finanças pessoais.

O sistema permite cadastrar receitas e despesas, organizar movimentações por categorias, consultar o histórico financeiro, aplicar filtros e acompanhar os principais indicadores através de um dashboard.

O projeto foi desenvolvido utilizando ASP.NET Core MVC, com separação entre Controllers, Models, Services, ViewModels e Views.

🎯 Objetivo

Oferecer uma maneira simples e visual de acompanhar:

💵 Receitas

💸 Despesas

💰 Saldo

🧾 Transações

🏷️ Categorias

📊 Distribuição dos gastos

📈 Evolução financeira

✨ Funcionalidades

📊 Dashboard

O dashboard apresenta um resumo da situação financeira do usuário.

Indicadores

💵 Total de receitas

💸 Total de despesas

💰 Saldo financeiro

🧾 Quantidade de transações

🕐 Últimas transações

📊 Comparação entre receitas e despesas

🍩 Despesas por categoria

📅 Evolução mensal

Os dados são calculados a partir das movimentações cadastradas no banco de dados.

💵 Receitas

É possível cadastrar entradas financeiras, como:

Salário

Freelances

Investimentos

Vendas

Rendimentos

Outros recebimentos

Cada movimentação pode possuir:

Descrição

Valor

Data

Categoria

Tipo

💸 Despesas

O sistema também permite registrar gastos financeiros, como:

Alimentação

Transporte

Moradia

Educação

Saúde

Lazer

Compras

Contas

Outros gastos

As despesas são utilizadas automaticamente nos cálculos do dashboard e relatórios.

🧾 Transações

O módulo de transações permite administrar todas as movimentações financeiras.

Operações disponíveis

➕ Criar transação

👁️ Visualizar transações

✏️ Editar transação

🗑️ Excluir transação

🔎 Pesquisar transações

🏷️ Filtrar por categoria

💵 Filtrar por tipo

📅 Filtrar por período

🔎 Filtros

A tela de transações permite combinar diferentes filtros.

Descrição

Pesquisa uma movimentação através da descrição.

Tipo

Permite visualizar:

Todas

Receitas

Despesas

Categoria

Exibe somente transações pertencentes à categoria selecionada.

Período

Permite informar:

Data inicial

Data final

Os filtros podem ser combinados para encontrar movimentações específicas.

🏷️ Categorias

O sistema possui gerenciamento completo de categorias.

Funcionalidades

➕ Criar categoria

📋 Listar categorias

✏️ Editar categoria

🗑️ Excluir categoria

🚫 Evitar categorias duplicadas

🔒 Impedir exclusão de categoria utilizada

Uma categoria relacionada a transações não pode ser excluída, preservando a integridade dos dados.

📈 Gráficos

O projeto utiliza Chart.js para apresentar os dados financeiros de forma visual.

📊 Receitas x Despesas

Compara receitas e despesas ao longo dos meses.

🍩 Despesas por categoria

Mostra como as despesas estão distribuídas entre as categorias.

📅 Histórico mensal

O dashboard apresenta dados dos últimos meses para facilitar a identificação de tendências.

💰 Cálculo do saldo

O saldo é calculado automaticamente:

Saldo = Total de Receitas - Total de Despesas

Exemplo:

Receitas: R$ 3.000,00
Despesas: R$ 2.000,00
Saldo:    R$ 1.000,00

📑 Relatórios

O projeto possui uma área dedicada aos relatórios financeiros.

A interface apresenta recursos para:

📊 Comparação de receitas e despesas

🍩 Distribuição das despesas por categoria

📄 Exportação dos dados

Nota: os botões de exportação PDF e Excel estão presentes na interface, mas a geração dos arquivos pode ser implementada como uma próxima evolução do projeto.

⚙️ Configurações

A aplicação possui uma área de configurações.

🎨 Aparência

Suporte para:

☀️ Tema claro

🌙 Tema escuro

A preferência de tema é armazenada no navegador utilizando localStorage.

🔔 Notificações

A interface possui configuração para notificações, preparada para futuras funcionalidades de alertas.

🛠️ Informações

A página apresenta informações relacionadas à versão e tecnologias utilizadas no sistema.

🎨 Interface

A aplicação possui uma interface moderna e responsiva, com:

Dashboard

Cards de indicadores

Tabelas

Formulários

Botões de ação

Alertas

Gráficos

Ícones

Tema claro/escuro

Layout responsivo

🏗️ Arquitetura

O projeto utiliza o padrão MVC (Model-View-Controller).

Controller
    ↓
Service
    ↓
Model / ViewModel
    ↓
View

Models

Representam os dados da aplicação.

Principais entidades:

Transacao
Categoria
TipoTransacao

Controllers

Responsáveis pelo fluxo das requisições.

HomeController
TransacoesController
CategoriasController
RelatoriosController
ConfiguracoesController

Services

A camada de serviços concentra regras específicas.

Principal serviço:

DashboardService

Responsável por preparar os dados utilizados no dashboard.

ViewModels

Principais ViewModels:

DashboardViewModel
TransacaoFiltroViewModel

🗂️ Estrutura do projeto

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

🗄️ Banco de dados

O sistema utiliza MySQL e Entity Framework Core.

O contexto principal é:

AppDbContext

Relacionamento

Uma categoria pode possuir várias transações:

Categoria
    │
    └── 1:N ──> Transacao

A transação utiliza CategoriaId como chave estrangeira.

🛡️ Validações

O sistema utiliza validações através de Data Annotations e regras da aplicação.

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

Controle de duplicidade

Proteção contra exclusão quando existem transações relacionadas

🔐 Segurança

O projeto utiliza recursos do ASP.NET Core, incluindo:

HTTPS

HTTPS Redirection

HSTS em produção

Anti-forgery tokens

Validação de ModelState

Validação de entidades relacionadas

Controle de concorrência

Os formulários utilizam proteção contra requisições CSRF através de:

[ValidateAntiForgeryToken]

🧰 Tecnologias utilizadas

Backend

C#

ASP.NET Core MVC

.NET

Entity Framework Core

LINQ

Dependency Injection

Async/Await

Banco de dados

MySQL

Pomelo.EntityFrameworkCore.MySql

Entity Framework Core Migrations

Frontend

HTML5

CSS3

JavaScript

Razor

Bootstrap

Font Awesome

Chart.js

Bibliotecas

Bootstrap

jQuery

jQuery Validation

jQuery Validation Unobtrusive

📦 Principais dependências

Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Tools
Pomelo.EntityFrameworkCore.MySql

As dependências estão definidas no arquivo:

ControleFinanceiro.csproj

🚀 Como executar

1. Pré-requisitos

Instale:

.NET SDK

MySQL

Visual Studio, Visual Studio Code ou Rider

Git

2. Clonar o projeto

git clone https://github.com/gmachhh/ControleFinanceiroV2.git
cd ControleFinanceiroV2

3. Configurar o banco

Configure a connection string em:

ControleFinanceiro/appsettings.json

Exemplo:

{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;database=ControleFinanceiro;user=root;password=SUA_SENHA"
  }
}

⚠️ Nunca publique senhas reais ou credenciais do banco no GitHub.

4. Restaurar dependências

dotnet restore

5. Aplicar migrations

Caso ainda não possua o Entity Framework CLI:

dotnet tool install --global dotnet-ef

Depois:

dotnet ef database update

6. Compilar

dotnet build

7. Executar

dotnet run

O terminal mostrará o endereço local da aplicação.

🔄 Fluxo de utilização

Abrir o sistema
      ↓
Criar categorias
      ↓
Cadastrar receitas e despesas
      ↓
Consultar transações
      ↓
Aplicar filtros
      ↓
Acessar Dashboard
      ↓
Analisar gráficos
      ↓
Consultar Relatórios
      ↓
Configurar aparência

🧠 Conceitos aplicados

O projeto utiliza conceitos importantes de desenvolvimento de software:

Programação

Programação Orientada a Objetos

MVC

CRUD

Interfaces

Services

ViewModels

Dependency Injection

LINQ

Async/Await

Banco de dados

Relacionamentos

Chaves primárias

Chaves estrangeiras

Constraints

Migrations

Integridade referencial

Frontend

HTML

CSS

JavaScript

Razor

Bootstrap

Responsividade

Visualização de dados

📱 Responsividade

O frontend possui arquivos específicos para organização da interface:

wwwroot/css/
├── base.css
├── components.css
├── dashboard.css
├── forms.css
├── layout.css
├── responsive.css
└── site.css

O JavaScript também é separado por responsabilidade:

wwwroot/js/
├── charts.js
├── dashboard.js
├── site.js
├── theme.js
└── transacoes.js

🔮 Próximas melhorias

Algumas funcionalidades que podem ser adicionadas futuramente:

🔐 Usuários

Login

Cadastro

Logout

Recuperação de senha

Dados separados por usuário

💳 Contas e cartões

Contas bancárias

Cartões

Limites

Faturas

Parcelamentos

📅 Planejamento

Metas financeiras

Orçamento mensal

Limites por categoria

Planejamento de gastos

🔔 Notificações

Alertas de vencimento

Avisos de orçamento

Alertas de gastos elevados

📑 Relatórios

Exportação PDF

Exportação Excel

Relatórios personalizados

Filtros avançados

Relatórios anuais

📊 Dashboard avançado

Comparação entre períodos

Evolução do patrimônio

Percentuais de gastos

Novos indicadores

Previsões financeiras

📌 Status

🚧 Em desenvolvimento

O projeto já possui uma base funcional para gerenciamento financeiro, incluindo:

CRUD de transações

CRUD de categorias

Filtros

Dashboard

Indicadores

Gráficos

Relatórios

Configurações

Tema claro/escuro

Banco de dados MySQL

Entity Framework Core

Interface responsiva

👨‍💻 Desenvolvedor

Desenvolvido por gmachhh.

Projeto desenvolvido com foco em aprendizado, prática de desenvolvimento web e construção de uma aplicação real de controle financeiro.

📄 Licença

Este projeto está licenciado sob a Apache License 2.0.

Consulte o arquivo LICENSE.txt para mais informações.

⭐ Contribuição

Contribuições são bem-vindas.

# Criar uma branch
git checkout -b feature/nova-funcionalidade

# Fazer alterações

# Commit
git commit -m "Adiciona nova funcionalidade"

# Enviar para o GitHub
git push origin feature/nova-funcionalidade

Depois, abra um Pull Request.

💡 Resumo

O ControleFinanceiro combina:

💰 Controle financeiro
        +
🧾 Transações
        +
🏷️ Categorias
        +
📊 Dashboard
        +
📈 Gráficos
        +
🔎 Filtros
        +
📑 Relatórios
        +
🎨 Tema claro/escuro
        +
🗄️ MySQL
        +
⚙️ ASP.NET Core MVC

Organize suas finanças. Entenda seus gastos. Tome decisões melhores.
