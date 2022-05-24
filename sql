
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
