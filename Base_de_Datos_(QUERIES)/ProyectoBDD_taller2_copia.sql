/*
================================================================================
SCRIPT ORGANIZADO: BDD_SistemaVentas_Jardineria1
================================================================================
Contenido:
1. Definición de Tipos (UDTT)
2. Creación de Tablas
3. Definición de Valores por Defecto (Defaults)
4. Definición de Claves Foráneas (Foreign Keys)
5. Inserción de Datos Iniciales (Seed Data)
6. Creación de Procedimientos Almacenados (Stored Procedures)
7. Procedimientos de Reportes (Dashboard)
================================================================================
*/

-- Asegúrate de estar usando la base de datos correcta
USE [BDD_SistemaVentas_Jardineria1];
GO

/*
================================================================================
1. DEFINICIÓN DE TIPOS (UDTT)
================================================================================
*/

-- Tipo para el detalle de la Compra
CREATE TYPE [dbo].[EDetalle_Compra] AS TABLE(
    [IdProducto]   INT,
    [PrecioCompra] DECIMAL(18,2),
    [PrecioVenta]  DECIMAL(18,2),
    [Cantidad]     INT,
    [MontoTotal]   DECIMAL(18,2) -- Asumo que es el SubTotal
);
GO

-- Tipo para el detalle de la Venta
CREATE TYPE [dbo].[EDetalle_Venta] AS TABLE(
    [IdProducto]   INT NULL,
    [PrecioVenta]  DECIMAL(18,2),
    [Cantidad]     INT,
    [SubTotal]     DECIMAL(18,2)
);
GO


/*
================================================================================
2. CREACIÓN DE TABLAS
================================================================================
*/

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO

CREATE TABLE [dbo].[CATEGORIA](
    [IdCategoria] [int] IDENTITY(1,1) NOT NULL,
    [Descripcion] [varchar](100) NULL,
    [Estado] [bit] NULL,
    [FechaRegistro] [datetime] NULL,
    PRIMARY KEY CLUSTERED ([IdCategoria] ASC)
);
GO

CREATE TABLE [dbo].[CLIENTE](
    [IdCliente] [int] IDENTITY(1,1) NOT NULL,
    [Documento] [varchar](50) NULL,
    [NombreCompleto] [varchar](50) NULL,
    [Correo] [varchar](50) NULL,
    [Telefono] [varchar](50) NULL,
    [Estado] [bit] NULL,
    [FechaRegistro] [datetime] NULL,
    PRIMARY KEY CLUSTERED ([IdCliente] ASC)
);
GO

CREATE TABLE [dbo].[ROL](
    [IdRol] [int] IDENTITY(1,1) NOT NULL,
    [Descripcion] [varchar](50) NULL,
    [FechaRegistro] [datetime] NULL,
    PRIMARY KEY CLUSTERED ([IdRol] ASC)
);
GO

CREATE TABLE [dbo].[USUARIO](
    [IdUsuario] [int] IDENTITY(1,1) NOT NULL,
    [Documento] [varchar](50) NULL,
    [NombreCompleto] [varchar](50) NULL,
    [Correo] [varchar](50) NULL,
    [Clave] [varchar](50) NULL,
    [IdRol] [int] NULL,
    [Estado] [bit] NULL,
    [FechaRegistro] [datetime] NULL,
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC)
);
GO

CREATE TABLE [dbo].[PROVEEDOR](
    [IdProveedor] [int] IDENTITY(1,1) NOT NULL,
    [Documento] [varchar](50) NULL,
    [RazonSocial] [varchar](50) NULL,
    [Correo] [varchar](50) NULL,
    [Telefono] [varchar](50) NULL,
    [Estado] [bit] NULL,
    [FechaRegistro] [datetime] NULL,
    [Domicilio] [varchar](150) NULL, -- Columna consolidada
    PRIMARY KEY CLUSTERED ([IdProveedor] ASC)
);
GO

CREATE TABLE [dbo].[COMPRA](
    [IdCompra] [int] IDENTITY(1,1) NOT NULL,
    [IdUsuario] [int] NULL,
    [IdProveedor] [int] NULL,
    [TipoDocumento] [varchar](50) NULL,
    [NumeroDocumento] [varchar](50) NULL,
    [MontoTotal] [decimal](10, 2) NULL,
    [FechaRegistro] [datetime] NULL,
    PRIMARY KEY CLUSTERED ([IdCompra] ASC)
);
GO

CREATE TABLE [dbo].[PRODUCTO](
    [IdProducto] [int] IDENTITY(1,1) NOT NULL,
    [Codigo] [varchar](50) NULL,
    [Nombre] [varchar](50) NULL,
    [Descripcion] [varchar](50) NULL,
    [IdCategoria] [int] NULL,
    [Stock] [int] NOT NULL,
    [PrecioCompra] [decimal](10, 2) NULL,
    [PrecioVenta] [decimal](10, 2) NULL,
    [Estado] [bit] NULL,
    [FechaRegistro] [datetime] NULL,
    PRIMARY KEY CLUSTERED ([IdProducto] ASC)
);
GO

CREATE TABLE [dbo].[VENTA](
    [Idventa] [int] IDENTITY(1,1) NOT NULL,
    [IdUsuario] [int] NULL,
    [TipoDocumento] [varchar](50) NULL,
    [NumeroDocumento] [varchar](50) NULL,
    [DocumentoCliente] [varchar](50) NULL,
    [NombreCliente] [varchar](100) NULL,
    [MontoPago] [decimal](10, 2) NULL,
    [MontoCambio] [decimal](10, 2) NULL,
    [MontoTotal] [decimal](10, 2) NULL,
    [FechaRegistro] [datetime] NULL,
    PRIMARY KEY CLUSTERED ([Idventa] ASC)
);
GO

-- Esta es la tabla DETALLE_COMPRA corregida, basada en tu SP
CREATE TABLE [dbo].[DETALLE_COMPRA](
    [IdDetalleCompra] [int] IDENTITY(1,1) NOT NULL,
    [IdCompra] [int] NULL,
    [IdProducto] [int] NULL,
    [PrecioCompra] [decimal](10, 2) NULL,
    [PrecioVenta] [decimal](18, 2) NULL, -- Basado en tu SP
    [Cantidad] [int] NULL,
    [MontoTotal] [decimal](18, 2) NULL, -- Basado en tu SP (asumo SubTotal)
    [FechaRegistro] [datetime] NULL, -- Basado en tu SP
    PRIMARY KEY CLUSTERED ([IdDetalleCompra] ASC)
);
GO

CREATE TABLE [dbo].[DETALLE_VENTA](
    [IdDetalleventa] [int] IDENTITY(1,1) NOT NULL,
    [IdVenta] [int] NULL,
    [IdProducto] [int] NULL,
    [PrecioVenta] [decimal](10, 2) NULL,
    [Cantidad] [int] NULL,
    [SubTotal] [decimal](10, 2) NULL,
    [FechaRegistro] [datetime] NULL,
    PRIMARY KEY CLUSTERED ([IdDetalleventa] ASC)
);
GO

CREATE TABLE [dbo].[PERMISO](
    [IdPermiso] [int] IDENTITY(1,1) NOT NULL,
    [IdRol] [int] NULL,
    [NombreMenu] [varchar](100) NULL,
    [FechaRegistro] [datetime] NULL,
    PRIMARY KEY CLUSTERED ([IdPermiso] ASC)
);
GO

/*
================================================================================
3. DEFINICIÓN DE VALORES POR DEFECTO (DEFAULTS)
================================================================================
*/

ALTER TABLE [dbo].[CATEGORIA] ADD DEFAULT (getdate()) FOR [FechaRegistro];
GO
ALTER TABLE [dbo].[CLIENTE] ADD DEFAULT (getdate()) FOR [FechaRegistro];
GO
ALTER TABLE [dbo].[COMPRA] ADD DEFAULT (getdate()) FOR [FechaRegistro];
GO
ALTER TABLE [dbo].[DETALLE_COMPRA] ADD DEFAULT (getdate()) FOR [FechaRegistro];
GO
ALTER TABLE [dbo].[DETALLE_VENTA] ADD DEFAULT (getdate()) FOR [FechaRegistro];
GO
ALTER TABLE [dbo].[PERMISO] ADD DEFAULT (getdate()) FOR [FechaRegistro];
GO
ALTER TABLE [dbo].[PRODUCTO] ADD DEFAULT ((0)) FOR [Stock];
GO
ALTER TABLE [dbo].[PRODUCTO] ADD DEFAULT ((0)) FOR [PrecioCompra];
GO
ALTER TABLE [dbo].[PRODUCTO] ADD DEFAULT ((0)) FOR [PrecioVenta];
GO
ALTER TABLE [dbo].[PRODUCTO] ADD DEFAULT (getdate()) FOR [FechaRegistro];
GO
ALTER TABLE [dbo].[PROVEEDOR] ADD DEFAULT (getdate()) FOR [FechaRegistro];
GO
ALTER TABLE [dbo].[ROL] ADD DEFAULT (getdate()) FOR [FechaRegistro];
GO
ALTER TABLE [dbo].[USUARIO] ADD DEFAULT (getdate()) FOR [FechaRegistro];
GO
ALTER TABLE [dbo].[VENTA] ADD DEFAULT (getdate()) FOR [FechaRegistro];
GO

/*
================================================================================
4. DEFINICIÓN DE CLAVES FORÁNEAS (FOREIGN KEYS)
================================================================================
*/

ALTER TABLE [dbo].[USUARIO] WITH CHECK ADD FOREIGN KEY([IdRol])
REFERENCES [dbo].[ROL] ([IdRol]);
GO
ALTER TABLE [dbo].[PERMISO] WITH CHECK ADD FOREIGN KEY([IdRol])
REFERENCES [dbo].[ROL] ([IdRol]);
GO
ALTER TABLE [dbo].[PRODUCTO] WITH CHECK ADD FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[CATEGORIA] ([IdCategoria]);
GO
ALTER TABLE [dbo].[VENTA] WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[USUARIO] ([IdUsuario]);
GO
ALTER TABLE [dbo].[DETALLE_VENTA] WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[PRODUCTO] ([IdProducto]);
GO
ALTER TABLE [dbo].[DETALLE_VENTA] WITH CHECK ADD FOREIGN KEY([IdVenta])
REFERENCES [dbo].[VENTA] ([Idventa]);
GO
ALTER TABLE [dbo].[COMPRA] WITH CHECK ADD FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[PROVEEDOR] ([IdProveedor]);
GO
ALTER TABLE [dbo].[COMPRA] WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[USUARIO] ([IdUsuario]);
GO
ALTER TABLE [dbo].[DETALLE_COMPRA] WITH CHECK ADD FOREIGN KEY([IdCompra])
REFERENCES [dbo].[COMPRA] ([IdCompra]);
GO
ALTER TABLE [dbo].[DETALLE_COMPRA] WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[PRODUCTO] ([IdProducto]);
GO

/*
================================================================================
5. INSERCIÓN DE DATOS INICIALES (SEED DATA)
================================================================================
*/

SET IDENTITY_INSERT [dbo].[ROL] ON;
INSERT [dbo].[ROL] ([IdRol], [Descripcion], [FechaRegistro]) VALUES (1, N'ADMIN', CAST(N'2024-09-27T21:05:18.717' AS DateTime));
INSERT [dbo].[ROL] ([IdRol], [Descripcion], [FechaRegistro]) VALUES (2, N'Vendedor', CAST(N'2024-09-28T19:22:08.203' AS DateTime));
INSERT [dbo].[ROL] ([IdRol], [Descripcion]) VALUES (N'Reponedor');
SET IDENTITY_INSERT [dbo].[ROL] OFF;
GO

SET IDENTITY_INSERT [dbo].[USUARIO] ON;
INSERT [dbo].[USUARIO] ([IdUsuario], [Documento], [NombreCompleto], [Correo], [Clave], [IdRol], [Estado], [FechaRegistro]) VALUES (1, N'44542063', N'arminio', N'pietrocalathakigmail.com', N'1', 1, 1, CAST(N'2024-09-27T21:05:57.187' AS DateTime));
INSERT [dbo].[USUARIO] ([IdUsuario], [Documento], [NombreCompleto], [Correo], [Clave], [IdRol], [Estado], [FechaRegistro]) VALUES (2, N'123', N'Axel', N'Axelgmail.com', N'1', 2, 0, CAST(N'2024-09-28T19:38:55.710' AS DateTime));
INSERT [dbo].[USUARIO] ([IdUsuario], [Documento], [NombreCompleto], [Correo], [Clave], [IdRol], [Estado], [FechaRegistro]) VALUES (4, N'12113', N'Prueba 2', N'gmail', N'123', 2, 1, CAST(N'2024-09-30T00:06:56.103' AS DateTime));
INSERT [dbo].[USUARIO] ([IdUsuario], [Documento], [NombreCompleto], [Correo], [Clave], [IdRol], [Estado], [FechaRegistro]) VALUES (6, N'23123123', N'aa', N'aa', N'aa', 2, 0, CAST(N'2024-09-30T17:59:39.457' AS DateTime));
SET IDENTITY_INSERT [dbo].[USUARIO] OFF;
GO

SET IDENTITY_INSERT [dbo].[PERMISO] ON;
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (1, 1, N'menuusuarios', CAST(N'2024-09-27T21:38:54.123' AS DateTime));
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (2, 1, N'menuusuarios', CAST(N'2024-09-27T21:43:12.983' AS DateTime));
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (3, 1, N'menureportes', CAST(N'2024-09-27T21:43:12.983' AS DateTime));
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (4, 2, N'MenuClientes', CAST(N'2024-09-28T19:35:34.850' AS DateTime));
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (5, 2, N'MenuClientes', CAST(N'2024-09-28T19:35:34.850' AS DateTime));
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (6, 2, N'MenuClientes', CAST(N'2024-09-28T19:40:48.937' AS DateTime));
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (7, 2, N'MenuVentas', CAST(N'2024-09-28T19:40:48.937' AS DateTime));
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (8, 1, N'MenuReportes', CAST(N'2024-09-29T09:20:54.990' AS DateTime));
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (9, 1, N'MenuUsuarios', CAST(N'2024-09-29T09:20:54.990' AS DateTime));
INSERT [dbo].[PERMISO] ([IdRol], [NombreMenu]) VALUES (3,'menucompras'); -- Asumiendo IdRol 3 = Reponedor
SET IDENTITY_INSERT [dbo].[PERMISO] OFF;
GO

/*
================================================================================
6. CREACIÓN DE PROCEDIMIENTOS ALMACENADOS (Stored Procedures)
================================================================================
*/

-- --- Procedimientos para USUARIO ---
CREATE PROC [dbo].[SP_REGISTRARUSUARIO](
    @Documento varchar(50),
    @NombreCompleto varchar(100),
    @Correo varchar(100),
    @Clave varchar(100),
    @IdRol int,
    @Estado bit,
    @IdUsuarioResultado int output,
    @Mensaje varchar(500) output
)
as
begin
    set @IdUsuarioResultado = 0
    set @Mensaje = ''

    if not exists (select * from USUARIO where Documento = @Documento)
    begin
        insert into usuario(Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
        values (@Documento, @NombreCompleto, @Correo, @Clave, @IdRol, @Estado)
        set @IdUsuarioResultado = SCOPE_IDENTITY()
    end
    else
        set @Mensaje = 'No se puede repetir el documento para más de un usuario'
end
GO

CREATE PROC [dbo].[SP_EDITARUSUARIO](
    @IdUsuario int,
    @Documento varchar(50),
    @NombreCompleto varchar(100),
    @Correo varchar(100),
    @Clave varchar(100),
    @IdRol int,
    @Estado bit,
    @Respuesta bit output,
    @Mensaje varchar(500) output
)
as
begin
    set @Respuesta = 0
    set @Mensaje = ''

    if not exists (select * from USUARIO where Documento = @Documento and idusuario != @IdUsuario)
    begin
        update usuario set
        Documento =  @Documento,
        NombreCompleto = @NombreCompleto, 
        Correo = @Correo, 
        Clave = @Clave,
        IdRol = @IdRol, 
        Estado =  @Estado
        where IdUsuario = @IdUsuario 
        set @Respuesta = 1
    end
    else
        set @Mensaje = 'No se puede repetir el documento para más de un usuario'
end
GO

CREATE PROC [dbo].[SP_ELIMINARUSUARIO](
    @IdUsuario int,
    @Respuesta bit output,
    @Mensaje varchar(500) output
)
as
begin
    set @Respuesta = 0
    set @Mensaje = ''
    declare @reglas bit = 1

    IF EXISTS (SELECT * FROM COMPRA C WHERE C.IdUsuario = @IdUsuario)
    begin 
        set @reglas = 0
        set @Respuesta = 0
        set @Mensaje = @Mensaje + 'No se puede eliminar, el Usuario realizo una Compra\n'
    end 

    IF EXISTS (SELECT * FROM VENTA V WHERE V.IdUsuario = @IdUsuario)
    begin 
        set @Respuesta = 0
        set @reglas = 0
        set @Mensaje = @Mensaje + 'No se puede eliminar, el Usuario realizo una Venta\n'
    end 
    
    if (@reglas = 1)
    begin 
        DELETE from USUARIO where IdUsuario = @IdUsuario 
        set @Respuesta = 1
    end
end
GO

-- --- Procedimientos para CLIENTE ---
create proc sp_RegistrarCliente(
    @Documento varchar(50),
    @NombreCompleto varchar(50),
    @Correo varchar(50),
    @Telefono varchar(50),
    @Estado bit,
    @Resultado int output,
    @Mensaje varchar(500) output
)
as
begin
    set @Resultado = 0
    
    if not exists (select * from CLIENTE where Documento = @Documento)
    begin
        insert into CLIENTE(Documento, NombreCompleto, Correo, Telefono, Estado)
        values (@Documento, @NombreCompleto, @Correo, @Telefono, @Estado)
        set @Resultado = SCOPE_IDENTITY()
    end
    else
        set @Mensaje = 'El numero de documento ya existe'
end
GO

create proc sp_ModificarCliente(
    @IdCliente int,
    @Documento varchar(50),
    @NombreCompleto varchar(50),
    @Correo varchar(50),
    @Telefono varchar(50),
    @Estado bit,
    @Resultado bit output,
    @Mensaje varchar(500) output
)
as
begin
    set @Resultado = 1

    if not exists (select * from CLIENTE where Documento = @Documento and IdCliente != @IdCliente)
    begin
        update CLIENTE set
            Documento = @Documento,
            NombreCompleto = @NombreCompleto,
            Correo = @Correo,
            Telefono = @Telefono,
            Estado = @Estado
        where IdCliente = @IdCliente
    end
    else
    begin
        set @Resultado = 0
        set @Mensaje = 'El numero de documento ya existe'
    end
end
GO

-- --- Procedimientos para PROVEEDOR ---
CREATE PROC sp_RegistrarProveedor(
    @Documento varchar(50),
    @RazonSocial varchar(50),
    @Correo varchar(50),
    @Telefono varchar(50),
    @Estado bit,
    @Domicilio varchar(150),
    @Resultado int output,
    @Mensaje varchar(500) output
) as
begin
    set @Resultado = 0

    if not exists (select * from PROVEEDOR where Documento = @Documento)
    begin
        insert into PROVEEDOR(Documento, RazonSocial, Correo, Telefono, Estado, Domicilio) 
        values (@Documento, @RazonSocial, @Correo, @Telefono, @Estado, @Domicilio)
        set @Resultado = SCOPE_IDENTITY()
    end
    else
        set @Mensaje = 'El numero de documento ya existe'
end
GO

CREATE PROC sp_ModificarProveedor(
    @IdProveedor int,
    @Documento varchar(50),
    @RazonSocial varchar(50),
    @Correo varchar(50),
    @Telefono varchar(50),
    @Estado bit,
    @Domicilio varchar(150),
    @Resultado bit output,
    @Mensaje varchar(500) output
) as
begin
    set @Resultado = 1

    if not exists (select * from PROVEEDOR where Documento = @Documento and IdProveedor != @IdProveedor)
    begin
        update PROVEEDOR set
            Documento = @Documento,
            RazonSocial = @RazonSocial,
            Correo = @Correo,
            Telefono = @Telefono,
            Estado = @Estado,
            Domicilio = @Domicilio
        where IdProveedor = @IdProveedor
    end
    else
    begin
        set @Resultado = 0
        set @Mensaje = 'El numero de documento ya existe'
    end
end
GO

CREATE procedure sp_EliminarProveedor(
    @IdProveedor int,
    @Resultado bit output,
    @Mensaje varchar(500) output
)
as
begin
    set @Resultado = 1

    if not exists (
        select * from PROVEEDOR p
        inner join COMPRA c on p.IdProveedor = c.IdProveedor
        where p.IdProveedor = @IdProveedor
    )
    begin
        delete top(1) from PROVEEDOR where IdProveedor = @IdProveedor
    end
    else
    begin
        set @Resultado = 0
        set @Mensaje = 'El proveedor se encuentra relacionado a una compra'
    end
end
GO

-- --- Procedimientos para COMPRA ---
CREATE PROCEDURE sp_RegistrarCompra(
    @IdUsuario INT,
    @IdProveedor INT,
    @TipoDocumento VARCHAR(50),
    @NumeroDocumento VARCHAR(50),
    @MontoTotal DECIMAL(10, 2),
    @DetalleCompra [EDetalle_Compra] READONLY,
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    BEGIN TRY
        DECLARE @IdCompraGenerado INT = 0;
        SET @Resultado = 1
        SET @Mensaje = ''

        BEGIN TRANSACTION registro

        INSERT INTO COMPRA (IdUsuario, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro)
        VALUES (@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal, GETDATE())

        SET @IdCompraGenerado = SCOPE_IDENTITY()
        
        -- El INSERT ahora coincide con la tabla (sin SubTotal)
        INSERT INTO DETALLE_COMPRA (IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal, FechaRegistro)
        SELECT @IdCompraGenerado, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal, GETDATE() 
        FROM @DetalleCompra
        
        UPDATE p
        SET 
            p.Stock = p.Stock + dc.Cantidad,
            p.PrecioCompra = dc.PrecioCompra,
            p.PrecioVenta = dc.PrecioVenta
        FROM PRODUCTO p
        INNER JOIN @DetalleCompra dc ON dc.IdProducto = p.IdProducto

        COMMIT TRANSACTION registro
    END TRY
    BEGIN CATCH
        SET @Resultado = 0
        SET @Mensaje = ERROR_MESSAGE()
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION registro
    END CATCH
END
GO

-- --- Procedimientos para VENTA ---
CREATE PROCEDURE sp_RegistrarVenta
(
    @IdUsuario INT,
    @TipoDocumento VARCHAR(500),
    @NumeroDocumento VARCHAR(500),
    @DocumentoCliente VARCHAR(500),
    @NombreCliente VARCHAR(500),
    @MontoPago DECIMAL(18,2),
    @MontoCambio DECIMAL(18,2),
    @MontoTotal DECIMAL(18,2),
    @DetalleVenta [EDetalle_Venta] READONLY,
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    BEGIN TRY
        DECLARE @idventa INT = 0
        SET @Resultado = 1
        SET @Mensaje = ''

        BEGIN TRANSACTION registro

        INSERT INTO VENTA (IdUsuario, TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, MontoPago, MontoCambio, MontoTotal, FechaRegistro)
        VALUES (@IdUsuario, @TipoDocumento, @NumeroDocumento, @DocumentoCliente, @NombreCliente, @MontoPago, @MontoCambio, @MontoTotal, GETDATE())
        
        SET @idventa = SCOPE_IDENTITY()

        INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
        SELECT @idventa, IdProducto, PrecioVenta, Cantidad, SubTotal, GETDATE()
        FROM @DetalleVenta

        COMMIT TRANSACTION registro
    END TRY
    BEGIN CATCH
        SET @Resultado = 0
        SET @Mensaje = ERROR_MESSAGE()
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION registro
    END CATCH
END
GO


/*
================================================================================
7. PROCEDIMIENTOS DE REPORTES (Dashboard)
================================================================================
*/

-- --- 1. KPI: Total Ventas en Rango ---
CREATE PROCEDURE sp_ReporteDashboard_VentasHoy (
    @FechaInicio DATE,
    @FechaFin DATE
)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ISNULL(SUM(MontoTotal), 0)
    FROM VENTA
    WHERE CAST(FechaRegistro AS DATE) BETWEEN @FechaInicio AND @FechaFin;
END
GO

-- --- 2. KPI: Clientes Nuevos en Rango ---
CREATE PROCEDURE sp_ReporteDashboard_ClientesNuevosHoy (
    @FechaInicio DATE,
    @FechaFin DATE
)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(IdCliente)
    FROM CLIENTE
    WHERE CAST(FechaRegistro AS DATE) BETWEEN @FechaInicio AND @FechaFin;
END
GO

-- --- 3. Gráfico: Top 5 Productos en Rango ---
CREATE PROCEDURE sp_ReporteDashboard_Top5Productos (
    @FechaInicio DATE,
    @FechaFin DATE
)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 5
        p.Nombre AS NombreProducto,
        SUM(dv.Cantidad) AS TotalVendido
    FROM DETALLE_VENTA dv
    JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
    WHERE CAST(dv.FechaRegistro AS DATE) BETWEEN @FechaInicio AND @FechaFin
    GROUP BY p.Nombre
    ORDER BY TotalVendido DESC;
END
GO

-- --- 4. Gráfico: Ventas por Categoría en Rango ---
CREATE PROCEDURE sp_ReporteDashboard_VentasPorCategoria (
    @FechaInicio DATE,
    @FechaFin DATE
)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        c.Descripcion AS NombreCategoria,
        SUM(dv.SubTotal) AS TotalVido
    FROM DETALLE_VENTA dv
    JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
    JOIN CATEGORIA c ON c.IdCategoria = p.IdCategoria
    WHERE CAST(dv.FechaRegistro AS DATE) BETWEEN @FechaInicio AND @FechaFin
    GROUP BY c.Descripcion
    ORDER BY TotalVido DESC;
END
GO


/**********************************************************************************/
-- 1. Stored Procedure para listar solo Vendedores (para el ComboBox)
-- Asume que tu rol de vendedor se llama 'Vendedor'.
-- ¡Ajusta 'r.Descripcion = 'Vendedor'' si tu rol se llama 'Empleado' o 'Cajero'!

CREATE PROCEDURE SP_LISTARVENDEDORES
AS
BEGIN
    SELECT 
        u.IdUsuario,
        u.NombreCompleto
    FROM 
        USUARIO u
    INNER JOIN 
        ROL r ON u.IdRol = r.IdRol
    WHERE 
        r.Descripcion = 'Vendedor' -- O 'Empleado', 'Cajero', etc.
        AND u.Estado = 1;
END
GO


-- 2. Stored Procedure para el Reporte de Ventas (para el DataGridView)

CREATE PROCEDURE SP_REPORTEVENTAS(
    @FechaInicio DATE,
    @FechaFin DATE,
    @IdUsuario INT
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        v.IdVenta,
        u.NombreCompleto AS Vendedor,
        c.NombreCompleto AS Cliente,
        c.Documento AS DocumentoCliente,
        FORMAT(v.FechaRegistro, 'dd/MM/yyyy') AS FechaRegistro,
        v.MontoPago,
        v.MontoCambio,
        v.MontoTotal
    FROM
        VENTA v
    INNER JOIN
        USUARIO u ON v.IdUsuario = u.IdUsuario
    INNER JOIN
        CLIENTE c ON v.IdCliente = c.IdCliente
    WHERE
        -- Convertir a DATE para ignorar la parte de tiempo y hacer la comparación
        CAST(v.FechaRegistro AS DATE) BETWEEN @FechaInicio AND @FechaFin
        
        -- Si @IdUsuario es 0, trae todos.
        -- Si @IdUsuario es > 0, filtra por ese IdUsuario.
        AND (@IdUsuario = 0 OR v.IdUsuario = @IdUsuario);
END
GO


-- 1. Stored Procedure para obtener los datos de la Venta (Cabecera)
CREATE PROCEDURE SP_OBTENERVENTA(
    @IdVenta INT
)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT
        V.IdVenta,
        FORMAT(V.FechaRegistro, 'dd/MM/yyyy HH:mm') AS FechaRegistro,
        V.TipoDocumento,
        V.MontoTotal,
        V.MontoPago,
        V.MontoCambio,
        U.NombreCompleto AS UsuarioVendedor,
        C.Documento AS DocumentoCliente,
        C.NombreCompleto AS NombreCliente
    FROM VENTA V
    INNER JOIN USUARIO U ON V.IdUsuario = U.IdUsuario
    INNER JOIN CLIENTE C ON V.IdCliente = C.IdCliente
    WHERE V.IdVenta = @IdVenta;
END
GO

-- 2. Stored Procedure para obtener los productos de esa Venta (Detalle)
CREATE PROCEDURE SP_OBTENERDETALLEVENTA(
    @IdVenta INT
)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT
        P.Nombre AS NombreProducto,
        DV.PrecioVenta,
        DV.Cantidad,
        DV.SubTotal
    FROM DETALLE_VENTA DV
    INNER JOIN PRODUCTO P ON DV.IdProducto = P.IdProducto
    WHERE DV.IdVenta = @IdVenta;
END
GO


/**********************************************************************************/
-- 1. SP para el ComboBox de Reponedores (IdRol 3)
CREATE PROCEDURE SP_LISTARREPONEDORES
AS
BEGIN
    SELECT 
        u.IdUsuario,
        u.NombreCompleto
    FROM 
        USUARIO u
    INNER JOIN 
        ROL r ON u.IdRol = r.IdRol
    WHERE 
        r.IdRol = 3 -- IdRol 3 = Reponedor
        AND u.Estado = 1;
END
GO

-- 2. SP para el Reporte de Compras (DataGridView Principal)
CREATE PROCEDURE SP_REPORTECOMPRAS(
    @FechaInicio DATE,
    @FechaFin DATE,
    @IdProveedor INT,
    @IdReponedor INT
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        c.IdCompra,
        c.TipoDocumento,
        c.NumeroDocumento,
        p.RazonSocial,
        u.NombreCompleto AS UsuarioRegistro,
        c.MontoTotal,
        FORMAT(c.FechaRegistro, 'dd/MM/yyyy') AS FechaRegistro
    FROM
        COMPRA c
    INNER JOIN
        USUARIO u ON c.IdUsuario = u.IdUsuario
    INNER JOIN
        PROVEEDOR p ON c.IdProveedor = p.IdProveedor
    WHERE
        CAST(c.FechaRegistro AS DATE) BETWEEN @FechaInicio AND @FechaFin
        AND (@IdProveedor = 0 OR c.IdProveedor = @IdProveedor)
        AND (@IdReponedor = 0 OR c.IdUsuario = @IdReponedor);
END
GO

-- 3. SP para la cabecera del modal (Detalle)
CREATE PROCEDURE SP_OBTENERCOMPRA(
    @IdCompra INT
)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT
        C.IdCompra,
        C.FechaRegistro, 
        C.TipoDocumento,
        C.NumeroDocumento,
        C.MontoTotal,
        U.NombreCompleto AS UsuarioReponedor, -- Corregido
        P.Documento AS DocumentoProveedor,
        P.RazonSocial AS RazonSocialProveedor
    FROM COMPRA C
    INNER JOIN USUARIO U ON C.IdUsuario = U.IdUsuario
    INNER JOIN PROVEEDOR P ON C.IdProveedor = P.IdProveedor
    WHERE C.IdCompra = @IdCompra;
END
GO

-- 4. SP para la grilla del modal (Detalle)
-- CORREGIDO: Cambiado DC.SubTotal por DC.MontoTotal
CREATE PROCEDURE SP_OBTENERDETALLECOMPRA(
    @IdCompra INT
)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT
        P.Nombre AS NombreProducto,
        DC.PrecioCompra,
        DC.Cantidad,
        DC.MontoTotal -- <-- CORRECCIÓN FINAL
    FROM DETALLE_COMPRA DC
    INNER JOIN PRODUCTO P ON DC.IdProducto = P.IdProducto
    WHERE DC.IdCompra = @IdCompra;
END
GO