/*
================================================================================
  SCRIPT 1: ESTRUCTURA (SCHEMA)
  Base de Datos: BDD_SistemaVentas_Jardineria1
================================================================================
  Contenido:
  1. Creación de Tipos (UDTT)
  2. Creación de Tablas (Con columnas Domicilio agregadas)
  3. Claves Foráneas
  4. Procedimientos Almacenados (CRUD, Transacciones, Reportes)
================================================================================
*/
CREATE DATABASE BDD_SistemaVentas_Jardineria1;
GO

USE [BDD_SistemaVentas_Jardineria1];
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO

/* --------------------------------------------------------------------------
   1. TIPOS DE DATOS (Table Types)
   -------------------------------------------------------------------------- */

IF TYPE_ID(N'EDetalle_Compra') IS NULL
BEGIN
    CREATE TYPE [dbo].[EDetalle_Compra] AS TABLE(
        [IdProducto]   INT,
        [PrecioCompra] DECIMAL(18,2),
        [PrecioVenta]  DECIMAL(18,2),
        [Cantidad]     INT,
        [MontoTotal]   DECIMAL(18,2)
    );
END
GO

IF TYPE_ID(N'EDetalle_Venta') IS NULL
BEGIN
    CREATE TYPE [dbo].[EDetalle_Venta] AS TABLE(
        [IdProducto]   INT NULL,
        [PrecioVenta]  DECIMAL(18,2),
        [Cantidad]     INT,
        [SubTotal]     DECIMAL(18,2)
    );
END
GO

/* --------------------------------------------------------------------------
   2. TABLAS
   -------------------------------------------------------------------------- */

CREATE TABLE [dbo].[CATEGORIA](
    [IdCategoria] [int] IDENTITY(1,1) NOT NULL,
    [Descripcion] [varchar](100) NULL,
    [Estado] [bit] NULL DEFAULT 1,
    [FechaRegistro] [datetime] NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([IdCategoria] ASC)
);

CREATE TABLE [dbo].[ROL](
    [IdRol] [int] IDENTITY(1,1) NOT NULL,
    [Descripcion] [varchar](50) NULL,
    [FechaRegistro] [datetime] NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([IdRol] ASC)
);

CREATE TABLE [dbo].[USUARIO](
    [IdUsuario] [int] IDENTITY(1,1) NOT NULL,
    [Documento] [varchar](50) NULL,
    [NombreCompleto] [varchar](50) NULL,
    [Correo] [varchar](50) NULL,
    [Clave] [varchar](50) NULL,
    [IdRol] [int] NULL,
    [Estado] [bit] NULL DEFAULT 1,
    [Domicilio] [varchar](500) NULL DEFAULT '', -- Columna ya incluida
    [FechaRegistro] [datetime] NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC),
    FOREIGN KEY([IdRol]) REFERENCES [dbo].[ROL] ([IdRol])
);

CREATE TABLE [dbo].[PERMISO](
    [IdPermiso] [int] IDENTITY(1,1) NOT NULL,
    [IdRol] [int] NULL,
    [NombreMenu] [varchar](100) NULL,
    [FechaRegistro] [datetime] NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([IdPermiso] ASC),
    FOREIGN KEY([IdRol]) REFERENCES [dbo].[ROL] ([IdRol])
);

CREATE TABLE [dbo].[PROVEEDOR](
    [IdProveedor] [int] IDENTITY(1,1) NOT NULL,
    [Documento] [varchar](50) NULL,
    [RazonSocial] [varchar](50) NULL,
    [Correo] [varchar](50) NULL,
    [Telefono] [varchar](50) NULL,
    [Estado] [bit] NULL DEFAULT 1,
    [Domicilio] [varchar](150) NULL,
    [FechaRegistro] [datetime] NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([IdProveedor] ASC)
);

CREATE TABLE [dbo].[CLIENTE](
    [IdCliente] [int] IDENTITY(1,1) NOT NULL,
    [Documento] [varchar](50) NULL,
    [NombreCompleto] [varchar](50) NULL,
    [Correo] [varchar](50) NULL,
    [Telefono] [varchar](50) NULL,
    [Estado] [bit] NULL DEFAULT 1,
    [Domicilio] [varchar](500) NULL DEFAULT '', -- Columna ya incluida
    [FechaRegistro] [datetime] NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([IdCliente] ASC)
);

CREATE TABLE [dbo].[PRODUCTO](
    [IdProducto] [int] IDENTITY(1,1) NOT NULL,
    [Codigo] [varchar](50) NULL,
    [Nombre] [varchar](50) NULL,
    [Descripcion] [varchar](50) NULL,
    [IdCategoria] [int] NULL,
    [Stock] [int] NOT NULL DEFAULT 0,
    [PrecioCompra] [decimal](10, 2) NULL DEFAULT 0,
    [PrecioVenta] [decimal](10, 2) NULL DEFAULT 0,
    [Estado] [bit] NULL DEFAULT 1,
    [FechaRegistro] [datetime] NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([IdProducto] ASC),
    FOREIGN KEY([IdCategoria]) REFERENCES [dbo].[CATEGORIA] ([IdCategoria])
);

CREATE TABLE [dbo].[COMPRA](
    [IdCompra] [int] IDENTITY(1,1) NOT NULL,
    [IdUsuario] [int] NULL,
    [IdProveedor] [int] NULL,
    [TipoDocumento] [varchar](50) NULL,
    [NumeroDocumento] [varchar](50) NULL,
    [MontoTotal] [decimal](10, 2) NULL,
    [FechaRegistro] [datetime] NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([IdCompra] ASC),
    FOREIGN KEY([IdUsuario]) REFERENCES [dbo].[USUARIO] ([IdUsuario]),
    FOREIGN KEY([IdProveedor]) REFERENCES [dbo].[PROVEEDOR] ([IdProveedor])
);

CREATE TABLE [dbo].[DETALLE_COMPRA](
    [IdDetalleCompra] [int] IDENTITY(1,1) NOT NULL,
    [IdCompra] [int] NULL,
    [IdProducto] [int] NULL,
    [PrecioCompra] [decimal](10, 2) NULL,
    [PrecioVenta] [decimal](18, 2) NULL,
    [Cantidad] [int] NULL,
    [MontoTotal] [decimal](18, 2) NULL,
    [FechaRegistro] [datetime] NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([IdDetalleCompra] ASC),
    FOREIGN KEY([IdCompra]) REFERENCES [dbo].[COMPRA] ([IdCompra]),
    FOREIGN KEY([IdProducto]) REFERENCES [dbo].[PRODUCTO] ([IdProducto])
);

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
    [FechaRegistro] [datetime] NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([Idventa] ASC),
    FOREIGN KEY([IdUsuario]) REFERENCES [dbo].[USUARIO] ([IdUsuario])
);

CREATE TABLE [dbo].[DETALLE_VENTA](
    [IdDetalleventa] [int] IDENTITY(1,1) NOT NULL,
    [IdVenta] [int] NULL,
    [IdProducto] [int] NULL,
    [PrecioVenta] [decimal](10, 2) NULL,
    [Cantidad] [int] NULL,
    [SubTotal] [decimal](10, 2) NULL,
    [FechaRegistro] [datetime] NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([IdDetalleventa] ASC),
    FOREIGN KEY([IdVenta]) REFERENCES [dbo].[VENTA] ([Idventa]),
    FOREIGN KEY([IdProducto]) REFERENCES [dbo].[PRODUCTO] ([IdProducto])
);
GO

/* --------------------------------------------------------------------------
   4. PROCEDIMIENTOS ALMACENADOS - MANTENEDORES
   -------------------------------------------------------------------------- */

-- USUARIOS (Con Domicilio)
CREATE PROCEDURE SP_REGISTRARUSUARIO(
    @Documento varchar(50), @NombreCompleto varchar(100), @Correo varchar(100), @Clave varchar(100),
    @IdRol int, @Domicilio varchar(500), @Estado bit, @IdUsuarioResultado int output, @Mensaje varchar(500) output
) AS
BEGIN
    SET @IdUsuarioResultado = 0; SET @Mensaje = '';
    IF NOT EXISTS (SELECT * FROM USUARIO WHERE Documento = @Documento)
    BEGIN
        INSERT INTO USUARIO(Documento, NombreCompleto, Correo, Clave, IdRol, Domicilio, Estado)
        VALUES (@Documento, @NombreCompleto, @Correo, @Clave, @IdRol, @Domicilio, @Estado);
        SET @IdUsuarioResultado = SCOPE_IDENTITY();
    END
    ELSE SET @Mensaje = 'No se puede repetir el documento.';
END
GO

CREATE PROCEDURE SP_EDITARUSUARIO(
    @IdUsuario int, @Documento varchar(50), @NombreCompleto varchar(100), @Correo varchar(100), @Clave varchar(100),
    @IdRol int, @Domicilio varchar(500), @Estado bit, @Respuesta bit output, @Mensaje varchar(500) output
) AS
BEGIN
    SET @Respuesta = 0; SET @Mensaje = '';
    IF NOT EXISTS (SELECT * FROM USUARIO WHERE Documento = @Documento AND IdUsuario != @IdUsuario)
    BEGIN
        UPDATE USUARIO SET Documento = @Documento, NombreCompleto = @NombreCompleto, Correo = @Correo,
                           Clave = @Clave, IdRol = @IdRol, Domicilio = @Domicilio, Estado = @Estado
        WHERE IdUsuario = @IdUsuario;
        SET @Respuesta = 1;
    END
    ELSE SET @Mensaje = 'No se puede repetir el documento.';
END
GO

CREATE PROCEDURE SP_ELIMINARUSUARIO(@IdUsuario int, @Respuesta bit output, @Mensaje varchar(500) output) AS
BEGIN
    SET @Respuesta = 0; SET @Mensaje = '';
    IF EXISTS (SELECT * FROM COMPRA WHERE IdUsuario = @IdUsuario) OR EXISTS (SELECT * FROM VENTA WHERE IdUsuario = @IdUsuario)
        SET @Mensaje = 'No se puede eliminar, el usuario tiene operaciones asociadas.';
    ELSE
    BEGIN
        DELETE FROM USUARIO WHERE IdUsuario = @IdUsuario;
        SET @Respuesta = 1;
    END
END
GO

-- CLIENTES (Con Domicilio)
CREATE PROCEDURE sp_RegistrarCliente(
    @Documento varchar(50), @NombreCompleto varchar(50), @Correo varchar(50), @Telefono varchar(50),
    @Domicilio varchar(500), @Estado bit, @Resultado int output, @Mensaje varchar(500) output
) AS
BEGIN
    SET @Resultado = 0;
    IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento)
    BEGIN
        INSERT INTO CLIENTE(Documento, NombreCompleto, Correo, Telefono, Domicilio, Estado)
        VALUES (@Documento, @NombreCompleto, @Correo, @Telefono, @Domicilio, @Estado);
        SET @Resultado = SCOPE_IDENTITY();
    END
    ELSE SET @Mensaje = 'Documento ya existe';
END
GO

CREATE PROCEDURE sp_ModificarCliente(
    @IdCliente int, @Documento varchar(50), @NombreCompleto varchar(50), @Correo varchar(50),
    @Telefono varchar(50), @Domicilio varchar(500), @Estado bit, @Resultado bit output, @Mensaje varchar(500) output
) AS
BEGIN
    SET @Resultado = 0;
    IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento AND IdCliente != @IdCliente)
    BEGIN
        UPDATE CLIENTE SET Documento=@Documento, NombreCompleto=@NombreCompleto, Correo=@Correo,
                           Telefono=@Telefono, Domicilio=@Domicilio, Estado=@Estado
        WHERE IdCliente = @IdCliente;
        SET @Resultado = 1;
    END
    ELSE SET @Mensaje = 'Documento ya existe';
END
GO

-- PROVEEDORES
CREATE PROCEDURE sp_RegistrarProveedor(
    @Documento varchar(50), @RazonSocial varchar(50), @Correo varchar(50), @Telefono varchar(50),
    @Estado bit, @Domicilio varchar(150), @Resultado int output, @Mensaje varchar(500) output
) AS
BEGIN
    SET @Resultado = 0;
    IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento)
    BEGIN
        INSERT INTO PROVEEDOR(Documento, RazonSocial, Correo, Telefono, Estado, Domicilio)
        VALUES (@Documento, @RazonSocial, @Correo, @Telefono, @Estado, @Domicilio);
        SET @Resultado = SCOPE_IDENTITY();
    END
    ELSE SET @Mensaje = 'Documento ya existe';
END
GO

CREATE PROCEDURE sp_ModificarProveedor(
    @IdProveedor int, @Documento varchar(50), @RazonSocial varchar(50), @Correo varchar(50),
    @Telefono varchar(50), @Estado bit, @Domicilio varchar(150), @Resultado bit output, @Mensaje varchar(500) output
) AS
BEGIN
    SET @Resultado = 0;
    IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento AND IdProveedor != @IdProveedor)
    BEGIN
        UPDATE PROVEEDOR SET Documento=@Documento, RazonSocial=@RazonSocial, Correo=@Correo,
                             Telefono=@Telefono, Estado=@Estado, Domicilio=@Domicilio
        WHERE IdProveedor = @IdProveedor;
        SET @Resultado = 1;
    END
    ELSE SET @Mensaje = 'Documento ya existe';
END
GO

CREATE PROCEDURE sp_EliminarProveedor(@IdProveedor int, @Resultado bit output, @Mensaje varchar(500) output) AS
BEGIN
    SET @Resultado = 0;
    IF NOT EXISTS (SELECT * FROM COMPRA WHERE IdProveedor = @IdProveedor)
    BEGIN
        DELETE FROM PROVEEDOR WHERE IdProveedor = @IdProveedor;
        SET @Resultado = 1;
    END
    ELSE SET @Mensaje = 'Proveedor relacionado a una compra.';
END
GO

-- PRODUCTOS
CREATE PROCEDURE sp_RegistrarProducto(
    @Codigo varchar(50), @Nombre varchar(50), @Descripcion varchar(50), @IdCategoria int,
    @Estado bit, @Resultado int output, @Mensaje varchar(500) output
) AS
BEGIN
    SET @Resultado = 0;
    IF NOT EXISTS (SELECT * FROM PRODUCTO WHERE Codigo = @Codigo)
    BEGIN
        INSERT INTO PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria, Estado)
        VALUES (@Codigo, @Nombre, @Descripcion, @IdCategoria, @Estado);
        SET @Resultado = SCOPE_IDENTITY();
    END
    ELSE SET @Mensaje = 'Codigo ya existe';
END
GO

CREATE PROCEDURE sp_ModificarProducto(
    @IdProducto int, @Codigo varchar(50), @Nombre varchar(50), @Descripcion varchar(50),
    @IdCategoria int, @Estado bit, @Resultado bit output, @Mensaje varchar(500) output
) AS
BEGIN
    SET @Resultado = 0;
    IF NOT EXISTS (SELECT * FROM PRODUCTO WHERE Codigo = @Codigo AND IdProducto != @IdProducto)
    BEGIN
        UPDATE PRODUCTO SET Codigo=@Codigo, Nombre=@Nombre, Descripcion=@Descripcion,
                            IdCategoria=@IdCategoria, Estado=@Estado
        WHERE IdProducto = @IdProducto;
        SET @Resultado = 1;
    END
    ELSE SET @Mensaje = 'Codigo ya existe';
END
GO

CREATE PROCEDURE SP_eliminarProducto(@IdProducto int, @Respuesta bit output, @Mensaje varchar(500) output) AS
BEGIN
    SET @Respuesta = 0;
    IF NOT EXISTS (SELECT * FROM DETALLE_VENTA WHERE IdProducto = @IdProducto) AND NOT EXISTS (SELECT * FROM DETALLE_COMPRA WHERE IdProducto = @IdProducto)
    BEGIN
        DELETE FROM PRODUCTO WHERE IdProducto = @IdProducto;
        SET @Respuesta = 1;
    END
    ELSE SET @Mensaje = 'Producto relacionado a una venta o compra.';
END
GO

/* --------------------------------------------------------------------------
   5. PROCEDIMIENTOS - TRANSACCIONES
   -------------------------------------------------------------------------- */

CREATE PROCEDURE sp_RegistrarCompra(
    @IdUsuario INT, @IdProveedor INT, @TipoDocumento VARCHAR(50), @NumeroDocumento VARCHAR(50),
    @MontoTotal DECIMAL(10, 2), @DetalleCompra [EDetalle_Compra] READONLY,
    @Resultado BIT OUTPUT, @Mensaje VARCHAR(500) OUTPUT
) AS
BEGIN
    BEGIN TRY
        DECLARE @IdCompraGenerado INT = 0; SET @Resultado = 1; SET @Mensaje = '';
        BEGIN TRANSACTION
            INSERT INTO COMPRA (IdUsuario, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal)
            VALUES (@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal);
            SET @IdCompraGenerado = SCOPE_IDENTITY();

            INSERT INTO DETALLE_COMPRA (IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal)
            SELECT @IdCompraGenerado, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal FROM @DetalleCompra;

            UPDATE p SET p.Stock = p.Stock + dc.Cantidad, p.PrecioCompra = dc.PrecioCompra, p.PrecioVenta = dc.PrecioVenta
            FROM PRODUCTO p INNER JOIN @DetalleCompra dc ON dc.IdProducto = p.IdProducto;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        SET @Resultado = 0; SET @Mensaje = ERROR_MESSAGE(); ROLLBACK TRANSACTION;
    END CATCH
END
GO

CREATE PROCEDURE sp_RegistrarVenta(
    @IdUsuario INT, @TipoDocumento VARCHAR(500), @NumeroDocumento VARCHAR(500),
    @DocumentoCliente VARCHAR(500), @NombreCliente VARCHAR(500),
    @MontoPago DECIMAL(18,2), @MontoCambio DECIMAL(18,2), @MontoTotal DECIMAL(18,2),
    @DetalleVenta [EDetalle_Venta] READONLY,
    @Resultado BIT OUTPUT, @Mensaje VARCHAR(500) OUTPUT
) AS
BEGIN
    BEGIN TRY
        DECLARE @idventa INT = 0; SET @Resultado = 1; SET @Mensaje = '';
        BEGIN TRANSACTION
            INSERT INTO VENTA (IdUsuario, TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, MontoPago, MontoCambio, MontoTotal)
            VALUES (@IdUsuario, @TipoDocumento, @NumeroDocumento, @DocumentoCliente, @NombreCliente, @MontoPago, @MontoCambio, @MontoTotal);
            SET @idventa = SCOPE_IDENTITY();

            INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal)
            SELECT @idventa, IdProducto, PrecioVenta, Cantidad, SubTotal FROM @DetalleVenta;

            UPDATE p SET p.Stock = p.Stock - dv.Cantidad
            FROM PRODUCTO p INNER JOIN @DetalleVenta dv ON dv.IdProducto = p.IdProducto;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        SET @Resultado = 0; SET @Mensaje = ERROR_MESSAGE(); ROLLBACK TRANSACTION;
    END CATCH
END
GO

/* --------------------------------------------------------------------------
   6. PROCEDIMIENTOS - REPORTES Y UTILIDADES
   -------------------------------------------------------------------------- */

CREATE PROCEDURE SP_LISTARVENDEDORES AS
BEGIN
    SELECT u.IdUsuario, u.NombreCompleto FROM USUARIO u
    INNER JOIN ROL r ON u.IdRol = r.IdRol
    WHERE r.Descripcion = 'Vendedor' AND u.Estado = 1;
END
GO

CREATE PROCEDURE SP_LISTARREPONEDORES AS
BEGIN
    SELECT u.IdUsuario, u.NombreCompleto FROM USUARIO u
    INNER JOIN ROL r ON u.IdRol = r.IdRol
    WHERE r.IdRol = 3 AND u.Estado = 1;
END
GO

CREATE PROCEDURE SP_LISTARPROVEEDORES AS
BEGIN
    SELECT IdProveedor, RazonSocial FROM PROVEEDOR WHERE Estado = 1;
END
GO

CREATE PROCEDURE SP_REPORTEVENTAS(@FechaInicio DATE, @FechaFin DATE, @IdUsuario INT) AS
BEGIN
    SELECT v.IdVenta, u.NombreCompleto AS Vendedor, v.NombreCliente AS Cliente,
           v.DocumentoCliente, FORMAT(v.FechaRegistro, 'dd/MM/yyyy') AS FechaRegistro,
           v.MontoPago, v.MontoCambio, v.MontoTotal
    FROM VENTA v INNER JOIN USUARIO u ON v.IdUsuario = u.IdUsuario
    WHERE CAST(v.FechaRegistro AS DATE) BETWEEN @FechaInicio AND @FechaFin
    AND (@IdUsuario = 0 OR v.IdUsuario = @IdUsuario);
END
GO

CREATE PROCEDURE SP_REPORTECOMPRAS(@FechaInicio DATE, @FechaFin DATE, @IdProveedor INT, @IdReponedor INT) AS
BEGIN
    SELECT c.IdCompra, c.TipoDocumento, c.NumeroDocumento, p.RazonSocial,
           u.NombreCompleto AS UsuarioRegistro, c.MontoTotal,
           FORMAT(c.FechaRegistro, 'dd/MM/yyyy') AS FechaRegistro
    FROM COMPRA c
    INNER JOIN USUARIO u ON c.IdUsuario = u.IdUsuario
    INNER JOIN PROVEEDOR p ON c.IdProveedor = p.IdProveedor
    WHERE CAST(c.FechaRegistro AS DATE) BETWEEN @FechaInicio AND @FechaFin
    AND (@IdProveedor = 0 OR c.IdProveedor = @IdProveedor)
    AND (@IdReponedor = 0 OR c.IdUsuario = @IdReponedor);
END
GO

CREATE PROCEDURE SP_OBTENERVENTA(@IdVenta INT) AS
BEGIN
    SELECT V.IdVenta, FORMAT(V.FechaRegistro, 'dd/MM/yyyy HH:mm') AS FechaRegistro,
           V.TipoDocumento, V.MontoTotal, V.MontoPago, V.MontoCambio,
           U.NombreCompleto AS UsuarioVendedor, V.DocumentoCliente, V.NombreCliente
    FROM VENTA V INNER JOIN USUARIO U ON V.IdUsuario = U.IdUsuario
    WHERE V.IdVenta = @IdVenta;
END
GO

CREATE PROCEDURE SP_OBTENERDETALLEVENTA(@IdVenta INT) AS
BEGIN
    SELECT P.Nombre AS NombreProducto, DV.PrecioVenta, DV.Cantidad, DV.SubTotal
    FROM DETALLE_VENTA DV INNER JOIN PRODUCTO P ON DV.IdProducto = P.IdProducto
    WHERE DV.IdVenta = @IdVenta;
END
GO

CREATE PROCEDURE SP_OBTENERCOMPRA(@IdCompra INT) AS
BEGIN
    SELECT C.IdCompra, C.FechaRegistro, C.TipoDocumento, C.NumeroDocumento, C.MontoTotal,
           U.NombreCompleto AS UsuarioReponedor, P.Documento AS DocumentoProveedor, P.RazonSocial AS RazonSocialProveedor
    FROM COMPRA C
    INNER JOIN USUARIO U ON C.IdUsuario = U.IdUsuario
    INNER JOIN PROVEEDOR P ON C.IdProveedor = P.IdProveedor
    WHERE C.IdCompra = @IdCompra;
END
GO

CREATE PROCEDURE SP_OBTENERDETALLECOMPRA(@IdCompra INT) AS
BEGIN
    SELECT P.Nombre AS NombreProducto, DC.PrecioCompra, DC.Cantidad, DC.MontoTotal
    FROM DETALLE_COMPRA DC INNER JOIN PRODUCTO P ON DC.IdProducto = P.IdProducto
    WHERE DC.IdCompra = @IdCompra;
END
GO

/* --------------------------------------------------------------------------
   7. PROCEDIMIENTOS - DASHBOARD
   -------------------------------------------------------------------------- */

CREATE PROCEDURE sp_ReporteDashboard_VentasHoy (@FechaInicio DATE, @FechaFin DATE) AS
BEGIN
    SELECT ISNULL(SUM(MontoTotal), 0) FROM VENTA WHERE CAST(FechaRegistro AS DATE) BETWEEN @FechaInicio AND @FechaFin;
END
GO

CREATE PROCEDURE sp_ReporteDashboard_ClientesNuevosHoy (@FechaInicio DATE, @FechaFin DATE) AS
BEGIN
    SELECT COUNT(IdCliente) FROM CLIENTE WHERE CAST(FechaRegistro AS DATE) BETWEEN @FechaInicio AND @FechaFin;
END
GO

CREATE PROCEDURE sp_ReporteDashboard_Top5Productos (@FechaInicio DATE, @FechaFin DATE) AS
BEGIN
    SELECT TOP 5 p.Nombre AS NombreProducto, SUM(dv.Cantidad) AS TotalVendido
    FROM DETALLE_VENTA dv JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
    WHERE CAST(dv.FechaRegistro AS DATE) BETWEEN @FechaInicio AND @FechaFin
    GROUP BY p.Nombre ORDER BY TotalVendido DESC;
END
GO

CREATE PROCEDURE sp_ReporteDashboard_VentasPorCategoria (@FechaInicio DATE, @FechaFin DATE) AS
BEGIN
    SELECT c.Descripcion AS NombreCategoria, SUM(dv.SubTotal) AS TotalVendido
    FROM DETALLE_VENTA dv JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
    JOIN CATEGORIA c ON c.IdCategoria = p.IdCategoria
    WHERE CAST(dv.FechaRegistro AS DATE) BETWEEN @FechaInicio AND @FechaFin
    GROUP BY c.Descripcion ORDER BY TotalVendido DESC;
END
GO