
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/18/2023 13:49:35
-- Generated from EDMX file: E:\Escritorio\MyProyecto\CargasRecorridos\DatosCargasRecorridos\CapaDatos\GestionUsuario\Gestion.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [UsuarioR];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FuncionDeAccesoFuncionAsignada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FuncionesAsignadas] DROP CONSTRAINT [FK_FuncionDeAccesoFuncionAsignada];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioFuncionAsignada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FuncionesAsignadas] DROP CONSTRAINT [FK_UsuarioFuncionAsignada];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FuncionesDeAcceso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FuncionesDeAcceso];
GO
IF OBJECT_ID(N'[dbo].[FuncionesAsignadas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FuncionesAsignadas];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FuncionesDeAcceso'
CREATE TABLE [dbo].[FuncionesDeAcceso] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(100)  NOT NULL,
    [Codigo] varchar(20)  NOT NULL
);
GO

-- Creating table 'FuncionesAsignadas'
CREATE TABLE [dbo].[FuncionesAsignadas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FechaDeVencimiento] datetime  NOT NULL,
    [FuncionDeAccesoId] int  NOT NULL,
    [UsuarioId] int  NOT NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NombreDeUsuario] varchar(20)  NOT NULL,
    [ClaveDeUsuario] varchar(20)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'FuncionesDeAcceso'
ALTER TABLE [dbo].[FuncionesDeAcceso]
ADD CONSTRAINT [PK_FuncionesDeAcceso]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FuncionesAsignadas'
ALTER TABLE [dbo].[FuncionesAsignadas]
ADD CONSTRAINT [PK_FuncionesAsignadas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FuncionDeAccesoId] in table 'FuncionesAsignadas'
ALTER TABLE [dbo].[FuncionesAsignadas]
ADD CONSTRAINT [FK_FuncionDeAccesoFuncionAsignada]
    FOREIGN KEY ([FuncionDeAccesoId])
    REFERENCES [dbo].[FuncionesDeAcceso]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionDeAccesoFuncionAsignada'
CREATE INDEX [IX_FK_FuncionDeAccesoFuncionAsignada]
ON [dbo].[FuncionesAsignadas]
    ([FuncionDeAccesoId]);
GO

-- Creating foreign key on [UsuarioId] in table 'FuncionesAsignadas'
ALTER TABLE [dbo].[FuncionesAsignadas]
ADD CONSTRAINT [FK_UsuarioFuncionAsignada]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioFuncionAsignada'
CREATE INDEX [IX_FK_UsuarioFuncionAsignada]
ON [dbo].[FuncionesAsignadas]
    ([UsuarioId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------