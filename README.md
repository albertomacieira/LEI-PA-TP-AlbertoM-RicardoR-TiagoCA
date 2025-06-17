# LEI-PA-TP-AlbertoM-RicardoR-TiagoCA

# 🎫 Ticket2Help

Ticket2Help é uma aplicação de gestão de tickets de suporte, construída em **WPF (.NET)** com a arquitetura **MVVM**, separação em camadas (UI, BLL, DAL) e autenticação básica por utilizador e técnico.

---

## 📁 Estrutura do Projeto

Ticket2Help/
│
├── Ticket2Help.Models/ # Modelos de dados (Ticket, User)
├── Ticket2Help.DAL/ # Acesso a dados (AppDbContext, Repositórios)
├── Ticket2Help.BLL/ # Lógica de negócio (Serviços, Interfaces, Autenticação)
└── UI/ # Interface Gráfica (Views, ViewModels, Navegação)


---

## 🔑 Funcionalidades

- Login com autenticação por função (`User` ou `Tecnico`)
- Dashboards separados para cada tipo de utilizador
- Criação e gestão de tickets
- Padrão MVVM completo (Binding, Commands, ViewModels)
- Navegação entre páginas com `NavigationService`
- Separação por camadas (Clean Architecture)

---

## 🚀 Como correr o projeto

### Pré-requisitos

- Visual Studio 2022 ou superior
- .NET 6 ou superior
- Entity Framework Core
- SQLite (ou outra BD caso expandas o projeto)

### Passos

1. **Clonar o projeto** ou copiar os ficheiros locais
2. **Abrir o `.sln` no Visual Studio**
3. **Instalar pacotes NuGet** (no `Ticket2Help.DAL`, abre a consola e escreve):
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Sqlite
Install-Package Microsoft.EntityFrameworkCore.Tools
4. **Criar a base de dados** (no `Ticket2Help.DAL`):
Add-Migration InitialCreate
Update-Database
5. **Executar o projeto** (a partir da camada `UI`)

---

## 👥 Utilizadores de Teste

| Nome de utilizador | Password | Role     |
|--------------------|----------|----------|
| joao               | 1234     | User     |
| maria              | abcd     | User     |
| tecnico            | 4321     | Tecnico  |

> As passwords são encriptadas com `SHA256` (via `PasswordHasher`).

---

## 🧠 Tecnologias e Conceitos

- WPF com XAML
- MVVM (Model-View-ViewModel)
- Entity Framework Core
- Injeção de dependências simples (via construtores)
- Interface-based programming (`ITicketService`, `ITicketRepository`)
- Autenticação básica
- Binding, Commands e `INotifyPropertyChanged`
- Navegação programática com `NavigationService`

---

## 📌 Possíveis Melhorias Futuras

- Registo de novos utilizadores
- Acesso com base em BD real (em vez de lista local)
- Exportação de relatórios
- Upload de anexos em tickets
- Notificações internas

---

## 🧑‍💻 Autor

Este projeto foi criado por Alberto Macieira, Ricardo Rodrigues e Tiago Canedo com apoio do ChatGPT para fins académicos/formativos.  
Licença livre para uso e modificação.

---
