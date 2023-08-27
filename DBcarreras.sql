create database CarrerasDB_Menta
GO
USE CarrerasDB_Menta
GO

-- Tabla Carreras
CREATE TABLE Carreras (
    id_carrera INT identity (1,1),
    nombre VARCHAR(200) NOT NULL,
	CONSTRAINT pk_Carreras PRIMARY KEY (id_carrera)
);

-- Tabla Asignaturas
CREATE TABLE Asignaturas (
    id_asignatura INT identity (1,1),
    nombre VARCHAR(200) NOT NULL,
	CONSTRAINT pk_Asignatura PRIMARY KEY (id_asignatura)
);

-- Tabla Detalle_Carrera
CREATE TABLE Detalle_Carrera (
    id_detalle INT identity (1,1),
    anio_cursado INT NOT NULL,
    cuatrimestre INT NOT NULL,
    id_carrera INT,
    id_asignatura INT,
	CONSTRAINT pk_Detalles PRIMARY KEY (id_detalle),
    FOREIGN KEY (id_carrera) REFERENCES Carreras(id_carrera),
    FOREIGN KEY (id_asignatura) REFERENCES Asignaturas(id_asignatura)
);
--Insertar asignaturas
insert into asignaturas values ('Matemática')
insert into asignaturas values ('Ingles')
insert into asignaturas values ('Estadística')
insert into asignaturas values ('Laboratorio 1')
insert into asignaturas values ('Laboratorio 2')
insert into asignaturas values ('Programación 1')
insert into asignaturas values ('Programación 2')
insert into asignaturas values ('Legislación')
insert into asignaturas values ('Contabilidad')

--Procedimientos Almacenados

--CONSULTAR ASIGNATURAS
CREATE PROCEDURE [dbo].[SP_CONSULTAR_ASIGNATURAS]
AS
BEGIN
	
	SELECT * from Asignaturas;
END

--INSERTAR MAESTRO
CREATE PROCEDURE  [dbo].[SP_INSERTAR_MAESTRO] 
@nombre varchar(200),
@id_carrera int output
as
begin
	insert into carreras(nombre) 
	values(@nombre);
	set @id_carrera = SCOPE_IDENTITY();
end

--INSERTAR DETALLE
CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLE]
@anioCursado int,
@cuatrimestre int,
@id_carrera int,
@id_asignatura int
as
begin
	insert into Detalle_Carrera(anio_cursado, cuatrimestre, id_carrera, id_asignatura)
	values(@anioCursado, @cuatrimestre, @id_carrera, @id_asignatura)
end