CREATE DATABASE Clinica_San_Juan;
GO

USE Clinica_San_Juan;
GO

CREATE TABLE [Clientes] (
  [cliente_Cedula] INTEGER PRIMARY KEY,
  [Nombre_Cs] CHAR(50),
  [Apellido_Cs] CHAR(50),
  [NTelefono_CS] CHAR(8),
  [Fecha_Nacimiento_CS] DATE,
  [Correo_CS] CHAR(50),
  [Contraseña_CS] CHAR(50)
)
GO

CREATE TABLE [Empleado] (
  [Empleado_Cedula] INTEGER PRIMARY KEY,
  [Nombre_Em] CHAR(50),
  [Apellido_Em] CHAR(50),
  [hora_de_entrada] TIME,
  [hora_de_salida] TIME,
  [Fecha_De_Nacimiento_Em] DATE,
  [Ntelefono_Em] CHAR(8),
  [Correreo_Em] CHAR(50),
  [Contraseña_Em] CHAR(50),
  [Salario_Em] FLOAT,
  [Puesto_Em] CHAR(50)
)
GO

CREATE TABLE [Cita] (
  [Cita_id] INT PRIMARY KEY,
  [fecha_cita] TIME,
  [Cliente] INT,
  [Empleado] INT,
  [Estado] CHAR(50),
  [motivo] CHAR(50),
  [Comentarios] CHAR(50)
)
GO

CREATE TABLE [Expediente] (
  [Expediente_id] INT PRIMARY KEY,
  [Cliente_Ex_id] INT,
  [Fecha_de_Actualizacion] DATE,
  [Comentarios_exp] CHAR(50),
  [Encargado_Emp_id] INT
)
GO

CREATE TABLE [facturas] (
  [Factura_id] INT PRIMARY KEY,
  [fecha_factu] DATE,
  [Total_Fact] FLOAT,
  [Cliente_id] INT,
  [producto_id] INT
)
GO

CREATE TABLE [comentarios] (
  [Comentario_id] INT PRIMARY KEY,
  [Cliente_Ct_id] INT,
  [fecha_Creacion] DATE,
  [Comentario] CHAR(50)
)
GO

CREATE TABLE [Productos] (
  [producto_id] INT PRIMARY KEY,
  [producto_nombre] CHAR(50),
  [producto_descripcion] CHAR(50),
  [producto_precio] DECIMAL,
  [fecha_de_ingreso] TIME,
  [Cantidad_stock] INT
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
