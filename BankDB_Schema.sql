-- ==============================================================
-- BankDB Database & Table Creation Script
-- Author: Mohamed Diaa El-Din Samy
-- ==============================================================
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'BankDB')
BEGIN
    CREATE DATABASE BankDB;
END
GO

USE BankDB;
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BankAccounts]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[BankAccounts] (
        [AccountNumber] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
        [Owner] NVARCHAR(150) NOT NULL,
        [Balance] DECIMAL(18, 2) NOT NULL DEFAULT 0.00,
        [CreatedAt] DATETIME2 NOT NULL DEFAULT GETDATE()
    );
END
GO
