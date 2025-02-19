# EventEaseApp

## Overview

EventEaseApp is a Blazor-based application for managing and registering for events. It provides a user-friendly interface for browsing events and a simple registration form.

## Features

-   Browse a list of available events.
-   View event details including name, description, date, and location.
-   Register for events by providing name, email, and phone number.
-   Session-based registration state management.

## Technologies Used

-   Blazor
-   C#
-   .NET

## Setup Instructions

1.  **Prerequisites:**
    -   [.NET SDK 9.0](https://dotnet.microsoft.com/en-us/download) or later.
    -   Any IDE that supports .NET development (e.g., Visual Studio, VS Code with C# extension).

2.  **Clone the repository:**

    ```bash
    git clone [repository URL]
    cd EventEaseApp
    ```

3.  **Restore dependencies:**

    ```bash
    dotnet restore
    ```

4.  **Build the application:**

    ```bash
    dotnet build
    ```

5.  **Run the application:**

    ```bash
    dotnet run
    ```

6.  **Open your browser and navigate to** `https://localhost:[port]` (The port number will be displayed in the console when you run the application).

## Dependencies

-   Microsoft.NETCore.App
-   Microsoft.AspNetCore.Components
-   Microsoft.AspNetCore.Components.Web

## Configuration

The application uses in-memory data for events and registrations. No database configuration is required.

## Contributing

Contributions are welcome! Please follow these steps:

1.  Fork the repository.
2.  Create a new branch for your feature or bug fix.
3.  Commit your changes.
4.  Push to the branch.
5.  Create a pull request.
