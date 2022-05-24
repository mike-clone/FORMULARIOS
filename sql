
create table animales
(
dueño varchar(50),
nombre varchar(50),
edad int,
raza varchar(50)
);
select* from animales;

----------------------------------------------------------

 CREATE TABLE NEGOCIO(
 CODIGO INT PRIMARY KEY,
 NOMBRE VARCHAR(50),
 RUC NUMERIC(12,0),
 DESCRIPCION VARCHAR(100),
 FECHA DATE

 );
 -- Date acepta mes dias año
 INSERT INTO NEGOCIO VALUES(1234,'ADDIN','1040268666', 'COMPRA Y VENTA', '4/15/1996');

 SELECT * FROM NEGOCIO;
 ---------------------------------------------------
 
 Create table Proveedor
(
IdProv int not null primary key,
Raz_Social varchar (150) not null,
Sector_Comercial varchar(50) not null,
tipo_documento varchar (15) not null,
num_documento int not null,
direccion varchar (50) null,
telefono int null
)

SELECT *FROM PROVEEDOR;
insert into proveedor (IdProv,Raz_Social,Sector_Comercial,tipo_documento,num_documento,direccion,telefono)
values(01,'Inv Trujillo','fdg','dni',534345,'dfbgs',54653);
--------------------------------------------------------------------




