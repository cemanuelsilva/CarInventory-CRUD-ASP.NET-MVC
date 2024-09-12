# LearnApp

**LearnApp** is a basic ASP.NET Core MVC application that demonstrates CRUD (Create, Read, Update, Delete) operations using Entity Framework Core, with a car listing as an example.

## Features

- List all cars.
- Create a new car entry.
- View car details.
- Update and delete existing cars.

## Technologies Used

- **ASP.NET Core MVC** - For building the web application.
- **Entity Framework Core** - For interacting with the database.
- **C#** - Main programming language.
- **SQL Server** - Database management system.

## Project Structure

- **Controllers**: Handles the HTTP requests and manages the logic for retrieving or saving data.
  - `CarController.cs`: Manages all car-related operations, such as listing, creating, and editing cars.
  - `HomeController.cs`: Manages general home page logic.
  
- **Models**: Contains the business logic and definitions of the data structures.
  - `Car.cs`: Defines the car model, with properties such as `Id`, `Plate`, `CarOwner`, etc.
  
- **Data**: Handles the database context for Entity Framework Core.
  - `DbContext.cs`: Configures the database context, and contains DbSets for the models.
  
- **Views**: Contains the Razor pages that are rendered in response to requests.
  - Example: `Index.cshtml` for listing all cars, `Create.cshtml` for creating a new car.

## Setup Instructions

1. **Clone the repository**:

   ```bash
   git clone https://github.com/your-username/CarInventory-CRUD-ASP.NET-MVC.git
   cd LearnApp

2. **Configure the Database:**

In appsettings.json, configure your connection string to your SQL Server database.

```js
"ConnectionStrings": {
  "DefaultConnection": "Server=your-server-name;Database=your-data-base-name;Trusted_Connection=True;"
}
```

3. **Run the Migrations:**

To ensure the database is set up correctly with the appropriate tables:

```bash
dotnet ef database update
```

4. **Run the Application:**

```bash
dotnet run
Open your browser and navigate to https://localhost:... , verify on launchSettings.json
```
