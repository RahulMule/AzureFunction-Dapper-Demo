# Azure Function Dapper SQL Demo

This Azure Functions project demonstrates how to use Dapper, a micro ORM, to access SQL Server. The function acts as a simple bike store, providing an HTTP-triggered GET function. This function connects to a SQL Server database using Dapper, retrieves a list of bikes, and responds with the list in JSON format.

## Prerequisites

Before you begin, ensure you have the following prerequisites:

- Azure subscription
- Azure Functions tools installed (you can install it using [Azure Functions Core Tools](https://docs.microsoft.com/en-us/azure/azure-functions/functions-run-local#install-the-azure-functions-core-tools))

## Project Structure

- **BikeStore.cs**: Contains the main logic for the HTTP-triggered function.
- **Bike.cs**: Defines the `Bike` model used for mapping SQL query results.
- **local.settings.json**: Configuration file for local development, including the SQL Server connection string.

## Setup

1. Clone the repository:

   ```bash
   git clone https://github.com/RahulMule/AzureFunction_Dapper_Demo.git
   cd AzureFunction_Dapper

# SQL Server Database Setup

Follow these steps to set up a new SQL Server Database and obtain the connection string for your Azure Function using raw SQL queries.

## 1. Create a New SQL Server Database

1. Open SQL Server Management Studio (SSMS) or any preferred SQL Server administration tool.
2. Connect to your SQL Server instance.
3. Execute the following SQL script to create a new database:

   ```sql
   CREATE DATABASE YourDatabaseName;

USE YourDatabaseName;

CREATE TABLE Bikes (
    Id INT PRIMARY KEY,
    Brand VARCHAR(255) NOT NULL,
    Model VARCHAR(255) NOT NULL,
    EngineCapacity INT NOT NULL,
    EngineName VARCHAR(255) NOT NULL
);

INSERT INTO Bikes (Id, Brand, Model, EngineCapacity, EngineName)
VALUES
    (1, 'Honda', 'CBR1000RR', 1000, 'Fireblade'),
    (2, 'Yamaha', 'YZF-R6', 600, 'YZF-R6 Engine'),
    (3, 'Kawasaki', 'Ninja ZX-10R', 998, 'Ninja Engine'),
    (4, 'Ducati', 'Panigale V4', 1103, 'Desmosedici Stradale'),
    (5, 'Suzuki', 'GSX-R750', 750, 'GSX-R Engine');

## Usage

Local Development:

Run the project locally using Visual Studio or the func CLI.
Test the functions using tools like Postman or cURL.

## Deployment to Azure:

Publish the function app to your Azure subscription.
Ensure the required configuration settings are set in the Azure Portal.

## Known Issues

None reported.

## Contributions

Contributions are welcome! Please create an issue or pull request for any improvements or bug fixes.

## License

This project is licensed under the MIT License.
