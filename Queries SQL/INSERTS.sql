select IdCategoria, Descripcion, Estado FROM CATEGORIA





SELECT IdProducto, Codigo, Nombre, p.Descripcion, c.IdCategoria, c.Descripcion[DescripcionCategoria], Stock, PrecioCompra, PrecioVenta, p.Estado  FROM PRODUCTO p
INNER JOIN CATEGORIA c on c.IdCategoria = p.IdCategoria

SELECT * FROM PRODUCTO
SELECT * FROM CATEGORIA
select*from USUARIO
select*from ROL

INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Herramientas', 1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Utileria', 1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Plantas', 1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Abono', 1)



insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values (101010, 'Pala Jardinera', 'Punta ancha', 1)

update PRODUCTO set Estado = 1