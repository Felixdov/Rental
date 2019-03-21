
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/18/2019 20:47:13
-- Generated from EDMX file: C:\Users\user\Documents\לימודים\project\Rental\Rental_BE\RemtCar_DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RentCar];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[carinventory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[carinventory];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'carinventory'
CREATE TABLE [dbo].[carinventory] (
    [CarTypeId] int  NOT NULL,
    [CarID] int  NOT NULL,
    [Color] varchar(50)  NULL,
    [Engine] varchar(50)  NULL,
    [CarTypeName] varchar(15)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CarID] in table 'carinventory'
ALTER TABLE [dbo].[carinventory]
ADD CONSTRAINT [PK_carinventory]
    PRIMARY KEY CLUSTERED ([CarID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------