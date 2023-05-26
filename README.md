# Movie Database CRUD Application

This project is a Movie Database CRUD application built using ASP.NET MVC framework and a SQL database. It allows users to manage a collection of movies, including creating, reading, updating, and deleting movie records.

## Features

- **Create**: Users can add new movies to the database by providing details such as title, genre, release year, and director.
- **Read**: The application provides a list view to display all the movies in the database, showing important information about each movie.
- **Update**: Users can edit the details of existing movies, including modifying the title, genre, release year, and director.
- **Delete**: Movies can be removed from the database using the delete functionality, permanently deleting the record.

## Technologies Used

- **ASP.NET MVC**: The project utilizes the ASP.NET MVC framework for implementing the application's architecture, routing, and views.
- **SQL Database**: The movie records are stored in a SQL database, providing persistence and data retrieval capabilities.
- **Entity Framework**: Entity Framework is used as the Object-Relational Mapping (ORM) tool to interact with the SQL database.
- **HTML/CSS**: The project incorporates HTML and CSS for building the user interface and styling the application.
- **C#**: The backend logic and data manipulation are implemented using the C# programming language.

## Getting Started

To run the Movie Database CRUD application on your local machine, follow these steps:

1. **Prerequisites**: Ensure that you have the following prerequisites installed on your machine:
   - .NET Framework
   - SQL Server (or SQL Server Express)

2. **Clone the repository**: Clone this repository to your local machine using the following command:
   ```
   git clone https://github.com/onemanarmy45/MVCMovie.git
   ```

3. **Database setup**: Create a new SQL database and update the connection string in the project's configuration file (`Web.config`) with the appropriate credentials.

4. **Build and run**: Open the solution in Visual Studio or your preferred IDE and build the project. Then, run the application, and it should launch in your browser.

5. **Start managing movies**: You can now start using the Movie Database CRUD application. Use the provided user interface to create, read, update, and delete movie records in the database.

## Contributing

Contributions are welcome! If you find any issues or want to enhance the application, feel free to open a pull request. 

## Acknowledgements

- [ASP.NET MVC Documentation](https://docs.microsoft.com/en-us/aspnet/mvc/)
- [Entity Framework Documentation](https://docs.microsoft.com/en-us/ef/)
- [SQL Server Documentation](https://docs.microsoft.com/en-us/sql/sql-server/sql-server-technical-documentation)
