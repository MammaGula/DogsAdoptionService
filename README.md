# 🐶 DogsAdoptionService

A simple ASP.NET Core MVC web app to browse dogs and adopt them. Built with 
.NET 10 + Entity Framework Core + SQL Server (LocalDB by default).

## ✨ Features

- 📋 List all dogs
- 🔎 View dog details
- 🏡 Adopt a dog
- 🗄️ Database seeded with initial dog data

## 🧰 Tech Stack

- ⚙️ .NET 10 (`net10.0`)
- 🧩 ASP.NET Core MVC (Controllers + Views)
- 🗃️ Entity Framework Core 10
- 💾 SQL Server / LocalDB

## 🗂️ Project Structure

- `DogsAdoptionService.slnx` — solution file
- `README.md` — project documentation
- `images/` — repository images for README/screenshots
- `DogsAdoptionService/` — main ASP.NET Core MVC project
  - `Controllers/` — MVC controllers (ex: `DogsController`)
  - `Services/` — business logic (ex: `DogService`)
  - `Data/` — EF Core + repositories (ex: `ApplicationDbContext`, `DogRepository`)
  - `Models/` — database entity models (ex: `DogModel`)
  - `ViewModels/` — models used by views (`DogListViewModel`, `DogDetailsViewModel`)
  - `Views/` — Razor views (`Views/Dogs/Index.cshtml`, `Details.cshtml`, `Adopt.cshtml`)
  - `wwwroot/` — static assets served by the app
	- `css/` — site styles
	- `js/` — client-side scripts
	- `Images/` — dog photos used by the app

## 🖼️ Images Folder

This repository keeps documentation images in the root `images/` folder.

Dog photos used by the web app are stored in `DogsAdoptionService/wwwroot/Images/`.

Current files include:
- `BarkTwain1.jpg`
- `Biscuit5.jpg`
- `CaptainWoof7.jpg`
- `Coco14.jpg`
- `Daisy6.jpg`
- `Furball3.jpg`
- `KaiYoj15.jpg`
- `Kenji16.jpg`
- `Lola10.jpg`
- `Maximus11.jpg`
- `PrincessPaws4.jpg`
- `Rocky9.jpg`
- `Roxy12.jpg`
- `SirWaggington2.jpg`
- `SnugglePaws8.jpg`
- `Teddy13.jpg`

## ⚙️ Configuration

Connection string is in `DogsAdoptionService/appsettings.json`:

## 🚀 Setup and Run

### Prerequisites

- .NET 10 SDK
- SQL Server LocalDB

### Run the app

1. Restore packages:
   ```powershell
   dotnet restore
   ```
2. Apply the database migration:
   ```powershell
   dotnet ef database update --project DogsAdoptionService/DogsAdoptionService.csproj
   ```
3. Start the application:
   ```powershell
   dotnet run --project DogsAdoptionService/DogsAdoptionService.csproj
   ```

### Notes

- The default connection string uses LocalDB and creates the `DogAdoptionDb` database.
- README screenshots or diagrams can be placed in the root `images/` folder and linked here with relative paths.
- Dog images are loaded from `DogsAdoptionService/wwwroot/Images/`.

## About

ASP.NET Core MVC dog adoption web application
