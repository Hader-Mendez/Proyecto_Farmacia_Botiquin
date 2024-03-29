CREATE DATABASE Farmacia_Botiquin
USE Farmacia_Botiquin

Create table Estado
(
	IdEstado int identity primary key,
	Estado char(8) not null unique
);
Create table Puesto
(
	IdPuesto int identity primary key,
	Puesto nvarchar(15) not null unique
);
Create table Empleado
(
	IdEmpleado int identity primary key,
	NombreEmpleado nvarchar(30) not null,
	ApellidoEmpleado nvarchar(30) not null,
	Email nvarchar(25) unique not null,
	Telefono char(8) unique null,
	IdPuesto int not null,
	IdEstado int not null,
	CONSTRAINT Fk_Empleado_Puesto Foreign key (IdPuesto)
		References Puesto(IdPuesto),
	CONSTRAINT Fk_Empleado_Estado Foreign key (IdEstado)
		References Estado(IdEstado)
);
Create table Usuario
(
	IdUsuario int identity primary key,
	Usuario nvarchar(25) unique not null,
	Contra nvarchar(20) not null,
	IdEmpleado int not null,
	IdEstado int not null,
	CONSTRAINT Fk_Usuario_Empleado Foreign key (IdEmpleado)
		References Puesto(IdPuesto),
	CONSTRAINT Fk_Usuario_Estado Foreign key (IdEstado)
		References Estado(IdEstado)
);
Create table Cliente
(
	IdCliente int identity primary key,
	DNICliente nvarchar(13) not null unique,
	NombreCliente nvarchar(30) not null,
	ApellidoCliente nvarchar(30) not null,
	Email nvarchar(25) unique,
	FechaNacimiento datetime not null,
	IdEstado int not null
	Constraint Fk_Cliente_Estado foreign key(IdEstado)
		References Estado(IdEstado)
);
Create table Proveedor
(
	CodProveedor nvarchar(13) primary key,
	RTN nvarchar(14) unique not null,
	NombreProveedor nvarchar(30) unique not null,
	Telefono char(8) unique,
	Email nvarchar(25),
	Direccion nvarchar(50),
	IdEstado int not null
	Constraint Fk_Proveedor_Estado foreign key(IdEstado)
		References Estado(IdEstado)
);
Create table Producto 
(
	CodProducto nvarchar(20) primary key,
	NombreProducto nvarchar(30) unique not null,
	Descripcion nvarchar(40) not null,
	Existencia int not null,
	FechaVencimiento date not null,
	IdEstado int not null
	Constraint Fk_Producto_Estado foreign key(IdEstado)
		References Estado(IdEstado)
);
Create table Factura
(
	IdFactura int primary key identity,
	IdEmpleado int not null,
	IdCliente int not null,
	Fecha datetime not null,
	Total float not null,
	Constraint Fk_Factura_Empleado foreign key(IdEmpleado)
		References Empleado(IdEmpleado),
	Constraint Fk_Factura_Cliente foreign key(Idcliente)
		References Cliente(IdCliente),

);

Create table DetalleFactura
(
	Id_Detall_Factura int identity primary key,
	IdFactura int not null,
	CodProducto nvarchar(20) not null,
	Cantidad int not null,
	Precio float not null,
	Constraint Fk_DetalleFactura_Factura foreign key(IdFactura)
		References Factura(IdFactura),
	Constraint Fk_DetalleFactura_Producto foreign key(CodProducto)
		References Producto(CodProducto)
);

--Datos para probar la base de datos
--================================================================================================
--Tabla de ESTADO
Insert into Estado
values('Activo')
Insert into Estado
values('Inactivo')
--================================================================================================
--Tabla de PUESTO
Insert into Puesto
values('Gerente')
Insert into Puesto
values('Administrador')
Insert into Puesto
values('Personal')
--================================================================================================
--Tabla de EMPLEADO
Insert into Empleado
values('Hader Obed', 'Mendez', 'hader.mendez@gmail.com', '89188022', 2, 1) --administrador
Insert into Empleado
values('Jordi', 'Martinez', 'ejemplo1@gmail.com', '00000001', 1, 1) --gerente
Insert into Empleado
values('Josue David', 'Lainez', 'ejemplo2@gmail.com', '00000002', 3, 1) --personal
--================================================================================================
--Tabla de USUARIO
Insert into Usuario
values('Hmendez', 'admin123', 1, 1)
--================================================================================================
--Tabla de USUARIO
Insert into Producto
values('HRT13', 'Omeprazol', 'Omeprazol Sandoz 20 mg','655','2023-09-10', 1)
--================================================================================================
Select * from Usuario
--Procedimientos almacenados
Create procedure Sp_Usuario
@IdUsuario int = null,
@Usuario nvarchar(25) = null,
@Contra nvarchar(25) = null,
@IdEmpleado int = null,
@IdEstado int = null,
@accion nvarchar(50),
@BuscarUsuario nvarchar(50) = null
AS
BEGIN
	if @accion = 'obtenerUsuario'
	BEGIN
		SELECT U.IdUsuario, U.Usuario, U.Contra, U.IdEmpleado, U.IdEstado
		FROM Usuario U
		where U.Usuario = @Usuario
	END
	Else If @accion = 'mostrar'
	BEGIN
		SELECT U.IdUsuario, U.Usuario, U.Contra, E.Email, EE.Estado
		FROM Usuario U
		inner join Empleado E
		on U.IdEmpleado = E.IdEmpleado
		inner Join Estado EE
		on U.IdEstado = EE.IdEstado
	END
	else if @accion = 'buscar'
	BEGIN
		SELECT U.Usuario, U.Contra, CONCAT(E.NombreEmpleado, ' ', E.ApellidoEmpleado) as 'Empleado', EE.Estado
		FROM Usuario U
		inner join Empleado E
		on U.IdEmpleado = E.IdEmpleado
		inner join Estado EE
		On U.IdEstado = E.IdEstado
		WHERE  CONCAT(U.Usuario, ' ', U.Contra, ' ', E.NombreEmpleado, ' ', E.ApellidoEmpleado,' ', EE.Estado) LIKE CONCAT('%', @BuscarUsuario,'%')
	end
	Else IF @accion = 'insertar'
	BEGIN
		INSERT INTO Usuario
		VALUES(@Usuario, @Contra, @IdEstado, @IdEmpleado)
	END
	ELSE IF @accion = 'editar'
	BEGIN
		UPDATE Usuario
		SET  Usuario = @Usuario, Contra = @Contra, IdEstado = @IdEstado, IdEmpleado = @IdEmpleado
		WHERE IdUsuario = @IdUsuario
	END
End

Create Procedure Sp_Empleados
@IdEmpleado int = null,
@NombreEmpleado nvarchar(30) = null,
@ApellidoEmpleado nvarchar(30) = null,
@Email nvarchar(25) = null,
@Telefono char(8) = null,
@IdPuesto int = null,
@IdEstado int = null,
@accion nvarchar(50),
@BuscarEmpleado nvarchar(50) = null
As
Begin
	if @accion = 'mostrar'
	Begin
		Select E.IdEmpleado, E.NombreEmpleado as 'Nombre', E.ApellidoEmpleado as 'Apellido', E.Email, E.Telefono, P.Puesto, EE.Estado
		From Empleado E
		Inner Join Puesto P
		On P.IdPuesto = E.IdPuesto
		Inner Join Estado EE
		on EE.IdEstado = E.IdEstado
	End
	else if @accion = 'buscar'
	BEGIN
		SELECT E.NombreEmpleado as 'Nombre', E.ApellidoEmpleado as 'Apellido', E.Email, E.Telefono, P.Puesto, EE.Estado
		FROM Empleado E
		Inner JOIN Puesto P
		ON P.IdPuesto = E.IdPuesto
		inner join Estado EE
		On EE.IdEstado = E.IdEstado
		WHERE  CONCAT(E.NombreEmpleado, ' ', E.ApellidoEmpleado, ' ', E.Email, ' ', E.Telefono, ' ', P.Puesto) LIKE CONCAT('%', @BuscarEmpleado,'%')
	END
	ELSE IF @accion = 'obtenerTelefono'
	BEGIN
		SELECT IdEmpleado as 'ID', CONCAT(NombreEmpleado, ' ' , ApellidoEmpleado) as 'Empleados', Email as 'Correo', Telefono, IdPuesto as 'Puesto', IdEstado as 'Estado'
		FROM Empleado 
		WHERE Telefono = @Telefono
	END
	ELSE IF @accion = 'obtenerCorreo'
	BEGIN
		SELECT IdEmpleado as 'ID', CONCAT(NombreEmpleado, ' ' , ApellidoEmpleado) as 'Empleados', Email as 'Correo', Telefono, IdPuesto as 'Puesto', IdEstado as 'Estado'
		FROM Empleado
		WHERE Email = @Email
	END
	Else IF @accion = 'insertar'
	BEGIN
		INSERT INTO Empleado
		VALUES(@NombreEmpleado, @ApellidoEmpleado, @Email, @Telefono, @IdPuesto, @IdEstado)
	END
	ELSE IF @accion = 'editar'
	BEGIN
		UPDATE Empleado
		SET NombreEmpleado = @NombreEmpleado, ApellidoEmpleado = @ApellidoEmpleado, Email = @Email,Telefono = @Telefono,IdPuesto = @IdPuesto, IdEstado = @IdEstado
		WHERE IdEmpleado = @IdEmpleado
	END
End

Create procedure Sp_Puesto
@IdPuesto int = null,
@Puesto nvarchar(15) = null,
@accion nvarchar(50)
as
begin
	IF @accion = 'mostrar'
	BEGIN
		SELECT  P.IdPuesto, P.Puesto
		FROM Puesto P
		ORDER BY P.Puesto ASC
	END
	Else IF @accion = 'insertar'
	BEGIN
		INSERT INTO Puesto
		VALUES(@Puesto)
	END
	ELSE IF @accion = 'editar'
	BEGIN
		UPDATE Puesto
		SET Puesto = @Puesto
		WHERE IdPuesto = @IdPuesto
	END
end

Create Procedure Sp_Estado
@IdEstado int = null,
@Estado char(8) = null,
@accion nvarchar(50)
As
Begin
	IF @accion = 'mostrar'
	BEGIN
		SELECT  E.IdEstado, E.Estado
		FROM Estado E
		ORDER BY E.Estado ASC
	END
End

Create Procedure Sp_Producto
@CodProducto nvarchar(20) = null,
@NombreProducto nvarchar(30) = null,
@Descripcion nvarchar(40) = null,
@Existencia int = null,
@FechaVencimiento date = null,
@IdEstado int = null,
@accion nvarchar(50),
@BuscarProducto nvarchar(50) = null
As
Begin
	if @accion = 'mostrar'
	Begin
		Select Pr.CodProducto, Pr.NombreProducto as 'Nombre', Pr.Descripcion, Pr.Existencia, Pr.FechaVencimiento, E.Estado
		From Producto Pr
		Inner Join Estado E
		on E.IdEstado = Pr.IdEstado
	End
	else if @accion = 'buscar'
	BEGIN
		SELECT Pr.NombreProducto as 'Nombre', Pr.Descripcion, Pr.Existencia, Pr.FechaVencimiento, E.Estado
		FROM Producto Pr
		inner join Estado E
		On E.IdEstado = Pr.IdEstado
		WHERE  CONCAT(Pr.NombreProducto, ' ', Pr.Descripcion, ' ', Pr.FechaVencimiento, ' ', E.Estado) LIKE CONCAT('%', @BuscarProducto,'%')
	end
	Else IF @accion = 'insertar'
	BEGIN
		INSERT INTO Producto
		VALUES(@CodProducto, @NombreProducto, @Descripcion, @Existencia, @FechaVencimiento, @IdEstado)
	END
	ELSE IF @accion = 'editar'
	BEGIN
		UPDATE Producto
		SET CodProducto = @CodProducto, NombreProducto = @NombreProducto, Descripcion = @Descripcion, Existencia = @Existencia, FechaVencimiento = @FechaVencimiento, IdEstado = @IdEstado
		WHERE CodProducto = @CodProducto
	END
End

--=================================================================
Create Procedure Sp_Cliente
@IdCliente int = null,
@DNICliente nvarchar(13) = null,
@NombreCliente nvarchar(30) = null,
@ApellidoCliente nvarchar(30) = null,
@Email nvarchar(25) = null,
@FechaNacimiento date = null,
@IdEstado int = null,
@accion nvarchar(50),
@BuscarCliente nvarchar(50) = null
As
Begin
	if @accion = 'mostrar'
	Begin
		Select C.IdCliente, C.DNICliente, C.NombreCliente as 'Nombre', C.ApellidoCliente as 'Apellidos', C.Email, C.FechaNacimiento, E.Estado
		From Cliente C
		Inner Join Estado E
		on E.IdEstado = C.IdEstado
	End
	else if @accion = 'buscar'
	BEGIN
		SELECT C.DNICliente, C.NombreCliente as 'Nombre', C.ApellidoCliente as 'Apellidos', C.Email, C.FechaNacimiento, E.Estado
		FROM Cliente C
		inner join Estado E
		On E.IdEstado = C.IdEstado
		WHERE  CONCAT(C.DNICliente,' ',C.NombreCliente, ' ', C.ApellidoCliente, ' ',C.Email,' ', C.FechaNacimiento, ' ', E.Estado) LIKE CONCAT('%', @BuscarCliente,'%')
	end
	Else IF @accion = 'insertar'
	BEGIN
		INSERT INTO Cliente
		VALUES(@DNICliente, @NombreCliente, @ApellidoCliente, @Email, @FechaNacimiento, @IdEstado)
	END
	ELSE IF @accion = 'editar'
	BEGIN
		UPDATE Cliente
		SET DNICliente = @DNICliente, NombreCliente = @NombreCliente, ApellidoCliente = @ApellidoCliente, Email = @Email, FechaNacimiento = @FechaNacimiento, IdEstado = @IdEstado
		WHERE IdCliente = @IdCliente
	END
End
--=====================================================
Create Procedure Sp_DetalleFactura
@Id_Detall_Factura int = null,
@Cantidad int = null,
@Precio float = null,
@CodProducto nvarchar(20)= null,
@IdFactura int = null,
@accion nvarchar(50)
As
Begin
	if @accion = 'mostrar'
	Begin
		Select DF.Id_Detall_Factura,P.CodProducto, P.NombreProducto as 'Nombre', P.Descripcion, DF.Cantidad, DF.Precio
		From DetalleFactura DF
		Inner Join Producto P
		on DF.CodProducto = P.CodProducto
	End
	ELSE IF @accion = 'editar'
	BEGIN
		UPDATE DetalleFactura
		SET Cantidad = @Cantidad, Precio = @Precio
		WHERE Id_Detall_Factura = @Id_Detall_Factura
	END
End


--======================================================================
Create Procedure Sp_Factura
@IdFactura int = null,
@Fecha date = null,
@CodProducto nvarchar(20) = null,
@IdEmpleado int = null,
@IdCliente int = null,
@accion nvarchar(50)
As
Begin
	if @accion = 'mostrar'
	Begin
		Select f.IdFactura, CONCAT(c.NombreCliente, ' ', c.ApellidoCliente) as 'Nombre cliente', e.NombreEmpleado as 'Empleado', p.NombreProducto as 'Producto', df.Cantidad, df.Precio, f.Total, f.Fecha
			From DetalleFactura df
			inner join Producto p
			on p.CodProducto = df.CodProducto
			inner join Factura F
			on f.IdFactura = df.IdFactura
			inner join Cliente c
			on c.IdCliente = f.IdCliente
			inner join Empleado e
			on e.IdEmpleado = f.IdEmpleado 
	End
End
--=====================================================================
Create Procedure Sp_Proveedor
@CodProveedor nvarchar(13) = null,
@RTN nvarchar(14) = null,
@NombreProveedor nvarchar(30) = null,
@Telefono char(8) = null,
@Email nvarchar(25) = null,
@Direccion nvarchar(50) = null,
@IdEstado int = null,
@accion nvarchar(50),
@BuscarProveedor nvarchar(50) = null
As
Begin
	if @accion = 'mostrar'
	Begin
		Select P.CodProveedor,P.RTN, P.NombreProveedor as 'Nombre', P.Email, P.Direccion, P.Telefono, E.Estado
		From Proveedor P
		Inner Join Estado E
		on P.IdEstado = E.IdEstado
	End
	else if @accion = 'buscar'
	BEGIN
		SELECT P.RTN, P.NombreProveedor as 'Nombre', P.Email, P.Direccion, P.Telefono, E.Estado
		FROM Proveedor P
		inner join Estado E
		On P.IdEstado = E.IdEstado
		WHERE  CONCAT(P.RTN,' ', P.NombreProveedor,' ', P.Email,' ', P.Direccion,' ', P.Telefono,' ', E.Estado) LIKE CONCAT('%', @BuscarProveedor,'%')
	end
	Else IF @accion = 'insertar'
	BEGIN
		INSERT INTO Proveedor
		VALUES(@CodProveedor,@RTN, @NombreProveedor, @Email, @Direccion, @Telefono, @IdEstado)
	END
	ELSE IF @accion = 'editar'
	BEGIN
		UPDATE Proveedor
		SET RTN = @RTN, NombreProveedor = @NombreProveedor, Email = @Email, Direccion = @Direccion, Telefono = @Telefono, IdEstado = @IdEstado
		WHERE CodProveedor = @CodProveedor
	END
End



