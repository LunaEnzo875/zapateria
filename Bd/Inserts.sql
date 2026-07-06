SET AUTOCOMMIT=0;
START TRANSACTION;

INSERT INTO Cliente (dni,nombre,apellido,nacimiento,correo) VALUES
(48526379,'Enzo','Luna','2008-04-04','enzoluna760@gmail.com'),
(47702699, 'Ezequiel', 'Lizasoain', '2007-07-06','monkicapo@gmail.com');


INSERT INTO Color (idColor,nombre) VALUES
(),
(),
(),
();

INSERT INTO Compra (numeroCompra,dni,fechaHora) VALUES
(),
(),
(),
();

INSERT INTO DetalleCompra (numeroCompra,idModelo,talle,idZapatilla,precioUnitario,cantidad) VALUES
(),
(),
(),
();

INSERT INTO Devolucion (idDevolucion,dni,idRazon,fechaHora) VALUES
(),
(),
(),
();

INSERT INTO Fabricante (idFabricante,NombreFab) VALUES
(),
(),
(),
();

INSERT INTO Modelo (idModelo,idFabricante,nombre,idPais) VALUES
(),
(),
(),
();

INSERT INTO ModeloColor (idModelo,idColor) VALUES
(),
(),
(),
();

INSERT INTO Opinion (dni,idModelo,fechaHora,descripcion,puntaje) VALUES
(),
(),
(),
();

INSERT INTO Pais (idPais,nombre) VALUES
(),
(),
(),
();

INSERT INTO RazonDevolucion (idRazon,Descripcion) VALUES
(),
(),
(),
();

INSERT INTO Zapatilla (idZapatilla,idModelo,stock,nombre) VALUES
(),
(),
(),
();