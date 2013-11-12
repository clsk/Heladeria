CREATE DATABASE heladeria;
 
USE heladeria;
/* ======= DDL ====== */

/* DROP all Tables */

drop table INFO;
drop table Venta_Productos
drop table Venta_Ofertas;
drop table RegistroInventario_Productos;
drop table Orden_Productos;
drop table SaborHelado;
drop table OfertaPorciento;
drop table NFC;
drop table Oferta;
drop table RegistroInventario;
drop table Venta;
drop table Orden;
drop table Suplidor;
drop table Producto;
drop table Caja;
drop table Cliente;
drop table Empleado;
drop table Turno;

/* Create Tables */

CREATE TABLE INFO (
	llave varchar(50) PRIMARY KEY NOT NULL,
	valor text
);

/* 0x01 = Domingo, 0x02 = Lunes, 0x04 = Martes, 0x08 = JMiercoles, 0x010 = Jueves, 0x020 = Viernes, 0x40 = Sabado */
/* 1 = Domingo, 2 = Lunes, 4 = Martes, 8 = Miercoles,  16 = Jueves, 32 = Viernes, 64 = Sabado */
/* Todos los dias = 127, Lunes a Viernes =  62, Sabados y Domingos = 65 */
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
	tipo_identificacion varchar(30) CHECK(tipo_identificacion IN('cedula', 'pasaporte')),
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
	supervisor BIT DEFAULT 0,
	constraint empleado_turno_fk FOREIGN KEY (turno_id) REFERENCES Turno(turno_id)
);

CREATE TABLE Caja (
	caja_id INT identity(1,1) PRIMARY KEY NOT NULL,
	empleado_id INT NOT NULL,
	cash_entrada money NOT NULL,
	estado BIT DEFAULT 1 NOT NULL, -- 1 = abierta, 0 = cerrada
	fecha_abre DATETIME NOT NULL DEFAULT GETDATE(),
	fecha_cierra DATETIME,
	constraint caja_empleado_fk FOREIGN KEY (empleado_id) REFERENCES Empleado(empleado_id)
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
    provincia VARCHAR(50),
	no_tarjeta SMALLINT, -- ultimos 4 digitos
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
 
CREATE TABLE RegistroInventario_Productos(
    producto_id INT NOT NULL,
    inventario_id INT NOT NULL,
    cantidad DECIMAL(10, 2) NOT NULL,
    CONSTRAINT Producto_RegistroInventario_pk PRIMARY KEY (producto_id, inventario_id),
    CONSTRAINT producto_fk FOREIGN KEY (producto_id) REFERENCES Producto(producto_id),
    CONSTRAINT inventario_fk FOREIGN KEY (inventario_id) REFERENCES RegistroInventario(inventario_id)
);

CREATE TABLE Suplidor (
	suplidor_id INT NOT NULL PRIMARY KEY identity(1,1),
	nombre varchar(30) NOT NULL,
	descripcion varchar(30),
	calle varchar(50),
	calle_no varchar(30),
	ciudad varchar(50),
	provincia varchar(50),
	telefono varchar(16)
)

CREATE TABLE Orden(
	orden_id INT identity(1,1) PRIMARY KEY NOT NULL,
	empleado_id INT NOT NULL,
	suplidor_id INT NOT NULL,
	NOTAS TEXT,
	aceptada BIT DEFAULT 0,
	fecha_aceptada DATE,
	despachada BIT DEFAULT 0,
	fecha_despachada DATE,
	recibida BIT DEFAULT 0,
	fecha_recibida DATE,
	constraint orden_empleado_fk FOREIGN KEY (empleado_id) REFERENCES Empleado(empleado_id),
	constraint orden_suplidor_fk FOREIGN KEY (suplidor_id) REFERENCES Suplidor(suplidor_id)
);

CREATE TABLE Orden_Productos (
	orden_id INT NOT NULL,
	producto_id INT NOT NULL,
	cantidad INT NOT NULL,
	CONSTRAINT orden_producto_pk PRIMARY KEY (orden_id, producto_id),
	CONSTRAINT orden_producto_orden_fk FOREIGN KEY (orden_id) REFERENCES Orden(orden_id),
	CONSTRAINT orden_produto_producto_fk FOREIGN KEY (producto_id) REFERENCES Producto(producto_id)
);

CREATE TABLE Venta(
    venta_id BIGINT identity(1,1) PRIMARY KEY NOT NULL,
    cliente_id INT,
    caja_id INT NOT NULL,
    fecha DATETIME NOT NULL,
    forma_pago VARCHAR(50) CHECK (forma_pago IN('efectivo', 'tarjeta')) NOT NULL,
	total money DEFAULT 0.00,
    CONSTRAINT venta_cliente_fk FOREIGN KEY (cliente_id) REFERENCES Cliente(cliente_id),
    CONSTRAINT venta_caja_fk FOREIGN KEY (caja_id) REFERENCES Caja(caja_id)
);

CREATE TABLE Venta_Productos(
    venta_id BIGINT NOT NULL,
    producto_id INT NOT NULL,
    cantidad INT NOT NULL,
    CONSTRAINT venta_productos_pk PRIMARY KEY (venta_id, producto_id),
    CONSTRAINT venta_id_fk FOREIGN KEY (venta_id) REFERENCES Venta(venta_id),
    CONSTRAINT producto_id_fk FOREIGN KEY (producto_id) REFERENCES Producto(producto_id)
);

CREATE TABLE NFC(
    no_nfc INT PRIMARY KEY NOT NULL,
	venta_id BIGINT UNIQUE NOT NULL,
	CONSTRAINT nfc_venta FOREIGN KEY (venta_id) REFERENCES Venta (venta_id) ON DELETE CASCADE
);
 
CREATE TABLE Oferta(
    oferta_id INT PRIMARY KEY identity(1,1) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    descripcion VARCHAR(200),
    fecha_empieza DATE NOT NULL,
    fecha_termina DATE NOT NULL,
	dias_disponible INT NOT NULL, -- BIT MASK
	hora_disponible_empieza TIME NOT NULL,
	hora_disponible_termina TIME NOT NULL,
	cantidad_maxima INT,
	cantidad_minima INT, 
	producto_id INT NOT NULL,
	tipo varchar(20) NOT NULL CHECK (tipo IN ('2x1', 'porciento')),
	constraint oferta_producto_pk FOREIGN KEY (producto_id) REFERENCES Producto(producto_id) 
);
 
CREATE TABLE OfertaPorciento(
    oferta_id INT PRIMARY KEY NOT NULL,
	porciento DECIMAL(10,2) NOT NULL,
	constraint porciento_oferta_fk FOREIGN KEY (oferta_id) REFERENCES Oferta(oferta_id)
);


CREATE TABLE Venta_Ofertas (
	venta_id BIGINT NOT NULL,
	oferta_id INT NOT NULL,
	rebaja money NOT NULL,
	constraint venta_ofertas_pk PRIMARY KEY (venta_id, oferta_id),
	constraint venta_ofertas_oferta_fk FOREIGN KEY (oferta_id) REFERENCES Oferta(oferta_id),
	constraint venta_ofertas_venta_fk FOREIGN KEY (venta_id) REFERENCES Venta(venta_id)
)


/* ============== STORED PROCEDURES ========================= */

use heladeria;
drop proc sp_InsertSaborHelado
CREATE PROCEDURE sp_InsertSaborHelado @nombre varchar(50), @descripcion varchar(100) = null, @etiqueta_negra bit = 0, 
				 @precio_compra money, @temporal bit = 0, @principio_temporada date = null, @fin_temporada date = null
AS
BEGIN
	INSERT INTO Producto(nombre, descripcion, etiqueta_negra, precio_venta, precio_compra) 
	VALUES (@nombre, @descripcion, @etiqueta_negra, null, @precio_compra);
	
	INSERT INTO SaborHelado(producto_id, temporal, principio_temporada, fin_temporada) 
	VALUES(@@IDENTITY, @temporal, @principio_temporada, @fin_temporada);
END

EXEC sp_InsertSaborHelado @nombre = 'Chocolate', @precio_compra = 300.00;
EXEC sp_InsertSaborHelado @nombre = 'Vainilla', @precio_compra = 300.00;
EXEC sp_InsertSaborHelado @nombre = 'Fresa', @precio_compra = 300.00;
EXEC sp_InsertSaborHelado @nombre = 'Mantecado', @precio_compra = 300.00;

/*Procedure para Reporte de Cierres de Caja*/
CREATE PROCEDURE sp_CajaCerrada
	(
		@fc_Inicia DATETIME,
		@fc_Termina DATETIME
	)
AS
BEGIN
	(
		SELECT Caja.caja_id, Caja.fecha_cierra, Caja.cash_entrada , Empleado.nombre, Empleado.apellido
		FROM Caja INNER JOIN Empleado
		ON Caja.empleado_id=Empleado.empleado_id
		WHERE Caja.fecha_cierra BETWEEN @fc_Inicia AND @fc_Termina
	)
END

DROP PROCEDURE sp_CajaCerrada;

EXECUTE sp_CajaCerrada @fc_Inicia = '2013/03/23', @fc_Termina = '2013/03/25'


/*Procedure para Reporte de Comprobantes Usados*/

CREATE PROCEDURE sp_ComprobantesRegistrados 
	(
		@fc_desde DATETIME,
		@fc_hasta DATETIME
	)
AS
BEGIN
	(
		SELECT NFC.no_nfc, Cliente.nombre, Cliente.RNC, Venta.total, (Venta.total * 0.18) as MontoITBIS
		FROM NFC INNER JOIN Venta
		ON NFC.venta_id=Venta.venta_id INNER JOIN Cliente
		ON Cliente.cliente_id=Venta.cliente_id
		WHERE Venta.fecha BETWEEN @fc_desde AND @fc_hasta
	)
END

DROP PROCEDURE sp_ComprobantesRegistrados;

EXECUTE sp_ComprobantesRegistrados @fc_desde = '2013/03/23', @fc_hasta = '2013/03/25'

/* ============== Triggers =================================*/

drop trigger trg_CalcularTotalVenta
CREATE TRIGGER trg_CalcularTotalVenta
ON Venta_Productos
AFTER INSERT
AS
BEGIN
	
	declare @total_actual AS INT, @precio_producto AS INT, @cantidad_producto AS INT, @venta_id AS INT, @rebaja AS MONEY, @venta_fecha AS DATETIME;
	select @venta_id = venta_id, @cantidad_producto = cantidad FROM inserted;
	select @total_actual = total, @venta_fecha = fecha FROM Venta WHERE venta_id = @venta_id;
	select @precio_producto = precio_venta FROM Producto WHERE producto_id = (SELECT producto_id FROM inserted);


	-- Aplicar precio producto a venta totals
	SET @total_actual = @total_actual + (@precio_producto * @cantidad_producto);

	-- Revisar si hay ofertas que se apliquen a este producto
    declare @oferta_id as INT, @oferta_tipo as varchar(20);
	SELECT TOP 1 @oferta_id = oferta_id, @oferta_tipo = tipo from Oferta WHERE producto_id = (select producto_id from inserted) AND 
														(@venta_fecha BETWEEN Oferta.fecha_empieza AND Oferta.fecha_termina) AND
														(CONVERT(TIME, @venta_fecha) BETWEEN hora_disponible_empieza AND hora_disponible_termina) AND
														(dias_disponible & POWER(2, DATEPART(DW, @venta_fecha-1)) > 0);
	PRINT @oferta_id


	IF (@oferta_id IS NOT NULL)
	BEGIN
		IF (@oferta_tipo = '2x1')
		BEGIN
			SET @rebaja = @precio_producto * (@cantidad_producto / 2);
			IF @rebaja > 0
				INSERT INTO Venta_Ofertas (venta_id, oferta_id, rebaja) VALUES (@venta_id, @oferta_id, @rebaja);
			ELSE
				SET @rebaja = NULL;
		END
		ELSE
		IF (@oferta_tipo = 'porciento')
		BEGIN
			declare @porciento AS INT;
			set @porciento = (SELECT porciento FROM OfertaPorciento WHERE oferta_id = @oferta_id) / 100;
			SET @rebaja = @precio_producto * @porciento * @cantidad_producto;
			INSERT INTO Venta_Ofertas (venta_id, oferta_id, rebaja) VALUES (@venta_id, @oferta_id, @rebaja);
		END
	END
	IF (@rebaja IS NOT NULL)
		UPDATE Venta SET total = (@total_actual - @rebaja) WHERE venta_id = @venta_id;
	ELSE
		UPDATE Venta SET total = @total_actual WHERE venta_id = @venta_id;
END


/* ============== INTRODUCCION DE DATOS ===================== */

/* Turnos */
INSERT INTO Turno VALUES ('Semana manana', 31, '09:00:00', '13:00:00');
INSERT INTO Turno VALUES ('Semana Tarde', 31, '13:00:00', '18:00:00');

/* Empleados */
-- TODO: introducir correos y cedulas
INSERT INTO Empleado(no_identificacion, tipo_identificacion, correo, password, nombre, apellido, telefono, calle, no_casa, sector, ciudad, provincia, turno_id, supervisor) VALUES 
('001-1493849-1', 'cedula', 'aalvarez@bon.com.do', '0b530ea2fea822b77d5a910956bc1db9', 'Alan', 'Alvarez', '809-482-5924', 'calle 5', '#4 Residencial Las Flores APTO 5A', 'Los Jardines', 'D.N.', 'Santo Domingo', 1, 1),
('001-1494939-1', 'cedula', 'rmartinez@bon.com.do', '0b530ea2fea822b77d5a910956bc1db9', 'Ramon', 'Martinez', '809-820-9857', 'calle 8', '#25', 'Los Alcarrizos', 'D.N.', 'Santo Domingo', 2, 0),
('001-4391939-7', 'Cedula', 'lpeguero@bon.com.do', '0b530ea2fea822b77d5a910956bc1db9', 'Laide', 'Peguero', '809-394-2119', 'San Francisdo de Macoris', 'Gazcue', 'D. N', 'Santo Domingo', 'Manz. CQ Edif. 2', 1, 0),
('223-4896545-1', 'Cedula', 'mpena@bon.com.do', '0b530ea2fea822b77d5a910956bc1db9', 'Manuela', 'Pena', '809-213-2213', 'Rep. de Paraguay', 'Ens. La Fe', 'D. N.', 'Santo Domingo', 'No. 123', 2, 1),
('223-5211298-1', 'Cedula', 'llugo@bon.com.do', '0b530ea2fea822b77d5a910956bc1db9', 'Lissanna', 'Lugo', '809-424-3923', 'Av. Bolivar', 'Ens. Evaristo Morales', 'D. N.', 'Santo Domingo', 'Edif. Rojo Apart. 21', 2, 0);

/* Clientes */
INSERT INTO Cliente(nombre, apellido, telefono, correo, RNC, calle, no_casa, sector, ciudad, provincia) VALUES 
('Alex', 'Figuereo', '829-458-2948', 'afiguereo@correo.com', '130156964', 'Calle F', '#65', 'Bella Vista', 'Santo Domingo', 'D.N.'),
('Ramon', 'Alcantara', '829-432-9481', 'ra@correo.com', '184930485', 'Calle C', '#89', 'Naco', 'Santo Domingo', 'D.N.');

/*-----> Insercion de Registros a la Tabla de Caja*/
INSERT INTO Caja (empleado_id, cash_entrada, estado, fecha_abre, fecha_cierra) VALUES
(1, 10000.00, 0, '3/23/2013 09:00:00', '3/23/2013 13:00:00'),
(2, 10000.00, 0, '3/23/2013 13:00:00', '3/23/2013 18:00:00')

INSERT INTO Caja (empleado_id, cash_entrada, estado, fecha_abre, fecha_cierra) VALUES
(5, 23568, 0, '1/1/2013 08:30:00', '1/1/2013 12:30:00'),
(4, 19183, 0, '1/2/2013 13:00:00', '1/2/2013 19:30:00'),
(2, 13821, 0, '1/3/2013 08:30:00', '1/3/2013 12:30:00'),
(3, 17371, 0, '1/4/2013 13:00:00', '1/4/2013 19:30:00'),
(3, 18885, 0, '1/5/2013 08:30:00', '1/5/2013 12:30:00'),
(4, 19172, 0, '1/6/2013 13:00:00', '1/6/2013 19:30:00'),
(1, 11357, 0, '1/7/2013 08:30:00', '1/7/2013 12:30:00'),
(3, 17288, 0, '1/8/2013 13:00:00', '1/8/2013 19:30:00'),
(1, 10438, 0, '1/9/2013 08:30:00', '1/9/2013 12:30:00'),
(4, 21283, 0, '1/10/2013 13:00:00', '1/10/2013 19:30:00'),
(1, 12288, 0, '1/11/2013 08:30:00', '1/11/2013 12:30:00'),
(1, 11317, 0, '1/12/2013 13:00:00', '1/12/2013 19:30:00'),
(5, 23353, 0, '1/13/2013 08:30:00', '1/13/2013 12:30:00'),
(5, 24670, 0, '1/14/2013 13:00:00', '1/14/2013 19:30:00'),
(1, 11414, 0, '1/15/2013 08:30:00', '1/15/2013 12:30:00'),
(2, 14339, 0, '1/16/2013 13:00:00', '1/16/2013 19:30:00'),
(4, 20134, 0, '1/17/2013 08:30:00', '1/17/2013 12:30:00'),
(4, 19155, 0, '1/18/2013 13:00:00', '1/18/2013 19:30:00'),
(2, 14317, 0, '1/19/2013 08:30:00', '1/19/2013 12:30:00'),
(2, 13349, 0, '1/20/2013 13:00:00', '1/20/2013 19:30:00'),
(2, 15247, 0, '1/21/2013 08:30:00', '1/21/2013 12:30:00'),
(3, 16657, 0, '1/22/2013 13:00:00', '1/22/2013 19:30:00'),
(2, 15128, 0, '1/23/2013 08:30:00', '1/23/2013 12:30:00'),
(5, 23675, 0, '1/24/2013 13:00:00', '1/24/2013 19:30:00'),
(5, 22269, 0, '1/25/2013 08:30:00', '1/25/2013 12:30:00'),
(5, 22852, 0, '1/26/2013 13:00:00', '1/26/2013 19:30:00'),
(2, 15074, 0, '1/27/2013 08:30:00', '1/27/2013 12:30:00'),
(4, 21119, 0, '1/28/2013 13:00:00', '1/28/2013 19:30:00'),
(5, 23377, 0, '1/29/2013 08:30:00', '1/29/2013 12:30:00'),
(3, 18386, 0, '2/1/2013 13:00:00', '2/1/2013 19:30:00'),
(4, 19953, 0, '2/2/2013 08:30:00', '2/2/2013 12:30:00'),
(5, 23249, 0, '2/3/2013 13:00:00', '2/3/2013 19:30:00'),
(2, 15237, 0, '2/4/2013 08:30:00', '2/4/2013 12:30:00'),
(3, 17320, 0, '2/5/2013 13:00:00', '2/5/2013 19:30:00'),
(5, 23436, 0, '2/6/2013 08:30:00', '2/6/2013 12:30:00'),
(5, 24229, 0, '2/7/2013 13:00:00', '2/7/2013 19:30:00'),
(2, 14016, 0, '2/8/2013 08:30:00', '2/8/2013 12:30:00'),
(2, 14907, 0, '2/9/2013 13:00:00', '2/9/2013 19:30:00'),
(1, 11506, 0, '2/10/2013 08:30:00', '2/10/2013 12:30:00'),
(5, 23499, 0, '2/11/2013 13:00:00', '2/11/2013 19:30:00'),
(3, 16028, 0, '2/12/2013 08:30:00', '2/12/2013 12:30:00'),
(3, 17004, 0, '2/13/2013 13:00:00', '2/13/2013 19:30:00'),
(4, 19540, 0, '2/14/2013 08:30:00', '2/14/2013 12:30:00'),
(4, 20178, 0, '2/15/2013 13:00:00', '2/15/2013 19:30:00'),
(1, 12699, 0, '2/16/2013 08:30:00', '2/16/2013 12:30:00'),
(1, 12272, 0, '2/17/2013 13:00:00', '2/17/2013 19:30:00'),
(5, 22147, 0, '2/18/2013 08:30:00', '2/18/2013 12:30:00'),
(4, 21613, 0, '2/19/2013 13:00:00', '2/19/2013 19:30:00'),
(3, 18964, 0, '2/20/2013 08:30:00', '2/20/2013 12:30:00'),
(4, 19041, 0, '2/21/2013 13:00:00', '2/21/2013 19:30:00'),
(1, 11151, 0, '2/22/2013 08:30:00', '2/22/2013 12:30:00'),
(2, 14804, 0, '2/23/2013 13:00:00', '2/23/2013 19:30:00'),
(4, 19887, 0, '2/24/2013 08:30:00', '2/24/2013 12:30:00'),
(3, 17795, 0, '2/25/2013 13:00:00', '2/25/2013 19:30:00'),
(2, 15817, 0, '2/26/2013 08:30:00', '2/26/2013 12:30:00'),
(3, 16911, 0, '2/27/2013 13:00:00', '2/27/2013 19:30:00'),
(2, 14055, 0, '2/28/2013 08:30:00', '2/28/2013 12:30:00'),
(4, 20102, 0, '3/1/2013 08:30:00', '3/1/2013 12:30:00'),
(4, 21032, 0, '3/2/2013 13:00:00', '3/2/2013 19:30:00'),
(2, 14098, 0, '3/3/2013 08:30:00', '3/3/2013 12:30:00'),
(2, 15238, 0, '3/4/2013 13:00:00', '3/4/2013 19:30:00'),
(3, 18910, 0, '3/5/2013 08:30:00', '3/5/2013 12:30:00'),
(3, 17052, 0, '3/6/2013 13:00:00', '3/6/2013 19:30:00'),
(1, 11329, 0, '3/7/2013 08:30:00', '3/7/2013 12:30:00'),
(2, 14038, 0, '3/8/2013 13:00:00', '3/8/2013 19:30:00'),
(4, 21079, 0, '3/9/2013 08:30:00', '3/9/2013 12:30:00'),
(3, 16032, 0, '3/10/2013 13:00:00', '3/10/2013 19:30:00')


/* Productos */
INSERT INTO Producto(nombre, descripcion, etiqueta_negra, precio_venta, precio_compra) VALUES 
('Barquito', NULL, 0, 100.00, 50.00),
('Barquito', NULL, 1, 150.00, 50.00),
('Barquito Abordado', NULL, 0, 120.00, 60.00),
('Barquito Abordado', NULL, 1, 175.00, 60.00),
('Barquilla Danesa', NULL, 0, 50.00, 25.00),
('Barquilla Danesa', NULL, 1, 100.00, 25.00),
('Bonito', NULL, 0, 50.00, 25.00),
('Bonito', NULL, 1, 70.00, 25.00),
('Cajita', '4 onz', 0, 50.00, 25.00),
('Cajita', '4 onz', 1, 90.00, 25.00),
('Super Sundae', NULL, 0, 130.00, 60.00),
('Super Sundae', NULL, 1, 150.00, 60.00),
('Malteada', NULL, 0, 100.00, 50.00),
('Malteada', NULL, 1, 150.00, 50.00),
('1 Pinta', NULL, 0, 130.00, 60.00),
('1 Pinta', NULL, 1, 220.00, 110.00),
('2 Pintas', NULL, 0, 250.00, 120.00),
('2 Pintas', NULL, 1, 375.00, 2000.00),
('1/2 Galon', NULL, 0, 350.00, 170.00),
('1/2 Galon', NULL, 1, 700.00, 250.00),
('Tarta Pequena', NULL, NULL, 425.00, 200.00),
('Tarta Grande', NULL, NULL, 650.00, 300.00),
('Tarta Especial', NULL, NULL, 800.00, 400.00),
('Smoothie', 'Producto Yogen', NULL, 150.00, 70.00),
('Frozen Yogurt Pequeno', 'Producto Yogen', NULL, 85.00, 40.00),
('Frozen Yogurt Mediano', 'Producto Yogen', NULL, 135.00, 70.00),
('Frozen Yogurt Pequeno', 'Producto Yogen', NULL, 175.00, 85.00);


/* Ventas */
INSERT INTO Venta(cliente_id, caja_id, fecha, forma_pago) VALUES 
(1, 1, '3/23/2013 09:15:00', 'efectivo'),
(NULL, 1, '3/23/2013 09:20:23', 'tarjeta'),
(NULL, 1, '3/23/2013 10:01:42', 'tarjeta'),
(NULL, 1, '3/23/2013 10:03:22', 'tarjeta'),
(2, 1, '3/23/2013 10:20:43', 'efectivo'),
(NULL, 1, '3/23/2013 10:30:10', 'efectivo'),
(NULL, 1, '3/23/2013 10:35:22', 'efectivo'),
(NULL, 1, '3/23/2013 10:45:32', 'tarjeta'),
(NULL, 1, '3/23/2013 11:10:04', 'efectivo'),
(1, 1, '3/23/2013 11:25:34', 'efectivo'),
(NULL, 1, '3/23/2013 11:30:11', 'efectivo'),
(NULL, 1, '3/23/2013 11:45:12', 'efectivo'),
(NULL, 1, '3/23/2013 11:55:12', 'efectivo'),
(NULL, 1, '3/23/2013 12:05:23', 'efectivo'),
(NULL, 1, '3/23/2013 12:23:11', 'efectivo'),
(NULL, 1, '3/23/2013 12:50:05', 'tarjeta'),
(NULL, 2, '3/23/2013 13:03:12', 'efectivo'),
(NULL, 2, '3/23/2013 13:10:43', 'efectivo'),
(NULL, 2, '3/23/2013 13:15:32', 'efectivo'),
(NULL, 2, '3/23/2013 13:24:43', 'tarjeta'),
(NULL, 2, '3/23/2013 13:37:23', 'efectivo'),
(NULL, 2, '3/23/2013 13:46:23', 'efectivo'),
(NULL, 2, '3/23/2013 13:55:09', 'efectivo'),
(NULL, 2, '3/23/2013 14:03:05', 'efectivo'),
(NULL, 2, '3/23/2013 14:15:03', 'efectivo'),
(NULL, 2, '3/23/2013 14:20:02', 'tarjeta'),
(NULL, 2, '3/23/2013 14:23:03', 'efectivo'),
(NULL, 2, '3/23/2013 14:32:02', 'efectivo'),
(NULL, 2, '3/23/2013 14:42:33', 'efectivo');

/* Test venta trigger */
select * from venta;
select * from Venta_Productos
select * from Venta_Ofertas;
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (1, 1, 7);
select * from Oferta

UPDATE Venta SET total = 0.00
delete from Venta_Productos
delete from Venta_Ofertas;
/* END OF Test venta trigger */

insert into Oferta(nombre, descripcion, fecha_empieza, fecha_termina, dias_disponible, hora_disponible_empieza, hora_disponible_termina, producto_id, tipo) VALUES 
('2x1 Barquito', '2x1 en barquitos', '3/1/2013', '3/30/2013', 127, '09:00:00', '18:00:00', 1, '2x1');

select * from Venta


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


/* Queries (para reportes) */

-- Ventas
DECLARE @fecha_empieza AS DATETIME, @fecha_termina AS DATETIME;
SET @fecha_empieza = '3/1/2013';
SET @fecha_termina = '3/31/2013'
SELECT Venta.venta_id, Venta.fecha, Venta.forma_pago, Cliente.nombre + ' ' +  Cliente.apellido AS Cliente, Venta.total  FROM Venta LEFT JOIN Cliente ON Venta.cliente_id = Cliente.cliente_id WHERE Venta.fecha BETWEEN @fecha_empieza AND @fecha_termina; 

drop function maskToDias
CREATE FUNCTION maskToDias (@mask AS INT)
RETURNS VARCHAR(60)
BEGIN
	DECLARE @ret AS VARCHAR(60)
	SET @ret = ''
	IF (@mask & 1 = 1)
		SET @ret = @ret + 'Domingo, '
	IF (@mask & 2 = 2)
		SET @ret = @ret + 'Lunes, '
	IF (@mask & 4 = 4)
		SET @ret = @ret + 'Martes, '
	IF (@mask & 8 = 8)
		SET @ret = @ret + 'Miercoles, '
	IF (@mask & 16 = 16)
		SET @ret = @ret + 'Jueves, '
	IF (@mask & 32 = 32)
		SET @ret = @ret + 'Viernes, '
	IF (@mask & 64 = 64)
		SET @ret = @ret + 'Sabado,'

	IF (LEN(@ret) > 0)
		RETURN SUBSTRING(@ret, 1, LEN(@ret) - 1);
	
	RETURN @ret
END

-- Ofertas
SELECT Venta_Ofertas.oferta_id, Oferta.nombre FROM Venta_Ofertas INNER JOIN Oferta ON Venta_Ofertas.oferta_id = Oferta.oferta_id;
SELECT Oferta.oferta_id, Oferta.nombre, Oferta.fecha_empieza, Oferta.fecha_termina, dbo.maskToDias(Oferta.dias_disponible) AS 'Dias Disponible', (SELECT COUNT(*) FROM Venta_Ofertas WHERE oferta_id = Oferta.oferta_id) AS Cantidad FROM Oferta