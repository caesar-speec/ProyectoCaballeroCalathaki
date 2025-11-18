/*
================================================================================
SCRIPT DE DATOS Y CONSULTAS: BDD_SistemaVentas_Jardineria1
================================================================================
Contenido:
1. Inserción de Datos Iniciales (Seed Data)
2. NUEVOS PRODUCTOS (5 por Categoría)
3. Consultas de Verificación (SELECTs)
4. Consultas de Mantenimiento y Limpieza (PELIGRO)
================================================================================
*/

-- Asegúrate de estar usando la base de datos correcta
USE [BDD_SistemaVentas_Jardineria1];
GO

/*
================================================================================
1. INSERCIÓN DE DATOS INICIALES (Seed Data)
================================================================================
*/

-- INSERTS CATEGORIA
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Herramientas', 1);
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Utileria', 1);
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Plantas', 1);
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Abono', 1);
GO

-- INSERTS PRODUCTO (LOS 5 ORIGINALES)
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro)
VALUES
('44', 'Pala de jardín', 'Pala metálica con mango de madera', 1, 25, 1500.00, 2200.00, 1, GETDATE()),
('55', 'Tijera de podar', 'Tijera de acero inoxidable', 1, 40, 1800.00, 2600.00, 1, GETDATE()),
('66', 'Planta de lavanda', 'Planta aromática de lavanda', 3, 30, 700.00, 1200.00, 1, GETDATE()), -- Corregido a IdCategoria 3
('77', 'Sustrato universal 10L', 'Bolsa de sustrato nutritivo', 4, 50, 900.00, 1500.00, 1, GETDATE()), -- Corregido a IdCategoria 4
('88', 'Maceta de barro 25cm', 'Maceta artesanal de barro', 2, 60, 500.00, 950.00, 1, GETDATE()); -- Corregido a IdCategoria 2
GO

-- INSERTS CLIENTE
INSERT INTO CLIENTE (Documento, NombreCompleto, Correo, Telefono, Estado, FechaRegistro)
VALUES 
('40123456', 'Juan Pérez', 'juan.perez@gmail.com', '1134567890', 1, GETDATE()),
('38222111', 'María Gómez', 'maria.gomez@hotmail.com', '1145671234', 1, GETDATE()),
('42789432', 'Carlos Díaz', 'carlos.diaz@yahoo.com', '1123459876', 0, GETDATE()),
('39551234', 'Lucía Fernández', 'lucia.fernandez@gmail.com', '1156784321', 1, GETDATE()),
('41098765', 'Santiago Ruiz', 'santiago.ruiz@outlook.com', '1165432198', 1, GETDATE());
GO

-- INSERT PROVEEDOR
INSERT INTO [dbo].[PROVEEDOR]
           ([Documento]
           ,[RazonSocial]
           ,[Correo]
           ,[Telefono]
           ,[Estado]
           ,[FechaRegistro]
           ,[Domicilio])
     VALUES
           ('30-71234567-8'
           ,'Vivero Crecimiento Verde S.A.'
           ,'contacto@crecimientoverde.com'
           ,'+54114568901'
           ,1
           ,GETDATE()
           ,'Av. del Libertador 1234');
GO

/*
================================================================================
2. NUEVOS PRODUCTOS (5 por Categoría)
================================================================================
*/

-- Categoría 1: Herramientas
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro)
VALUES
('H01', 'Rastrillo de mano', 'Mango ergonómico de goma', 1, 30, 800.00, 1300.00, 1, GETDATE()),
('H02', 'Guantes de jardinería', 'Resistentes, talle M', 1, 50, 400.00, 750.00, 1, GETDATE()),
('H03', 'Regadera metálica 5L', 'Acero galvanizado, color verde', 1, 15, 2000.00, 3100.00, 1, GETDATE()),
('H04', 'Escardillo de mano', 'Para remover malezas pequeñas', 1, 25, 600.00, 1000.00, 1, GETDATE()),
('H05', 'Pulverizador 1.5L', 'Botella plástica con rociador', 1, 40, 700.00, 1250.00, 1, GETDATE());
GO

-- Categoría 2: Utileria
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro)
VALUES
('U01', 'Tutores de madera (10u)', '1 metro de alto, pack x10', 2, 50, 300.00, 550.00, 1, GETDATE()),
('U02', 'Etiquetas para plantas (20u)', 'Plástico blanco, pack x20', 2, 100, 150.00, 300.00, 1, GETDATE()),
('U03', 'Malla anti-helada 2x2m', 'Protege de heladas leves', 2, 20, 1000.00, 1700.00, 1, GETDATE()),
('U04', 'Soporte p/ maceta de pared', 'Hierro forjado, color negro', 2, 30, 900.00, 1600.00, 1, GETDATE()),
('U05', 'Plato base maceta 20cm', 'Plástico terracota', 2, 80, 100.00, 220.00, 1, GETDATE());
GO

-- Categoría 3: Plantas
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro)
VALUES
('P01', 'Potus (Epipremnum aureum)', 'Planta de interior, fácil cuidado', 3, 20, 450.00, 900.00, 1, GETDATE()),
('P02', 'Helecho de Boston', 'Requiere alta humedad ambiental', 3, 15, 600.00, 1100.00, 1, GETDATE()),
('P03', 'Cactus Surtidos (Chicos)', 'Mix de cactus en maceta N°8', 3, 40, 250.00, 500.00, 1, GETDATE()),
('P04', 'Lazo de amor (Chlorophytum)', 'Ideal para colgar, purificadora', 3, 25, 400.00, 800.00, 1, GETDATE()),
('P05', 'Suculenta Echeveria', 'Forma de roseta, varios colores', 3, 30, 300.00, 650.00, 1, GETDATE());
GO

-- Categoría 4: Abono
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro)
VALUES
('A01', 'Humus de lombriz 1kg', 'Abono orgánico concentrado', 4, 50, 200.00, 450.00, 1, GETDATE()),
('A02', 'Fertilizante triple 15 1kg', 'NPK 15-15-15, granulado', 4, 30, 300.00, 600.00, 1, GETDATE()),
('A03', 'Perlita (Bolsa 5L)', 'Mejora el drenaje del sustrato', 4, 25, 350.00, 700.00, 1, GETDATE()),
('A04', 'Turba (Bolsa 5L)', 'Aporta acidez y retiene agua', 4, 25, 300.00, 650.00, 1, GETDATE()),
('A05', 'Harina de hueso 1kg', 'Fuente de fósforo y calcio', 4, 20, 280.00, 550.00, 1, GETDATE());
GO

/*
================================================================================
3. CONSULTAS DE VERIFICACIÓN (SELECTs)
================================================================================
*/

PRINT '--- CONSULTAS GENERALES DE TABLAS ---';
SELECT * FROM [dbo].[CATEGORIA];
SELECT * FROM [dbo].[PRODUCTO];
SELECT * FROM [dbo].[USUARIO];
SELECT * FROM [dbo].[ROL];
SELECT * FROM [dbo].[CLIENTE];
SELECT * FROM [dbo].[PROVEEDOR];
SELECT * FROM [dbo].[COMPRA];
SELECT * FROM [dbo].[DETALLE_COMPRA];
SELECT * FROM [dbo].[VENTA];
SELECT * FROM [dbo].[DETALLE_VENTA];
GO

PRINT '--- CONSULTAS ESPECÍFICAS DE DIAGNÓSTICO ---';

-- Ver productos con sus categorías
SELECT p.IdProducto, p.Codigo, p.Nombre, p.Descripcion, c.IdCategoria, c.Descripcion[DescripcionCategoria], p.Stock, p.PrecioCompra, p.PrecioVenta, p.Estado 
FROM PRODUCTO p
INNER JOIN CATEGORIA c on c.IdCategoria = p.IdCategoria;
GO

-- Diagnóstico de Reportes (Ventas)
PRINT '--- VENTAS REGISTRADAS ---';
SELECT IdVenta, MontoTotal, FechaRegistro
FROM VENTA
ORDER BY FechaRegistro DESC;
GO

-- Diagnóstico de Reportes (Detalles y Categorías)
PRINT '--- DETALLES DE VENTA REGISTRADOS ---';
SELECT dv.IdDetalleventa, p.Nombre AS Producto, c.Descripcion AS Categoria, dv.Cantidad, dv.SubTotal
FROM DETALLE_VENTA dv
JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
JOIN CATEGORIA c ON c.IdCategoria = p.IdCategoria;
GO

-- Diagnóstico de Reportes (Clientes)
PRINT '--- CLIENTES REGISTRADOS ---';
SELECT IdCliente, NombreCompleto, FechaRegistro
FROM CLIENTE
ORDER BY FechaRegistro DESC;
GO



DROP PROCEDURE IF EXISTS SP_OBTENERDETALLECOMPRA;
GO
DROP PROCEDURE IF EXISTS SP_OBTENERCOMPRA;
GO
DROP PROCEDURE IF EXISTS SP_REPORTECOMPRAS;
GO
DROP PROCEDURE IF EXISTS SP_LISTARREPONEDORES;
GO
/*
================================================================================
4. QUERIES DE MANTENIMIENTO Y LIMPIEZA (PELIGRO)
================================================================================
*/

/*
-- !! CUIDADO: QUERIES DE BORRADO !!
-- Descomentar solo si es necesario limpiar datos de prueba.


-- Borrar TODOS los proveedores (si no tienen compras asociadas)
-- DELETE FROM PROVEEDOR;
-- GO

-- Borrar TODOS los proveedores y reiniciar el ID (si no tienen FK)
-- TRUNCATE TABLE PROVEEDOR;
-- GO

-- Actualizar estado de todos los productos a "Activo"
UPDATE PRODUCTO SET Estado = 1;
GO


-- !! CUIDADO: QUERIES DE BORRADO DE OBJETOS !!
-- Descomentar solo si se necesita rehacer los SP o Tipos.

-- DROP PROCEDURE IF EXISTS sp_RegistrarCompra;
-- GO
-- DROP TYPE IF EXISTS [dbo].[EDetalle_Compra];
-- GO
-- DROP TYPE IF EXISTS [dbo].[DetalleCompraType];
-- GO
*/