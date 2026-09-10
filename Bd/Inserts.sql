SET AUTOCOMMIT=0;
START TRANSACTION;

INSERT INTO Cliente (idCliente,dni,nombre,apellido,nacimiento,correo) VALUES
(1,48526379,'Enzo','Luna','2008-04-04','enzoluna760@gmail.com'),
(2,47702699, 'Ezequiel', 'Lizasoain', '2007-07-06','monkicapo@gmail.com'),
(3,47396736, 'Carla', 'Gonzalez', '2007-05-12', 'carla.gonzalez@gmail.com'),
(4,47482374, 'Cliente', 'Sin especificar', '2000-01-01', 'cliente47482374@example.com');

INSERT INTO Color (idColor,nombre) VALUES
(1, 'azul'),
(2, 'rojo'),
(3, 'verde'),
(4, 'negro');

INSERT INTO Compra (numeroCompra,dni,fechaHora) VALUES
(1001,48526379, '2026-07-13 14:30'),
(1002,47702699, '2026-07-12 17:45'),
(1003,47396736, '2026-07-11 10:15'),
(1004,47482374, '2026-07-11 16:15');

INSERT INTO DetalleCompra (numeroCompra,idModelo,talle,idZapatilla,precioUnitario,cantidad) VALUES
(1001, 200, 38, 1, 45000, 1),
(1002, 201, 40, 2, 60000, 1),
(1003, 202, 37, 3, 30000, 2),
(1004, 203, 42, 4, 55000, 1);

INSERT INTO Devolucion (idDevolucion,dni,idRazon,fechaHora) VALUES
(1, 48526379, 1, '2026-07-13 15:00'),
(2, 47702699, 2, '2026-07-12 11:30'),
(3, 47396736, 3, '2026-07-12 09:45'), 
(4, 47482374, 1, '2026-07-10 16:20');

INSERT INTO Fabricante (idFabricante,NombreFab) VALUES
(1, 'Nike'),
(2, 'Adidas'),
(3, 'Puma'),
(4, 'Reebok');

INSERT INTO Modelo (idModelo,idFabricante,nombre,idPais) VALUES
(200, 1, 'Air Zoom', 3),
(201, 2, 'Ultraboost', 2),
(202, 3, 'RS-X', 1),
(203, 4, 'Classic Leather', 4);

INSERT INTO ModeloColor (idModelo,idColor) VALUES
(200, 1),
(201, 2),
(202, 3),
(203, 4);

INSERT INTO Opinion (dni,idModelo,fechaHora,descripcion,puntaje) VALUES
(48526379, 200, '2026-07-13 16:00', 'muy comodas y livianas', 5),
(47702699, 201, '2026-07-12 18:00' 'buen diseño pero caras', 4,)
(47396736, 202 '2026-07-11 09:30', 'excelente calidad', 5)
(47482374, 203, '2026-07-10 14:00', '');

INSERT INTO Pais (idPais,nombre) VALUES
(1,'Argentina'),
(2,'Paraguay'),
(3,'China'),
(4,'Brasil');

INSERT INTO RazonDevolucion (idRazon,Descripcion) VALUES
(1,'No e¿son los zapatos que pedi'),
(2,'no era mi talla'),
(3,'No es el modelo que pedi'),
(4,'otro');

INSERT INTO Zapatilla (idZapatilla,idModelo,talle,stock,nombre) VALUES
(1,1,30,500),
(2,2,30,450),
(3,3,30,450),
(4,4,30,450),
(5,1,30,540),
(6,3,30,600),
(7,2,30,777),
(8,2,30,666),
(1,1,35,500),
(2,2,35,450),
(3,3,35,450),
(4,4,35,450),
(5,1,35,540),
(6,3,35,600),
(7,2,35,777),
(8,2,35,666),
(1,1,40,500),
(2,2,40,450),
(3,3,40,450),
(4,4,40,450),
(5,1,40,540),
(6,3,40,600),
(7,2,40,777),
(8,2,40,666);