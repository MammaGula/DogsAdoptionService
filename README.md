# 🐶 DogsAdoptionService

A simple ASP.NET Core MVC web app to browse dogs and adopt them.  
Built with **.NET 10** + **Entity Framework Core** + **SQL Server (LocalDB by default)**.

---

## ✨ Features
- 📋 List all dogs
- 🔎 View dog details
- 🏡 Adopt a dog
- 🗄️ Database seeded with initial dog data

---

## 🧰 Tech Stack
- ⚙️ .NET 10 (`net10.0`)
- 🧩 ASP.NET Core MVC (Controllers + Views)
- 🗃️ Entity Framework Core 10
- 💾 SQL Server / LocalDB

---

## 🗂️ Project Structure
- `Controllers/` — MVC controllers (ex: `DogsController`)
- `Services/` — business logic (ex: `DogService`)
- `Data/` — EF Core + repositories (ex: `ApplicationDbContext`, `DogRepository`)
- `Models/` — database entity models (ex: `DogModel`)
- `ViewModels/` — models used by views (`DogListViewModel`, `DogDetailsViewModel`)
- `Views/` — Razor views (`Views/Dogs/Index.cshtml`, `Details.cshtml`, `Adopt.cshtml`)
- `wwwroot/` — static assets (images, css, js)

---

## ⚙️ Configuration
Connection string is in `DogsAdoptionService/appsettings.json`:
