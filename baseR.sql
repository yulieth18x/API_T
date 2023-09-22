create database Tienda;
use Tienda;
drop database Tienda;

/********************************************************se crea la primer tabla********************************************************************/


/******************************************************segunda tabla*****************************************************************/

CREATE TABLE Productos (
    IDpro INT PRIMARY KEY,
    Nombre VARCHAR(255),
    Descripcion varchar(200),
    Precio INT
);

select * from Productos;

insert into Productos (IDpro,Nombre,Descripcion,Precio) values (100,'Bases','Una base de maquillaje que ofrece una cobertura total y duradera',25000);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (101,'Polvos','Acabado mate y duradero para un look impecable',15000);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (102,'Contorno','apariencia más equilibrada y estilizada',13500);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (103,'Correctores','Oculta imperfecciones al instante',10000);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (104,'Fijadores','Mantiene tu maquillaje en su lugar todo el día',30000);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (105,'Iluminadores','Agrega un toque de resplandor a tu belleza natural',10000);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (106,'Rubores','Añade un toque de color y vitalidad a tus mejillas',10000);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (107,'Delineadores','Define tus ojos con precisión y estilo',15000);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (108,'pestañina','Realza tus pestañas para una mirada impactante',20000);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (109,'pestañas','Dale a tus pestañas el volumen y longitud que merecen',10500);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (110,'sobra de ojos','Agrega profundidad y color a tu mirada con estilo',50000);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (111,'encrespador','Realza tus pestañas con un toque de curvatura elegante',10000);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (112,'Tratamientos','Nutre y revitaliza tu cabello con nuestros tratamientos especializados',76000);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (113,'Champoo','Limpieza y cuidado excepcionales para tu cabello',35000);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (114,'Cremas de peinar','Domina tu cabello con suavidad y estilo con nuestras cremas de peinar',40000);
insert into Productos (IDpro,Nombre,Descripcion,Precio) values (115,'Acondicionador','Hidratación y suavidad para un cabello radiante y saludable',30000);

/*procemientos almacenados*/
/*REGISTRAR*/

create procedure usp_registrar2(
@IDpro INT,
@nombre varchar(25),
@Descripcion varchar(60),
@Precio INT
)
as
begin
insert into Productos(IDpro,nombre,Descripcion,precio)
values
(
@IDpro,
@nombre,
@Descripcion,
@Precio
)
end

/*ACTUALIZAR*/

create procedure usp_actualizar2 (
@IDpro INT,
@nombre varchar(255),
@Descripcion varchar(200),
@Precio INT
)
as
begin
update Productos set
IDpro = @IDpro,
nombre = @nombre,
Descripcion = @Descripcion,
Precio = @Precio
where IDpro = @IDpro
end

/*ELIMINAR*/

create procedure usp_eliminar2(
@IDpro int
)
as
begin
delete from Productos where IDpro = @IDpro
end

/*CONSULTAR*/

create procedure usp_obtener2
@IDpro int
as
begin
select * from Productos where IDpro = @IDpro
end

/*LISTAR*/

create procedure usp_listar2
as
begin
select * from Productos
end

execute usp_listar2;
/*********************************************************Tercer Tabla***************************************************************/

CREATE TABLE Clientes (
    IDc INT PRIMARY KEY,
    nombre VARCHAR(25),
	apellido varchar(25),
    direccion VARCHAR(40),
    correoElectronico VARCHAR(50),
    telefono VARCHAR(20),
	codigoPostal varchar(20)
);

/*registros para la tabla clientes*/
INSERT INTO Clientes (IDc,nombre,apellido, direccion,correoElectronico, telefono,CodigoPostal)
VALUES (1001,'Juan','perez','santa rita','juan@gamail.com','3009764433', '12345');
INSERT INTO Clientes (IDc,nombre,apellido, direccion,correoElectronico, telefono,CodigoPostal)
VALUES (1002,'ana','lopez','virginia','ana@gamail.com','3214453756', '4322');
INSERT INTO Clientes (IDc,nombre,apellido, direccion,correoElectronico, telefono,CodigoPostal)
VALUES (1003,'laura','ruiz','ciudad dorada','laura@gamail.com','3176578833', '7700');
INSERT INTO Clientes (IDc,nombre,apellido, direccion,correoElectronico, telefono,CodigoPostal)
VALUES (1004,'antonia','rodriguez','puerto espejo','antonia@gamail.com','3147659987', '4567');

select * from Clientes;

/*procemientos almacenados*/
/*REGISTRAR*/

create procedure usp_registrar3(
@IDc INT,
@nombre varchar(255),
@apellido varchar (25),
@direccion varchar (40),
@correoElectronico VARCHAR(50),
@telefono VARCHAR(20),
@codigoPostal varchar(20)
)
as
begin
insert into Clientes(IDc,nombre,apellido,direccion,correoElectronico,telefono,codigoPostal)
values
(
@IDc,
@nombre,
@apellido,
@direccion,
@correoElectronico,
@telefono,
@codigoPostal
)
end

/*ACTUALIZAR*/

create procedure usp_actualizar3 (
@IDc INT,
@nombre varchar(255),
@apellido varchar (25),
@direccion varchar (40),
@correoElectronico VARCHAR(50),
@telefono VARCHAR(20),
@codigoPostal varchar(20)
)
as
begin
update Clientes set
IDc = @IDc,
nombre = @nombre,
apellido = @apellido,
direccion = @direccion,
correoElectronico = @correoElectronico,
telefono = @telefono,
codigoPostal = @codigoPostal
where IDc = @IDc
end

/*ELIMINAR*/

create procedure usp_eliminar3(
@IDc int
)
as
begin
delete from Clientes where IDc = @IDc
end

/*CONSULTAR*/

create procedure usp_obtener3
@IDc int
as
begin
select * from Clientes where IDc = @IDc
end

/*LISTAR*/

create procedure usp_listar3
as
begin
select * from Clientes
end

/**************************************************************** Cuarta Tabla ********************************************************************************/

create TABLE Pedidos (
IDpe INT PRIMARY KEY,
Fecha DATETIME,
fk_IDc INT,
fk_IDpro int,
direccionEnvio varchar(30),
FOREIGN KEY (fk_IDc) REFERENCES Clientes (IDc),
foreign key (fk_IDpro) references Productos (IDpro)
);

 /*registros para la tabla PEDIDOS*/


INSERT INTO Pedidos (IDpe, Fecha, fk_IDc,fk_IDpro,direccionEnvio) VALUES (2002, '2023-08-15', 1002, 101, 'Avenida X, Ciudad Y');
INSERT INTO Pedidos (IDpe, Fecha, fk_IDc,fk_IDpro,direccionEnvio) VALUES (2003, '2023-08-20', 1003, 102,'Calle Z, Ciudad W');
INSERT INTO Pedidos (IDpe, Fecha, fk_IDc,fk_IDpro,direccionEnvio) VALUES (2004, '2023-08-25', 1001, 102,'Calle C, Ciudad D');
INSERT INTO Pedidos (IDpe, Fecha, fk_IDc,fk_IDpro,direccionEnvio) VALUES (2005, '2023-08-26', 1002, 103,'Avenida Y, Ciudad X');
INSERT INTO Pedidos (IDpe, Fecha, fk_IDc,fk_IDpro,direccionEnvio) VALUES (2006, '2023-08-28', 1003, 100,'Calle E, Ciudad F');
INSERT INTO Pedidos (IDpe, Fecha, fk_IDc,fk_IDpro,direccionEnvio) VALUES (2007, '2023-08-30', 1001,111, 'Calle G, Ciudad H');

select * from Pedidos;

/*procemientos almacenados*/
/*REGISTRAR*/

create procedure usp_registrar4(
@IDpe INT,
@fecha datetime,
@fk_IDc int,
@fk_IDpro int,
@direccionEnvio varchar(30)
)
as
begin
insert into pedidos(IDpe, Fecha, fk_IDc,fk_IDpro, direccionEnvio)
values
(
@IDpe,
@fecha, 
@fk_IDc,
@fk_IDpro,
@direccionEnvio
)
end

/*ACTUALIZAR*/

create procedure usp_actualizar4 (
@IDpe INT,
@fecha datetime,
@fk_IDc int,
@fk_IDpro int,
@direccionEnvio varchar(30)
)
as
begin
update pedidos set
IDpe = @IDpe,
fecha = @fecha,
fk_IDc = @fk_IDc,
fk_IDpro = @fk_IDpro,
direccionEnvio = @direccionEnvio
where IDpe = @IDpe
end

/*ELIMINAR*/

create procedure usp_eliminar4(
@IDpe int
)
as
begin
delete from pedidos where IDpe = @IDpe
end

/*CONSULTAR*/

create procedure usp_obtener4
@IDpe int
as
begin
select * from Pedidos where IDpe = @IDpe
end

/*LISTAR*/

create procedure usp_listar4
as
begin
select * from pedidos
end

/********************************************* QUINTA TABLA ************************************************************************/

CREATE TABLE Proveedores (
IDprov INT PRIMARY KEY,
nombre VARCHAR(25),
apellido varchar(25),
telefono VARCHAR(20),
correoElectronico VARCHAR(50),
direccion VARCHAR(255)
);

INSERT INTO Proveedores (IDprov, nombre,apellido, telefono, CorreoElectronico, direccion)
VALUES (20, 'juan',' Pérez', '123456789', 'juan@proveedora.com', 'san jose');
INSERT INTO Proveedores (IDprov, nombre, apellido, telefono,  CorreoElectronico, direccion)
VALUES (21,  'María',' López', '987654321', 'maria@proveedorb.com', 'san francisco');

/*procemientos almacenados*/
/*REGISTRAR*/

create procedure usp_registrar5(
@IDprov INT,
@nombre VARCHAR(25),
@apellido varchar(25),
@telefono VARCHAR(20),
@correoElectronico VARCHAR(50),
@direccion VARCHAR(50)
)
as
begin
insert into Proveedores(IDprov,nombre,apellido,telefono,correoElectronico,direccion)
values
(
@IDprov,
@nombre,
@apellido,
@telefono,
@correoElectronico,
@direccion
)
end

/*ACTUALIZAR*/

create procedure usp_actualizar5 (
@IDprov INT,
@nombre VARCHAR(25),
@apellido varchar(25),
@telefono VARCHAR(20),
@correoElectronico VARCHAR(50),
@direccion VARCHAR(255)
)
as
begin
update Proveedores set
IDprov = @IDprov,
nombre = @nombre,
apellido = @apellido,
telefono = @telefono,
correoElectronico = @correoElectronico,
direccion = @direccion
where IDprov = @IDprov
end

/*ELIMINAR*/

create procedure usp_eliminar5(
@IDprov int
)
as
begin
delete from Proveedores where @IDprov = @IDprov
end

/*CONSULTAR*/

create procedure usp_obtener5
@IDprov int
as
begin
select * from Proveedores where @IDprov = @IDprov
end

/*LISTAR*/

create procedure usp_listar5
as
begin
select * from Proveedores
end

execute usp_listar5;