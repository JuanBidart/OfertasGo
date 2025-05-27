CREATE TABLE "Proveedores" (
	"idProveedores"	INTEGER NOT NULL UNIQUE,
	"RazonSocial"	TEXT,
	"Direccion"	TEXT,
	"Ciudad"	TEXT,
	"Telefono"	TEXT,
	"Telefono2"	TEXT,
	"Activo"	INTEGER,
	"Eliminado"	INTEGER, Email varchar(50),
	PRIMARY KEY("idProveedores" AUTOINCREMENT)
);
CREATE TABLE "Clientes" (
	"idCliente"	INTEGER NOT NULL UNIQUE,
	"Nombre y apellido"	TEXT NOT NULL,
	"Razon social"	TEXT,
	"Telefono"	TEXT,
	"Direccion"	TEXT,
	"Barrio"	TEXT,
	"Ciudad"	TEXT,
	"Observaciones"	TEXT,
	"Activo"	INTEGER,
	"Eliminado"	INTEGER,
	PRIMARY KEY("idCliente" AUTOINCREMENT)
);
CREATE TABLE "HistorialPrecios" (
	"idHistorial"	INTEGER NOT NULL,
	"Descripcion"	TEXT,
	"Costo"	REAL,
	"Final"	REAL,
	"FechaMod"	TEXT,
	"idProducto"	INTEGER,
	PRIMARY KEY("idHistorial" AUTOINCREMENT)
);
CREATE TABLE "Productos" (
	"idProductos"	INTEGER NOT NULL UNIQUE,
	"Descripcion"	TEXT(100),
	"idRubro"	INTEGER,
	"Costo"	REAL,
	"DescuentoCosto%"	REAL,
	"Iva"	REAL,
	"AjustePesos"	REAL,
	"Recargo%"	REAL,
	"Final"	REAL,
	"FechaModificacion"	TEXT,
	"Activo"	INTEGER,
	"Eliminado"	INTEGER,
	"Observaciones"	TEXT,
	"idProveedores"	INTEGER,
	FOREIGN KEY("idRubro") REFERENCES "Rubro",
	PRIMARY KEY("idProductos" AUTOINCREMENT)
);
CREATE TABLE "Rubro" (
	"IdRubro"	INTEGER NOT NULL UNIQUE,
	"Rubro"	TEXT UNIQUE,
	"Activo"	INTEGER,
	"Eliminado"	INTEGER,
	PRIMARY KEY("IdRubro" AUTOINCREMENT)
);
