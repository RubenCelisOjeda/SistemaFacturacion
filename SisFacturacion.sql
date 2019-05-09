create database SistemaFacturacion

use SistemaFacturacion

CREATE TABLE Usuario(
IdUsu int primary key identity,
NomUsu nvarchar(50),
Usuario nvarchar(30),
Password nvarchar(30),
)

alter table Usuario add Tel nvarchar(20)
alter table Usuario add Ema nvarchar(50)
alter table Usuario add ApeUsu nvarchar(50)

select *
from  Cliente where Nombre = 'otro' or case when Nombre = '' then 



select *
from Factura


alter table Usuario add foreign key (IdCli)references Cliente (IdCli)
alter table Factura add foreign key (NumPag)references Modo_Pago (NumPag)

alter table Factura add IdCli int
alter table Factura add foreign key (IdCli)references Cliente (IdCli)

create table Cliente(
IdCli int primary key identity,
Nombre nvarchar(50),
Apellido nvarchar(50),
Direccion nvarchar(50),
FecNac date,
Telefono nvarchar(20),
Email nvarchar(50),
)

alter table Cliente add IdUsu int 
alter table Cliente add foreign key (IdUsu)references Usuario (IdUsu)

select *
from Cliente

CREATE TABLE Factura(
IdFac int primary key identity,
IdCli int,
Fec smalldatetime,
NumPag int,
)


select *
from Factura


CREATE TABLE Factura_Producto(
IdFacPro int primary key identity,
IdFac int,
IdPro int,
Can int,
Pre decimal,
)

drop table Factura_Producto
drop table Factura

alter table Factura_Producto add foreign key (IdFac)references Factura(IdFac)
alter table Factura_Producto add foreign key (IdPro)references Producto(IdPro)

CREATE TABLE Modo_Pago(
NumPag int primary key,
Nom nvarchar(50),
OtrDet nvarchar(50),
)

select *
from Modo_Pago


CREATE TABLE Producto(
IdPro int primary key identity,
Nom nvarchar(50),
Pre decimal,
Stock int,
)
alter table Producto add IdCat int
alter table Producto add foreign key(IdCat) references Categoria(IdCat)

CREATE TABLE Categoria(
IdCat int primary key identity,
Nom nvarchar(50),
Des nvarchar(100),
)

select *
from Usuario

insert into Usuario values ('Ruben','rubneco','123','936235142','sistemas.celis@gmail.com','Celis')

select * 
from Usuario


select *
from Cliente

insert into Cliente values('Ruben','Celis Ojeda','Mz G1 Lt 2','22/02/2019','Tel','sistemas.celis@gmail.com')

CREATE PROCEDURE SP_ValUsu
@Usu nvarchar(30),
@Pass nvarchar(30)
as
select *
from Usuario  WHERE Usuario = @Usu AND Password = @Pass

alter table Usuario add Email

CREATE PROCEDURE SP_InsUsu
@Nom nvarchar(50),
@Ape nvarchar(50),
@Dir nvarchar(50),
@Tel nvarchar(20),
@Email nvarchar(50),
@Usu nvarchar(50),
@Pass nvarchar(50)
as
	INSERT INTO Usuario (NomUsu,
						 Usuario,
						 Password,
						 Tel,
						 Ema,
						 ApeUsu)
						VALUES
						(@Nom,
						 @Usu,
						 @Pass,
						 @Tel,
						 @Email,
						 @Ape)

select *
from Usuario	

select *
from Cliente


CREATE PROCEDURE SP_ValEma
@Ema nvarchar(50)
as
select * from Usuario where Ema = @Ema


CREATE PROCEDURE SP_InsCli
@Nom nvarchar(50),
@Ape nvarchar(50),
@Dir nvarchar(50),
@FecNac date,
@Tel nvarchar(20),
@Ema nvarchar(50),
@IdUsu int
as

INSERT INTO Cliente (Nombre,
					 Apellido,
					 Direccion,
					 FecNac,
					 Telefono,
					 Email,
					 IdUsu)
					 VALUES
					 (@Nom,
					  @Ape,
					  @Dir,
					  @FecNac,
					  @Tel,
					  @Ema,
					  @IdUsu)

					

select *
from Categoria

insert into Categoria values ('Construcción','Obra')
insert into Categoria values ('Textil','telas')
insert into Categoria values ('Ganaderia','animales y ganados')
insert into Categoria values ('Pesca','marinos')
insert into Categoria values ('Servicio social','ciudadania')

select *
from Producto

alter table Producto add IdUsu int
alter table Producto add foreign key (IdUsu)references Usuario(IdUsu)

insert into Modo_Pago values('Efectivo','dinero')
insert into Modo_Pago values('Tarjeta visa','visa')
insert into Modo_Pago values('Cheque','Cheque')
insert into Modo_Pago values('Intercambio','Intercambio u otro')
insert into Modo_Pago values('Credito','cuotas')

CREATE PROCEDURE SP_RecCat
as
select * from Categoria

alter PROCEDURE SP_GuaPro
@Nom nvarchar(50),
@Pre decimal,
@Stock int,
@IdCat int,
@IdUsu int,
@IdCli int
as

insert into Producto (Nom,
					  Pre,
					  Stock,
					  IdCat,
					  IdUsu,
					  IdCli)
					  VALUES
					 (@Nom,
					  @Pre,
					  @Stock,
					  @IdCat,
					  @IdUsu,
					  @IdCli)
					  
					  
			
select *
from Cliente				

delete from Producto
alter table Producto alter column Pre nvarchar(20)
alter table Factura add NumFac nvarchar(50)

CREATE PROCEDURE SP_GuaFac
@IdCli int,
@Fec smalldatetime,
@NumPag int,
@NumFac nvarchar(50)
as

INSERT INTO Factura (IdCli,
				     Fec,
					 NumPag,
					 NumFac)
					 VALUES
					(@IdCli,
					 @Fec,
					 @NumPag,
					 @NumFac)
					 
insert into Factura values(2,'22/02/2019',22,'0002')

select *
from Modo_Pago

insert into Modo_Pago values(22,'por todo','todo bien')

select *
from Cliente  cli  inner join  