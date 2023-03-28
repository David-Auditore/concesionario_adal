create database DB_Concesionario;
use DB_Concesionario;

create table vehiculo
(
placa varchar(8)primary key,
modelo varchar(4),
color varchar(10),
marca varchar(20),
precio float
);

--insertar registro

insert into vehiculo(placa,modelo,color,marca,precio)values('ARM 356','2009','vinotinto','KIA',45000000);
insert into vehiculo(placa,modelo,color,marca,precio)values('XZD 000','1998','rojo','BMW',28000000);
insert into vehiculo(placa,modelo,color,marca,precio)values('JJG 789','2000','blanco','Renault.',33000000);
insert into vehiculo(placa,modelo,color,marca,precio)values('OPU 123','2018','plateado','ford',30000000);
insert into vehiculo(placa,modelo,color,marca,precio)values('VJF 091','1993','negro','TOYOTA',23000000);


--Actualizar 

update vehiculo set marca='Volkswagen',color='azul',precio= 52000000 where placa='ARM 356';

--consultar

select * from vehiculo;
select * from vehiculo where placa='JJG 789'

--eliminar registro

delete from vehiculo where placa='XZD 000'

--guardar registro

create procedure usp_guardar_vehiculo
--parametros
@placa varchar(8),
@modelo varchar(4),
@color varchar(10),
@marca varchar(20),
@precio float
as
begin
--procesos
insert into vehiculo(placa,modelo,color,marca,precio)values(@placa,@modelo,@color,@marca,@precio)
end

--ejecutar sp

execute usp_guardar_vehiculo 'yyv 163','1990','verde','renault',18000000

select * from vehiculo

--Actualizar

create procedure usp_actualizar_vehiculo
--parametros

@placa varchar(8),
@modelo varchar(4),
@color varchar(10),
@marca varchar(20),
@precio float
as
begin
--procesos
update vehiculo set placa=@placa,modelo=@modelo,color=@color,marca=@marca,precio=@precio
where placa=@placa
end

--ejecutar un procedimiento
execute usp_actualizar_vehiculo 'mnk 995','2002','dorado','NISSAN',35000000

--eliminar
--fuction usp_delete-vehiculo(placa){
--
--}

create procedure usp_delete_vehiculo
--parametros
@placa varchar(8)
as
begin
delete from vehiculo where placa=@placa
end

execute usp_delete_vehiculo 'XZD 000'

--consultar un vehiculo

create procedure usp_consultar_vehiculo
--parametros
@placa varchar(8)
as 
begin
select * from vehiculo where placa=@placa 
end

execute usp_consultar_vehiculo 'OPU 123'

--listar todos los vehiculos

create procedure usp_listar_vehiculo
as
begin
select * from vehiculo
end


create table propietario
(
id varchar(15)primary key,
nombre varchar(40),
apellido varchar(60),
edad int,
telefono varchar(15)
);

insert into propietario(id,nombre,apellido,edad,telefono)values('1005735823','Mario','Alvarez',20,'3103670825');
insert into propietario(id,nombre,apellido,edad,telefono)values('8620831','Juliana','Perez',25,'3113300942');
insert into propietario(id,nombre,apellido,edad,telefono)values('28319064','David','Guerrero',30,'3009061170');
insert into propietario(id,nombre,apellido,edad,telefono)values('1006834208','Cristina','Gonzalez',19,'3140311278');
insert into propietario(id,nombre,apellido,edad,telefono)values('1005735823','Hector','Vasquez',35,'3012244654');

--actualizar
update propietario set nombre='Merlina',telefono='3217360954'
where id='8620831'
--consultar
select * from propietario
--eliminar
delete from propietario where id='8620831'

--guardar registro

create procedure usp_guardar_propietario
@id varchar(15),
@nombre varchar(40),
@apellido varchar(60),
@edad int,
@telefono varchar(15)
as 
begin
insert into propietario(id,nombre,apellido,edad,telefono)values(@id,@nombre,@apellido,@edad,@telefono)
end

execute usp_guardar_propietario '37650971','Derek','Martinez',32,'3027332109'

--actualizar

create procedure usp_actualizar_propietario
@id varchar(15),
@nombre varchar(40),
@apellido varchar(60),
@edad int,
@telefono varchar(15)
as 
begin
update propietario set nombre=@nombre,apellido=@apellido,edad=@edad,telefono=@telefono where id=@id 
end

execute usp_actualizar_propietario '1006834208','Cristina','Gonzalez',19,'3140311278'

--eliminar

create procedure usp_delete_propietario
@id varchar(15)
as
begin 
delete from propietario where id=@id
end

execute usp_delete_propietario '28319064'

--consultar

create procedure usp_consultar_propietario
@id varchar(15)
as 
begin 
select * from propietario where id=@id
end
  
execute usp_consultar_propietario '1006834208'

--listar

create procedure usp_listar_propietario
as 
begin 
select * from propietario
end
