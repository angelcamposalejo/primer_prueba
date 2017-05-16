create database gestionoperaciones;
use gestionoperaciones;
create table almacengeneral(
id int(10) auto_increment not null primary key,
tipo varchar(50) not null,
descripcion varchar(50) not null,
cantidad int(10)
);
create table almacenchips(
id int(10) auto_increment not null primary key,
descripcion varchar(50) not null,
folio varchar(30),
iccid varchar(30),
ruta varchar(30),
cantidad int(10) not null
);
create table almacenequipos(
id int(10) auto_increment not null primary key,
descripcion varchar(50) not null,
imei varchar(30),
ruta varchar(30),
cantidad int(10) not null
);
create table rutas(
id int(10) auto_increment not null primary key,
ruta varchar(30) not null
);
create table categoria(
id int(10) auto_increment not null primary key,
categoria varchar(30) not null
);
create table articulos(
id int(10) auto_increment not null primary key,
categoria varchar(30) not null,
descripcion varchar(50) not null
);
insert into rutas(ruta)values
('R1'),
('R2'),
('R3');
insert into categoria(categoria)values
('CHIPS'),
('EQUIPOS');
create table almacenrutas(
id int(10) auto_increment not null primary key,
ruta varchar(30) not null,
tipo varchar(50) not null,
descripcion varchar(50) not null,
cantidad int(10)
);
drop table ventas;
create table ventas(
id int(10) auto_increment not null primary key,
ruta varchar(30) not null,
tipo varchar(50) not null,
descripcion varchar(50) not null,
preciounitario double(10,2) not null,
cantidad int(10) not null,
total double(10,2) not null,
fecha date
);
create table caja(
id int(10) auto_increment not null primary key,
concepto varchar(50) not null,
cargo double(10,2) not null,
abono double(10,2) not null,
fecha date
);
drop table caja;
insert into caja(concepto,cargo,abono) values
('CAJA','0','0');
select sum(total) from ventas where ruta='R1';
alter table ventas add comision varchar(30) not null;
create table acceso(
id int(10) auto_increment not null primary key,
acceso varchar(30) not null
);
insert into acceso(acceso) values
('0f1c1n4');
create table movimientosalmacen(
id int auto_increment not null primary key,
concepto varchar(50) not null,
descripcion varchar(50) not null,
llegadas int(10) not null,
salidas int(10) not null,
fecha date 
);
drop table movimientosalmacen;
select * from ventas where cliente='ANGEL PRECOMA';
alter table almacengeneral add codigo varchar(30) not null;
alter table almacenrutas add codigo varchar(30) not null;
alter table articulos add codigo varchar(30) not null;
alter table caja add saldo double(10,4);