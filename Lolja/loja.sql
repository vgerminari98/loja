CREATE DATABASE Loja;
USE loja;

CREATE TABLE administrador(
codigo_adm INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
usuario_adm VARCHAR(10) NOT NULL,
senha_adm VARCHAR(10) NOT NULL);

INSERT INTO administrador(usuario_adm,senha_adm) VALUES('Patricia','1234');
-- SELECT * FROM administrador;
-- SELECT COUNT(*) FROM administrador WHERE usuario_adm = 'Patricia' AND senha_adm ='1234';

CREATE TABLE usuarios(
codigo_user INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
usuario_user VARCHAR(10) NOT NULL,
senha_user VARCHAR(10) NOT NULL);

INSERT INTO usuarios(usuario_user,senha_user) VALUES('Paty','1234');
-- SELECT * FROM usuarios;
-- SELECT COUNT(*) FROM usuarios WHERE usuario_user = 'Paty' AND senha_user ='1234';

CREATE TABLE categorias(
codigo_categoria INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
desc_categoria VARCHAR(50) NOT NULL,
estado bool not null
);
select * from categorias where estado=1;

INSERT INTO categorias(desc_categoria,estado) VALUES("Saia",true); 
INSERT INTO categorias(desc_categoria,estado) VALUES("Camisa",false); 
INSERT INTO categorias(desc_categoria,estado) VALUES("Blusa",true); 
/*SELECT * FROM categorias
SELECT desc_categoria FROM categorias;
ALTER TABLE Produtos NO CHECK CONSTRAINT codigo_categoria;
SET FOREIGN_KEY_CHECKS=1;
DELETE FROM categorias WHERE desc_categoria= 'Camisetes'; */

CREATE TABLE Produtos(
codigo_produtos INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
desc_produto VARCHAR(50) NOT NULL,
valor DECIMAL(25,2) NOT NULL,
codigo_categoria INT,
FOREIGN KEY(codigo_categoria) REFERENCES categorias(codigo_categoria));

INSERT INTO Produtos(desc_produto,valor,codigo_categoria) VALUES("Saia Jeans M",50.00,1);
INSERT INTO Produtos(desc_produto,valor,codigo_categoria) VALUES("Camisa branca M",150.00,2);
INSERT INTO Produtos(desc_produto,valor,codigo_categoria) VALUES("Blusa Frio Preta",200.00,3);

-- SELECT * FROM Produtos
-- SELECT C.desc_categoria	FROM Categorias AS C INNER JOIN PRODUTOS AS P
-- 	ON C.CODIGO_CATEGORIA=P.CODIGO_CATEGORIA;
-- 
-- SELECT codigo_produtos, desc_produto,valor,categorias.desc_categoria,
-- FROM loja.produtos
-- inner join loja.categorias
-- on categorias.codigo_categoria=produtos.codigo_categoria
-- 
-- SELECT codigo_categoria FROM categorias WHERE desc_categoria='Blusinha';
-- INSERT INTO Produtos(desc_produto,valor,codigo_categoria)VALUES('Camisete azul P',60.00,13);

-- DROP TABLE Clientes

CREATE TABLE Clientes(
codigo_Cliente INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
nome VARCHAR(50) NOT NULL,
cpf VARCHAR(15) NOT NULL,
rg VARCHAR(10) NOT NULL,
idade INT,
endereco VARCHAR(50),
numero VARCHAR(5),
cidade VARCHAR(50),
bairro VARCHAR(50),
telefone VARCHAR(15),
celular VARCHAR(15),
email VARCHAR(50));

INSERT INTO clientes(nome,cpf,rg,idade,endereco,numero,cidade,bairro,telefone,celular,email) VALUES('Patricia Ziviani','27853391854','301243906',33,'Av.Alberto Santos Dumont','1121','Araraquara','Jd Eliana','1633228843','16981748003','patriciaziviani@gmail.com');

CREATE TABLE venda(
codigo_venda INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
data_venda DATE NOT NULL,
codigo_cliente INT NOT NULL,
valor DECIMAL(20,2),
FOREIGN KEY (codigo_cliente) REFERENCES clientes(codigo_cliente));

INSERT INTO venda(data_venda,codigo_cliente,valor) VALUES('2017-03-10',1,0.00);

-- SELECT * FROM venda

CREATE TABLE item_venda(
codigo_item INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
codigo_venda INT NOT NULL,
codigo_produtos INT NOT NULL,
quantidade INT NOT NULL,
FOREIGN KEY (codigo_venda) REFERENCES venda(codigo_venda),
FOREIGN KEY (codigo_produtos) REFERENCES produtos(codigo_produtos));

INSERT INTO item_venda(codigo_venda,codigo_produtos,quantidade) VALUES(1,1,1);

-- DROP DATABASE LOJA;