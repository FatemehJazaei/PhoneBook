# 📒 PhoneBook Web Application with Clean Architecture

## 📌 Project Description
This project is a web-based **PhoneBook application** that allows users to manage their contacts (add, view, update, delete, and search).  
The main goal is to implement the project following **Clean Architecture** principles and **SOLID** design practices to ensure maintainability, scalability, and testability.  

---

## ⚙️ Tech Stack
- **ASP.NET Core 7 (MVC)** – WebUI layer  
- **Entity Framework Core** – Database ORM  
- **SQL Server / SQLite** – Database  
- **C# 10** – Programming language  
- **xUnit / NUnit** – Unit testing  
- **Git & GitHub** – Version control and collaboration  
- *(Optional later: **Docker**, **Serilog Logging**, **GitHub Actions CI/CD**)*  

---

## 🏗️ Architecture
The project follows the **Clean Architecture** pattern with four main layers:
- **Domain** → Core entities (e.g., `Contact`).  
- **Application** → Business logic and use cases.  
- **Infrastructure** → Database, repositories, and external services.  
- **WebUI (MVC)** → Presentation layer (controllers, views, Razor).  

---

## ✨ Features
- [x] Add new contact  
- [x] Display all contacts  
- [x] Search contact by name or phone number  
- [x] Update contact details  
- [x] Delete contact  
- [x] Input validation  
- [x] User authentication (Login/Register)  
- [x] Role-based authorization  

---

## 🚀 Roadmap
1. Create project skeleton with Clean Architecture.  
2. Implement `Contact` entity.  
3. Build CRUD operations for contacts.  
4. Connect project to database and add EF Core migrations.  
5. Create Views with Razor Pages.  
6. Add unit tests for Application layer.  
7. Implement authentication & authorization.  
8. Containerize with Docker.  

---

## ▶️ How to Run
```bash
# Clone repository
git clone https://github.com/username/phonebook-clean-architecture.git
cd phonebook-clean-architecture

# Apply database migrations
dotnet ef database update

# Run the project
dotnet run --project PhoneBook.WebUI
