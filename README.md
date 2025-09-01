# Project-TaskManagementApp

**TaskManagementApp** is a simple **Task Management Application** built using **Blazor WebAssembly** for the frontend and **PHP + MySQL** for the backend API.  

It allows users to manage their daily tasks in a simple and efficient way.

---
## Purpose
The purpose of this application is to:

- **Organize tasks** – Keep track of what needs to be done.
- **Mark tasks as completed** – Easily toggle the status of tasks.
- **Add new tasks quickly** – Input tasks without complex setup.
- **Delete tasks** – Remove tasks that are no longer needed.
- **Learn Blazor & Fullstack concepts** – Demonstrates a clean architecture setup with Blazor, C#, and PHP backend.

---
## Features

- **Blazor WebAssembly UI**  
  Single Page Application with filtering: All / Completed / Pending  
  Form to add tasks and buttons to mark as complete or delete

- **Clean Architecture**  
Domain, Application, Infrastructure, UI layers separated

---
### 2. Run Frontend Locally

```bash
cd TaskManagementApp.UI
dotnet restore
dotnet clean
dotnet build
dotnet run

```bash

### 3. Project Structure
<img width="667" height="302" alt="image" src="https://github.com/user-attachments/assets/75dc459d-6b2b-499d-8c93-2b6fd6dd1072" />

---
### 4. Requirements
- .NET 8 SDK
- PHP 7+
- MySQL or compatible database

---
### 5. Setup

---
### 6. Deployment
- Frontend can be hosted via GitHub Pages, Netlify, or any static web server.
- Backend PHP API hosted by a server with PHP + MySQL.
- Ensure CORS is configured if frontend and backend are on different domains.

---
### 7. Clone the repository
git clone https://github.com/aihanif/TaskManagementApp.git
cd TaskManagementApp

---
### 8. Build & Publish Frontend
- cd TaskManagementApp.UI
- dotnet clean
- dotnet build
- dotnet publish -c Release -o publish
- dotnet run

---
### 9. Notes
1)For GitHub Pages deployment, only frontend (wwwroot) can be hosted. Backend PHP must be on a PHP-enabled server.
2)Make sure to adjust <base href="/TaskManagementApp/" /> in index.html if deploying to GitHub Pages.
if in Local can adjust to <base href="/" /> in index.html

