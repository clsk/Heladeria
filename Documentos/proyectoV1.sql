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
drop table NCF;
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
	cargo varchar(20) CHECK(cargo IN('vendedor', 'supervisor','delivery')),
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

 CREATE TABLE Producto(
    producto_id INT identity(1,1) PRIMARY KEY NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    descripcion VARCHAR(100),
	etiqueta_negra BIT DEFAULT 0,
    precio_venta money,
	precio_compra money,
	punto_reorden DECIMAL(10, 2),
	suplidor INT,
	CONSTRAINT producto_suplidor_fk FOREIGN KEY (suplidor) REFERENCES Suplidor(suplidor_id)
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
	fecha_entrega DATETIME,
    forma_pago VARCHAR(50) CHECK (forma_pago IN('efectivo', 'tarjeta')) NOT NULL,
	total money DEFAULT 0.00,
	entregado_por INT,
    CONSTRAINT venta_cliente_fk FOREIGN KEY (cliente_id) REFERENCES Cliente(cliente_id),
    CONSTRAINT venta_caja_fk FOREIGN KEY (caja_id) REFERENCES Caja(caja_id),
	CONSTRAINT venta_empleado_fk FOREIGN KEY (entregado_por) REFERENCES Empleado(empleado_id)
);

CREATE TABLE Venta_Productos(
    venta_id BIGINT NOT NULL,
    producto_id INT NOT NULL,
    cantidad INT NOT NULL,
    CONSTRAINT venta_productos_pk PRIMARY KEY (venta_id, producto_id),
    CONSTRAINT venta_id_fk FOREIGN KEY (venta_id) REFERENCES Venta(venta_id),
    CONSTRAINT producto_id_fk FOREIGN KEY (producto_id) REFERENCES Producto(producto_id)
);

CREATE TABLE NCF(
    no_NCF VARCHAR (25) PRIMARY KEY NOT NULL,
	venta_id BIGINT UNIQUE NOT NULL,
	CONSTRAINT NCF_venta FOREIGN KEY (venta_id) REFERENCES Venta (venta_id) ON DELETE CASCADE
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
	codigo_cupon varchar(10),
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

/*Procedure para Reporte de Cierre de Caja*/
CREATE PROCEDURE sp_CajaCerrada
	(
		@empleado_id INT,
		@fecha DATE,
		@cash_salida AS money
	)
AS
BEGIN
	(
		SELECT Caja.caja_id, Caja.fecha_abre, Caja.cash_entrada , Empleado.nombre, Empleado.apellido,
		(
			SELECT SUM (venta.total)
			FROM Venta
			WHERE Venta.caja_id = Caja.caja_id AND Venta.forma_pago = 'efectivo'
		) as TotalVentas, (@cash_salida-(Caja.cash_entrada+
		(SELECT SUM (venta.total) FROM Venta WHERE Venta.caja_id = Caja.caja_id AND Venta.forma_pago = 'efectivo')
		)) AS Balance
		FROM Caja INNER JOIN Empleado
		ON Caja.empleado_id=Empleado.empleado_id
		WHERE Empleado.empleado_id = @empleado_id AND CONVERT(DATE, Caja.fecha_abre) = @fecha
	)
END

select * from Caja
EXEC sp_CajaCerrada @empleado_id = 1, @fecha = '2013/3/23', @cash_salida = 12000.00 

DROP PROCEDURE sp_CajaCerrada;

EXECUTE sp_CajaCerrada @fc_Inicia = '2013/03/23', @fc_Termina = '2013/03/25'


/*Procedure para Reporte de Comprobantes Usados*/

/*----VERSION CON TABLA CORREGIDA-----*/
CREATE PROCEDURE sp_ComprobantesRegistrados 
	(
		@fc_desde DATETIME,
		@fc_hasta DATETIME
	)
AS
BEGIN
	(
		SELECT NCF.no_NCF, (Cliente.nombre + ' ' + Cliente.apellido) as Cliente, Cliente.RNC, Venta.total, CONVERT(DECIMAL(10,2), (Venta.total * 0.18)) as MontoITBIS
		FROM NCF INNER JOIN Venta
		ON NCF.venta_id=Venta.venta_id INNER JOIN Cliente
		ON Cliente.cliente_id=Venta.cliente_id
		WHERE Venta.fecha BETWEEN @fc_desde AND @fc_hasta
	)
END

DROP PROCEDURE sp_ComprobantesRegistrados;

EXECUTE sp_ComprobantesRegistrados @fc_desde = '2013/03/23', @fc_hasta = '2013/03/25'

use heladeria;
drop PROCEDURE sp_ObetenerNFCParaVenta
CREATE PROCEDURE sp_ObetenerNFCParaVenta @venta_id INT
AS
BEGIN
	DECLARE @no_nfc AS INT
	SELECT @no_nfc = no_nfc FROM NFC WHERE venta_id IS NULL
	IF (@no_nfc IS NOT NULL)
		UPDATE NFC SET venta_id = @venta_id WHERE no_nfc = @no_nfc
	ELSE
		RAISERROR('No Quedan Numeros NFCs disponibles', 1, 1);
	RETURN @no_nfc
END

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



	IF (@oferta_tipo = '2x1')
	BEGIN
		SET @rebaja = @precio_producto * (@cantidad_producto / 2);
		IF @rebaja > 0
			INSERT INTO Venta_Ofertas (venta_id, oferta_id, rebaja) VALUES (@venta_id, @oferta_id, @rebaja);
		ELSE
			SET @rebaja = NULL;
	END
	ELSE IF (@oferta_tipo = 'porciento')
	BEGIN
		declare @porciento AS INT;
		set @porciento = (SELECT porciento FROM OfertaPorciento WHERE oferta_id = @oferta_id) / 100;
		SET @rebaja = @precio_producto * @porciento * @cantidad_producto;
		INSERT INTO Venta_Ofertas (venta_id, oferta_id, rebaja) VALUES (@venta_id, @oferta_id, @rebaja);
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
-- Password is pass123
INSERT INTO Empleado(no_identificacion, tipo_identificacion, correo, password, nombre, apellido, telefono, calle, no_casa, sector, ciudad, provincia, turno_id, cargo) VALUES 
('001-1493849-1', 'cedula', 'aalvarez@bon.com.do', '32250170a0dca92d53ec9624f336ca24', 'Alan', 'Alvarez', '809-482-5924', 'calle 5', '#4 Residencial Las Flores APTO 5A', 'Los Jardines', 'D.N.', 'Santo Domingo', 1, 'supervisor'),
('001-1494939-1', 'cedula', 'rmartinez@bon.com.do', '32250170a0dca92d53ec9624f336ca24', 'Ramon', 'Martinez', '809-820-9857', 'calle 8', '#25', 'Los Alcarrizos', 'D.N.', 'Santo Domingo', 2, 'vendedor'),
('001-4311939-7', 'cedula', 'lpeguero@bon.com.do', '32250170a0dca92d53ec9624f336ca24', 'Laide', 'Peguero', '809-394-2119', 'San Francisdo de Macoris', 'Gazcue', 'D. N', 'Santo Domingo', 'Manz. CQ Edif. 2', 1, 'vendedor'),
('223-4896545-1', 'cedula', 'mpena@bon.com.do', '32250170a0dca92d53ec9624f336ca24', 'Manuela', 'Pena', '809-213-2213', 'Rep. de Paraguay', 'Ens. La Fe', 'D. N.', 'Santo Domingo', 'No. 123', 2, 'supervisor'),
('223-5211298-1', 'cedula', 'llugo@bon.com.do', '32250170a0dca92d53ec9624f336ca24', 'Lissanna', 'Lugo', '809-424-3923', 'Av. Bolivar', 'Ens. Evaristo Morales', 'D. N.', 'Santo Domingo', 'Edif. Rojo Apart. 21', 2, 'vendedor'),
('001-3850284-4', 'cedula', 'ralcantara@bon.com.do', '32250170a0dca92d53ec9624f336ca24', 'Ramon', 'Alcantara', '809-583-2849', 'Calle Estrella', '#85', 'Villa Mella', 'D.N.', 'Santo Domingo', 1, 'delivery');

/* Clientes */
INSERT INTO Cliente(nombre, apellido, telefono, correo, RNC, calle, no_casa, sector, ciudad, provincia) VALUES 
('Alex', 'Figuereo', '829-458-2948', 'afiguereo@correo.com', '130156964', 'Calle F', '#65', 'Bella Vista', 'Santo Domingo', 'D.N.'),
('Ramon', 'Alcantara', '829-432-9481', 'ra@correo.com', '184930485', 'Calle C', '#89', 'Naco', 'Santo Domingo', 'D.N.');


INSERT INTO Cliente(nombre, apellido, telefono, correo, RNC, calle, no_casa, sector, ciudad, provincia) VALUES 
('Ana', 'Gonzalez', '829-123-3489', 'agonz23@yahoo.com', '341-2524731-2', 'Los Robles', 'Edif. Jose, Apart. 21', 'La Julia', 'Santo Domingo', 'D.N'),
('Yunik', 'Rafavelo', '809-482-1381', 'rsayunik@outlook.com', '313-3541652-4', 'Atalaya', 'Casa No. 13', 'La Julia', 'Santo Domingo', 'D.N'),
('Iris', 'Portobelo', '849-342-3489', 'bonito@msn.com', '223-9493423-3', 'Boy Scouts', 'Casa No. 30 ', 'La Yuca', 'Santo Domingo', 'D.N'),
('John', 'Lugo', '809-348-5729', 'gentebuena@gmai.com', '402-4523745-7', 'Jose A. Aybar', 'Torre Casandra', 'La Julia', 'Santo Domingo', 'D.N'),
('Luis', 'Suero', '829-988-5398', 'lioq193@hotmail.es', '001-84882952-0', 'Pedro Henriquez U.', 'Bacno Ademi', 'La Julia', 'Santo Domingo', 'D.N'),
('Ilucion', 'Cuello', '809-889-6323', 'ilu0900@yahoo.com', '402-8609238-5', 'Desiderio Arias', 'Edificio La Luz', 'La Julia', 'Santo Domingo', 'D.N'),
('Keila', 'Montero', '849-219-8429', 'km1505@hotmail.com', '001-5493784-2', 'F. Geraldino esq. Fco. Pratts', '', 'Piantini', 'Santo Domingo', 'D. N'),
('Alberto', 'Baldera', '829-399-8984', 'ab_boy10@hotmail.com', '402-3884902-7', 'Pedro Henriquez', 'Edif. Aurora', 'La Julia', 'Santo Domingo', 'D. N'),
('Antonio', 'Alfau', '809-482-3872', 'aa.negocios@outlook.com', '001-8487582-9', 'Atalaya', 'Casa No. 23', 'La Julia', 'Santo Domingo', 'D. N')

/*-----> Insercion de Registros a la Tabla de Caja*/
INSERT INTO Caja (empleado_id, cash_entrada, estado, fecha_abre, fecha_cierra) 
VALUES
(4, 9386, 0, '2/1/2013 08:30:00', '2/1/2013 12:30:00'),
(3, 7556, 0, '2/1/2013 13:00:00', '2/1/2013 19:30:00'),
(3, 7562, 0, '2/2/2013 08:30:00', '2/2/2013 12:30:00'),
(1, 4093, 0, '2/2/2013 13:00:00', '2/2/2013 19:30:00'),
(5, 10026, 0, '2/3/2013 08:30:00', '2/3/2013 12:30:00'),
(3, 6920, 0, '2/3/2013 13:00:00', '2/3/2013 19:30:00'),
(2, 6258, 0, '2/4/2013 08:30:00', '2/4/2013 12:30:00'),
(1, 5099, 0, '2/4/2013 13:00:00', '2/4/2013 19:30:00'),
(4, 8208, 0, '2/5/2013 08:30:00', '2/5/2013 12:30:00'),
(3, 7299, 0, '2/5/2013 13:00:00', '2/5/2013 19:30:00'),
(2, 6258, 0, '2/6/2013 08:30:00', '2/6/2013 12:30:00'),
(3, 7759, 0, '2/6/2013 13:00:00', '2/6/2013 19:30:00'),
(4, 8824, 0, '2/7/2013 08:30:00', '2/7/2013 12:30:00'),
(3, 8131, 0, '2/7/2013 13:00:00', '2/7/2013 19:30:00'),
(3, 7832, 0, '2/8/2013 08:30:00', '2/8/2013 12:30:00'),
(3, 7742, 0, '2/8/2013 13:00:00', '2/8/2013 19:30:00'),
(1, 4364, 0, '2/9/2013 08:30:00', '2/9/2013 12:30:00'),
(1, 5341, 0, '2/9/2013 13:00:00', '2/9/2013 19:30:00'),
(3, 8065, 0, '2/10/2013 08:30:00', '2/10/2013 12:30:00'),
(1, 5257, 0, '2/10/2013 13:00:00', '2/10/2013 19:30:00'),
(5, 10596, 0, '2/11/2013 08:30:00', '2/11/2013 12:30:00'),
(1, 4732, 0, '2/11/2013 13:00:00', '2/11/2013 19:30:00'),
(4, 9034, 0, '2/12/2013 08:30:00', '2/12/2013 12:30:00'),
(1, 4747, 0, '2/12/2013 13:00:00', '2/12/2013 19:30:00'),
(5, 10616, 0, '2/13/2013 08:30:00', '2/13/2013 12:30:00'),
(2, 5629, 0, '2/13/2013 13:00:00', '2/13/2013 19:30:00'),
(2, 6729, 0, '2/14/2013 08:30:00', '2/14/2013 12:30:00'),
(2, 6373, 0, '2/14/2013 13:00:00', '2/14/2013 19:30:00'),
(5, 10513, 0, '2/15/2013 08:30:00', '2/15/2013 12:30:00'),
(3, 7260, 0, '2/15/2013 13:00:00', '2/15/2013 19:30:00'),
(3, 6895, 0, '2/16/2013 08:30:00', '2/16/2013 12:30:00'),
(3, 7156, 0, '2/16/2013 13:00:00', '2/16/2013 19:30:00'),
(2, 6642, 0, '2/17/2013 08:30:00', '2/17/2013 12:30:00'),
(3, 7456, 0, '2/17/2013 13:00:00', '2/17/2013 19:30:00'),
(1, 4292, 0, '2/18/2013 08:30:00', '2/18/2013 12:30:00'),
(5, 10858, 0, '2/18/2013 13:00:00', '2/18/2013 19:30:00'),
(3, 8111, 0, '2/19/2013 08:30:00', '2/19/2013 12:30:00'),
(5, 9976, 0, '2/19/2013 13:00:00', '2/19/2013 19:30:00'),
(4, 9506, 0, '2/20/2013 08:30:00', '2/20/2013 12:30:00'),
(3, 7841, 0, '2/20/2013 13:00:00', '2/20/2013 19:30:00')

INSERT INTO Caja (empleado_id, cash_entrada, estado, fecha_abre, fecha_cierra) VALUES
(1, 10000.00, 0, '3/23/2013 09:00:00', '3/23/2013 13:00:00'),
(2, 10000.00, 0, '3/23/2013 13:00:00', '3/23/2013 18:00:00')

/*NCF*/
INSERT INTO NCF(no_NCF, venta_id) VALUES 
('AC000100724101', 1 ),
('AC000100724102', 2 ),
('AC000100724103', 3 ),
('AC000100724104', 4 ),
('AC000100724105', 5 ),
('AC000100724106', 6 ),
('AC000100724107', 7 ),
('AC000100724108', 8 ),
('AC000100724109', 9 ),
('AC000100724110', 10 ),
('AC000100724111', 11 ),
('AC000100724112', 12 ),
('AC000100724113', 13 ),
('AC000100724114', 14 ),
('AC000100724115', 15 ),
('AC000100724116', 16 ),
('AC000100724117', 17 ),
('AC000100724118', 18 ),
('AC000100724119', 19 ),
('AC000100724120', 20 ),
('AC000100724121', 21 ),
('AC000100724122', 22 ),
('AC000100724123', 23 ),
('AC000100724124', 24 ),
('AC000100724125', 25 ),
('AC000100724126', 26 ),
('AC000100724127', 27 ),
('AC000100724128', 28 ),
('AC000100724129', 29 ),
('AC000100724130', 30 ),
('AC000100724131', 31 ),
('AC000100724132', 32 ),
('AC000100724133', 33 ),
('AC000100724134', 34 ),
('AC000100724135', 35 ),
('AC000100724136', 36 ),
('AC000100724137', 37 ),
('AC000100724138', 38 ),
('AC000100724139', 39 ),
('AC000100724140', 40 ),
('AC000100724141', 41 ),
('AC000100724142', 42 ),
('AC000100724143', 43 ),
('AC000100724144', 44 ),
('AC000100724145', 45 ),
('AC000100724146', 46 ),
('AC000100724147', 47 ),
('AC000100724148', 48 ),
('AC000100724149', 49 ),
('AC000100724150', 50 ),
('AC000100724151', 51 ),
('AC000100724152', 52 ),
('AC000100724153', 53 ),
('AC000100724154', 54 ),
('AC000100724155', 55 ),
('AC000100724156', 56 ),
('AC000100724157', 57 ),
('AC000100724158', 58 ),
('AC000100724159', 59 ),
('AC000100724160', 60 ),
('AC000100724161', 61 ),
('AC000100724162', 62 ),
('AC000100724163', 63 ),
('AC000100724164', 64 ),
('AC000100724165', 65 ),
('AC000100724166', 66 ),
('AC000100724167', 67 ),
('AC000100724168', 68 ),
('AC000100724169', 69 ),
('AC000100724170', 70 ),
('AC000100724171', 71 ),
('AC000100724172', 72 ),
('AC000100724173', 73 ),
('AC000100724174', 74 ),
('AC000100724175', 75 ),
('AC000100724176', 76 ),
('AC000100724177', 77 ),
('AC000100724178', 78 ),
('AC000100724179', 79 ),
('AC000100724180', 80 ),
('AC000100724181', 81 ),
('AC000100724182', 82 ),
('AC000100724183', 83 ),
('AC000100724184', 84 ),
('AC000100724185', 85 ),
('AC000100724186', 86 ),
('AC000100724187', 87 ),
('AC000100724188', 88 ),
('AC000100724189', 89 ),
('AC000100724190', 90 ),
('AC000100724191', 91 ),
('AC000100724192', 92 ),
('AC000100724193', 93 ),
('AC000100724194', 94 ),
('AC000100724195', 95 ),
('AC000100724196', 96 ),
('AC000100724197', 97 ),
('AC000100724198', 98 ),
('AC000100724199', 99 ),
('AC000100724200', 100 ),
('AC000100724201', 101 ),
('AC000100724202', 102 ),
('AC000100724203', 103 ),
('AC000100724204', 104 ),
('AC000100724205', 105 ),
('AC000100724206', 106 ),
('AC000100724207', 107 ),
('AC000100724208', 108 ),
('AC000100724209', 109 ),
('AC000100724210', 110 ),
('AC000100724211', 111 ),
('AC000100724212', 112 ),
('AC000100724213', 113 ),
('AC000100724214', 114 ),
('AC000100724215', 115 ),
('AC000100724216', 116 ),
('AC000100724217', 117 ),
('AC000100724218', 118 ),
('AC000100724219', 119 ),
('AC000100724220', 120 ),
('AC000100724221', 121 ),
('AC000100724222', 122 ),
('AC000100724223', 123 ),
('AC000100724224', 124 ),
('AC000100724225', 125 ),
('AC000100724226', 126 ),
('AC000100724227', 127 ),
('AC000100724228', 128 ),
('AC000100724229', 129 ),
('AC000100724230', 130 ),
('AC000100724231', 131 ),
('AC000100724232', 132 ),
('AC000100724233', 133 ),
('AC000100724234', 134 ),
('AC000100724235', 135 ),
('AC000100724236', 136 ),
('AC000100724237', 137 ),
('AC000100724238', 138 ),
('AC000100724239', 139 ),
('AC000100724240', 140 ),
('AC000100724241', 141 ),
('AC000100724242', 142 ),
('AC000100724243', 143 ),
('AC000100724244', 144 ),
('AC000100724245', 145 ),
('AC000100724246', 146 ),
('AC000100724247', 147 ),
('AC000100724248', 148 ),
('AC000100724249', 149 ),
('AC000100724250', 150 ),
('AC000100724251', 151 ),
('AC000100724252', 152 ),
('AC000100724253', 153 ),
('AC000100724254', 154 ),
('AC000100724255', 155 ),
('AC000100724256', 156 ),
('AC000100724257', 157 ),
('AC000100724258', 158 ),
('AC000100724259', 159 ),
('AC000100724260', 160 ),
('AC000100724261', 161 ),
('AC000100724262', 162 ),
('AC000100724263', 163 ),
('AC000100724264', 164 ),
('AC000100724265', 165 ),
('AC000100724266', 166 ),
('AC000100724267', 167 ),
('AC000100724268', 168 ),
('AC000100724269', 169 ),
('AC000100724270', 170 ),
('AC000100724271', 171 ),
('AC000100724272', 172 ),
('AC000100724273', 173 ),
('AC000100724274', 174 ),
('AC000100724275', 175 ),
('AC000100724276', 176 ),
('AC000100724277', 177 ),
('AC000100724278', 178 ),
('AC000100724279', 179 ),
('AC000100724280', 180 ),
('AC000100724281', 181 ),
('AC000100724282', 182 ),
('AC000100724283', 183 ),
('AC000100724284', 184 ),
('AC000100724285', 185 ),
('AC000100724286', 186 ),
('AC000100724287', 187 ),
('AC000100724288', 188 ),
('AC000100724289', 189 ),
('AC000100724290', 190 ),
('AC000100724291', 191 ),
('AC000100724292', 192 ),
('AC000100724293', 193 ),
('AC000100724294', 194 ),
('AC000100724295', 195 ),
('AC000100724296', 196 ),
('AC000100724297', 197 ),
('AC000100724298', 198 ),
('AC000100724299', 199 ),
('AC000100724300', 200 ),
('AC000100724301', 201 ),
('AC000100724302', 202 ),
('AC000100724303', 203 ),
('AC000100724304', 204 ),
('AC000100724305', 205 ),
('AC000100724306', 206 ),
('AC000100724307', 207 ),
('AC000100724308', 208 ),
('AC000100724309', 209 ),
('AC000100724310', 210 ),
('AC000100724311', 211 ),
('AC000100724312', 212 ),
('AC000100724313', 213 ),
('AC000100724314', 214 ),
('AC000100724315', 215 ),
('AC000100724316', 216 ),
('AC000100724317', 217 ),
('AC000100724318', 218 ),
('AC000100724319', 219 ),
('AC000100724320', 220 ),
('AC000100724321', 221 ),
('AC000100724322', 222 ),
('AC000100724323', 223 ),
('AC000100724324', 224 ),
('AC000100724325', 225 ),
('AC000100724326', 226 ),
('AC000100724327', 227 ),
('AC000100724328', 228 ),
('AC000100724329', 229 ),
('AC000100724330', 230 ),
('AC000100724331', 231 ),
('AC000100724332', 232 ),
('AC000100724333', 233 ),
('AC000100724334', 234 ),
('AC000100724335', 235 ),
('AC000100724336', 236 ),
('AC000100724337', 237 ),
('AC000100724338', 238 ),
('AC000100724339', 239 ),
('AC000100724340', 240 ),
('AC000100724341', 241 ),
('AC000100724342', 242 ),
('AC000100724343', 243 ),
('AC000100724344', 244 ),
('AC000100724345', 245 ),
('AC000100724346', 246 ),
('AC000100724347', 247 ),
('AC000100724348', 248 ),
('AC000100724349', 249 ),
('AC000100724350', 250 ),
('AC000100724351', 251 ),
('AC000100724352', 252 ),
('AC000100724353', 253 ),
('AC000100724354', 254 ),
('AC000100724355', 255 ),
('AC000100724356', 256 ),
('AC000100724357', 257 ),
('AC000100724358', 258 ),
('AC000100724359', 259 ),
('AC000100724360', 260 ),
('AC000100724361', 261 ),
('AC000100724362', 262 ),
('AC000100724363', 263 ),
('AC000100724364', 264 ),
('AC000100724365', 265 ),
('AC000100724366', 266 ),
('AC000100724367', 267 ),
('AC000100724368', 268 ),
('AC000100724369', 269 ),
('AC000100724370', 270 ),
('AC000100724371', 271 ),
('AC000100724372', 272 ),
('AC000100724373', 273 ),
('AC000100724374', 274 ),
('AC000100724375', 275 ),
('AC000100724376', 276 ),
('AC000100724377', 277 ),
('AC000100724378', 278 )

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

/*Insert RegistroInventario*/
INSERT INTO RegistroInventario (empleado_id, notas, fecha) VALUES
(5, NULL, '1/13/2013'),
(3, NULL, '1/14/2013'),
(3, NULL, '1/15/2013'),
(4, NULL, '1/16/2013'),
(1, NULL, '1/17/2013'),
(5, NULL, '1/18/2013'),
(4, NULL, '1/19/2013'),
(3, NULL, '1/20/2013'),
(5, NULL, '1/21/2013'),
(2, NULL, '1/22/2013'),
(3, NULL, '1/23/2013'),
(5, NULL, '1/24/2013'),
(3, NULL, '1/25/2013'),
(2, NULL, '1/26/2013'),
(4, NULL, '1/27/2013'),
(2, NULL, '1/28/2013'),
(3, NULL, '1/29/2013'),
(3, NULL, '2/1/2013'),
(4, NULL, '2/2/2013')

/*RegistroInventario_Productos*/
INSERT INTO RegistroInventario_Productos (producto_id, inventario_id, cantidad) VALUES
(12, 1, 30),
(14, 1, 40),
(2, 1, 60),
(3, 1, 12),
(20, 1, 15),
(22, 1, 12),
(9, 1, 14),
(10, 1, 25),
(13, 1, 10),
(15, 1, 14),
(1, 2, 4),
(2, 2, 5),
(3, 2, 9),
(4, 2, 20),
(5, 2, 4),
(6, 2, 15),
(7, 2, 18),
(8, 2, 20),
(9, 2, 14),
(10, 2, 25),
(12, 3, 10),
(15, 3, 14),
(01, 3, 18),
(2, 3, 25),
(3, 3, 20),
(4, 3, 16),
(5, 3, 70),
(1, 4, 40),
(2, 4, 50),
(3, 4, 10),
(4, 4, 20),
(5, 4, 4),
(6, 4, 15),
(7, 4, 50),
(12, 5, 10),
(15, 5, 15),
(01, 5, 40),
(2, 5, 30),
(3, 5, 20),
(16, 5, 30),
(11, 5, 25),
(12, 6, 55),
(13, 6, 50),
(14, 6, 65),
(15, 6, 75),
(1, 6, 24),
(2, 6, 30),
(3, 6, 20),
(4, 6, 22),
(5, 6, 30),
(10, 7, 20),
(9, 7, 30),
(8, 7, 40),
(7,7, 20),
(6, 7, 25),
(13, 7, 30),
(11, 7, 25),
(1, 7, 40),
(2, 7, 30),
(3, 7, 20),
(4, 7, 25),
(12, 7, 30)

insert into Oferta(nombre, descripcion, fecha_empieza, fecha_termina, dias_disponible, hora_disponible_empieza, hora_disponible_termina, producto_id, tipo) VALUES 
('2x1 Barquito', '2x1 en barquitos', '3/1/2013', '3/30/2013', 127, '09:00:00', '18:00:00', 1, '2x1');

insert into Oferta(nombre, descripcion, fecha_empieza, fecha_termina, dias_disponible, hora_disponible_empieza, hora_disponible_termina, producto_id, tipo) VALUES 
('2x1 Cajita', '2x1 en Cajitas', '1/1/2013', '4/30/2013', 127, '09:00:00', '18:00:00', 9, '2x1');

/* Ventas */
INSERT INTO Venta(cliente_id, caja_id, fecha, total, forma_pago) VALUES 
(NULL, 1, '2/1/2013 8:40:22', 300.00 ,'Efectivo'),
(7, 1, '2/1/2013 8:50:24', 700.00,'Efectivo'),
(5, 1, '2/1/2013 9:10:36', 650.00,'Efectivo'),
(4, 1, '2/1/2013 9:23:52', 200.00,'Efectivo'),
(9, 1, '2/1/2013 9:30:48', 425.00,'Efectivo'),
(4, 1, '2/1/2013 9:35:10', 350.00,'Efectivo'),
(3, 1, '2/1/2013 9:44:58', 50.00,'Efectivo'),
(10, 1, '2/1/2013 9:59:00', 100.00,'Efectivo'),
(10, 1, '2/1/2013 10:17:05', 650.00,'Efectivo'),
(2, 1, '2/1/2013 10:29:12', 650.00,'Efectivo'),
(5, 1, '2/1/2013 10:33:53', 220.00,'Efectivo'),
(1, 1, '2/1/2013 10:46:35', 150.00,'Efectivo'),
(3, 1, '2/1/2013 10:57:05', 220.00,'Efectivo'),
(NULL, 1, '2/1/2013 11:04:22', 220.00,'Efectivo'),
(3, 1, '2/1/2013 11:17:05', 150.00,'Efectivo'),
(2, 1, '2/1/2013 11:37:05', 350.00,'Efectivo'),
(NULL, 2, '2/1/2013 13:02:47', 420.00,'Efectivo'),
(8, 2, '2/1/2013 13:15:57', 100.00,'Efectivo'),
(4, 2, '2/1/2013 13:23:26', 75.00,'Efectivo'),
(2, 2, '2/1/2013 13:44:52', 200.00 ,'Efectivo'),
(4, 2, '2/1/2013 13:59:43', 300.00,'Efectivo'),
(1, 2, '2/1/2013 14:03:06', 120.00,'Efectivo'),
(3, 2, '2/1/2013 14:15:24', 150.00,'Efectivo'),
(1, 2, '2/1/2013 15:18:32', 650.00 ,'Efectivo'),
(4, 2, '2/1/2013 15:22:43', 425.00,'Efectivo'),
(1, 2, '2/1/2013 15:33:16', 100.00,'Efectivo'),
(2, 2, '2/1/2013 16:36:55', 220.00 ,'Efectivo'),
(6, 2, '2/1/2013 16:47:10', 300.00,'Efectivo'),
(1, 2, '2/1/2013 16:51:16', 425.00,'Efectivo'),
(9, 2, '2/1/2013 18:54:25', 500.00,'Efectivo'),
(3, 2, '2/1/2013 19:10:36', 1300.00,'Efectivo'),
(NULL, 3, '2/2/2013 9:33:58', 150.00,'Efectivo'),
(NULL, 3, '2/2/2013 10:34:45', 200.00,'Efectivo'),
(5, 3, '2/2/2013 10:38:00', 300.00,'Efectivo'),
(2, 3, '2/2/2013 10:34:12', 190.00,'Efectivo'),
(5, 3, '2/2/2013 10:38:27', 300.00,'Efectivo'),
(2, 3, '2/2/2013 10:52:56', 250.00,'Efectivo'),
(8, 3, '2/2/2013 10:58:45', 300.00,'Efectivo'),
(3, 3, '2/2/2013 11:04:05', 450.00,'Efectivo'),
(5, 3, '2/2/2013 11:22:38', 100.00 ,'Efectivo'),
(5, 3, '2/2/2013 11:25:26', 230.00,'Efectivo'),
(2, 3, '2/2/2013 11:55:34', 425.00,'Efectivo'),
(NULL, 3, '2/2/2013 12:03:26', 500.00,'Efectivo'),
(2, 3, '2/2/2013 12:07:57', 600.00,'Efectivo'),
(5, 3, '2/2/2013 12:18:26', 120.00,'Efectivo'),
(NULL, 4, '2/2/2013 13:29:57', 180.00,'Efectivo'),
(7, 4, '2/2/2013 14:34:17', 200.00,'Efectivo'),
(1, 4, '2/2/2013 15:49:39', 120.00, 'Efectivo'),
(3, 4, '2/2/2013 16:29:55', 350.00,'Efectivo'),
(NULL, 4, '2/2/2013 18:47:07', 425.00,'Efectivo'),
(NULL, 5, '2/3/2013 9:35:10', 500.00,'Efectivo'),
(7, 5, '2/3/2013 10:51:38', 230.00,'Efectivo'),
(3, 5, '2/3/2013 10:58:12', 180.00,'Efectivo'),
(3, 5, '2/3/2013 11:03:43', 250.00,'Efectivo'),
(10, 5, '2/3/2013 11:38:19', 620.00,'Efectivo'),
(2, 5, '2/3/2013 11:50:11', 150.00,'Efectivo'),
(1, 5, '2/3/2013 11:58:15', 100.00,'Efectivo'),
(1, 5, '2/3/2013 12:03:18', 250.00,'Efectivo'),
(9, 5, '2/3/2013 12:12:36', 300.00,'Efectivo'),
(2, 5, '2/3/2013 12:18:25', 425.00,'Efectivo'),
(5, 5, '2/3/2013 12:29:47', 500.00,'Efectivo'),
(1, 6, '2/3/2013 13:26:32', 650.00,'Efectivo'),
(6, 6, '2/3/2013 13:39:12', 100.00,'Efectivo'),
(4, 6, '2/3/2013 15:08:42', 250.00,'Efectivo'),
(4, 6, '2/3/2013 15:33:16', 300.00,'Efectivo'),
(7, 6, '2/3/2013 16:16:11', 425.00,'Efectivo'),
(1, 6, '2/3/2013 16:33:17', 650.00,'Efectivo'),
(6, 6, '2/3/2013 17:23:39', 200.00,'Efectivo'),
(10, 6, '2/3/2013 17:31:16', 300.00,'Efectivo'),
(NULL, 6, '2/3/2013 17:41:15', 425.00,'Efectivo'),
(2, 6, '2/3/2013 18:21:55', 50.00,'Efectivo'),
(4, 6, '2/3/2013 18:43:51', 75.00,'Efectivo'),
(3, 6, '2/3/2013 18:55:32', 90.00,'Efectivo'),
(4, 6, '2/3/2013 19:27:33', 100.00,'Efectivo'),
(NULL, 7, '2/4/2013 8:39:31', 200.00,'Efectivo'),
(NULL, 7, '2/4/2013 8:41:46', 300.00,'Efectivo'),
(NULL, 7, '2/4/2013 9:00:25',425.00 ,'Efectivo'),
(NULL, 7, '2/4/2013 9:15:42', 650.00,'Efectivo'),
(NULL, 7, '2/4/2013 9:27:16', 650.00,'Efectivo'),
(NULL, 7, '2/4/2013 9:38:12', 120.00,'Efectivo'),
(NULL, 7, '2/4/2013 9:45:47', 300.00,'Efectivo'),
(NULL, 7, '2/4/2013 10:15:42', 425.00,'Efectivo'),
(NULL, 7, '2/4/2013 10:26:51', 50.00, 'Efectivo'),
(NULL, 7, '2/4/2013 10:41:26', 100.00,'Efectivo'),
(NULL, 7, '2/4/2013 10:46:52', 200.00,'Efectivo'),
(NULL, 7, '2/4/2013 10:55:41', 300.00,'Efectivo'),
(NULL, 7, '2/4/2013 11:00:36', 100.00,'Efectivo'),
(NULL, 7, '2/4/2013 11:23:21', 75.00,'Efectivo'),
(NULL, 7, '2/4/2013 11:43:32', 150.00,'Efectivo'),
(NULL, 7, '2/4/2013 12:15:54', 150.00,'Efectivo'),
(NULL, 8, '2/4/2013 13:00:18', 150.00,'Efectivo'),
(NULL, 8, '2/4/2013 13:54:04', 200.00,'Efectivo'),
(1, 8, '2/4/2013 14:22:41 ', 100.00, 'Efectivo'),
(2, 8, '2/4/2013 15:55:15 ', 650.00,'Efectivo'),
(NULL, 8, '2/4/2013 18:33:40', 425.00,'Efectivo'),
(NULL, 9, '2/5/2013 9:09:03 ', 650.00, 'Efectivo'),
(4, 9, '2/5/2013 9:19:07', 350.00,'Efectivo'),
(4, 9, '2/5/2013 9:35:06', 650.00,'Efectivo'),
(1, 9, '2/5/2013 10:34:29', 400.00,'Efectivo'),
(3, 9, '2/5/2013 10:56:42', 500.00,'Efectivo'),
(NULL, 9, '2/5/2013 11:28:43', 600.00,'Efectivo'),
(NULL, 9, '2/5/2013 11:43:22', 100.00,'Efectivo'),
(2, 9, '2/5/2013 12:03:08', 200.00,'Efectivo'),
(2, 9, '2/5/2013 12:16:32', 300.00,'Efectivo'),
(3, 9, '2/5/2013 12:22:27', 75.00,'Efectivo'),
(1, 9, '2/5/2013 12:24:42', 100.00,'Efectivo'),
(3, 9, '2/5/2013 12:27:14', 200.00,'Efectivo'),
(1, 9, '2/5/2013 12:29:07', 100.00,'Efectivo'),
(NULL, 10, '2/5/2013 13:01:56', 650.00,'Efectivo'),
(3, 10, '2/5/2013 13:03:46', 650.00,'Efectivo'),
(3, 10, '2/5/2013 13:12:53', 220.00,'Efectivo'),
(4, 10, '2/5/2013 13:29:25', 100.00,'Efectivo'),
(1, 10, '2/5/2013 15:21:54', 100.00,'Efectivo'),
(3, 10, '2/5/2013 15:43:55', 100.00,'Efectivo'),
(NULL, 10, '2/5/2013 16:05:24', 200.00,'Efectivo'),
(NULL, 10, '2/5/2013 16:58:22', 300.00,'Efectivo'),
(NULL, 10, '2/5/2013 17:34:27', 425.00,'Efectivo'),
(NULL, 10, '2/5/2013 17:38:11', 400.00,'Efectivo'),
(NULL, 10, '2/5/2013 18:01:10', 100.00,'Efectivo'),
(NULL, 10, '2/5/2013 18:29:18', 650.00,'Efectivo'),
(NULL, 10, '2/5/2013 19:11:37', 425.00,'Efectivo'),
(NULL, 11, '2/6/2013 9:11:37', 650.00,'Efectivo'),
(2, 11, '2/6/2013 9:28:06', 100.00,'Efectivo'),
(NULL, 11, '2/6/2013 9:41:52', 100.00,'Efectivo'),
(3, 11, '2/6/2013 10:13:19', 100.00,'Efectivo'),
(2, 11, '2/6/2013 11:02:46', 200.00,'Efectivo'),
(4, 11, '2/6/2013 11:13:11', 200.00,'Efectivo'),
(NULL, 12, '2/6/2013 13:10:23', 300.00, 'Efectivo'),
(4, 12, '2/6/2013 13:19:00', 100.00,'Efectivo'),
(1, 12, '2/6/2013 14:09:38', 200.00,'Efectivo'),
(1, 12, '2/6/2013 14:27:36', 300.00,'Efectivo'),
(NULL, 12, '2/6/2013 15:27:36', 400.00,'Efectivo'),
(4, 12, '2/6/2013 17:01:10', 100.00,'Efectivo'),
(NULL, 13, '2/7/2013 8:50:24', 650.00,'Efectivo'),
(4, 13, '2/7/2013 9:23:52', 425.00,'Efectivo'),
(2, 13, '2/7/2013 9:35:10', 650.00,'Efectivo'),
(3, 13, '2/7/2013 10:46:35', 1300.00,'Efectivo'),
(NULL, 13, '2/7/2013 13:26:32', 100.00,'Efectivo'),
(NULL, 14, '2/7/2013 13:29:25', 200.00,'Efectivo'),
(NULL, 14, '2/7/2013 13:36:12', 300.00, 'Efectivo'),
(NULL, 14, '2/7/2013 14:15:24', 650.00,'Efectivo'),
(NULL, 14, '2/7/2013 15:21:54', 100.00,'Efectivo'),
(NULL, 14, '2/7/2013 15:43:55', 100.00,'Efectivo'),
(NULL, 14, '2/7/2013 16:05:24', 100.00,'Efectivo'),
(NULL, 14, '2/7/2013 17:23:39', 100.00,'Efectivo'),
(NULL, 14, '2/7/2013 17:34:27', 100.00,'Efectivo'),
(NULL, 14, '2/7/2013 17:38:11', 100.00,'Efectivo'),
(NULL, 14, '2/7/2013 17:41:10', 100.00,'Efectivo'),
(NULL, 14, '2/7/2013 18:29:18', 100.00,'Efectivo'),
(NULL, 14, '2/7/2013 18:34:12', 100.00,'Efectivo'),
(NULL, 14, '2/7/2013 18:38:34', 100.00,'Efectivo'),
(NULL, 14, '2/7/2013 18:49:18', 220.00,'Efectivo'),
(NULL, 14, '2/7/2013 19:20:12', 220.00,'Efectivo'),
(NULL, 14, '2/7/2013 19:23:57', 220.00,'Efectivo'),
(NULL, 15, '2/8/2013 19:25:51', 220.00,'Efectivo'),
(9, 15, '2/8/2013 9:32:24', 220.00,'Efectivo'),
(NULL, 15, '2/8/2013 10:14:42',220.00, 'Efectivo'),
(NULL, 15, '2/8/2013 10:21:23', 220.00,'Efectivo'),
(5, 15, '2/8/2013 11:00:39', 220.00,'Efectivo'),
(6, 15, '2/8/2013 11:37:21', 220.00,'Efectivo'),
(8, 15, '2/8/2013 11:23:12', 220.00,'Efectivo'),
(NULL, 15, '2/8/2013 12:12:12',220.00, 'Efectivo'),
(NULL, 15, '2/8/2013 12:23:12', 150.00,'Efectivo'),
(NULL, 16, '2/8/2013 13:59:43',150.00, 'Efectivo'),
(7, 16, '2/8/2013 14:15:24', 150.00,'Efectivo'),
(NULL, 16, '2/8/2013 14:28:42', 150.00,'Efectivo'),
(3, 16, '2/8/2013 15:43:55', 150.00,'Efectivo'),
(9, 16, '2/8/2013 16:05:24', 150.00,'Efectivo'),
(NULL, 16, '2/8/2013 17:23:39', 150.00,'Efectivo'),
(2, 16, '2/8/2013 17:34:27', 150.00,'Efectivo'),
(NULL, 16, '2/8/2013 17:38:11',150.00, 'Efectivo'),
(NULL, 16, '2/8/2013 18:29:18', 150.00,'Efectivo'),
(6, 16, '2/8/2013 18:33:12', 150.00,'Efectivo'),
(NULL, 16, '2/8/2013 19:20:12',150.00,'Efectivo'),
(7, 16, '2/8/2013 19:25:51', 150.00,'Efectivo'),
(NULL, 16, '2/8/2013 19:27:56', 150.00,'Efectivo'),
(NULL, 17, '2/9/2013 9:10:36', 50.00,'Efectivo'),
(7, 17, '2/9/2013 9:20:10', 50.00,'Efectivo'),
(NULL, 17, '2/9/2013 9:24:56', 50.00,'Efectivo'),
(NULL, 17, '2/9/2013 9:29:05', 50.00,'Efectivo'),
(1, 17, '2/9/2013 10:19:05', 50.00,'Efectivo'),
(NULL, 17, '2/9/2013 10:23:30', 50.00,'Efectivo'),
(4, 17, '2/9/2013 11:12:43', 50.00,'Efectivo'),
(7, 17, '2/9/2013 12:01:32', 50.00,'Efectivo'),
(NULL, 17, '2/9/2013 12:17:48', 50.00,'Efectivo'),
(NULL, 18, '2/9/2013 12:49:22',120.00, 'Efectivo'),
(NULL, 18, '2/9/2013 13:00:45', 120.00,'Efectivo'),
(NULL, 18, '2/9/2013 13:06:37', 120.00,'Efectivo'),
(5, 18, '2/9/2013 13:12:53', 120.00,'Efectivo'),
(4, 18, '2/9/2013 13:23:26', 120.00,'Efectivo'),
(NULL, 18, '2/9/2013 13:29:25', 120.00,'Efectivo'),
(NULL, 18, '2/9/2013 14:15:24', 120.00,'Efectivo'),
(NULL, 18, '2/9/2013 15:21:54',120.00, 'Efectivo'),
(NULL, 18, '2/9/2013 15:27:48', 120.00,'Efectivo'),
(NULL, 18, '2/10/2013 16:29:55', 120.00,'Efectivo'),
(1, 18, '2/10/2013 17:23:39', 120.00,'Efectivo'),
(NULL, 19, '2/10/2013 9:11:37', 120.00,'Efectivo'),
(NULL, 19, '2/10/2013 9:31:12',120.00, 'Efectivo'),
(NULL, 19, '2/10/2013 9:43:23',120.00,'Efectivo'),
(NULL, 19, '2/10/2013 10:34:45',120.00, 'Efectivo'),
(1, 19, '2/10/2013 10:41:34', 120.00,'Efectivo'),
(1, 19, '2/10/2013 10:53:31', 120.00,'Efectivo'),
(NULL, 19, '2/10/2013 11:12:43', 120.00,'Efectivo'),
(NULL, 19, '2/10/2013 11:23:21',120.00, 'Efectivo'),
(10, 19, '2/10/2013 11:32:17', 120.00,'Efectivo'),
(NULL, 19, '2/10/2013 11:41:56',120.00, 'Efectivo'),
(1, 19, '2/10/2013 11:56:43', 120.00,'Efectivo'),
(NULL, 19, '2/10/2013 12:00:00',120.00, 'Efectivo'),
(4, 19, '2/10/2013 12:23:33', 120.00,'Efectivo'),
(11, 19, '2/10/2013 12:43:44', 120.00,'Efectivo'),
(NULL, 20, '2/10/2013 13:15:57',120.00, 'Efectivo'),
(10, 20, '2/10/2013 15:29:25', 120.00,'Efectivo'),
(2, 20, '2/10/2013 16:36:12', 120.00,'Efectivo'),
(4, 20, '2/10/2013 17:48:18', 120.00,'Efectivo'),
(NULL, 20, '2/10/2013 18:48:18', 120.00,'Efectivo'),
(NULL, 21, '2/11/2013 9:23:52', 120.00,'Efectivo'),
(7, 21, '2/11/2013 10:41:34',110.00, 'Efectivo'),
(8, 21, '2/11/2013 11:12:43', 110.00,'Efectivo'),
(NULL, 21, '2/11/2013 11:23:21',110.00, 'Efectivo'),
(NULL, 21, '2/11/2013 11:41:56',110.00, 'Efectivo'),
(NULL, 21, '2/11/2013 11:43:22',110.00, 'Efectivo'),
(1, 21, '2/11/2013 12:14:00', 110.00,'Efectivo'),
(2, 21, '2/11/2013 12:23:26', 110.00,'Efectivo'),
(NULL, 22, '2/11/2013 13:15:57', 110.00,'Efectivo'),
(NULL, 22, '2/11/2013 13:29:25', 110.00,'Efectivo'),
(NULL, 22, '2/11/2013 14:15:24', 110.00,'Efectivo'),
(NULL, 22, '2/11/2013 15:29:25',110.00, 'Efectivo'),
(3, 22, '2/11/2013 16:29:52', 110.00,'Efectivo'),
(8, 22, '2/11/2013 17:23:39', 110.00,'Efectivo'),
(NULL, 22, '2/11/2013 19:42:43', 110.00,'Efectivo'),
(NULL, 23, '2/12/2013 9:10:36',110.00, 'Efectivo'),
(5, 23, '2/12/2013 9:12:43', 110.00,'Efectivo'),
(9, 23, '2/12/2013 10:41:34', 110.00,'Efectivo'),
(NULL, 23, '2/12/2013 11:12:43', 110.00,'Efectivo'),
(NULL, 23, '2/12/2013 11:41:56',110.00, 'Efectivo'),
(2, 23, '2/12/2013 12:23:26', 200.00,'Efectivo'),
(5, 23, '2/12/2013 12:26:12',200.00, 'Efectivo'),
(NULL, 23, '2/12/2013 12:28:43', 200.00,'Efectivo'),
(NULL, 24, '2/12/2013 13:15:57', 200.00,'Efectivo'),
(1, 24, '2/12/2013 13:29:25', 200.00,'Efectivo'),
(NULL, 24, '2/12/2013 13:59:43',200.00, 'Efectivo'),
(NULL, 24, '2/12/2013 14:15:24',200.00, 'Efectivo'),
(NULL, 24, '2/12/2013 14:21:54',200.00, 'Efectivo'),
(NULL, 24, '2/12/2013 15:03:55',200.00, 'Efectivo'),
(NULL, 25, '2/13/2013 15:18:32', 200.00,'Efectivo'),
(NULL, 25, '2/13/2013 16:16:52',200.00, 'Efectivo'),
(NULL, 25, '2/13/2013 16:19:11',200.00, 'Efectivo'),
(4, 25, '2/13/2013 8:26:11', 200.00,'Efectivo'),
(9, 25, '2/13/2013 8:23:39', 200.00,'Efectivo'),
(NULL, 25, '2/13/2013 9:26:09', 200.00,'Efectivo'),
(4, 25, '2/13/2013 9:34:27', 425.00,'Efectivo'),
(NULL, 25, '2/13/2013 9:41:10', 425.00,'Efectivo'),
(NULL, 25, '2/13/2013 9:09:14', 425.00,'Efectivo'),
(NULL, 25, '2/13/2013 10:24:00',425.00, 'Efectivo'),
(NULL, 25, '2/13/2013 10:29:18', 425.00,'Efectivo'),
(6, 25, '2/13/2013 10:39:18', 425.00,'Efectivo'),
(NULL, 25, '2/13/2013 11:12:18',425.00, 'Efectivo'),
(2, 25, '2/13/2013 11:23:42',425.00, 'Efectivo'),
(NULL, 26, '2/13/2013 12:38:43', 425.00,'Efectivo'),
(5, 26, '2/13/2013 13:15:57', 425.00,'Efectivo'),
(3, 26, '2/13/2013 14:27:36', 425.00,'Efectivo'),
(NULL, 26, '2/13/2013 15:08:42', 425.00,'Efectivo'),
(5, 26, '2/13/2013 16:28:56', 425.00,'Efectivo'),
(4, 26, '2/13/2013 16:29:55',425.00, 'Efectivo'),
(6, 26, '2/13/2013 17:38:11', 425.00,'Efectivo'),
(2, 26, '2/13/2013 18:43:51',  100.00,'Efectivo'),
(NULL, 26, '2/13/2013 19:09:03', 100.00, 'Efectivo'),
(9, 26, '2/13/2013 19:28:37',  100.00,'Efectivo'),
(NULL, 27, '2/14/2013 8:50:24',  100.00,'Efectivo'),
(NULL, 27, '2/14/2013 9:26:09',  100.00,'Efectivo'),
(NULL, 27, '2/14/2013 10:25:09', 100.00, 'Efectivo'),
(11, 27, '2/14/2013 10:39:18',  100.00,'Efectivo'),
(NULL, 27, '2/14/2013 11:12:18',  100.00,'Efectivo'),
(NULL, 27, '2/14/2013 11:23:21',  100.00,'Efectivo'),
(NULL, 27, '2/14/2013 11:43:32', 100.00, 'Efectivo'),
(NULL, 27, '2/14/2013 12:08:37', 100.00,'Efectivo'),
(NULL, 27, '2/14/2013 12:08:37', 100.00,'Efectivo'),
(NULL, 27, '2/14/2013 12:12:43', 100.00,'Efectivo')

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


INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (1, 4, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (2, 1, 4);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (3, 6, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (3, 2, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (4, 4, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (4, 3, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (5, 1, 6);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (6, 3, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (6, 2, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (7, 8, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (8, 1, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (8, 7, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (9, 2, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (9, 3, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (10, 6, 3);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (10, 1, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (11, 6, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (11, 9, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (12, 4, 4);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (13, 6, 7);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (14, 1, 8);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (14, 2, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (15, 4, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (15, 6, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (16, 7, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (16, 3, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (17, 8, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (17, 5, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (18, 3, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (19, 10, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (19, 6, 3);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (20, 1, 7);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (20, 3, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (20, 12, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (21, 7, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (21, 6, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (21, 8, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (22, 11, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (22, 3, 3);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (23, 6, 4);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (23, 5, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (24, 5, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (24, 6, 4);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (25, 8, 3);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (25, 10, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (26, 14, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (27, 23, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (28, 21, 2);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (29, 22, 1);
INSERT INTO Venta_Productos(venta_id, producto_id, cantidad) VALUES (1, 1, 7);
insert into Venta_Productos(venta_id, producto_id, cantidad) VALUES (319, 9, 7);
insert into Venta_Productos(venta_id, producto_id, cantidad) VALUES (320, 9, 8);
insert into Venta_Productos(venta_id, producto_id, cantidad) VALUES (321, 9, 4);
insert into Venta_Productos(venta_id, producto_id, cantidad) VALUES (322, 9, 2);

/*Tabla Suplidor*/
INSERT INTO Suplidor (nombre, descripcion, calle, calle_no, ciudad, provincia, telefono)
VALUES ('Don Confinteria', 'Conos, Chispas y demás', 'Juana Saltitopa', 'No. 42', 'D. N.', 'Santo Domingo', '809-234-5235'),
	('Kids Party', 'Decoraciones Festivas', 'Plaza Naco', 'Local 23', 'D. N.', 'Santo Domingo', '809-125-2352'),
	('Central Bon', 'Helados, Mermeladas, Otros', 'Zona Industrial de Herrera', 'No. 45', 'D. N.', 'Santo Domingo', '809-523-5123')

/*Orden*/
INSERT INTO Orden (empleado_id, suplidor_id, NOTAS, aceptada, fecha_aceptada, fecha_despachada, recibida, fecha_recibida)
VALUES (7, 3, 'Pedido Semanal de Helados', 1, '2013/03/17', '2013/03/22', 1,'2013/03/22'),
	(4, 2, 'Pedido Materiales para Decorar', 1, '2013/03/25', '2013/03/26', 1,'2013/03/26'),
	(5, 3, 'Pedido Semanal de Helados', 1, '2013/03/25', '2013/03/29', 1,'2013/03/29'),
	(2, 1, 'Pedido Conos', 1, '2013/03/26', '2013/03/27', 1,'2013/03/27'),
	(7, 3, 'Pedido Quincenal de Envases', 1, '2013/03/30', '2013/04/02', 1,'2013/04/02'),
	(6, 3, 'Pedido Semanal de Helados', 1, '2013/04/01', '2013/04/05', 1,'2013/04/05'),
	(7, 3, 'Pedido Semanal de Helados', 1, '2013/04/08', '2013/04/13', 1,'2013/03/13'),
	(4, 3, 'Pedido Quincenal de Envases', 1, '2013/04/15', '2013/04/20', 1,'2013/04/20'),
	(5, 3, 'Pedido Semanal de Helados', 1, '2013/04/22', '2013/04/27', 1,'2013/04/27'),
	(2, 3, 'Pedido Quincenal de Envases', 1, '2013/04/30', '2013/05/03', 1,'2013/05/03'),
	(4, 1, 'Pedido Conos', 1, '2013/04/29', '2013/04/30', 1,'2013/04/30'),
	(6, 2, 'Pedido Materiales para Decorar', 1, '2013/05/15', '2013/05/16', 1,'2013/05/16'),
	(2, 3, 'Pedido Quincenal de Envases', 1, '2013/05/15', '2013/05/17', 1,'2013/05/17'),
	(7, 3, 'Pedido Semanal de Helados', 1, '2013/05/20', '2013/05/25', 1,'2013/05/25'),
	(4, 3, 'Pedido Semanal de Helados', 1, '2013/05/27', '2013/06/01', 1,'2013/06/01'),
	(6, 1, 'Pedido Conos', 1, '2013/05/28', '2013/05/29', 1,'2013/05/29'),
	(5, 3, 'Pedido Quincenal de Envases', 1, '2013/06/03', '2013/06/08', 1,'2013/06/08'),
	(2, 3, 'Pedido Semanal de Helados', 1, '2013/06/10', '2013/06/15', 1,'2013/06/15'),
	(2, 1, 'Pedido Conos', 1, '2013/06/10', '2013/06/11', 1,'2013/06/11'),
	(7, 3, 'Pedido Semanal de Helados', 1, '2013/06/15', '2013/06/22', 1,'2013/06/22'),
	(5, 3, 'Pedido Semanal de Helados', 1, '2013/06/24', '2013/06/29', 1,'2013/06/29')

INSERT INTO Orden (empleado_id, suplidor_id, NOTAS, aceptada, despachada, fecha_despachada, recibida, fecha_recibida) VALUES
(1, 3, NULL,0, 0, '5/10/2013',0, '5/10/2013'),
(5, 3, NULL,0, 0, '5/11/2013',0, '5/11/2013'),
(2, 3, NULL,1, 1, '5/12/2013',1, '5/12/2013'),
(4, 3, NULL,0,0, '5/13/2013',1, '5/13/2013'),
(4, 3, NULL,0,1, '5/14/2013',0, '5/14/2013'),
(2, 2, NULL,1,1, '5/15/2013',0, '5/15/2013'),
(1, 3, NULL,0,0, '5/16/2013',0, '5/16/2013'),
(3, 2, NULL,1,1, '5/17/2013',0, '5/17/2013'),
(4, 3, NULL,0,0, '5/18/2013',0, '5/18/2013'),
(2, 3, NULL,0,1, '5/19/2013',0, '5/19/2013'),
(5, 3, NULL,0,1, '5/20/2013',1, '5/20/2013'),
(1, 2, NULL,0,1, '5/21/2013',0, '5/21/2013'),
(3, 2, NULL,0,0, '5/22/2013',0, '5/22/2013'),
(2, 2, NULL,0,0, '5/23/2013',0, '5/23/2013'),
(1, 1, NULL,1,1, '5/24/2013',0, '5/24/2013'),
(5, 2, NULL,0,0, '5/25/2013',1, '5/25/2013'),
(2, 1, NULL,0,1, '5/26/2013',0, '5/26/2013'),
(3, 3, NULL,1,1, '5/27/2013',0, '5/27/2013'),
(1, 1, NULL,1,0, '5/28/2013',1, '5/28/2013'),
(2, 2, NULL,0,0, '5/29/2013',1, '5/29/2013'),
(4, 3, NULL,1,0, '6/1/2013',0, '6/1/2013'),
(4, 1, NULL,0,0, '6/2/2013',1, '6/2/2013')



/* Queries (para reportes) */

-- Ventas
DECLARE @fecha_empieza AS DATETIME, @fecha_termina AS DATETIME;
SET @fecha_empieza = '3/1/2013';
SET @fecha_termina = '3/31/2013'
SELECT Venta.venta_id, Venta.fecha, (SELECT SUM(Producto.precio_venta*Venta_Productos.cantidad) FROM Venta_Productos LEFT JOIN Producto ON Venta_Productos.producto_id = Producto.producto_id WHERE Venta_Productos.venta_id = Venta.venta_id) AS subtotal, SUM(Venta_Ofertas.rebaja) AS descuento, Venta.total, (CONVERT(DECIMAL(10,2), Venta.total * 0.18)) AS ITBIS FROM Venta LEFT JOIN Venta_Ofertas ON Venta.venta_id = Venta_Ofertas.venta_id WHERE Venta.fecha BETWEEN @fecha_empieza AND @fecha_termina GROUP BY Venta.venta_id, Venta.fecha, Venta.total;

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
SELECT Oferta.oferta_id, Oferta.nombre, CONVERT(DATE, Oferta.fecha_empieza), CONVERT(DATE,Oferta.fecha_termina), Oferta.hora_disponible_empieza, Oferta.hora_disponible_termina, tipo, dbo.maskToDias(Oferta.dias_disponible) AS 'Dias Disponible', (SELECT COUNT(*) FROM Venta_Ofertas WHERE oferta_id = Oferta.oferta_id) AS Cantidad, (SELECT SUM(rebaja) FROM Venta_Ofertas WHERE oferta_id = Oferta.oferta_id) AS 'Ahorro Clientes' FROM Oferta


CREATE FUNCTION bitToBool (@bit as BIT)
RETURNS nvarchar(2)
BEGIN
	IF (@bit = 1)
		return 'Si'
	return 'No'
END

SELECT producto_id, nombre, dbo.bitToBool(etiqueta_negra) AS etiqueta_negra, precio_venta, precio_compra, 
	ISNULL((SELECT TOP 1 cantidad FROM RegistroInventario_Productos INNER JOIN RegistroInventario ON RegistroInventario_Productos.inventario_id = RegistroInventario.inventario_id
		 WHERE RegistroInventario_Productos.producto_id = Producto.producto_id ORDER BY RegistroInventario.fecha DESC), 0) AS Cantidad FROM Producto


SELECT * FROM Empleado