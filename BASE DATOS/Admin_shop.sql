CREATE DATABASE Admin_shop
GO

USE Admin_shop
GO


-- Borrar procedimiento
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'InsertarProductoDB')
BEGIN
    DROP PROCEDURE InsertarProductoDB;
END;
GO

-- Borrar tablas si existen
IF OBJECT_ID('Venta_detalle', 'U') IS NOT NULL DROP TABLE Venta_detalle;
IF OBJECT_ID('Producto', 'U') IS NOT NULL DROP TABLE Producto;
IF OBJECT_ID('Venta', 'U') IS NOT NULL DROP TABLE Venta;
IF OBJECT_ID('Cliente', 'U') IS NOT NULL DROP TABLE Cliente;
IF OBJECT_ID('Categoria', 'U') IS NOT NULL DROP TABLE Categoria;
IF OBJECT_ID('Usuario', 'U') IS NOT NULL DROP TABLE Usuario;
GO




CREATE TABLE Usuario
(
  id_usuario INT NOT NULL IDENTITY,
  tipo_usuario INT NOT NULL,
  dni BIGINT NOT NULL,
  correo VARCHAR(50) NOT NULL,
  contrasena VARCHAR(100) NOT NULL,
  nombre VARCHAR(50) NOT NULL,
  apellido VARCHAR(50) NOT NULL,
  telefono BIGINT NOT NULL,
  instagram VARCHAR(50) NOT NULL,
  create_date DATE DEFAULT GETDATE() NOT NULL,
  modify_date DATE,
  estado VARCHAR(1) CONSTRAINT user_default_state DEFAULT 1,
  CONSTRAINT id_user PRIMARY KEY (id_usuario),
  CONSTRAINT user_dni UNIQUE (dni),
  CONSTRAINT user_corre UNIQUE (correo),
  CONSTRAINT state_user CHECK (estado IN (0,1)),
  CONSTRAINT type_user CHECK(tipo_usuario IN(1,2,3)),
);
GO

CREATE TABLE Cliente
(
  id_cliente INT NOT NULL IDENTITY,
  nombre VARCHAR(50) NOT NULL,
  apellido VARCHAR(50) NOT NULL,
  correo VARCHAR(100) NOT NULL,
  telefono BIGINT NOT NULL,
  dni BIGINT NOT NULL,
  instagram VARCHAR(50) NOT NULL,
  create_date DATE DEFAULT GETDATE() NOT NULL,
  modify_date DATE,
  domicilio VARCHAR(50) NOT NULL,
  id_usuario INT NOT NULL,
  estado VARCHAR(1)CONSTRAINT cliente_default_state DEFAULT 1,
  CONSTRAINT id_client PRIMARY KEY (id_cliente),
  CONSTRAINT client_user FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario),
  CONSTRAINT state_client CHECK (estado IN (0,1)),
  CONSTRAINT client_correo UNIQUE (correo),
  CONSTRAINT client_dni UNIQUE (dni)
);
GO

CREATE TABLE Categoria
(
  id_categoria INT NOT NULL,
  descripcion VARCHAR(50) NOT NULL,
  create_date DATE DEFAULT GETDATE() NOT NULL,
  modify_date DATE,
  estado VARCHAR(1) CONSTRAINT category_default_state DEFAULT 1,
  CONSTRAINT state_category CHECK (estado IN (0,1)),
  CONSTRAINT id_category PRIMARY KEY (id_categoria)
);
GO

CREATE TABLE Venta
(
  id_venta INT NOT NULL IDENTITY,
  total DECIMAL(10,2) NOT NULL,
  fecha DATE NOT NULL,
  id_cliente INT,
  id_usuario INT NOT NULL,
  create_date DATE DEFAULT GETDATE() NOT NULL,
  modify_date DATE,
  estado VARCHAR(1) CONSTRAINT sale_default_state DEFAULT 1,
  CONSTRAINT id_venta PRIMARY KEY (id_venta),
  CONSTRAINT FK_Venta_Usuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario),
  CONSTRAINT FK_Venta_Cliente FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente),
  CONSTRAINT state_sale CHECK (estado IN (0,1))
);
GO

-- SOLUCION ERROR: error al replicar base decimal no coincide con double
ALTER TABLE Venta
ALTER COLUMN total FLOAT NOT NULL;
GO

CREATE TABLE Producto
(
  id_producto INT NOT NULL IDENTITY,
  descripcion VARCHAR(100) NOT NULL,
  precio_costo FLOAT NOT NULL,
  precio_venta FLOAT NOT NULL,
  stock INT NOT NULL,
  create_date DATE DEFAULT GETDATE(),
  modify_date DATE,
  id_categoria INT NOT NULL,
  create_by INT NOT NULL,
  estado VARCHAR(1) CONSTRAINT product_default_state DEFAULT 1,
  CONSTRAINT id_product PRIMARY KEY (id_producto),
  CONSTRAINT product_category FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria),
  CONSTRAINT product_user FOREIGN KEY (create_by) REFERENCES Usuario(id_usuario),
  CONSTRAINT state_product CHECK (estado IN (0,1)),
  CONSTRAINT pcPositivo CHECK (precio_costo >= 0),
  CONSTRAINT pvPositivo CHECK (precio_venta >= 0),
  CONSTRAINT stock CHECK(stock >= 0),
);
GO

CREATE TABLE Venta_detalle
(
  id_venta_detalle INT NOT NULL IDENTITY,
  cantidad INT NOT NULL,
  subtotal FLOAT NOT NULL,
  create_date DATE DEFAULT GETDATE(),
  modify_date DATE,
  id_venta INT NOT NULL,
  id_producto INT NOT NULL,
  estado VARCHAR(1) CONSTRAINT detailSale_default_state DEFAULT 1,
  CONSTRAINT id_venta_detalle PRIMARY KEY (id_venta_detalle),
  CONSTRAINT detailVenta_venta FOREIGN KEY (id_venta) REFERENCES Venta(id_venta),
  CONSTRAINT detailVenta_product FOREIGN KEY (id_producto) REFERENCES Producto(id_producto),
  CONSTRAINT state_detailSale CHECK (estado IN (0,1)),
  CONSTRAINT cantidad_posit CHECK(cantidad > 0)
);
GO

-- procedimientos almacenados

CREATE PROCEDURE InsertarProductoDB
    @descripcion VARCHAR(100),
    @precio_costo FLOAT,
    @precio_venta FLOAT,
    @stock INT,
    @id_categoria INT,
    @create_by INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar la nueva fila en la tabla Producto
    INSERT INTO Producto (descripcion, precio_costo, precio_venta, stock, id_categoria, create_by)
    VALUES (@descripcion, @precio_costo, @precio_venta, @stock, @id_categoria, @create_by);

    -- Mostrar mensaje de éxito
    PRINT 'Producto insertado correctamente.';
END;
GO



--Super usuario --contraseña 123
INSERT INTO Usuario (tipo_usuario, dni, correo, contraseña, nombre, apellido, telefono, instagram, estado) 
VALUES (1, 123456789, 'admin', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'Juan', 'Perez', 1234567890, 'juanperez_insta', '1');
GO

-- categorias
INSERT INTO Categoria (id_categoria, descripcion, modify_date, estado) 
VALUES ('1','Golosinas', NULL, '1');
GO

INSERT INTO Categoria (id_categoria, descripcion, modify_date, estado) 
VALUES ('2','Bebidas', NULL, '1');
GO

INSERT INTO Categoria (id_categoria, descripcion, modify_date, estado) 
VALUES ('3','Snacks', NULL, '1');
GO

INSERT INTO Categoria (id_categoria, descripcion, modify_date, estado) 
VALUES ('4','Cigarrillos', NULL, '1');
GO

INSERT INTO Categoria (id_categoria, descripcion, modify_date, estado) 
VALUES ('5','Helados y Postres', NULL, '1');
GO

INSERT INTO Categoria (id_categoria, descripcion, modify_date, estado) 
VALUES ('6','Panadería', NULL, '1');
GO

INSERT INTO Categoria (id_categoria, descripcion, modify_date, estado) 
VALUES ('7','Primera Necesidad', NULL, '1');
GO