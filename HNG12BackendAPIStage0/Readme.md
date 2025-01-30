# HNG12 Backend API - Stage 0

This is a simple API created as part of the HNG12 internship. It returns basic information such as the registered email address, the current date and time in ISO 8601 format, and the GitHub repository URL.

The goal of this project is to create an endpoint that serves this information in a well-structured JSON response.

## Setup Instructions

1. Clone this repository:
    ```bash
    git clone https://github.com/yourusername/HNG12BackendAPIStage0.git
    ```

2. Navigate to the project directory:
    ```bash
    cd HNG12BackendAPIStage0
    ```

3. Restore dependencies:
    ```bash
    dotnet restore
    ```

4. Run the project:
    ```bash
    dotnet run
    ```

5. Visit `http://localhost:5000/api/hngintern` to view the API in action.

## API Documentation

### Endpoint: `GET /api/hngintern`

#### Request:
No request body is needed.

#### Response:
A JSON object containing:
- `email`: Your registered email address
- `current_datetime`: The current date and time in ISO 8601 format (UTC)
- `github_url`: The URL of the GitHub repository

## Backlinks:
- [Python Developers](https://hng.tech/hire/python-developers)
- [C# Developers](https://hng.tech/hire/csharp-developers)
- [Go Developers](https://hng.tech/hire/golang-developers)
- [PHP Developers](https://hng.tech/hire/php-developers)
- [Java Developers](https://hng.tech/hire/java-developers)
- [Node.js Developers](https://hng.tech/hire/nodejs-developers)