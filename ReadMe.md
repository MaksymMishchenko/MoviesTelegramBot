# Movies Telegram Bot

## Project Overview
A console-based Telegram bot built with ASP.NET Core, allowing users to interact with a database of movies. The bot features page-based navigation, movie search functionality, random movie retrieval, and the ability to display cartoons. It handles user requests, processes updates, and logs key events while managing exceptions.

## Description

This Movies Telegram Bot allows users to:
- **Search for movies in the database.**
- **Navigate through movies with page-based navigation.**
- **Get random movie suggestions.**
- **Retrieve information about cartoons.**
- **Handle exceptions gracefully with proper logging.**

## Features

1. Movie Search: Users can search for movies by title, genre, or other attributes.
2. Pagination: Allows users to navigate through movie lists with 'Next' and 'Previous' buttons.
3. Random Movie: Provides a random movie suggestion from the database.
4. Cartoon Information: Retrieves information about cartoons as well.
5. Logging: Integrated with the built-in ASP.NET Core logging framework to log key events and errors.
6. Global Exception Handling Middleware: Centralized error handling for the bot.

## Technologies Used

1. ASP.NET Core 8.0
2. Entity Framework Core 8.0
3. SQL Server 8.0
4. Telegram.Bot (Telegram Bot API) 18.0.0
5. Dependency Injection (for managing services)
6. Logging (via ASP.NET Core's built-in logging)

## Installation

### Step 1: Clone the repository
Clone the repository to your local machine:

`git clone https://github.com/MaksymMishchenko/MoviesTelegramBot.git`
`cd MoviesTelegramBot`

### Step 2: Configure the Database
Open the appsettings.json file and update the database connection string:

`"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=MoviesDatabase;User Id=sa;Password=your_password;"
}`

Apply migrations to create the necessary database tables:

`dotnet ef database update`

### Step 3: Set up the Telegram Bot
Create a bot on Telegram by talking to BotFather and obtain your API Key.

Add the API key to the appsettings.json file:

`"TelegramBot": {
    "ApiKey": "7480202458:AAGTHC66vyBSIZO..."
  },
  "AdminChatId": "123456789"`

### Step 4: Run the Project
Build and run the application:

`dotnet run`

The bot will start and listen for incoming updates from users.

## How to Use

### 1. Search for Movies
Send a query to the bot with the movie title or genre.
The bot will return a list of matching movies with page-based navigation.

### 2. Get a Random Movie
Use the Random Movie feature to get a movie suggestion.
The bot will return a random movie from the database.

### 3. Get Cartoon Information
Request details about cartoons, and the bot will provide relevant information.

### 4. Navigation
Use Next and Previous buttons to navigate through the list of movies.

## Project Structure

```
MoviesTelegramBot/
│
├── README.md                // Project documentation
│
├── MoviesTelegramBot/       // ASP.NET Core project
│   ├── Controllers/         // API or MVC Controllers (if applicable)
│   ├── Migrations/          // Database migrations
│   ├── Models/              // Data models for movies and cartoons
│   ├── Services/            // Business logic services (MovieService, etc.)
│   ├── Middlewares/         // Middleware components
│   ├── Interfaces/          // Interfaces for services
│   ├── appsettings.json     // Application configuration
│   ├── Program.cs           // Application entry point

```


## To-Do
- Implement user authentication and personalization (e.g., favorite movies).
- Add more advanced movie filtering options (by rating, release date, etc.).
- Increase test coverage to ensure reliability.

## Contact
- Author: [Maksym Mishchenko](https://github.com/MaksymMishchenko)
- Email: [mischenkomv@hotmail.com](mailto:mischenkomv@hotmail.com)
- GitHub: [MaksymMishchenko](https://github.com/MaksymMishchenko)