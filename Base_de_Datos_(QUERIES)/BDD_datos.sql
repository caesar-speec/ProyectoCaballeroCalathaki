/*
================================================================================
  SCRIPT 2: DATOS INICIALES 
================================================================================
  Contenido:
  1. Roles y Usuarios
  2. Permisos
  3. Categorías y Productos
  4. Clientes y Proveedores
================================================================================
*/

USE [BDD_SistemaVentas_Jardineria1];
GO

-- 1. ROLES
SET IDENTITY_INSERT [dbo].[ROL] ON;
INSERT INTO [dbo].[ROL] ([IdRol], [Descripcion]) VALUES (1, 'ADMIN');
INSERT INTO [dbo].[ROL] ([IdRol], [Descripcion]) VALUES (2, 'Vendedor');
INSERT INTO [dbo].[ROL] ([IdRol], [Descripcion]) VALUES (3, 'Reponedor');
SET IDENTITY_INSERT [dbo].[ROL] OFF;
GO

-- 2. USUARIOS (Con Domicilio)
SET IDENTITY_INSERT [dbo].[USUARIO] ON;
INSERT INTO [dbo].[USUARIO] ([IdUsuario], [Documento], [NombreCompleto], [Correo], [Clave], [IdRol], [Estado], [Domicilio]) 
VALUES 
(1, '44542063', 'Arminio', 'pietrocalathakigmail.com', '1', 1, 1, 'Av. Lopez 234'),
(2, '123', 'Axel', 'Axelgmail.com', '1', 2, 1, 'Av. Maipu 300'),
(3, '4455221', 'Prueba 2', 'gmail', '123', 2, 1, 'Peru 1200'),
(4, '1234', 'Test Reponedor', 'repo@gmail.com', '123', 3, 1, 'Jujuy 728'),
(5, '44542062', 'Otro User', 'aa@aa.com', 'aa', 2, 0, 'Cabral 1800'),
(6, '43452430', 'Usuario 6', 'user6@gmail.com', '123', 2, 1, 'Av. Libertador 450');
SET IDENTITY_INSERT [dbo].[USUARIO] OFF;
GO

-- 3. PERMISOS
INSERT INTO [dbo].[PERMISO] ([IdRol], [NombreMenu]) VALUES 
(1, 'menuusuarios'), (1, 'menureportes'), (1, 'MenuReportes'), (1, 'MenuUsuarios'),
(2, 'MenuClientes'), (2, 'MenuVentas'),
(3, 'menucompras');
GO

-- 4. CATEGORÍAS
INSERT INTO CATEGORIA (Descripcion) VALUES ('Herramientas'), ('Utileria'), ('Plantas'), ('Abono');
GO

-- 5. PROVEEDOR
INSERT INTO [dbo].[PROVEEDOR] ([Documento], [RazonSocial], [Correo], [Telefono], [Domicilio])
VALUES ('30-71234567-8', 'Vivero Crecimiento Verde S.A.', 'contacto@crecimientoverde.com', '+54114568901', 'Av. del Libertador 1234');
GO

-- 6. CLIENTES (Con Domicilio)
INSERT INTO CLIENTE (Documento, NombreCompleto, Correo, Telefono, Domicilio)
VALUES 
('40123456', 'Juan Pérez', 'juan.perez@gmail.com', '1134567890', 'Calle Falsa 123'),
('38222111', 'María Gómez', 'maria.gomez@hotmail.com', '1145671234', 'Av. Siempre Viva 742'),
('42789432', 'Carlos Díaz', 'carlos.diaz@yahoo.com', '1123459876', 'Sin Domicilio Registrado'),
('39551234', 'Lucía Fernández', 'lucia.fernandez@gmail.com', '1156784321', 'Sin Domicilio Registrado'),
('41098765', 'Santiago Ruiz', 'santiago.ruiz@outlook.com', '1165432198', 'Sin Domicilio Registrado');
GO

-- 7. PRODUCTOS
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta) VALUES
('44', 'Pala de jardín', 'Pala metálica con mango de madera', 1, 25, 1500.00, 2200.00),
('55', 'Tijera de podar', 'Tijera de acero inoxidable', 1, 40, 1800.00, 2600.00),
('66', 'Planta de lavanda', 'Planta aromática', 3, 30, 700.00, 1200.00),
('77', 'Sustrato universal 10L', 'Bolsa de sustrato', 4, 50, 900.00, 1500.00),
('88', 'Maceta de barro 25cm', 'Maceta artesanal', 2, 60, 500.00, 950.00),
('H01', 'Rastrillo de mano', 'Mango ergonómico', 1, 30, 800.00, 1300.00),
('H02', 'Guantes de jardinería', 'Resistentes talle M', 1, 50, 400.00, 750.00),
('H03', 'Regadera metálica 5L', 'Acero galvanizado', 1, 15, 2000.00, 3100.00),
('H04', 'Escardillo de mano', 'Para remover malezas', 1, 25, 600.00, 1000.00),
('H05', 'Pulverizador 1.5L', 'Botella plástica', 1, 40, 700.00, 1250.00),
('U01', 'Tutores de madera', 'Pack x10', 2, 50, 300.00, 550.00),
('U02', 'Etiquetas para plantas', 'Pack x20', 2, 100, 150.00, 300.00),
('U03', 'Malla anti-helada', '2x2m', 2, 20, 1000.00, 1700.00),
('U04', 'Soporte maceta pared', 'Hierro forjado', 2, 30, 900.00, 1600.00),
('U05', 'Plato base maceta', 'Plástico 20cm', 2, 80, 100.00, 220.00),
('P01', 'Potus', 'Planta de interior', 3, 20, 450.00, 900.00),
('P02', 'Helecho de Boston', 'Alta humedad', 3, 15, 600.00, 1100.00),
('P03', 'Cactus Surtidos', 'Mix', 3, 40, 250.00, 500.00),
('P04', 'Lazo de amor', 'Colgante', 3, 25, 400.00, 800.00),
('P05', 'Suculenta Echeveria', 'Roseta', 3, 30, 300.00, 650.00),
('A01', 'Humus de lombriz 1kg', 'Abono orgánico', 4, 50, 200.00, 450.00),
('A02', 'Fertilizante triple 15', '1kg', 4, 30, 300.00, 600.00),
('A03', 'Perlita', 'Bolsa 5L', 4, 25, 350.00, 700.00),
('A04', 'Turba', 'Bolsa 5L', 4, 25, 300.00, 650.00),
('A05', 'Harina de hueso', '1kg', 4, 20, 280.00, 550.00);
GO