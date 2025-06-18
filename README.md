🎫 Ticket2Help
Aplicação de gestão de tickets de suporte, desenvolvida em WPF (.NET) com arquitetura MVVM e separação por camadas (UI, BLL, DAL). Suporta autenticação básica para utilizadores e técnicos.

🗂️ Estrutura do Projeto

Ticket2Help/
│
├── Ticket2Help.Models/   → Modelos de dados (Ticket, User)
├── Ticket2Help.DAL/      → Acesso a dados (DbContext, Repositórios)
├── Ticket2Help.BLL/      → Lógica de negócio (Serviços, Interfaces, Autenticação)
└── UI/                   → Interface Gráfica (Views, ViewModels, Navegação)


🔑 Funcionalidades

Autenticação com base no tipo de utilizador (User ou Técnico)

Dashboards separados por perfil

Criação, edição e gestão de tickets

Gráfico de pizza com percentagens por estado (via LiveCharts)

Labels dos tickets adaptados ao perfil:

User: Aberto, Em Progresso, Fechado

Técnico: Por Fazer, Em Andamento, Concluído

Implementação completa do padrão MVVM:

Bindings, Commands, ViewModels

Navegação entre páginas com NavigationService

Estrutura limpa e modular com Clean Architecture


📊 Estatísticas Visuais
O dashboard inclui um gráfico de pizza interativo, que mostra visualmente a proporção de tickets por estado:

Exemplo:

40% Aberto

30% Em Progresso

30% Fechado


🚀 Como Correr o Projeto

✅ Pré-requisitos
Visual Studio 2022 ou superior

.NET 6 ou superior

Entity Framework Core

SQLite (ou outro provider, se necessário)

⚙️ Passos para Execução
Clona o repositório ou copia os ficheiros localmente

Abre o .sln no Visual Studio

Instala os pacotes NuGet necessários (na camada DAL):

Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Sqlite
Install-Package Microsoft.EntityFrameworkCore.Tools


Cria a base de dados (na camada DAL):

Add-Migration InitialCreate
Update-Database


Instala o pacote de gráficos (na camada UI):

Install-Package LiveCharts.Wpf -Version 0.9.7
Corre o projeto a partir da camada UI


👥 Utilizadores de Teste

Nome de Utilizador	Password	Role
joao	1234	User
maria	abcd	User
tecnico	4321	Tecnico

⚠️ As passwords são encriptadas com SHA256 via PasswordHasher.


🧠 Tecnologias e Conceitos

WPF com XAML

MVVM (Model-View-ViewModel)

Entity Framework Core

Injeção de dependências via construtores

Interfaces (ex: ITicketService, ITicketRepository)

Autenticação básica

Data Binding, Commands e INotifyPropertyChanged

Navegação com NavigationService

LiveCharts para gráficos dinâmicos


📌 Possíveis Melhorias Futuras
Registo de novos utilizadores

Integração com base de dados remota

Exportação de relatórios (PDF/CSV)

Upload de anexos em tickets

Notificações internas e atribuição de tickets

Dashboard com filtros e intervalos de datas


👨‍💻 Autores
Projeto desenvolvido por:

Alberto Macieira

Ricardo Rodrigues

Tiago Canedo

Com o apoio do ChatGPT, no contexto da unidade curricular LEI-PA-TP.
Licenciado para fins educativos e formativos, extensível a projetos reais.