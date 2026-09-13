# Module 2 Challenge: Miles Per Gallon (MPG) Calculator

## Objective
A simple web application built in C# (ASP.NET Core Razor Pages) that calculates the miles per gallon (MPG) for a given distance traveled and amount of fuel consumed.

## Features
- Input fields for **miles driven** and **gallons used**
- A submit button that calculates MPG on form submission
- Displays the calculated result on a dedicated **Result** page (`/resultpage`)
- Navbar link to jump directly to the Result page at any time

## Formula

## Tech Stack
- C# / .NET
- ASP.NET Core Razor Pages
- Bootstrap (default template styling)
- GitHub Codespaces for development

## Project Structure
| File | Purpose |
|---|---|
| `Pages/Index.cshtml` | Home page with the MPG input form |
| `Pages/Index.cshtml.cs` | Handles form submission and MPG calculation logic |
| `Pages/ResultPage.cshtml` | Displays the calculated MPG result |
| `Pages/ResultPage.cshtml.cs` | Reads the passed-in result data and displays it |
| `Pages/Shared/_Layout.cshtml` | Shared layout including the navbar |

## How to Run Locally
1. Clone this repository:
```bash
   git clone https://github.com/sally-developer/Module2Challenge.git
```
2. Navigate into the project folder:
```bash
   cd Module2Challenge
```
3. Restore dependencies and run the app:
```bash
   dotnet restore
   dotnet run
```
4. Open the forwarded port / localhost URL shown in the terminal to view the app in your browser.

## Usage
1. Enter the number of **miles driven** and **gallons used** on the home page.
2. Click **Calculate MPG**.
3. You'll be redirected to the Result page, showing your calculated MPG.
4. Use the navbar **Result** link to return to this page at any time.

## Author
Salma Muhumed (Sally)
