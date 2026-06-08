SET AUTOCOMMIT=0;
START TRANSACTION;

DROP DATABASE if EXISTS 5to_Calzados

create DATABASE 5to_Calzados

use 5to_Calzados


CREATE TABLE Cliente(
    dni int PRIMARY KEY AUTO_INCREMENT,
    nombre varchar(45) not null,
    apellido varchar(45) not null,
    nacimiento DATETIME not null,
    correo varchar(45) not null
);

CREATE TABLE Color(
    idColor int PRIMARY KEY,
    nombre varchar(45)
);

CREATE TABLE Compra(
    numeroCompra int PRIMARY KEY AUTO_INCREMENT,
    dni int,
    fechaHora DATETIME,
    FOREIGN KEY (dni) REFERENCES Cliente (dni)
);

CREATE TABLE DetalleCompra(
    numeroCompra int PRIMARY KEY AUTO_INCREMENT,
    idModelo int NOT NULL,
    talle int NOT NULL,
    idZapatilla int NOT NULL,
    precioUnitario int NOT NULL,
    cantidad int
);
CREATE TABLE RazonDevolucion(
    idRazon int PRIMARY KEY,
    Descripcion varchar(45)
);


CREATE TABLE Devolucion(
    idDevolucion int PRIMARY KEY AUTO_INCREMENT,
    dni int,
    idRazon int,
    fechaHora DateTime,
    FOREIGN KEY (idRazon) REFERENCES RazonDevolucion (idRazon),
    FOREIGN KEY (dni) REFERENCES Cliente (dni)
);

CREATE TABLE Fabricante(
    idFabricante int PRIMARY KEY,
    NombreFab varchar(45)
);

CREATE TABLE ModeloColor(
idModelo int ,
idColor int ,
FOREIGN KEY (idModelo) REFERENCES Modelo(idModelo),
FOREIGN KEY (idColor) REFERENCES Color(idColor)
);

CREATE TABLE Pais(
    idPais int PRIMARY KEY,
    nombre VARCHAR(45)
);

CREATE TABLE Modelo(
idModelo int PRIMARY KEY,
idFabricante int,
nombre VARCHAR(45),
idPais int,
FOREIGN KEY (idPais) REFERENCES Pais (idPais),
FOREIGN KEY (idFabricante) REFERENCES Fabricante(idFabricante)
);

