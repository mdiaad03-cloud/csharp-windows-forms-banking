# C# Windows Forms Enterprise Banking & Account Management System

[![Language](https://img.shields.io/badge/Language-C%23%2012-blue.svg)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-.NET%2010%20Windows%20Desktop-512BD4.svg)](https://dotnet.microsoft.com/)
[![Database](https://img.shields.io/badge/Database-Microsoft%20SQL%20Server-CC292B.svg)](https://www.microsoft.com/sql-server)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

An enterprise-ready Windows desktop financial management system engineered with **C#**, **.NET Windows Forms**, **ADO.NET (Microsoft.Data.SqlClient)**, and **Microsoft SQL Server**.

Developed by **Mohamed Diaa El-Din Samy** (Computer Science / Information Systems @ Badr University in Assiut).

---

## 🌟 Key Features

- **Object-Oriented Architecture**: Clean separation between presentation layer (Form1), domain entities (BankAccount, SaveingsAccount), and data access repository (BankRepository).
- **Relational SQL Server Integration**: Direct ADO.NET connectivity (Microsoft.Data.SqlClient) with parameterized queries preventing SQL Injection.
- **Anti-Money Laundering (AML) Compliance Rules**:
  - Daily/single deposit threshold enforcement (flagging transactions > 20,000 EGP).
  - Maximum withdrawal limits per transaction (8,000 EGP cap).
  - Overdraft protection ensuring transactions never exceed available balance.
- **Inheritance & Polymorphism**: Extensible domain modeling supporting specialized account types like interest-bearing Savings Accounts.
- **Interactive UI**: WinForms DataGridView binding with instant ledger balance recalculation and user feedback dialogs.

---

## 🏗️ Architecture & Component Design

`
WinFormsApp1/
├── BankAccount.cs           # Core Domain Entity (GUID AccountNumber, Owner, Balance, AML rules)
├── SaveingsAccount.cs       # Derived Entity with interest rate calculations
├── BankRepository.cs        # Data Access Layer using Microsoft.Data.SqlClient
├── Form1.cs                 # UI Code-behind & Event Handlers (Withdraw, Deposit, Create)
├── Form1.Designer.cs        # WinForms Visual Component Layout
├── Program.cs               # Application Entry Point
├── BankDB_Schema.sql        # SQL Server Database setup script
└── WinFormsApp1.csproj      # .NET Project Configuration
`

---

## 🗄️ Database Schema (BankDB)

`sql
CREATE DATABASE BankDB;
GO
USE BankDB;
GO

CREATE TABLE BankAccounts (
    AccountNumber UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Owner NVARCHAR(150) NOT NULL,
    Balance DECIMAL(18, 2) NOT NULL DEFAULT 0.00,
    CreatedAt DATETIME2 NOT NULL DEFAULT GETDATE()
);
`

---

## 🚀 Getting Started

### Prerequisites
- [.NET SDK 9.0 or 10.0](https://dotnet.microsoft.com/download)
- [Microsoft SQL Server](https://www.microsoft.com/sql-server) (LocalDB, Express, or Developer edition)
- [Visual Studio 2022 / JetBrains Rider](https://visualstudio.microsoft.com/)

### Installation & Run
1. **Clone the repository:**
   `ash
   git clone https://github.com/mdiaad03-cloud/csharp-windows-forms-banking.git
   cd csharp-windows-forms-banking
   `

2. **Initialize Database:**
   Execute BankDB_Schema.sql in SQL Server Management Studio (SSMS) or Azure Data Studio.

3. **Build & Run:**
   `ash
   dotnet build
   dotnet run --project WinFormsApp1/WinFormsApp1.csproj
   `

---

## 👨‍💻 Author

**Mohamed Diaa El-Din Samy**
- Third-Year Computer Science & Information Systems Student, Badr University in Assiut
- Portfolio: [mdiaad03-cloud.github.io/portfolio-](https://mdiaad03-cloud.github.io/portfolio-/)
- GitHub: [@mdiaad03-cloud](https://github.com/mdiaad03-cloud)
- LinkedIn: [linkedin.com/in/mohamed-diaa-dev](https://www.linkedin.com/in/mohamed-diaa-dev/)
