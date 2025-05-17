
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/11/2025 10:10:21
-- Generated from EDMX file: C:\Users\USER\Desktop\FullStack\winform\kütüphane_bos\kütüphane_bos\kütüphane\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Kutuphane_model];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'KitaplarSet'
CREATE TABLE [dbo].[KitaplarSet] (
    [KitapNo] int  NOT NULL,
    [KitapAdi] nvarchar(max)  NOT NULL,
    [Yazar] nvarchar(max)  NOT NULL,
    [BasimYili] datetime  NOT NULL
);
GO

-- Creating table 'UyelerSet'
CREATE TABLE [dbo].[UyelerSet] (
    [Tc] bigint  NOT NULL,
    [AdSoyad] nvarchar(max)  NOT NULL,
    [Dtarihi] datetime  NOT NULL,
    [Adres] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'IslemlerSet'
CREATE TABLE [dbo].[IslemlerSet] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [AlısTarihi] nvarchar(max)  NOT NULL,
    [VerişTarihi] nvarchar(max)  NOT NULL,
    [UyelerTc] bigint  NOT NULL,
    [KitaplarKitapNo] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [KitapNo] in table 'KitaplarSet'
ALTER TABLE [dbo].[KitaplarSet]
ADD CONSTRAINT [PK_KitaplarSet]
    PRIMARY KEY CLUSTERED ([KitapNo] ASC);
GO

-- Creating primary key on [Tc] in table 'UyelerSet'
ALTER TABLE [dbo].[UyelerSet]
ADD CONSTRAINT [PK_UyelerSet]
    PRIMARY KEY CLUSTERED ([Tc] ASC);
GO

-- Creating primary key on [Id] in table 'IslemlerSet'
ALTER TABLE [dbo].[IslemlerSet]
ADD CONSTRAINT [PK_IslemlerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UyelerTc] in table 'IslemlerSet'
ALTER TABLE [dbo].[IslemlerSet]
ADD CONSTRAINT [FK_UyelerIslemler]
    FOREIGN KEY ([UyelerTc])
    REFERENCES [dbo].[UyelerSet]
        ([Tc])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UyelerIslemler'
CREATE INDEX [IX_FK_UyelerIslemler]
ON [dbo].[IslemlerSet]
    ([UyelerTc]);
GO

-- Creating foreign key on [KitaplarKitapNo] in table 'IslemlerSet'
ALTER TABLE [dbo].[IslemlerSet]
ADD CONSTRAINT [FK_KitaplarIslemler]
    FOREIGN KEY ([KitaplarKitapNo])
    REFERENCES [dbo].[KitaplarSet]
        ([KitapNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KitaplarIslemler'
CREATE INDEX [IX_FK_KitaplarIslemler]
ON [dbo].[IslemlerSet]
    ([KitaplarKitapNo]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------