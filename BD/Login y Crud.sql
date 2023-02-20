CREATE DATABASE LoginCrud;

USE LoginCrud;

CREATE TABLE TablaLogin(
	Id int PRIMARY KEY NOT NULL,
	Contraseña varchar (50),
	Roll varchar (50),
	Nombre varchar (50),
	Correo varchar (50),
	Pais varchar (50),
	Ocupacion varchar (50)
);

CREATE TABLE Reporte(
	IdFactura int PRIMARY KEY NOT NULL,
	fecha date not null,
	hora time not null,
	producto varchar(50) not null,
	cod_producto int not null,
	cantidad_producto int not null,
	precio_unitario decimal(9,2) not null,
	precio_total decimal(9,2) not null,
	Cod_cliente int not null,
	nombre1_cliente varchar(50) not null,
	nombre2_cliente varchar(50) not null,
	apellido1_cliente varchar(50) not null,
	apellido2_cliente varchar(50) not null,
	correo varchar(50) not null,
	codigo_postal int not null,
	pais varchar(50) not null,
	region varchar(50) not null,
	departamento varchar(50) not null,
	municipio varchar(50) not null,
	zona int not null,
	colonia varchar(50) not null,
	avenida varchar(50) not null,
	numero_casa varchar(50) not null,
	telefono1_cliente int not null,
	telefono2_cliente int not null,
);




INSERT INTO TablaLogin VALUES (100,'Chiripa','Administrador','Ivan','ivan2020@gmai.com','Guatemala','Estudiante');
INSERT INTO TablaLogin VALUES (200,'Nose','Secretario','Jhonatan','jhona20@gmail.com','Guatemala','Estudiante');
INSERT INTO TablaLogin VALUES (300,'NoseB','Usuario','Santizo','a@gmail.com','Guatemala','Estudiante');

INSERT INTO Reporte VALUES (1,'2023-02-15','22:50:51','Computadora hp',100,1,4999.99,4999.99,1,'Jhonatan','Ivan','Santizo','Martinez','ivansantizo@gmail.com',01057,
'Guatemala','Región metropolitana','Guatemala','Mixco','7','Colonia Belen','5ta avenida','11-01',50515815,
74859655);
INSERT INTO Reporte VALUES (2,'2023-02-16','07:26:42','Mousepad Argom',200,2,60.00,120.00,2,'Angel','Javier','Torres','Turcios','angelturcios@gmail.com',01057,
'Guatemala','Región metropolitana','Guatemala','Mixco','7','Colonia Belen','6ta avenida','20-02',50514285,
74369655);
INSERT INTO Reporte VALUES (3,'2023-02-18','07:34:48','Mousepad Argom',300,4,60.00,240.00,3,'Jose','Daniel','Sandoval','Saban','josedaniel@gmail.com',01057,
'Guatemala','Región metropolitana','Guatemala','Mixco','7','Colonia Belen','6ta avenida','20-02',50514285,
74362580);
INSERT INTO Reporte VALUES (4,'2023-02-19','08:10:11','Computadora hp',400,2,4999.99,9999.98,4,'Marcos','Steven','Silvestre','Axjup','marcossilvestre@gmail.com',01057,
'Guatemala','Región metropolitana','Guatemala','Mixco','7','Colonia Belen','2da avenida','40-04',47894565,
20201536);
INSERT INTO Reporte VALUES (5,'2023-02-21','15:18:17','Mousepad Argom',500,3,60.00,180.00,5,'Pablo','Emilio','Socop','Culajay','pablosocop@gmail.com',01057,
'Guatemala','Región metropolitana','Guatemala','Mixco','7','Colonia Belen','4ta avenida','50-05',63337855,
66884454);

SELECT *FROM Reporte;

