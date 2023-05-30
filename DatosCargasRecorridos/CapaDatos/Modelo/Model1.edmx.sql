
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/23/2023 20:29:44
-- Generated from EDMX file: E:\Programación\Visual Studio\CargasRecorridos\DatosCargasRecorridos - copia\CapaDatos\Modelo\Model1.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Vehiculos'
CREATE TABLE [dbo].[Vehiculos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PlacaVehiculo] varchar(15)  NOT NULL,
    [DescripcionVehiculo] varchar(50)  NOT NULL,
    [TipoDeVehiculoId] int  NOT NULL,
    [MarcaDelVehiculoId] int  NOT NULL,
    [CantidadPasajeros] int  NOT NULL,
    [Tonelage] decimal(5,2)  NOT NULL,
    [EstadoVehiculo] varchar(10)  NOT NULL
);
GO

-- Creating table 'TipoDeVehiculos'
CREATE TABLE [dbo].[TipoDeVehiculos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoTipoVehiculo] char(5)  NOT NULL,
    [DescripcionTipoVehiculo] varchar(50)  NOT NULL
);
GO

-- Creating table 'Viajes'
CREATE TABLE [dbo].[Viajes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoViaje] char(5)  NOT NULL,
    [CostoViaje] int  NOT NULL,
    [PagoChoferViaje] int  NOT NULL,
    [DescripcionViaje] varchar(50)  NOT NULL,
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
    [Nombre2Encargado] varchar(15)  NOT NULL,
    [Apellido1Encargado] varchar(15)  NOT NULL,
    [Apellido2Encargado] varchar(15)  NOT NULL,
    [Cargo] varchar(15)  NOT NULL,
    [DireccionEmpresa] varchar(50)  NOT NULL,
    [CelularProveedor] char(12)  NOT NULL,
    [Comentario] varchar(50)  NOT NULL
);
GO

-- Creating table 'Choferes'
CREATE TABLE [dbo].[Choferes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CedulaChofer] char(16)  NOT NULL,
    [Nombre1Chofer] varchar(15)  NOT NULL,
    [Nombre2Chofer] varchar(15)  NOT NULL,
    [Apellido1Chofer] varchar(15)  NOT NULL,
    [Apellido2Chofer] varchar(15)  NOT NULL,
    [CelularChofer] char(12)  NOT NULL,
    [INSSChofer] char(9)  NOT NULL,
    [DireccionChofer] varchar(50)  NOT NULL,
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
    [Descripcion] varchar(50)  NOT NULL
);
GO

-- Creating table 'Marcas'
CREATE TABLE [dbo].[Marcas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Marca] varchar(20)  NOT NULL,
    [Modelo] varchar(20)  NOT NULL
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

-- Creating primary key on [Id] in table 'Marcas'
ALTER TABLE [dbo].[Marcas]
ADD CONSTRAINT [PK_Marcas]
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

-- Creating foreign key on [MarcaDelVehiculoId] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [FK_MarcaDelVehiculoVehiculo]
    FOREIGN KEY ([MarcaDelVehiculoId])
    REFERENCES [dbo].[Marcas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MarcaDelVehiculoVehiculo'
CREATE INDEX [IX_FK_MarcaDelVehiculoVehiculo]
ON [dbo].[Vehiculos]
    ([MarcaDelVehiculoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------