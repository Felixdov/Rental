
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/31/2019 19:12:40
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

IF OBJECT_ID(N'[dbo].[FK_OrderList_carinventory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderList] DROP CONSTRAINT [FK_OrderList_carinventory];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[carinventory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[carinventory];
GO
IF OBJECT_ID(N'[dbo].[OrderList]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderList];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'carinventories'
CREATE TABLE [dbo].[carinventories] (
    [CarTypeId] int  NOT NULL,
    [CarID] int  NOT NULL,
    [Color] varchar(50)  NULL,
    [Engine] varchar(50)  NULL,
    [CarTypeName] varchar(15)  NULL,
    [PricePerDay] decimal(18,2)  NULL
);
GO

-- Creating table 'OrderLists'
CREATE TABLE [dbo].[OrderLists] (
    [OrderID] int IDENTITY(1,1) NOT NULL,
    [CustName] varchar(50)  NOT NULL,
    [CarID] int  NOT NULL,
    [OrderDate] datetime  NOT NULL,
    [PickUpDate] datetime  NOT NULL,
    [DropOffDate] datetime  NOT NULL,
    [DiscountCode] decimal(18,2)  NULL,
    [OrderCost] decimal(18,2)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CarID] in table 'carinventories'
ALTER TABLE [dbo].[carinventories]
ADD CONSTRAINT [PK_carinventories]
    PRIMARY KEY CLUSTERED ([CarID] ASC);
GO

-- Creating primary key on [OrderID] in table 'OrderLists'
ALTER TABLE [dbo].[OrderLists]
ADD CONSTRAINT [PK_OrderLists]
    PRIMARY KEY CLUSTERED ([OrderID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CarID] in table 'OrderLists'
ALTER TABLE [dbo].[OrderLists]
ADD CONSTRAINT [FK_OrderList_carinventory]
    FOREIGN KEY ([CarID])
    REFERENCES [dbo].[carinventories]
        ([CarID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderList_carinventory'
CREATE INDEX [IX_FK_OrderList_carinventory]
ON [dbo].[OrderLists]
    ([CarID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------