use gestionoperaciones;
create table conceptos(
id int(10) auto_increment not null primary key,
tipo varchar(50) not null,
categoria varchar(100) not null
);
insert into conceptos(tipo,categoria) values
('Caja','Saldo Inicial'),
('Ventas','Ventas'),
('Gastos de Venta','Viaticos de Rutas'),
('Gastos de Venta','Ventas a Credito'),
('Gastos de Venta','Gasolina Rutas'),
('Gastos de Venta','Casetas'),
('Gastos de Venta','Hospedaje'),
('Gastos de Venta','Estacionamiento'),
('Gastos de Venta','Extras'),
('Gastos de Venta','Devoluciones sobre venta'),
('Gastos de Administración','Viaticos Oficina'),
('Gastos de Administración','Comida'),
('Gastos de Administración','Limpieza'),
('Gastos de Administración','Papaleria y Utiles'),
('Gastos de Administración','Servicios'),
('Gastos de Administración','Renta Oficina'),
('Gastos de Administración','Nomina'),
('Gastos de Administración','Comisiones Portas y Venta Equipos'),
('Gastos de Administración','Prestamos de Nomina'),
('Gastos de Operación','Uniformes y Credenciales'),
('Gastos de Operación','Mantenimiento Automoviles'),
('Gastos de Operación','Pension Automoviles'),
('Gastos de Operación','Publicidad'),
('Gastos de Operación','Equipos'),
('Gastos de Operación','Operaciones Cadenas'),
('David','David'),
('Marquesada','Marquesada');
alter table caja add categoria varchar(100) not null;