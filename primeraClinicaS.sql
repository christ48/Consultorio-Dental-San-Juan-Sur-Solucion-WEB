Create database Clinica_San_Juan;
go

USE Clinica_San_Juan;
GO
CREATE TABLE [Clientes] (
  [cliente_Cedula] integer PRIMARY KEY,
  [Nombre_Cs] char,
  [Apellido_Cs] char,
  [NTelefono_CS] char,
  [Fecha_Nacimiento_CS] date,
  [Correo_CS] char,
  [Contraseña_CS] char
)
GO

CREATE TABLE [Empleado] (
  [Empleado_Cedula] integer PRIMARY KEY,
  [Nombre_Em] char,
  [Apellido_Em] char,
  [hora_de_entrada] time,
  [hora_de_salida] time,
  [Fecha_De_Nacimiento_Em] date,
  [Ntelefono_Em] char,
  [Correreo_Em] char,
  [Contraseña_Em] char,
  [Salario_Em] float,
  [Puesto_Em] char
)
GO

CREATE TABLE [Cita] (
  [Cita_id] int PRIMARY KEY,
  [fecha_cita] time,
  [Cliente] int,
  [Empleado] int,
  [Estado] char,
  [motivo] char,
  [Comentarios] char
)
GO

CREATE TABLE [Expediente] (
  [Expediente_id] int PRIMARY KEY,
  [Cliente_Ex_id] int,
  [Fecha_de_Actualizacion] date,
  [Comentarios_exp] char,
  [Encargado_Emp_id] INt
)
GO

CREATE TABLE [facturas] (
  [Factura_id] int PRIMARY KEY,
  [fecha_factu] date,
  [Total_Fact] float,
  [Cliente_id] int,
  [producto_id] int
)
GO

CREATE TABLE [comentarios] (
  [Comentario_id] int PRIMARY KEY,
  [Cliente_Ct_id] int,
  [fecha_Creacion] date,
  [Comentario] char
)
GO

CREATE TABLE [Productos] (
  [producto_id] int PRIMARY KEY,
  [producto_nombre] char,
  [producto_descripcion] char,
  [producto_precio] decimal,
  [fecha_de_ingreso] time,
  [Cantidad_stock] int
)
GO

ALTER TABLE [Cita] ADD FOREIGN KEY ([Cliente]) REFERENCES [Clientes] ([cliente_Cedula])
GO

ALTER TABLE [Cita] ADD FOREIGN KEY ([Empleado]) REFERENCES [Empleado] ([Empleado_Cedula])
GO

ALTER TABLE [facturas] ADD FOREIGN KEY ([producto_id]) REFERENCES [Productos] ([producto_id])
GO

ALTER TABLE [facturas] ADD FOREIGN KEY ([Cliente_id]) REFERENCES [Clientes] ([cliente_Cedula])
GO

ALTER TABLE [comentarios] ADD FOREIGN KEY ([Cliente_Ct_id]) REFERENCES [Clientes] ([cliente_Cedula])
GO

ALTER TABLE [Expediente] ADD FOREIGN KEY ([Cliente_Ex_id]) REFERENCES [Clientes] ([cliente_Cedula])
GO

ALTER TABLE [Expediente] ADD FOREIGN KEY ([Encargado_Emp_id]) REFERENCES [Empleado] ([Empleado_Cedula])
GO
