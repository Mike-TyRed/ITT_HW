create database tablaprueba1
go
use tablaprueba1
go
create table Users(
UserID int identity(1,1)primary key,
LoginName varchar(50) unique not null,
Email varchar(100) not null,
Telefono varchar(50) not null,
password varchar(50) not null,
Cargo varchar(50) not null
)

create Procedure InsertarUsuario
								 @LoginName varchar(50),
								 @Email varchar(100),
								 @Telefono varchar(50),
								 @password varchar(50),
								 @Cargo varchar(50)
as
insert into Users(LoginName,Email,Telefono,password,Cargo)
values(@LoginName,@Email,@Telefono,@password,@Cargo)
go

create Procedure ActualizarUsuario
								 @LoginName varchar(50),
								 @Email varchar(50),
								 @Telefono varchar(50),
								 @password varchar(50),
								 @UserID int
as
update Users set LoginName=@LoginName,
					Email=@Email,
					Telefono=@Telefono,
					password=@password
					where UserID=@UserID
go
create Procedure EliminarUsuario @UserID int

as
delete from Users where UserID=@UserID
go

create Procedure MostrarUsuario
as
select * from Users
go

insert into Users values('admin','omar@gmail.com','6643538663','admin','admin')
insert into Users values('omar','omar@gmail.com','6643538664','1234','usuario')
insert into Users values('omar2','omar@gmail.com','6643538664','1234','usuario')
insert into Users values('omar3','omar@gmail.com','6643538664','1234','admin')

select *from Users
drop table Users 

/*----------------------------------------------------------------------------------*/
CREATE TABLE [Libros] (
  [IDlibro] int identity(1,1) primary key not null,
  [Titulo] Varchar(40),
  [Autor] Varchar(40),
  [Edicion] Varchar(40),
  [Genero] Varchar(40),
);


create Procedure InsertarLibro
								 @Titulo varchar(100),
								 @Autor varchar(50),
								 @Edicion varchar(50),
								 @Genero varchar(50)
as
insert into Libros(Titulo,Autor,Edicion,Genero)
values(@Titulo,@Autor,@Edicion,@Genero)
go

create Procedure ActualizarLibro
								 @Titulo varchar(50),
								 @Autor varchar(50),
								 @Edicion varchar(50),
								 @Genero varchar(50),
								 @IDlibro int
as
update Libros set Titulo=@Titulo,
					Autor=@Autor,
					Edicion=@Edicion,
					Genero=@Genero
					where IDlibro=@IDlibro
go
create Procedure EliminarLibro @IDlibro int

as
delete from Libros where IDlibro=@IDlibro
go

create Procedure MostrarLibros
as
select * from Libros
go
/*------------------------------------------------------------------------*/
CREATE TABLE Existencia (
  [IDlibro] int identity(1,1) primary key not null,
  [Existentes] Int,
  [Disponibles] Int,
  [Rentados] Int,
  foreign key (IDlibro) references Libros(IDlibro)
);
create Procedure Stock
								 @Existentes int,
								 @Disponibles int,
								 @Rentados int
as
insert into Existencia(Existentes,Disponibles,Rentados)
values(@Existentes,@Disponibles,@Rentados)
go

select * from Existencia
select * from Libros

create Procedure MostrarDisponibles
as
select Disponibles from Existencia
go

create Procedure MostrarTítulos
								@Titulo varchar(50)
as
select * from Libros where Titulo = @Titulo
go

create Procedure MostrarGeneros
								@Genero varchar(50)
as
select * from Libros where Genero = @Genero
go

create procedure AllGeneros
as
select Genero from Libros
go
/*---------------------------------------------------------------------------------------------------*/
use tablaprueba1
CREATE TABLE Pedido (
  IDpedido int identity(1,1) primary key not null,
  UserID Int,
  IDlibro Int,
  FechaPed Varchar(40),
  FechaDev Varchar(40),
  Estado Varchar(40),
  FOREIGN KEY (UserID) references Users(UserID),
  FOREIGN KEY (IDlibro) references Libros(IDlibro)
  );


create procedure getIDuser
							@LoginName varchar(50)
as
RETURN (select UserID from Users where LoginName=@LoginName)
go 

select * from Pedido

select UserID from Users where LoginName = 'Mike'

create procedure NuevoPedido
							@UserID int,
							@IDlibro int,
							@FechaPed varchar(50),
							@FechaDev varchar(50),
							@Estado varchar(50)
as
Insert into Pedido(UserID,IDlibro,FechaPed,FechaDev,Estado) 
	values(@IDlibro,@UserID,@FechaPed,@FechaDev,@Estado)
go

create procedure MostrarPedidos
as
select * from Libros
go
create procedure Devolucion
							@Disponibles int,
							@IDlibro int
as
update Existencia set Disponibles = @Disponibles 
				where IDlibro = @IDlibro

create procedure Estados
							@Estado varchar(50),
							@IDpedido int
as
update Pedido set Estado = @Estado
		where IDpedido = @IDpedido
go

select Titulo from Libros where Autor = 'J.R.R.Tolkien' and Edicion = 'Gold'

create procedure VerDisponiblesEsp
@IDlibro int
as
RETURN (Select Disponibles from Existencia where IDlibro = @IDlibro)
go

create procedure ModificarDisponible
							@Disponibles int,
							@IDlibro int
as
update Existencia set Disponibles = @Disponibles
where IDlibro = @IDlibro
go

select * from Existencia
select * from Pedido
insert into Pedido values(2,1,'12-10-15','12-10-15','Prestado');