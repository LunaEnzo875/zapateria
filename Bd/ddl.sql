SET AUTOCOMMIT=0;
START TRANSACTION;

DROP DATABASE if EXISTS 5to_Calzados;

CREATE DATABASE 5to_Calzados;

use 5to_Calzados;


CREATE TABLE Cliente(
    idCliente int PRIMARY KEY AUTO_INCREMENT,
    dni int NOT NULL UNIQUE,
    nombre varchar(45) NOT NULL,
    apellido varchar(45) NOT NULL,
    nacimiento DATE NOT NULL,
    correo varchar(45) NOT NULL
);
CREATE TABLE Color(
    idColor int PRIMARY KEY,
    nombre varchar(45)
);

CREATE TABLE Pais(
    idPais int PRIMARY KEY,
    nombre VARCHAR(45)
);

CREATE TABLE Fabricante(
    idFabricante int PRIMARY KEY,
    NombreFab varchar(45)
);

CREATE TABLE Modelo(
idModelo int PRIMARY KEY,
idFabricante int,
nombre VARCHAR(45),
idPais int,
FOREIGN KEY (idPais) REFERENCES Pais (idPais),
FOREIGN KEY (idFabricante) REFERENCES Fabricante(idFabricante)
);

CREATE TABLE Zapatilla(
    idZapatilla int PRIMARY KEY,
    idModelo int,
    talla int,
    stock int,
    nombre varchar(45),
    FOREIGN KEY (idModelo) REFERENCES Modelo (idModelo)
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
    cantidad int,
    FOREIGN KEY(idZapatilla) REFERENCES Zapatilla (idZapatilla)
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

CREATE TABLE ModeloColor(
idModelo int ,
idColor int ,
FOREIGN KEY (idModelo) REFERENCES Modelo(idModelo),
FOREIGN KEY (idColor) REFERENCES Color(idColor)
);


CREATE TABLE Opinion(
    dni int PRIMARY KEY,
    idModelo int,
    fechaHora DATETIME,
    descripcion VARCHAR(45),
    puntaje DECIMAL,
    FOREIGN KEY (idModelo) REFERENCES Modelo (idModelo) 
);