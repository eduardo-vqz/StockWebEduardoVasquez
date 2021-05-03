CREATE DATABASE inventario
GO

USE inventario
GO

CREATE TABLE usuarios
(
id INT IDENTITY(1,1),
nombre VARCHAR(75),
apllidos VARCHAR(75),
usuario VARCHAR(75),
pw VARCHAR(250),
CONSTRAINT id_usuario PRIMARY KEY(id)
)
GO

CREATE TABLE sucursales
(
id INT IDENTITY(1,1),
sucursal VARCHAR(75),
direccion VARCHAR(150),
telefono VARCHAR(15),
habilitar_sucursal bit,
CONSTRAINT id_sucursales PRIMARY KEY(id)
)
GO

CREATE TABLE categorias
(
id INT IDENTITY(1,1),
categoria VARCHAR(45),
habilitar_categoria bit,
CONSTRAINT id_categorias PRIMARY KEY(id)
)
GO

CREATE TABLE electrodomesticos
(
id INT IDENTITY(1,1),
nombre_electrodomestico VARCHAR(40),
categoria_id INT,
habilitar_electrodomestico bit,
CONSTRAINT id_electrodomesticos PRIMARY KEY(id),
CONSTRAINT fk_categorias_electrodomesticos 
	FOREIGN KEY(categoria_id)
	REFERENCES categorias(id)
)
GO

CREATE TABLE sucursal_electrodomestico
(
id INT IDENTITY(1,1),
sucursal_id INT,
electrodomestico_id INT,
cantidad INT,
CONSTRAINT id_sucursal_electrodomesticos
	PRIMARY KEY(id),
CONSTRAINT fk_sucursal_sucursales_electrodomesticos
	FOREIGN KEY(sucursal_id)
	REFERENCES sucursales(id),
CONSTRAINT fk_electrodomestico_sucursales_electrodomesticos
	FOREIGN KEY(electrodomestico_id)
	REFERENCES electrodomesticos(id),
)
GO

CREATE TABLE inventario
(
id INT IDENTITY(1,1),
sucursal_electrodomestico_id INT,
cantidad_movimiento INT,
movimiento VARCHAR(25),
CONSTRAINT id_inventario PRIMARY KEY(id),
CONSTRAINT fk_sucursal_electrodomestico_inventario
	FOREIGN KEY(sucursal_electrodomestico_id)
	REFERENCES sucursal_electrodomestico(id)
)
GO


--RENOMBRAR LA COLUMNA apllido por apellidos en la tabla usuarios
EXEC sp_rename 'usuarios.apllidos', 'apellidos', 'COLUMN';