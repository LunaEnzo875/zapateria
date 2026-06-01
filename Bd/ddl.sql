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
    dni int PRIMARY KEY,
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