
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/01/2025 11:00:50
-- Generated from EDMX file: C:\Users\USER\Desktop\FullStack\web_mvc_dosyalar\mvc_modelfirst\mvc_modelfirst\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Mvc_modelfirst];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UrunlerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UrunlerSet];
GO
IF OBJECT_ID(N'[dbo].[KullanicilarSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KullanicilarSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UrunlerSet'
CREATE TABLE [dbo].[UrunlerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UrunAdi] nvarchar(max)  NOT NULL,
    [KategoriAdi] nvarchar(max)  NOT NULL,
    [Fiyat] decimal(18,0)  NOT NULL,
    [Aciklama] nvarchar(max)  NOT NULL,
    [Resim] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KullanicilarSet'
CREATE TABLE [dbo].[KullanicilarSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [KullaniciAdi] nvarchar(max)  NOT NULL,
    [Sifre] nvarchar(max)  NOT NULL,
    [Rol] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UrunlerSet'
ALTER TABLE [dbo].[UrunlerSet]
ADD CONSTRAINT [PK_UrunlerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'KullanicilarSet'
ALTER TABLE [dbo].[KullanicilarSet]
ADD CONSTRAINT [PK_KullanicilarSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------