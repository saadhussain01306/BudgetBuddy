# BudgetBuddy: Expense Tracker Application
![Screenshot 2024-12-16 115924](https://github.com/user-attachments/assets/60eccf8c-0fe1-4bbd-9fe5-debf2c54679a)

BudgetBuddy is a robust expense-tracking web application designed to help users manage their expenses efficiently. This project is built using **ASP.NET Core MVC** for the backend and **Entity Framework Core** for database management, with a modern user interface styled using **Bootstrap**.

## Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Project Directory Structure](#project-directory-structure)
- [Setup and Installation](#setup-and-installation)
- [Usage](#usage)
- [Endpoints and CRUD Operations](#endpoints-and-crud-operations)
- [Screenshots](#screenshots)
- [Future Enhancements](#future-enhancements)
- [License](#license)

## Features
- **Expense Management**: Add, edit, view, and delete expenses.
- **Responsive UI**: User-friendly interface designed with Bootstrap.
- **Data Validation**: Built-in validation to ensure accurate data entry.
- **Search and Filtering**: Easily find expenses by category or date.

## Technologies Used
- **Framework**: ASP.NET Core MVC
- **Frontend**: Razor Pages, Bootstrap 5
- **Backend**: Entity Framework Core
- **Database**: SQL Server
- **Languages**: C#, HTML, CSS, JavaScript

## Project Directory Structure
```
BudgetBuddy/
├── Controllers/
│   ├── ExpenseController.cs
├── Models/
│   ├── Expense.cs
│   ├── ApplicationDbContext.cs
├── Views/
│   ├── Expense/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Delete.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
├── wwwroot/
│   ├── css/
│   ├── js/
│   ├── lib/
├── appsettings.json
├── Program.cs
├── Startup.cs
```

## Setup and Installation

### Prerequisites
1. [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
2. [SQL Server](https://www.microsoft.com/en-us/sql-server)
3. IDE (e.g., Visual Studio or Visual Studio Code)

### Installation Steps

1. **Clone the Repository**
   ```bash
   git clone https://github.com/saadhussain01306/BudgetBuddy.git
   cd BudgetBuddy
   ```

2. **Restore Dependencies**
   ```bash
   dotnet restore
   ```

3. **Configure the Database**
   Update the `appsettings.json` file with your SQL Server connection string:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=BudgetBuddyDB;Trusted_Connection=True;"
   }
   ```

4. **Apply Migrations**
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

5. **Run the Application**
   ```bash
   dotnet run
   ```
   Open the browser and navigate to `http://localhost:5090`.

## Usage

1. **Add Expenses**: Navigate to the "Add Expense" page to record a new expense.
2. **View Expenses**: View a list of all recorded expenses on the "Expenses" page.
3. **Edit Expenses**: Update expense details by clicking the "Edit" button.
4. **Delete Expenses**: Remove an expense by clicking the "Delete" button.


## Screenshots

### 1. **Home Page**
The landing page with navigation links to manage expenses.

![Screenshot 2024-12-16 115924](https://github.com/user-attachments/assets/9e18e36e-a65e-4759-a6bd-c7168ccbd344)

![Screenshot 2024-12-16 115946](https://github.com/user-attachments/assets/6edfbfd5-a108-4456-ac1a-21b460f73e0b)

### 2. **Expenses Page**
A list of all recorded expenses with options to edit or delete.

![Screenshot 2024-12-16 120025](https://github.com/user-attachments/assets/3be5b501-b3dc-46a2-9512-797fba4d47cf)


### 3. **Add Expense Page**
Form to add a new expense.
![Screenshot 2024-12-16 120041](https://github.com/user-attachments/assets/4aeb0471-5e54-46ab-909f-1314bd80b06e)

### 4. **Edit Expense Page**
Form to update existing expense details.
![Screenshot 2024-12-16 120101](https://github.com/user-attachments/assets/74ca7434-2b58-44bd-a1f9-5d90e80240e6)


## Future Enhancements
- Add user authentication for secure access.
- Implement analytics and graphs for expense trends.
- Include support for exporting data to Excel or PDF.

## License
This project is licensed under the MIT License.
