# Purchasing Management Desktop Application

A desktop purchasing management application developed with C# and .NET Windows Forms.

## About the Project

Purchasing Management Desktop Application is a desktop application designed to manage purchasing records in a structured and user-friendly way.

The project was developed as a software development study to transform purchasing processes from an Excel/VBA-based workflow into a standalone desktop application.

The application uses SQLite for local data storage and does not depend on company-specific data.

## Features

- User login screen
- Add new purchasing records
- Automatic total price calculation
- Purchase record listing
- Search by item code
- Filter by supplier
- Update existing records
- Delete records
- Supplier-based analysis
- Total purchasing amount calculation
- Total supplier count
- Total item count
- Average unit price calculation
- Supplier-based purchasing statistics
- SQLite database integration
- Standalone Windows desktop application
- Custom application icon

## Technologies

- C#
- .NET 10
- Windows Forms
- SQLite
- Microsoft.Data.Sqlite
- Visual Studio
- Git / GitHub

## Database Structure

The application stores purchasing information in a SQLite database.

Main fields:

- `Id`
- `ItemCode`
- `Supplier`
- `Quantity`
- `UnitPrice`
- `PurchaseDate`
- `TotalPrice`

## Application Structure

The application contains several main forms:

- `LoginForm` – User login
- `MainForm` – Main menu
- `PurchaseForm` – Adding and updating purchases
- `PurchaseListForm` – Listing, searching, filtering, updating and deleting records
- `AnalysisForm` – Purchasing statistics and supplier analysis
- `Database` – SQLite database management

## Project Purpose

The main purpose of this project is to demonstrate the development of a practical desktop application using:

- Object-oriented programming
- Database management
- CRUD operations
- Data validation
- SQL queries
- Windows Forms
- Local data storage
- Application publishing

The project also demonstrates the transition from an Excel/VBA-based purchasing workflow to a standalone C# desktop application.

## Data Privacy

No company-specific or confidential company data is included in this repository.

The application is developed and tested using sample purchasing records.

## Future Development

Possible future improvements may include:

- Advanced purchasing reports
- Excel export
- Additional dashboard visualizations
- Role-based user authorization

## Author

**Çağla Burhan**

Computer Engineering Student

GitHub: [caglaab](https://github.com/caglaab)