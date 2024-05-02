CREATE DATABASE Admin_shop

USE Admin_shop

CREATE TABLE Usuario
(
  id_usuario INT NOT NULL IDENTITY,
  tipo_usuario INT NOT NULL,
  dni BIGINT NOT NULL,
  correo VARCHAR(50) NOT NULL,
  contrase�a VARCHAR(100) NOT NULL,
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


--Super usuario --contraseña 123
INSERT INTO Usuario (tipo_usuario, dni, correo, contraseña, nombre, apellido, telefono, instagram, estado) 
VALUES (1, 123456789, 'admin', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'Juan', 'Perez', 1234567890, 'juanperez_insta', '1');

-- categorias
INSERT INTO Categoria (id_categoria, descripcion, modify_date, estado) 
VALUES ('1','Golosinas', NULL, '1');

INSERT INTO Categoria (id_categoria, descripcion, modify_date, estado) 
VALUES ('2','Bebidas', NULL, '1');

INSERT INTO Categoria (id_categoria, descripcion, modify_date, estado) 
VALUES ('3','Snacks', NULL, '1');

INSERT INTO Categoria (id_categoria, descripcion, modify_date, estado) 
VALUES ('4','Cigarrillos', NULL, '1');

INSERT INTO Categoria (id_categoria, descripcion, modify_date, estado) 
VALUES ('5','Helados y Postres', NULL, '1');

INSERT INTO Categoria (id_categoria, descripcion, modify_date, estado) 
VALUES ('6','Panadería', NULL, '1');

INSERT INTO Categoria (id_categoria, descripcion, modify_date, estado) 
VALUES ('7','Primera Necesidad', NULL, '1');