
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/14/2023 19:57:22
-- Generated from EDMX file: C:\Users\USUARIO\Desktop\MyProyecto\CargasRecorridos\DatosCargasRecorridos\CapaDatos\Modelo\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Recorridos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TipoDeVehiculoVehiculo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehiculos] DROP CONSTRAINT [FK_TipoDeVehiculoVehiculo];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoDeViajeViaje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Viajes] DROP CONSTRAINT [FK_TipoDeViajeViaje];
GO
IF OBJECT_ID(N'[dbo].[FK_ProveedorViaje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Viajes] DROP CONSTRAINT [FK_ProveedorViaje];
GO
IF OBJECT_ID(N'[dbo].[FK_ViajeViajeChofer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ViajeChoferes] DROP CONSTRAINT [FK_ViajeViajeChofer];
GO
IF OBJECT_ID(N'[dbo].[FK_ChoferViajeChofer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ViajeChoferes] DROP CONSTRAINT [FK_ChoferViajeChofer];
GO
IF OBJECT_ID(N'[dbo].[FK_VehiculoVehiculoViaje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VehiculoViajes] DROP CONSTRAINT [FK_VehiculoVehiculoViaje];
GO
IF OBJECT_ID(N'[dbo].[FK_ViajeVehiculoViaje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VehiculoViajes] DROP CONSTRAINT [FK_ViajeVehiculoViaje];
GO
IF OBJECT_ID(N'[dbo].[FK_PaisViaje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Viajes] DROP CONSTRAINT [FK_PaisViaje];
GO
IF OBJECT_ID(N'[dbo].[FK_PaisViaje1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Viajes] DROP CONSTRAINT [FK_PaisViaje1];
GO
IF OBJECT_ID(N'[dbo].[FK_PaisChofer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Choferes] DROP CONSTRAINT [FK_PaisChofer];
GO
IF OBJECT_ID(N'[dbo].[FK_ModeloDelVehiculoVehiculo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehiculos] DROP CONSTRAINT [FK_ModeloDelVehiculoVehiculo];
GO
IF OBJECT_ID(N'[dbo].[FK_MarcaVehiculoModeloDelVehiculo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModeloDeLosVehiculos] DROP CONSTRAINT [FK_MarcaVehiculoModeloDelVehiculo];
GO
IF OBJECT_ID(N'[dbo].[FK_MarcaVehiculoVehiculo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehiculos] DROP CONSTRAINT [FK_MarcaVehiculoVehiculo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Vehiculos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehiculos];
GO
IF OBJECT_ID(N'[dbo].[TipoDeVehiculos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoDeVehiculos];
GO
IF OBJECT_ID(N'[dbo].[Viajes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Viajes];
GO
IF OBJECT_ID(N'[dbo].[TipoDeViajes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoDeViajes];
GO
IF OBJECT_ID(N'[dbo].[Proveedores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proveedores];
GO
IF OBJECT_ID(N'[dbo].[Choferes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Choferes];
GO
IF OBJECT_ID(N'[dbo].[VehiculoViajes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VehiculoViajes];
GO
IF OBJECT_ID(N'[dbo].[ViajeChoferes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ViajeChoferes];
GO
IF OBJECT_ID(N'[dbo].[Paises]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Paises];
GO
IF OBJECT_ID(N'[dbo].[ModeloDeLosVehiculos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModeloDeLosVehiculos];
GO
IF OBJECT_ID(N'[dbo].[MarcaVehiculos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MarcaVehiculos];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Vehiculos'
CREATE TABLE [dbo].[Vehiculos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PlacaVehiculo] varchar(15)  NOT NULL,
    [DescripcionVehiculo] varchar(50)  NULL,
    [TipoDeVehiculoId] int  NOT NULL,
    [MarcaDelVehiculoId] int  NOT NULL,
    [CantidadPasajeros] int  NOT NULL,
    [Tonelage] decimal(5,2)  NOT NULL,
    [EstadoVehiculo] varchar(10)  NOT NULL,
    [ModeloDelVehiculoId] int  NOT NULL,
    [MarcaVehiculoId] int  NOT NULL
);
GO

-- Creating table 'TipoDeVehiculos'
CREATE TABLE [dbo].[TipoDeVehiculos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoTipoVehiculo] char(5)  NOT NULL,
    [DescripcionTipoVehiculo] varchar(50)  NULL
);
GO

-- Creating table 'Viajes'
CREATE TABLE [dbo].[Viajes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoViaje] char(5)  NOT NULL,
    [CostoViaje] int  NOT NULL,
    [PagoChoferViaje] int  NOT NULL,
    [DescripcionViaje] varchar(50)  NULL,
    [TipoDeViajeId] int  NOT NULL,
    [ProveedorId] int  NOT NULL,
    [ChoferId] int  NOT NULL,
    [PaisId] int  NOT NULL,
    [PaisId1] int  NOT NULL,
    [CantidadPasajeros] int  NOT NULL,
    [Tonelage] decimal(5,2)  NOT NULL
);
GO

-- Creating table 'TipoDeViajes'
CREATE TABLE [dbo].[TipoDeViajes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoTipoViaje] nvarchar(max)  NOT NULL,
    [DescripcionTipoViaje] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Proveedores'
CREATE TABLE [dbo].[Proveedores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoProveedor] char(5)  NOT NULL,
    [NombreEmpresaProveedor] varchar(20)  NOT NULL,
    [Nombre1Encargado] varchar(15)  NOT NULL,
    [Nombre2Encargado] varchar(15)  NULL,
    [Apellido1Encargado] varchar(15)  NOT NULL,
    [Apellido2Encargado] varchar(15)  NULL,
    [Cargo] varchar(15)  NULL,
    [DireccionEmpresa] varchar(50)  NULL,
    [CelularProveedor] char(12)  NOT NULL,
    [Comentario] varchar(50)  NULL
);
GO

-- Creating table 'Choferes'
CREATE TABLE [dbo].[Choferes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CedulaChofer] char(16)  NOT NULL,
    [Nombre1Chofer] varchar(15)  NOT NULL,
    [Nombre2Chofer] varchar(15)  NULL,
    [Apellido1Chofer] varchar(15)  NOT NULL,
    [Apellido2Chofer] varchar(15)  NULL,
    [CelularChofer] char(12)  NOT NULL,
    [INSSChofer] char(9)  NULL,
    [DireccionChofer] varchar(50)  NULL,
    [PaisId] int  NOT NULL
);
GO

-- Creating table 'VehiculoViajes'
CREATE TABLE [dbo].[VehiculoViajes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [VehiculoId] int  NOT NULL,
    [ViajeId] int  NOT NULL,
    [FechaHoraSalida] time  NOT NULL,
    [FechaHoraLlegada] nvarchar(max)  NOT NULL,
    [FechaHoraRetorno] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ViajeChoferes'
CREATE TABLE [dbo].[ViajeChoferes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ViajeId] int  NOT NULL,
    [ChoferId] int  NOT NULL
);
GO

-- Creating table 'Paises'
CREATE TABLE [dbo].[Paises] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoPais] varchar(10)  NOT NULL,
    [Descripcion] varchar(50)  NULL
);
GO

-- Creating table 'ModeloDeLosVehiculos'
CREATE TABLE [dbo].[ModeloDeLosVehiculos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Modelo] varchar(20)  NOT NULL,
    [MarcaDelVehiculoId] int  NOT NULL,
    [MarcaVehiculoId] int  NOT NULL
);
GO

-- Creating table 'MarcaVehiculos'
CREATE TABLE [dbo].[MarcaVehiculos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Marca] varchar(20)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [PK_Vehiculos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoDeVehiculos'
ALTER TABLE [dbo].[TipoDeVehiculos]
ADD CONSTRAINT [PK_TipoDeVehiculos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Viajes'
ALTER TABLE [dbo].[Viajes]
ADD CONSTRAINT [PK_Viajes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoDeViajes'
ALTER TABLE [dbo].[TipoDeViajes]
ADD CONSTRAINT [PK_TipoDeViajes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [PK_Proveedores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Choferes'
ALTER TABLE [dbo].[Choferes]
ADD CONSTRAINT [PK_Choferes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VehiculoViajes'
ALTER TABLE [dbo].[VehiculoViajes]
ADD CONSTRAINT [PK_VehiculoViajes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ViajeChoferes'
ALTER TABLE [dbo].[ViajeChoferes]
ADD CONSTRAINT [PK_ViajeChoferes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Paises'
ALTER TABLE [dbo].[Paises]
ADD CONSTRAINT [PK_Paises]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ModeloDeLosVehiculos'
ALTER TABLE [dbo].[ModeloDeLosVehiculos]
ADD CONSTRAINT [PK_ModeloDeLosVehiculos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MarcaVehiculos'
ALTER TABLE [dbo].[MarcaVehiculos]
ADD CONSTRAINT [PK_MarcaVehiculos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TipoDeVehiculoId] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [FK_TipoDeVehiculoVehiculo]
    FOREIGN KEY ([TipoDeVehiculoId])
    REFERENCES [dbo].[TipoDeVehiculos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoDeVehiculoVehiculo'
CREATE INDEX [IX_FK_TipoDeVehiculoVehiculo]
ON [dbo].[Vehiculos]
    ([TipoDeVehiculoId]);
GO

-- Creating foreign key on [TipoDeViajeId] in table 'Viajes'
ALTER TABLE [dbo].[Viajes]
ADD CONSTRAINT [FK_TipoDeViajeViaje]
    FOREIGN KEY ([TipoDeViajeId])
    REFERENCES [dbo].[TipoDeViajes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoDeViajeViaje'
CREATE INDEX [IX_FK_TipoDeViajeViaje]
ON [dbo].[Viajes]
    ([TipoDeViajeId]);
GO

-- Creating foreign key on [ProveedorId] in table 'Viajes'
ALTER TABLE [dbo].[Viajes]
ADD CONSTRAINT [FK_ProveedorViaje]
    FOREIGN KEY ([ProveedorId])
    REFERENCES [dbo].[Proveedores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProveedorViaje'
CREATE INDEX [IX_FK_ProveedorViaje]
ON [dbo].[Viajes]
    ([ProveedorId]);
GO

-- Creating foreign key on [ViajeId] in table 'ViajeChoferes'
ALTER TABLE [dbo].[ViajeChoferes]
ADD CONSTRAINT [FK_ViajeViajeChofer]
    FOREIGN KEY ([ViajeId])
    REFERENCES [dbo].[Viajes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ViajeViajeChofer'
CREATE INDEX [IX_FK_ViajeViajeChofer]
ON [dbo].[ViajeChoferes]
    ([ViajeId]);
GO

-- Creating foreign key on [ChoferId] in table 'ViajeChoferes'
ALTER TABLE [dbo].[ViajeChoferes]
ADD CONSTRAINT [FK_ChoferViajeChofer]
    FOREIGN KEY ([ChoferId])
    REFERENCES [dbo].[Choferes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ChoferViajeChofer'
CREATE INDEX [IX_FK_ChoferViajeChofer]
ON [dbo].[ViajeChoferes]
    ([ChoferId]);
GO

-- Creating foreign key on [VehiculoId] in table 'VehiculoViajes'
ALTER TABLE [dbo].[VehiculoViajes]
ADD CONSTRAINT [FK_VehiculoVehiculoViaje]
    FOREIGN KEY ([VehiculoId])
    REFERENCES [dbo].[Vehiculos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehiculoVehiculoViaje'
CREATE INDEX [IX_FK_VehiculoVehiculoViaje]
ON [dbo].[VehiculoViajes]
    ([VehiculoId]);
GO

-- Creating foreign key on [ViajeId] in table 'VehiculoViajes'
ALTER TABLE [dbo].[VehiculoViajes]
ADD CONSTRAINT [FK_ViajeVehiculoViaje]
    FOREIGN KEY ([ViajeId])
    REFERENCES [dbo].[Viajes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ViajeVehiculoViaje'
CREATE INDEX [IX_FK_ViajeVehiculoViaje]
ON [dbo].[VehiculoViajes]
    ([ViajeId]);
GO

-- Creating foreign key on [PaisId] in table 'Viajes'
ALTER TABLE [dbo].[Viajes]
ADD CONSTRAINT [FK_PaisViaje]
    FOREIGN KEY ([PaisId])
    REFERENCES [dbo].[Paises]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaisViaje'
CREATE INDEX [IX_FK_PaisViaje]
ON [dbo].[Viajes]
    ([PaisId]);
GO

-- Creating foreign key on [PaisId1] in table 'Viajes'
ALTER TABLE [dbo].[Viajes]
ADD CONSTRAINT [FK_PaisViaje1]
    FOREIGN KEY ([PaisId1])
    REFERENCES [dbo].[Paises]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaisViaje1'
CREATE INDEX [IX_FK_PaisViaje1]
ON [dbo].[Viajes]
    ([PaisId1]);
GO

-- Creating foreign key on [PaisId] in table 'Choferes'
ALTER TABLE [dbo].[Choferes]
ADD CONSTRAINT [FK_PaisChofer]
    FOREIGN KEY ([PaisId])
    REFERENCES [dbo].[Paises]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaisChofer'
CREATE INDEX [IX_FK_PaisChofer]
ON [dbo].[Choferes]
    ([PaisId]);
GO

-- Creating foreign key on [ModeloDelVehiculoId] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [FK_ModeloDelVehiculoVehiculo]
    FOREIGN KEY ([ModeloDelVehiculoId])
    REFERENCES [dbo].[ModeloDeLosVehiculos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModeloDelVehiculoVehiculo'
CREATE INDEX [IX_FK_ModeloDelVehiculoVehiculo]
ON [dbo].[Vehiculos]
    ([ModeloDelVehiculoId]);
GO

-- Creating foreign key on [MarcaVehiculoId] in table 'ModeloDeLosVehiculos'
ALTER TABLE [dbo].[ModeloDeLosVehiculos]
ADD CONSTRAINT [FK_MarcaVehiculoModeloDelVehiculo]
    FOREIGN KEY ([MarcaVehiculoId])
    REFERENCES [dbo].[MarcaVehiculos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MarcaVehiculoModeloDelVehiculo'
CREATE INDEX [IX_FK_MarcaVehiculoModeloDelVehiculo]
ON [dbo].[ModeloDeLosVehiculos]
    ([MarcaVehiculoId]);
GO

-- Creating foreign key on [MarcaVehiculoId] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [FK_MarcaVehiculoVehiculo]
    FOREIGN KEY ([MarcaVehiculoId])
    REFERENCES [dbo].[MarcaVehiculos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MarcaVehiculoVehiculo'
CREATE INDEX [IX_FK_MarcaVehiculoVehiculo]
ON [dbo].[Vehiculos]
    ([MarcaVehiculoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------