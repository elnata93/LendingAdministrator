create database LendingAdministratorDb;
go
use LendingAdministratorDb;
go
create table Usuarios(
UsuarioId int primary key identity(1,1),
Nombres varchar(30),
Apellidos varchar(30),
NombresUsuarios varchar(40),
Contrasena varchar(30),
TiposUsuarios varchar(15)
);
go
create table Cobradores(
CobradorId int primary key identity(1,1),
Nombres varchar(30),
Apellidos varchar(30),
Direccion varchar(100),
Telefono varchar(14),
Celular varchar(14),
Cedula varchar(13)
);
go
create table Rutas(
RutaId int primary key identity(1,1),
NombreRuta varchar(100),
CobradorId int 
);
go
create table RutasCobradores(
RutasCobradoresId int primary key identity(1,1),
RutaId int references Rutas(RutaId),
CobradorId int references Cobradores(CobradorId)
);
go
create table Clientes(
ClienteId int primary key identity(1,1),
Nombres varchar(30),
Apellidos varchar(30),
Apodos varchar(30),
Sexo int,
Cedula varchar(13),
Direccion varchar(100),
Referencia varchar(50),
Telefono varchar(14),
Celular varchar(14)
);
go
create table Prestamos(PrestamoId int primary key identity(1,1),
ClienteId int references Clientes(ClienteId),
FechaInicial varchar(40),
FechaVencimiento varchar(40),
Monto float, 
NuSemana int,
CantidadCuota float,
Cuota float,
Interes float,
PagoTotal float);
go                            
create table Atrasos(
AtrasoId int primary key identity(1,1),
PrestamoId int,
Cantidad int,
Atraso float,
Total float);


select * from Usuarios;select * from Rutas;select * from Cobradores;
select * from Clientes;select * from Prestamos;select * from Atrasos;
select * from  RutasCobradores;

drop table Usuarios;drop table Rutas;drop table Cobradores;drop table Clientes;
drop table Prestamos;drop table Atrasos;drop table RutasCobradores;

insert into Usuarios(Nombres,NombresUsuarios,AreaUsuarios,Contrasena,Fecha) values('Deninson', 'deninson18', 'Administrador','12345','12-03-2015');
insert into Usuarios(Nombres,NombresUsuarios,AreaUsuarios,Contrasena,Fecha) values('Natanael', 'elnata93', 'Administrador','12345','12-03-2015');
--delete from Cobradores where CobradorId=2;
                            
--insert into Rutas(NombreRuta,CobradorId) Values ('Pimentel',1)
--select c.Nombres,c.Apellidos,c.Direccion,r.RutaId from Rutas r inner join Cobradores c on c.CobradorId = r.CobradorId where RutaId=3;
--insert into Cobradores(Nombres,Apellidos,Direccion,Telefono,Celular,Cedula) Values ('Anthony','Burgos','Los arcarizos','8092905555','80934324342','0564324324324')

--select c.CobradorId, c.Nombres,c.Apellidos from Cobradores c inner join Rutas r on c.CobradorId = r.CobradorId;