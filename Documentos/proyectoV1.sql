CREATE DATABASE heladeria;
 
USE heladeria;

/* 0x01 = Lunes, 0x02 = Martes, 0x04 = Miercoles, 0x08 = Jueves, 0x010 = Viernes, 0x020 = Sabado, 0x40 = Domingo */
/* 1 = Lunes, 2 = Martes, 4 = Miercoles, 8 = Jueves,  16 = Viernes, 32 = Sabado, 64 = Domingo */
CREATE TABLE Turno (
	turno_id INT identity(1,1) PRIMARY KEY NOT NULL,
	nombre VARCHAR(30) NOT NULL,
	dias INT NOT NULL,
	hora_comienza TIME NOT NULL,
	hora_termina TIME NOT NULL
);

CREATE TABLE Empleado(
    empleado_id INT identity(1,1) PRIMARY KEY NOT NULL,
	no_identificacion varchar(15),
	tipo_identificacion varchar(30),
	correo varchar(50) NOT NULL,
	password varchar(128) NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    apellido VARCHAR(30),
    telefono VARCHAR(12),
    calle VARCHAR(50),
	no_casa VARCHAR(50),
    sector VARCHAR(50),
    ciudad VARCHAR(50),
    provincia VARCHAR(50),
	turno_id INT,
	constraint empleado_turno_fk FOREIGN KEY (turno_id) REFERENCES Turno(turno_id)
);

CREATE TABLE Cliente(
    cliente_id INT identity(1,1) PRIMARY KEY NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    apellido VARCHAR(30),
    telefono VARCHAR(12) NOT NULL,
	correo VARCHAR(100),
	RNC varchar(15),
    calle VARCHAR(100),
	no_casa VARCHAR(100),
    sector VARCHAR(50),
    ciudad VARCHAR(50),
    provincia VARCHAR(50)
);

 CREATE TABLE Producto(
    producto_id INT identity(1,1) PRIMARY KEY NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    descripcion VARCHAR(100),
	etiqueta_negra BIT DEFAULT 0,
    precio_venta money,
	precio_compra money
);

CREATE TABLE SaborHelado(
    producto_id INT PRIMARY KEY NOT NULL,
	temporal BIT DEFAULT 0,
	principio_temporada DATE,
	fin_temporada DATE,
	CONSTRAINT sabor_helado_producto_fk FOREIGN KEY (producto_id) REFERENCES Producto(producto_id)
);


CREATE TABLE RegistroInventario(
    inventario_id INT PRIMARY KEY identity(1,1) NOT NULL,
	empleado_id INT NOT NULL,
    notas text,
    fecha DATE NOT NULL
	CONSTRAINT inventario_empleado_fk FOREIGN KEY (empleado_id) REFERENCES Empleado(empleado_id)
);
 
CREATE TABLE Producto_RegistroInventario(
    producto_id INT NOT NULL,
    inventario_id INT NOT NULL,
    cantidad DECIMAL(10, 2) NOT NULL,
    CONSTRAINT Producto_RegistroInventario_pk PRIMARY KEY (producto_id, inventario_id),
    CONSTRAINT producto_fk FOREIGN KEY (producto_id) REFERENCES Producto(producto_id),
    CONSTRAINT inventario_fk FOREIGN KEY (inventario_id) REFERENCES RegistroInventario(inventario_id)
);

CREATE TABLE Orden(
	orden_id INT identity(1,1) PRIMARY KEY NOT NULL,
	empleado_id INT NOT NULL,
	NOTAS TEXT,
	aceptada BIT DEFAULT 0,
	fecha_aceptada DATE,
	despachada BIT DEFAULT 0,
	fecha_despachada DATE,
	recibida BIT DEFAULT 0,
	fecha_recibida DATE,
	constraint orden_empleado_fk FOREIGN KEY (empleado_id) REFERENCES Empleado(empleado_id)
);

CREATE TABLE Orden_Producto (
	orden_id INT NOT NULL,
	producto_id INT NOT NULL,
	cantidad INT NOT NULL,
	CONSTRAINT orden_producto_pk PRIMARY KEY (orden_id, producto_id),
	CONSTRAINT orden_producto_orden_fk FOREIGN KEY (orden_id) REFERENCES Orden(orden_id),
	CONSTRAINT orden_produto_producto_fk FOREIGN KEY (producto_id) REFERENCES Producto(producto_id)
);

CREATE TABLE Venta(
    venta_id INT identity(1,1) PRIMARY KEY NOT NULL,
    cliente_id INT NOT NULL,
    vendedor_id INT NOT NULL,
    fecha DATETIME NOT NULL,
    forma_pago VARCHAR(50) CHECK (forma_pago IN('efectvivo', 'tarjeta')) NOT NULL,
	total money NOT NULL,
    CONSTRAINT venta_cliente_fk FOREIGN KEY (cliente_id) REFERENCES Cliente(cliente_id),
    CONSTRAINT venta_empleado_fk FOREIGN KEY (vendedor_id) REFERENCES Empleado(empleado_id)
);

 
CREATE TABLE Venta_Productos(
    venta_id INT NOT NULL,
    producto_id INT NOT NULL,
    cantidad INT NOT NULL,
    CONSTRAINT venta_pk PRIMARY KEY (venta_id, producto_id),
    CONSTRAINT venta_id_fk FOREIGN KEY (venta_id) REFERENCES Venta(venta_id),
    CONSTRAINT producto_id_fk FOREIGN KEY (producto_id) REFERENCES Producto(producto_id)
);

CREATE TABLE NFC(
    no_nfc INT PRIMARY KEY NOT NULL,
	venta_id INT UNIQUE NOT NULL,
	CONSTRAINT nfc_venta FOREIGN KEY (venta_id) REFERENCES Venta (venta_id) ON DELETE CASCADE
);
 
CREATE TABLE Oferta(
    oferta_id INT PRIMARY KEY identity(1,1) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    descripcion VARCHAR(200),
    fecha_empieza DATE NOT NULL,
    fecha_termina DATE NOT NULL,
	dias_disponible INT NOT NULL, -- BIT MASK
	hora_disponible_emieza TIME NOT NULL,
	hora_disponible_termina TIME NOT NULL
);
 
CREATE TABLE Oferta_Productos(
    oferta_id INT,
    producto_id INT,
    cantidad_maxima INT,
	tipo varchar(30) NOT NULL CHECK (tipo IN('2x1')),
    CONSTRAINT oferta_productos_pk PRIMARY KEY (oferta_id, producto_id),
    CONSTRAINT productos_oferta_fk FOREIGN KEY (oferta_id) REFERENCES Oferta(oferta_id),
    CONSTRAINT ofertas_producto_fk FOREIGN KEY (producto_id) REFERENCES Producto(producto_id)
);

USE heladeria;

/* ============== STORED PROCEDURES ========================= */

use heladeria;
CREATE PROCEDURE sp_InsertSaborHelado @nombre varchar(50), @descripcion varchar(100), @etiqueta_negra bit = 0, 
				 @precio_venta money, @precio_compra money, @temporal bit = 0, @principio_temporada date = null, @fin_temporada date = null
AS
BEGIN
	INSERT INTO Producto VALUES (@nombre, @descripcion, @etiqueta_negra, @precio_venta, @precio_compra);
	INSERT INTO SaborHelado VALUES(@@IDENTITY, @temporal, @principio_temporada, @fin_temporada);
END

/* ============== INTRODUCCION DE DATOS ===================== */

/* Turnos */
INSERT INTO Turno VALUES ('Semana manana', 31, '09:00:00', '13:00:00');
INSERT INTO Turno VALUES ('Semana Tarde', 31, '13:00:00', '18:00:00');

/* Empleados */
-- TODO: introducir correos y cedulas
INSERT INTO Empleado(no_identificacion, tipo_identificacion, nombre, apellido, telefono, calle, no_casa, sector, ciudad, provincia)
VALUES ('001-1493849-1', 'cedula', 'Juan', 'Perez', '809-482-5924', 'calle 5', '#4 Residencia Las Flores APTO 5A', 'Los Jardines', 'D.N.', 'Santo Domingo', 1);
INSERT INTO Empleado(no_identificacion, tipo_identificacion, nombre, apellido, telefono, calle, no_casa, sector, ciudad, provincia)
VALUES ('001-1493849-1', 'cedula', 'Ramon', 'Martinez', '809-820-9857', 'calle 8', '#25', 'Los Alcarrizos', 'D.N.', 'Santo Domingo', 2);

/* Clientes */
INSERT INTO Cliente VALUES ('Alex', 'Figuereo', '829-458-2948', 'afiguereo@correo.com', '130156964', 'Calle F', '#65', 'Bella Vista', 'Santo Domingo', 'D.N.');
INSERT INTO Cliente VALUES ('Ramon', 'Alcantara', '829-432-9481', 'ra@correo.com', '184930485', 'Calle C', '#89', 'Naco', 'Santo Domingo', 'D.N.');

/* Productos */
INSERT INTO Producto VALUES 
('Barquito', NULL, 0, 100.00),
('Barquito', NULL, 1, 150.00),
('Barquito Abordado', NULL, 0, 120.00),
('Barquito Abordado', NULL, 1, 175.00),
('Barquilla Danesa', NULL, 0, 50.00),
('Barquilla Danesa', NULL, 1, 100.00),
('Bonito', NULL, 0, 50.00),
('Bonito', NULL, 1, 70.00),
('Cajita', '4 onz', 0, 50.00),
('Cajita', '4 onz', 1, 90.00),
('Super Sundae', NULL, 0, 130.00),
('Super Sundae', NULL, 1, 150.00),
('Malteada', NULL, 0, 100.00),
('Malteada', NULL, 1, 150.00),
('1 Pinta', NULL, 0, 130.00),
('1 Pinta', NULL, 1, 220.00),
('2 Pintas', NULL, 0, 250.00),
('2 Pintas', NULL, 1, 375.00),
('1/2 Galon', NULL, 0, 350.00),
('1/2 Galon', NULL, 1, 700.00),
('Tarta Pequena', NULL, NULL, 425.00),
('Tarta Grande', NULL, NULL, 650.00),
('Tarta Especial', NULL, NULL, 800.00),
('Smoothie', 'Producto Yogen', NULL, 150.00),
('Frozen Yogurt Pequeno', 'Producto Yogen', NULL, 85.00),
('Frozen Yogurt Mediano', 'Producto Yogen', NULL, 135.00),
('Frozen Yogurt Pequeno', 'Producto Yogen', NULL, 175.00);

/*Sabores*/
INSERT INTO SaborHelado (nombre, temporal, etiqueta_negra)
VALUES ('Bizcocho', 0, 0),
        ('Brownie', 0, 0),
        ('Caramelo', 0, 0),
        ('Caramelo Crunch', 0, 0),
        ('Chicle', 0, 0),
        ('Chinola', 0, 0),
        ('Chispeado de Chocolata', 0, 0),
        ('Chocolate', 0, 0),
        ('Chocolate Pricila', 0, 0),
        ('Ciruela', 0, 0),
        ('Fresa', 0, 0),
        ('Galletas y Crema', 0, 0),
        ('Naranja - Piña', 0, 0),
        ('Ron Pasas', 0, 0),
        ('Sonrisa de Guanabana', 1, 0),
        ('Sonrisa de Guayaba', 1, 0),
        ('Tres Leches', 0, 0),
        ('Vainilla', 0, 0),
        ('Cafe Organico', 0, 1),
        ('Chocolate Organico', 0, 1),
        ('Fresa Natural', 0, 1),
        ('Fruta del Bosque', 0, 1),
        ('Imperial de Vainilla', 0, 1),
        ('Nuez de Macadamia', 0, 1),
        ('Pistacho', 0, 1)

/* Ventas */
INSERT INTO Venta VALUES 
(1, 1, '3/23/2013', '09:15:00', 'Efectivo'),
(NULL, 1, '3/23/2013', '09:20:23', 'Tarjeta'),
(NULL, 1, '3/23/2013', '10:01:42', 'Tarjeta'),
(NULL, 1, '3/23/2013', '10:03:22', 'Tarjeta'),
(2, 1, '3/23/2013', '10:20:43', 'Efectivo'),
(NULL, 1, '3/23/2013', '10:30:10', 'Efectivo'),
(NULL, 1, '3/23/2013', '10:35:22', 'Efectivo'),
(NULL, 1, '3/23/2013', '10:45:32', 'Tarjeta'),
(NULL, 1, '3/23/2013', '11:10:04', 'Efectivo'),
(1, 1, '3/23/2013', '11:25:34', 'Efectivo'),
(NULL, 1, '3/23/2013', '11:30:11', 'Efectivo'),
(NULL, 1, '3/23/2013', '11:45:12', 'Efectivo'),
(NULL, 1, '3/23/2013', '11:55:12', 'Efectivo'),
(NULL, 2, '3/23/2013', '12:05:23', 'Efectivo'),
(NULL, 2, '3/23/2013', '12:23:11', 'Efectivo'),
(NULL, 2, '3/23/2013', '12:50:05', 'Tarjeta'),
(NULL, 2, '3/23/2013', '13:03:12', 'Efectivo'),
(NULL, 2, '3/23/2013', '13:10:43', 'Efectivo'),
(NULL, 2, '3/23/2013', '13:15:32', 'Efectivo'),
(NULL, 2, '3/23/2013', '13:24:43', 'Tarjeta'),
(NULL, 2, '3/23/2013', '13:37:23', 'Efectivo'),
(NULL, 2, '3/23/2013', '13:46:23', 'Efectivo'),
(NULL, 2, '3/23/2013', '13:55:09', 'Efectivo'),
(NULL, 2, '3/23/2013', '14:03:05', 'Efectivo'),
(NULL, 2, '3/23/2013', '14:15:03', 'Efectivo'),
(NULL, 2, '3/23/2013', '14:20:02', 'Tarjeta'),
(NULL, 2, '3/23/2013', '14:23:03', 'Efectivo'),
(NULL, 2, '3/23/2013', '14:32:02', 'Efectivo'),
(NULL, 2, '3/23/2013', '14:42:33', 'Efectivo');

/*Registro Inventario*/
INSERT INTO RegistroInventario
VALUES ('Barquilla Barquito', '08-10-2013'),
        ('Barquilla Danesa', '08-10-2013'),
        ('Barquilla Bonito', '08-10-2013'),
        ('Barquilla Barquito', '08-10-2013'),
        ('Envase Cajita ET', '08-10-2013'),
        ('Envase Cajita EN', '08-10-2013'),
        ('Envase Super Sunday ET', '08-10-2013'),
        ('Envase Super Sundae EN', '08-10-2013'),
        ('Envase Malteada ET', '08-10-2013'),
        ('Envase Malteada EN', '08-10-2013'),
        ('Envase 1 Pinta ET', '08-10-2013'),
        ('Envase 1 Pinta EN', '08-10-2013'),
        ('Envase 2 Pinta ET', '08-10-2013'),
        ('Envase 2 Pinta EN', '08-10-2013'),
        ('Envase 1/2 Galon ET', '08-10-2013'),
        ('Envase 1/2 Galon EN', '08-10-2013'),
        ('Tarta Helada Tradicional Peq.', '08-10-2013'),
        ('Tarta Helada Tradicional Grd.', '08-10-2013'),
        ('Tarta Helada Especial Peq.', '08-10-2013'),
        ('Tarta Helada Especial Grd.', '08-10-2013')
