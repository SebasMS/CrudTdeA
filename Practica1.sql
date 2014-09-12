 

 create table tblPersona(
 cedula varchar(20) not null,
 nombre varchar(50) not null,
 apellido varchar(50) not null,
 fechaNacimiento date not null,
 edad int not null,
 direccion varchar(50)
 constraint pk_persona primary key(cedula)
 )

 /*Procedimiento almacenado consultar y elimnar*/
 go
 create procedure spPersonaSE(
 @operacion varchar(1),
 @cedula varchar(20)
 )
 as 
 begin
 if @operacion='S'
 select * from tblPersona where cedula=@cedula 
 else 
 if @operacion ='E'
  delete from tblPersona where cedula=@cedula
  else 
  select * from tblPersona
 end

 /*procedimiento para insertar y actualizar*/
 go
 create proc spPersonaIA(
 @operacion varchar(1),
 @cedula varchar(20),
 @nombre varchar(50),
 @apellido varchar(50),
 @fechaNacimiento date,
 @edad int,
 @direccion varchar(50)
 ) 
 as
 begin
 if @operacion ='I'/*para insertar en la bd*/
 insert into tblPersona values(@cedula,@nombre,@apellido,@fechaNacimiento,@edad,@direccion)
 else 
 if @operacion ='A'/*para actualizar*/
 update tblPersona set nombre=@nombre,
 apellido=@apellido,
 fechaNacimiento=@fechaNacimiento,
 edad=@edad,
 direccion=@direccion 
 where cedula=@cedula
 end