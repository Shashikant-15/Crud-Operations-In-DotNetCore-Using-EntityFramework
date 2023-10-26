# CrudOperationsInDotNetCore

## Brand Controller API

* This is a sample Brand Controller for an ASP.NET Core API that provides CRUD (Create, Read, Update, Delete) operations for brand data. It is designed to interact with a database using Entity Framework Core.

## Getting Started
* Before you begin, make sure you have the necessary tools and dependencies installed. This code assumes you have already set up your ASP.NET Core project and Entity Framework DbContext. If not, you can refer to official documentation or tutorials on how to set up an ASP.NET Core API with Entity Framework.

## Prerequisites
* 1 Visual Studio or Visual Studio Code (for development)
* 2 .NET Core SDK
* 3 Entity Framework Core
* 4 An SQL Server database or a database of your choice
## Installation
1. Clone this repository to your local machine.
```
    git clone [(https://github.com/Shashikant-15/APICrudServer1-With-EntityFramework)]
```

* 2. Open the project in your preferred development environment.

* 3. Configure the appsettings.json file to point to your database server and database name.



```
"ConnectionStrings": {
    "DefaultConnection": "Server=your-server;Database=your-database;Trusted_Connection=True;"
}
```

* 4 Open the Package Manager Console or run the following command in the terminal to apply Entity Framework migrations and update the database.

```
dotnet ef database update
Build and run the project.
```

## API Endpoints
This API provides the following endpoints to manage brand data:

* GET /api/brand: Retrieve a list of all brands.
* GET /api/brand/{id}: Retrieve a specific brand by ID.
* POST /api/brand: Create a new brand.
* PUT /api/brand/{id}: Update an existing brand by ID.
* DELETE /api/brand/{id}: Delete a brand by ID.
  
### Example Requests
```
GET /api/brand
```

* Retrieve a list of all brand.
```
GET /api/brand
GET /api/brand/{id}
```
* Retrieve a specific brand by ID.

```
GET /api/brand/1
POST /api/brand
```
Create a new brand. Send a JSON request body with brand data.
```
POST /api/brand
Content-Type: application/json

{
    "name": "Sample Brand",
    "description": "This is a sample brand."
}
```
```
PUT /api/brand/{id}
```

* Update an existing brand by ID. Send a JSON request body with the updated brand data.

```
PUT /api/brand/1
Content-Type: application/json

{
    "id": 1,
    "name": "Updated Brand",
    "description": "Updated description."
}
```
```
DELETE /api/brand/{id}
Delete a brand by ID.

```
DELETE /api/brand/1
```

## Response Codes

* 200 OK: The request was successful.
* 201 Created: The resource was successfully created (for POST requests).
* 204 No Content: The request was successful (for DELETE requests).
* 400 Bad Request: The request is invalid.
* 404 Not Found: The requested resource does not exist.
* 500 Internal Server Error: An error occurred on the server.

# Technologies Used

* ASP.NET Core
* Entity Framework Core
* SQL Server (or your preferred database)
