<p align="center">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" width="100" alt="project-logo">
</p>
<p align="center">
    <h1 align="center">ECOMMERCE USERS SERVICE</h1>
</p>
<p align="center">
    <em>Secure, scalable user management microservice for modern eCommerce solutions</em>
</p>
<p align="center">
	<img src="https://img.shields.io/github/license/jabbarhuseynzada/eCommerceSolution.UsersService?style=flat&logo=opensourceinitiative&logoColor=white&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/jabbarhuseynzada/eCommerceSolution.UsersService?style=flat&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/jabbarhuseynzada/eCommerceSolution.UsersService?style=flat&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/jabbarhuseynzada/eCommerceSolution.UsersService?style=flat&color=0080ff" alt="repo-language-count">
</p>
<p align="center">
		<em>Built with the tools and technologies:</em>
</p>
<p align="center">
	<img src="https://img.shields.io/badge/C%23-239120.svg?style=flat&logo=c-sharp&logoColor=white" alt="C#">
	<img src="https://img.shields.io/badge/.NET-5C2D91.svg?style=flat&logo=.net&logoColor=white" alt=".NET">
	<img src="https://img.shields.io/badge/Entity%20Framework-5C2D91.svg?style=flat&logo=.net&logoColor=white" alt="Entity Framework">
	<img src="https://img.shields.io/badge/JWT-000000.svg?style=flat&logo=JSON%20web%20tokens&logoColor=white" alt="JWT">
	<img src="https://img.shields.io/badge/PostgreSQL-336791.svg?style=flat&logo=postgresql&logoColor=white" alt="PostgreSQL">
	<img src="https://img.shields.io/badge/Swagger-85EA2D.svg?style=flat&logo=swagger&logoColor=black" alt="Swagger">
</p>

<br>

## 🔗 Table of Contents

- [📍 Overview](#-overview)
- [👾 Features](#-features)
- [📂 Repository Structure](#-repository-structure)
- [🧩 Modules](#-modules)
- [🚀 Getting Started](#-getting-started)
  - [🔖 Prerequisites](#-prerequisites)
  - [⚙️ Installation](#️-installation)
  - [🤖 Usage](#-usage)
- [📊 Project Roadmap](#-project-roadmap)
- [🤝 Contributing](#-contributing)
- [🎗 License](#-license)
- [🙏 Acknowledgments](#-acknowledgments)

---

## 📍 Overview

The **eCommerce Users Service** is a robust microservice designed to handle all user-related operations in a distributed eCommerce ecosystem. Built with modern architectural patterns and security best practices, it provides comprehensive user management capabilities including authentication, authorization, profile management, and account security features.

This service follows Domain-Driven Design (DDD) principles and implements CQRS patterns to ensure scalability, maintainability, and high performance in enterprise-grade applications.

---

## 👾 Features

<code>🔐 **Authentication & Authorization**</code>
- JWT-based stateless authentication
- Role-based access control (RBAC)
- Multi-factor authentication support
- OAuth 2.0 integration ready

<code>👤 **User Management**</code>
- Complete user lifecycle management
- Profile customization and preferences
- Account verification and activation
- Password policies and security

<code>📧 **Communication**</code>
- Email verification system
- Password reset workflows
- Notification preferences
- Multi-language support

<code>🛡️ **Security**</code>
- BCrypt password hashing
- Rate limiting and brute force protection
- Input validation and sanitization
- GDPR compliance features

<code>🔄 **Integration**</code>
- RESTful API with OpenAPI documentation
- Event-driven architecture support
- Database migrations and seeding
- Health checks and monitoring

---

## 📂 Repository Structure

```sh
└── eCommerceSolution.UsersService/
    ├── src/
    └── ├── Application/
        │   ├── Commands/
        │   ├── Queries/
        │   ├── DTOs/
        │   ├── Interfaces/
        │   └── Services/
        ├── Domain/
        │   ├── Entities/
        │   ├── Enums/
        │   ├── Events/
        │   └── ValueObjects/
        ├── Infrastructure/
        │   ├── Data/
        │   ├── Repositories/
        │   ├── Services/
        │   └── Migrations/
        └── API/
            ├── Controllers/
            ├── Middleware/
            ├── Extensions/
            └── Configuration/
```

---

## 🧩 Modules

<details closed><summary>Application Layer</summary>

| File | Summary |
| --- | --- |
| [UserService.cs](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/blob/main/src/Application/Services/UserService.cs) | Core user management operations and business logic implementation |
| [AuthService.cs](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/blob/main/src/Application/Services/AuthService.cs) | Authentication and authorization service with JWT token management |
| [EmailService.cs](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/blob/main/src/Application/Services/EmailService.cs) | Email notification service for user verification and communications |

</details>

<details closed><summary>Domain Layer</summary>

| File | Summary |
| --- | --- |
| [User.cs](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/blob/main/src/Domain/Entities/User.cs) | User entity with comprehensive properties and domain validation |
| [Role.cs](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/blob/main/src/Domain/Entities/Role.cs) | Role entity for implementing role-based access control |
| [UserPreferences.cs](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/blob/main/src/Domain/Entities/UserPreferences.cs) | User preferences and settings management |

</details>

<details closed><summary>Infrastructure Layer</summary>

| File | Summary |
| --- | --- |
| [UsersDbContext.cs](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/blob/main/src/Infrastructure/Data/UsersDbContext.cs) | Entity Framework Core database context configuration |
| [UserRepository.cs](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/blob/main/src/Infrastructure/Repositories/UserRepository.cs) | Repository pattern implementation for user data access |
| [CacheService.cs](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/blob/main/src/Infrastructure/Services/CacheService.cs) | Redis caching service for performance optimization |

</details>

<details closed><summary>API Layer</summary>

| File | Summary |
| --- | --- |
| [UsersController.cs](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/blob/main/src/API/Controllers/UsersController.cs) | RESTful API endpoints for user management operations |
| [AuthController.cs](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/blob/main/src/API/Controllers/AuthController.cs) | Authentication and authorization API endpoints |
| [Program.cs](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/blob/main/src/API/Program.cs) | Application entry point and service configuration |

</details>

---

## 🚀 Getting Started

### 🔖 Prerequisites

Before running this project, ensure you have the following installed:

- **.NET 8.0 SDK** or later
- **PostgreSQL 14+** or **SQL Server 2019+**
- **Redis 6.0+** (for caching)

### ⚙️ Installation

<h4>From <code>git clone</code></h4>

> 1. Clone the eCommerceSolution.UsersService repository:
>
> ```bash
> git clone https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService
> ```
>
> 2. Navigate to the project directory:
>
> ```bash
> cd eCommerceSolution.UsersService
> ```
>
> 3. Install the project dependencies:
>
> ```bash
> dotnet restore
> ```

### 🤖 Usage

<h4>From <code>source</code></h4>

> 1. Set up your environment variables:
>
> ```bash
> cp appsettings.example.json appsettings.Development.json
> ```
>
> 2. Configure your database connection string in `appsettings.Development.json`:
>
> ```json
> {
>   "ConnectionStrings": {
>     "DefaultConnection": "Host=localhost;Database=ecommerce_users;Username=your_username;Password=your_password"
>   },
>   "JwtSettings": {
>     "Secret": "your-super-secret-jwt-key-here",
>     "ExpiryMinutes": 60
>   },
>   "Redis": {
>     "ConnectionString": "localhost:6379"
>   }
> }
> ```
>
> 3. Run database migrations:
>
> ```bash
> dotnet ef database update
> ```
>
> 4. Start the development server:
>
> ```bash
> dotnet run --project src/API
> ```

---

## 📊 Project Roadmap

- [x] **`Task 1`**: <strike>Implement basic user CRUD operations</strike>
- [x] **`Task 2`**: <strike>Add JWT authentication and authorization</strike>
- [x] **`Task 3`**: <strike>Implement email verification system</strike>
- [x] **`Task 4`**: <strike>Add password reset functionality</strike>
- [x] **`Task 5`**: <strike>Implement role-based access control</strike>
- [ ] **`Task 6`**: Add multi-factor authentication (MFA)
- [ ] **`Task 7`**: Implement OAuth 2.0 integration
- [ ] **`Task 8`**: Add user activity logging and audit trail
- [ ] **`Task 9`**: Implement advanced user preferences
- [ ] **`Task 10`**: Add GDPR compliance features

---

## 🤝 Contributing

Contributions are welcome! Here are several ways you can contribute:

- **[Report Issues](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/issues)**: Submit bugs found or log feature requests for the `eCommerceSolution.UsersService` project.
- **[Submit Pull Requests](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/blob/main/CONTRIBUTING.md)**: Review open PRs, and submit your own PRs.
- **[Join the Discussions](https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService/discussions)**: Share your insights, provide feedback, or ask questions.

<details closed>
<summary>Contributing Guidelines</summary>

1. **Fork the Repository**: Start by forking the project repository to your github account.
2. **Clone Locally**: Clone the forked repository to your local machine using a git client.
   ```sh
   git clone https://github.com/jabbarhuseynzada/eCommerceSolution.UsersService
   ```
3. **Create a New Branch**: Always work on a new branch, giving it a descriptive name.
   ```sh
   git checkout -b new-feature-x
   ```
4. **Make Your Changes**: Develop and test your changes locally.
5. **Commit Your Changes**: Commit with a clear message describing your updates.
   ```sh
   git commit -m 'Implemented new feature x.'
   ```
6. **Push to github**: Push the changes to your forked repository.
   ```sh
   git push origin new-feature-x
   ```
7. **Submit a Pull Request**: Create a PR against the original project repository. Clearly describe the changes and their motivations.
8. **Review**: Once your PR is reviewed and approved, it will be merged into the main branch. Congratulations on your contribution!
</details>

<details closed>
<summary>Contributor Graph</summary>
<br>
<p align="left">
   <a href="https://github.com{/jabbarhuseynzada/eCommerceSolution.UsersService/}graphs/contributors">
      <img src="https://contrib.rocks/image?repo=jabbarhuseynzada/eCommerceSolution.UsersService">
   </a>
</p>
</details>

---

## 🎗 License

This project is protected under the [MIT](https://choosealicense.com/licenses/mit/) License. For more details, refer to the [LICENSE](https://choosealicense.com/licenses/mit/) file.

---

## 🙏 Acknowledgments

- **[ASP.NET Core](https://docs.microsoft.com/aspnet/core/)**: For providing the robust web framework
- **[Entity Framework Core](https://docs.microsoft.com/ef/core/)**: For excellent ORM capabilities
- **[JWT](https://jwt.io/)**: For secure authentication standards

---

<p align="center">
  <img src="https://raw.githubusercontent.com/eli64s/readme-ai/main/docs/docs/assets/img/project-logo/readme-ai-logo.svg" width="30" alt="readme-ai-logo">
  <br>
  <em>Generated with ❤️ by <a href="https://github.com/eli64s/readme-ai">readme-ai</a></em>
</p>
