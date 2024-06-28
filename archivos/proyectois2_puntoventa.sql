-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: mysql-proyectois2.alwaysdata.net
-- Generation Time: Jun 26, 2024 at 05:13 AM
-- Server version: 10.6.17-MariaDB
-- PHP Version: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `proyectois2_puntoventa`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`362639`@`%` PROCEDURE `active_users` ()   BEGIN
select p.nombre,p.apellido,td.descripcion as tipo_doc,p.numero_documento,r.descripcion,us.password,con.telefono,con.email
FROM Usuario as us 
join Persona as p on p.id_persona=us.id_persona
join Rol as r on us.id_rol=r.id_rol
left join Contacto as con on p.id_contacto=con.id_contacto
join Estado as est on us.id_estado=est.id_estado
join Tipo_documento as td on td.id_tipo_documento=p.id_tipo_documento
where us.id_estado=1;
END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `add_category` (IN `p_category` VARCHAR(60))   BEGIN
INSERT INTO `Categoria` (`id_categoria`, `descripcion`, `id_estado`) VALUES (NULL, p_category, '1');
select last_insert_id();
END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `add_client` (IN `p_telefono` VARCHAR(60), IN `p_email` VARCHAR(30), IN `p_nombre` VARCHAR(50), IN `p_apellido` VARCHAR(60), IN `p_tipo_doc` INT, IN `p_numero_documento` VARCHAR(30), IN `p_estado` INT)   BEGIN
insert into `Contacto`(`id_contacto`,`telefono`,`email`)
values (null,p_telefono,p_email);
INSERT INTO `Persona` (`id_persona`,`nombre`,`apellido`,`id_tipo_documento`, `numero_documento`, `id_contacto`) 
 VALUES (NULL, p_nombre, p_apellido,p_tipo_doc,p_numero_documento,last_insert_id());
INSERT INTO `Cliente`(`id_cliente`,`id_estado`,`id_persona`) 
 VALUES (NULL,p_estado,last_insert_id());
 select last_insert_id();
END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `add_person` (IN `p_nombre` VARCHAR(60), IN `p_apellido` VARCHAR(60), IN `p_tipo_doc` VARCHAR(40), IN `p_numero_documento` VARCHAR(40), IN `p_telefono` VARCHAR(30), IN `p_email` VARCHAR(50))   BEGIN
insert into `Contacto`(`id_contacto`,`telefono`,`email`) values (null,p_telefono,p_email);
INSERT INTO `Persona` (`id_persona`,`nombre`,`apellido`,`id_tipo_documento`, `numero_documento`, `id_contacto`) 
 VALUES (NULL, p_nombre, p_apellido,p_tipo_doc,p_numero_documento,last_insert_id());
END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `add_product` (IN `p_titulo` VARCHAR(30), IN `p_descripcion` VARCHAR(100), IN `p_codigo` VARCHAR(30), IN `p_precio_compra` DECIMAL(10,2), IN `p_precio_venta` DECIMAL(10,2), IN `p_id_categoria` INT, IN `p_id_estado` INT, IN `p_stock` INT)   BEGIN
insert into `Producto`(`id_producto`,`titulo`,`descripcion`,`codigo`,`precio_compra`,`precio_venta`,`id_categoria`,`id_estado`,`stock`)
values (null,p_titulo,p_descripcion,p_codigo,p_precio_compra,p_precio_venta,p_id_categoria,p_id_estado,p_stock);
END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `add_rol_permission` (IN `p_id_rol` INT, IN `p_id_permiso` INT)   BEGIN
insert into Rol_Permiso(`id_rol_permiso`,`id_rol`,`id_permiso`)VALUES
(null,p_id_rol,p_id_permiso);
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `add_sale` (IN `p_monto_total` DECIMAL(10,2), IN `p_id_usuario` INT, IN `p_id_cliente` INT)   BEGIN
insert into Venta(`id_venta`,`fecha`,`hora`,`monto_total`,`id_usuario`,
  `id_cliente`,`id_estado`)
  values (null,CURRENT_DATE,CURRENT_TIME,p_monto_total,p_id_usuario,p_id_cliente,1);
   select last_insert_id() as id_venta;
                  end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `add_sale_detail` (IN `p_id_producto` INT, IN `p_cantidad` INT, IN `p_id_venta` INT, IN `p_subtotal` DECIMAL(10,2))   BEGIN
insert into Detalle_venta (id_detalle_venta,cantidad,subtotal,id_producto,id_venta) 
values (null,p_cantidad,p_subtotal,p_id_producto,p_id_venta);

end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `add_sale_payment` (IN `p_monto` DECIMAL(10,2), IN `p_id_medio_pago` INT, IN `p_id_venta` INT)   begin 
    insert into Venta_medio_pago(`id_venta_medio_pago`,`monto`
                                 ,`id_medio_pago`,`id_venta`)
                                 values(null,	p_monto,	p_id_medio_pago,	p_id_venta	);
                                 end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `add_user` (IN `p_email` VARCHAR(50), IN `p_telefono` VARCHAR(30), IN `p_nombre` VARCHAR(60), IN `p_apellido` VARCHAR(60), IN `p_tipo_doc` INT, IN `p_numero_documento` VARCHAR(60), IN `p_id_rol` INT, IN `p_nombre_usuario` VARCHAR(60), IN `p_password` VARCHAR(60), IN `p_id_estado` INT)   BEGIN
insert into `Contacto`(`id_contacto`,`telefono`,`email`)
values (null,p_telefono,p_email);
INSERT INTO `Persona` (`id_persona`,`nombre`,`apellido`,`id_tipo_documento`, `numero_documento`, `id_contacto`) 
 VALUES (NULL, p_nombre, p_apellido,p_tipo_doc,p_numero_documento,last_insert_id());
INSERT INTO `Usuario` (`id_usuario`,`id_rol`,
 `nombre_usuario`,`password`, `id_estado`,`id_persona`) 
 VALUES (NULL, p_id_rol, p_nombre_usuario,p_password,p_id_estado,last_insert_id());
END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `all_ discounts` ()   BEGIN
select des.descripcion,des.fecha_inicio,des.fecha_fin,pr.titulo,pr.codigo,est.descripcion as estado FROM Descuento as des 
join Producto as pr on pr.id_producto=des.id_producto
join Estado as est on des.id_estado=est.id_estado;
END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `all_categories` ()   begin
select cat.id_categoria,cat.descripcion,est.descripcion as estado from Categoria as cat join
Estado as est on cat.id_estado=est.id_estado;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `all_categories_d` ()   BEGIN
select cat.id_categoria,cat.descripcion from Categoria as cat ;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `all_clients` ()   begin
select cl.id_cliente,p.nombre,p.apellido,td.descripcion as tipo_doc,p.numero_documento,con.telefono,con.email,est.descripcion as estado from Cliente as cl 
JOIN Persona as p on p.id_persona=cl.id_persona 
left join Contacto as con on p.id_contacto=con.id_contacto
join Estado as est on cl.id_estado=est.id_estado
join Tipo_documento as td on td.id_tipo_documento=p.id_tipo_documento;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `all_payment_method` ()   begin
select id_medio_pago,descripcion from Medio_pago;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `all_products` ()   begin
select pr.id_producto,pr.titulo,pr.descripcion,pr.codigo,pr.precio_compra,pr.precio_venta,cat.descripcion as categoria,est.descripcion as estado,pr.stock from Producto as pr 
join Categoria as cat on pr.id_categoria=cat.id_categoria
join Estado as est on pr.id_estado=est.id_estado;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `all_products_sale` ()   begin
select pr.id_producto,pr.titulo,pr.codigo,pr.precio_venta,cat.descripcion as categoria, pr.stock from Producto as pr 
join Categoria as cat on pr.id_categoria=cat.id_categoria where pr.id_estado=1;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `all_rols` ()   begin 
select rol.descripcion,est.descripcion as estado from Rol as rol join Estado as est on est.id_estado=rol.id_estado;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `all_rols_d` ()   begin 
select id_rol,descripcion from Rol where id_estado=1 ;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `all_sales` ()   BEGIN
select v.monto_total,v.fecha,v.hora,us.nombre_usuario,p.nombre,p.apellido,est.descripcion as estado FROM Venta as v 
join Usuario as us on us.id_usuario=v.id_usuario
join Cliente as cl on v.id_cliente=cl.id_cliente
join Persona as p on cl.id_persona=p.id_persona
join Estado as est on us.id_estado=est.id_estado;
END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `all_sale_details` ()   BEGIN
select dv.id_venta as nroventa,pr.titulo as producto,dv.cantidad,dv.subtotal FROM Detalle_venta as dv 
join Producto as pr on pr.id_producto=dv.id_producto;
END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `all_status_d` ()   begin select * from Estado;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `all_type_doc_d` ()   BEGIN select id_tipo_documento,descripcion from Tipo_documento;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `all_users` ()   BEGIN
select us.id_usuario,p.nombre,p.apellido,us.nombre_usuario,td.descripcion as tipo_doc,p.numero_documento,r.descripcion,us.password,con.telefono,con.email,est.descripcion as estado FROM Usuario as us 
join Persona as p on p.id_persona=us.id_persona
join Rol as r on us.id_rol=r.id_rol
left join Contacto as con on p.id_contacto=con.id_contacto
join Estado as est on us.id_estado=est.id_estado
join Tipo_documento as td on td.id_tipo_documento=p.id_tipo_documento;
END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `delete_category` (IN `p_id` INT)   BEGIN
update Categoria set id_estado=2 WHERE id_categoria=p_id;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `delete_client_id` (IN `p_id` INT)   BEGIN
update Cliente set id_estado=2 WHERE Cliente.id_cliente=p_id;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `delete_producto_id` (IN `p_id` INT)   BEGIN
update Producto set id_estado=2 WHERE Producto.id_producto=p_id;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `delete_prod_id` (IN `p_id_producto` INT)   BEGIN
update Producto set id_estado=2 WHERE Producto.id_producto=p_id_producto_id;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `delete_user_id` (IN `p_id` INT)   BEGIN
update Usuario set id_estado=2 WHERE Usuario.id_usuario=p_id;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `edit_category` (IN `p_id` INT, IN `p_category` VARCHAR(50), IN `p_status` TINYINT)   BEGIN
update Categoria set descripcion=p_category,id_estado=p_status WHERE id_categoria=p_id;
END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `edit_client` (IN `p_telefono` VARCHAR(30), IN `p_email` VARCHAR(50), IN `p_id_contacto` INT, IN `p_apellido` VARCHAR(60), IN `p_nombre` VARCHAR(60), IN `p_tipo_doc` INT, IN `p_id_persona` INT, IN `p_id_estado` INT, IN `p_id_cliente` INT)   BEGIN
UPDATE `Contacto` set `telefono`=p_telefono,`email`=p_email
 where  `Contacto`.id_contacto=p_id_contacto;
 UPDATE `Persona` set `nombre`=p_nombre,`apellido`=p_apellido,`id_tipo_documento`=p_tipo_doc where  `Persona`.id_persona=p_id_persona;
UPDATE `Cliente` set 
  `id_estado`=p_id_estado   where  `Cliente`.id_cliente=p_id_cliente;

end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `edit_product` (IN `p_id_producto` INT, IN `p_titulo` VARCHAR(30), IN `p_descripcion` VARCHAR(60), IN `p_codigo` VARCHAR(30), IN `p_precio_compra` DECIMAL(10,2), IN `p_precio_venta` DECIMAL(10,2), IN `p_id_categoria` INT, IN `p_id_estado` INT)   BEGIN
UPDATE `Producto` set `id_producto`=p_id_producto,`titulo`=p_titulo, `descripcion`=p_descripcion,`codigo`=p_codigo,`precio_compra`=p_precio_compra, `precio_venta`=p_precio_venta, `id_categoria`=p_id_categoria, `id_estado`=p_id_estado   where  `Producto`.`id_producto`=p_id_producto;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `edit_user` (IN `p_id_contacto` INT, IN `p_telefono` VARCHAR(30), IN `p_email` VARCHAR(50), IN `p_id_persona` INT, IN `p_nombre` VARCHAR(60), IN `p_apellido` VARCHAR(60), IN `p_tipo_doc` INT, IN `p_numero_documento` VARCHAR(40), IN `p_id_usuario` INT, IN `p_id_rol` INT, IN `p_nombre_usuario` VARCHAR(30), IN `p_id_estado` INT)   BEGIN
UPDATE `Contacto` set `telefono`=p_telefono,`email`=p_email
 where  `Contacto`.id_contacto=p_id_contacto;
 UPDATE `Persona` set `nombre`=p_nombre,`apellido`=p_apellido,`id_tipo_documento`=p_tipo_doc, `numero_documento`=p_numero_documento where  `Persona`.id_persona=p_id_persona;
UPDATE `Usuario` set `id_rol`=p_id_rol,
 `nombre_usuario`=p_nombre_usuario, `id_estado`=p_id_estado   where  `Usuario`.id_usuario=p_id_usuario;

end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `inactive_users` ()   BEGIN
select p.nombre,p.apellido,td.descripcion as tipo_doc,p.numero_documento,r.descripcion,us.password,con.telefono,con.email FROM Usuario as us 
join Persona as p on p.id_persona=us.id_persona
join Rol as r on us.id_rol=r.id_rol
left join Contacto as con on p.id_contacto=con.id_contacto
join Estado as est on us.id_estado=est.id_estado
join Tipo_documento as td on td.id_tipo_documento=p.id_tipo_documento
where us.id_estado=2;
END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `login` (IN `p_username` VARCHAR(60), IN `p_password` VARCHAR(60))   begin 
SELECT * FROM Usuario as us where us.nombre_usuario=p_username and us.password=p_password and us.id_estado=1 limit 1;
END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `restore_category` (IN `p_id` INT)   BEGIN
update Categoria set id_estado=1 WHERE id_categoria=p_id;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `restore_client_id` (IN `p_id` INT)   BEGIN
update Cliente set id_estado=1 WHERE Cliente.id_cliente=p_id;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `restore_producto_id` (IN `p_id_producto` INT)   BEGIN
update Producto set Producto.id_estado=1 WHERE Producto.id_producto=p_id_producto;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `restore_user_id` (IN `p_id` INT)   BEGIN
update Usuario set id_estado=1 WHERE Usuario.id_usuario=p_id;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `search_category` (IN `p_category` VARCHAR(60))   BEGIN
select * from Categoria where descripcion=p_category limit 1 ;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `search_clients_active` ()   begin
select cl.id_cliente,p.nombre,p.apellido,td.descripcion as tipo_doc,p.numero_documento,con.telefono,con.email,est.descripcion as estado from Cliente as cl 
JOIN Persona as p on p.id_persona=cl.id_persona 
left join Contacto as con on p.id_contacto=con.id_contacto
join Estado as est on cl.id_estado=est.id_estado
join Tipo_documento as td on td.id_tipo_documento=p.id_tipo_documento where cl.id_estado=1;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `search_client_dni` (IN `p_dni` INT)   BEGIN
select Cliente.id_cliente,Persona.nombre,Persona.apellido from Persona  join 
Cliente on Cliente.id_persona=Persona.id_persona where Persona.numero_documento=p_dni ;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `search_client_edit` (IN `p_id_cliente` INT)   BEGIN
select cl.id_cliente,p.id_persona,con.id_contacto,p.nombre,p.apellido,
p.id_tipo_documento,p.numero_documento,con.telefono,con.email,cl.id_estado  FROM Cliente as cl 
join Persona as p on p.id_persona=cl.id_persona
join Contacto as con on p.id_contacto=con.id_contacto where cl.id_cliente=p_id_cliente
;END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `search_client_nro_active` (IN `p_dni` INT)   BEGIN
select Cliente.id_cliente,Persona.nombre,Persona.apellido from Persona  join 
Cliente on Cliente.id_persona=Persona.id_persona where Persona.numero_documento=p_dni and Cliente.id_estado=1 ;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `search_client_surname` (IN `p_apellido` VARCHAR(50))   BEGIN
select Cliente.id_cliente,Persona.nombre,Persona.apellido from Persona  join 
Cliente on Cliente.id_persona=Persona.id_persona where Persona.apellido=p_apellido and Cliente.estado=1 ;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `search_conection` ()   begin 
select server,database,user,password from `Conexion` where id_conexion=1;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `search_producto_cod` (IN `p_cod` INT)   BEGIN
select * from Producto   where Producto.codigo=p_cod ;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `search_producto_id` (IN `p_id_producto` INT)   BEGIN
select * from Producto   where Producto.id_producto=p_id_producto ;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `search_user` (IN `p_user` VARCHAR(40))   BEGIN
select * from Usuario where nombre_usuario=p_user  ;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `search_user_dni` (IN `p_dni` VARCHAR(30))   BEGIN
select Usuario.id_usuario,Persona.nombre,Persona.apellido from Persona  join 
Usuario on Usuario.id_persona=Persona.id_persona where Persona.numero_documento=p_dni ;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `search_user_edit` (IN `p_id_usuario` INT)   BEGIN
select us.id_usuario,p.id_persona,con.id_contacto,p.nombre,p.apellido,us.nombre_usuario,p.id_tipo_documento,p.numero_documento,us.id_rol,con.telefono,con.email,us.id_estado  FROM Usuario as us 
join Persona as p on p.id_persona=us.id_persona
join Contacto as con on p.id_contacto=con.id_contacto where us.id_usuario=p_id_usuario
;END$$

CREATE DEFINER=`362639`@`%` PROCEDURE `set_conection` (IN `p_server` VARCHAR(200), IN `p_database` VARCHAR(100), IN `p_user` VARCHAR(100), IN `p_password` VARCHAR(50))   begin 
update `Conexion` set `server`=p_server,
`database`=p_database,
`user`=p_user,`password`=p_password where id_conexion=1;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `update_product_stock` (IN `p_id_producto` INT, IN `p_cantidad` INT)   begin 
update Producto set stock=stock-p_cantidad where id_producto=p_id_producto;
end$$

CREATE DEFINER=`362639`@`%` PROCEDURE `user_permissions` (IN `p_rol` INT)   BEGIN
select distinct per.nombre_menu from Rol_Permiso as rp 
join Permiso as per on per.id_permiso=rp.id_permiso 
join Usuario as us on  rp.id_rol=p_rol ;
end$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `Categoria`
--

CREATE TABLE `Categoria` (
  `id_categoria` int(11) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  `id_estado` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `Categoria`
--

INSERT INTO `Categoria` (`id_categoria`, `descripcion`, `id_estado`) VALUES
(27, 'Comestible', 1),
(28, 'Limpieza', 1),
(29, 'Panificados', 1);

-- --------------------------------------------------------

--
-- Table structure for table `Cliente`
--

CREATE TABLE `Cliente` (
  `id_cliente` int(11) NOT NULL,
  `id_persona` int(11) NOT NULL,
  `id_estado` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `Cliente`
--

INSERT INTO `Cliente` (`id_cliente`, `id_persona`, `id_estado`) VALUES
(13, 31, 1);

-- --------------------------------------------------------

--
-- Table structure for table `Contacto`
--

CREATE TABLE `Contacto` (
  `id_contacto` int(11) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `telefono` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `Contacto`
--

INSERT INTO `Contacto` (`id_contacto`, `email`, `telefono`) VALUES
(1, 'mati@gmail.com', '379522222'),
(2, 'Lorenzo@gmail.com', '32343333'),
(3, '', ''),
(4, 'aaa@', 'qqq'),
(5, 'as', 'qq'),
(6, '', ''),
(7, '', ''),
(8, '', ''),
(9, 'qqqq', '1111'),
(10, 'aaa', 'qqq'),
(11, 'weqwe', 'aqwq'),
(12, 'qwewq', 'qqqq'),
(13, 'qweqwe', 'wqeqe'),
(16, '', 'sd'),
(17, '', 'ss'),
(18, '', 'sss'),
(22, 'www', '2223'),
(23, '', 'sdsa'),
(24, 'wee', '213231'),
(54, '', '324325'),
(55, 'lucia@gmail.com', '');

-- --------------------------------------------------------

--
-- Table structure for table `Detalle_venta`
--

CREATE TABLE `Detalle_venta` (
  `id_detalle_venta` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL DEFAULT 0,
  `subtotal` decimal(10,2) NOT NULL DEFAULT 0.00,
  `id_producto` int(11) NOT NULL,
  `id_venta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `Estado`
--

CREATE TABLE `Estado` (
  `id_estado` int(11) NOT NULL,
  `descripcion` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `Estado`
--

INSERT INTO `Estado` (`id_estado`, `descripcion`) VALUES
(1, 'ACTIVO'),
(2, 'INACTIVO');

-- --------------------------------------------------------

--
-- Table structure for table `Medio_pago`
--

CREATE TABLE `Medio_pago` (
  `id_medio_pago` int(11) NOT NULL,
  `descripcion` varchar(60) NOT NULL DEFAULT 'Efectivo'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `Medio_pago`
--

INSERT INTO `Medio_pago` (`id_medio_pago`, `descripcion`) VALUES
(1, 'Efectivo'),
(2, 'Tarjeta de debito');

-- --------------------------------------------------------

--
-- Table structure for table `Permiso`
--

CREATE TABLE `Permiso` (
  `id_permiso` int(11) NOT NULL,
  `descripcion` varchar(60) DEFAULT NULL,
  `nombre_menu` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `Permiso`
--

INSERT INTO `Permiso` (`id_permiso`, `descripcion`, `nombre_menu`) VALUES
(1, 'Acceso a clientes', 'Clientes'),
(2, 'Realizar venta', 'Ventas'),
(3, 'Administrar productos', 'Productos'),
(4, 'Gestión usuarios', 'Usuarios'),
(5, 'Reportes', 'Reportes'),
(6, 'Backup', 'Copia_de_seguridad'),
(7, 'Logout', 'Cerrar_sesion'),
(8, 'Cuadro ventas', 'Cuadro_venta');

-- --------------------------------------------------------

--
-- Table structure for table `Persona`
--

CREATE TABLE `Persona` (
  `id_persona` int(11) NOT NULL,
  `nombre` varchar(60) DEFAULT NULL,
  `apellido` varchar(60) DEFAULT NULL,
  `numero_documento` varchar(20) NOT NULL,
  `id_tipo_documento` int(11) NOT NULL,
  `id_contacto` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `Persona`
--

INSERT INTO `Persona` (`id_persona`, `nombre`, `apellido`, `numero_documento`, `id_tipo_documento`, `id_contacto`) VALUES
(30, 'Jorge', 'Lopez', '4343434', 1, NULL),
(31, 'Marina', 'Perez', '43423434', 1, NULL),
(32, 'Nicolas', 'Gonzalez', '3243243', 1, 54),
(33, 'Lucia', 'Lorenzo', '3243242', 1, 55);

-- --------------------------------------------------------

--
-- Table structure for table `Producto`
--

CREATE TABLE `Producto` (
  `id_producto` int(11) NOT NULL,
  `titulo` varchar(60) DEFAULT NULL,
  `descripcion` varchar(120) DEFAULT NULL,
  `codigo` varchar(40) DEFAULT NULL,
  `precio_compra` decimal(10,2) NOT NULL DEFAULT 0.00,
  `precio_venta` decimal(10,2) NOT NULL DEFAULT 0.00,
  `id_categoria` int(11) DEFAULT NULL,
  `id_estado` int(11) NOT NULL DEFAULT 1,
  `stock` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `Producto`
--

INSERT INTO `Producto` (`id_producto`, `titulo`, `descripcion`, `codigo`, `precio_compra`, `precio_venta`, `id_categoria`, `id_estado`, `stock`) VALUES
(20, 'Fideo', '', '324234', 700.00, 900.00, 27, 1, 10),
(21, 'Arroz', '', '324266', 700.00, 900.00, 27, 1, 10),
(22, 'Lavandina', '', '3242663', 1000.00, 1200.00, 28, 1, 10);

-- --------------------------------------------------------

--
-- Table structure for table `Rol`
--

CREATE TABLE `Rol` (
  `id_rol` int(11) NOT NULL,
  `descripcion` varchar(60) NOT NULL,
  `id_estado` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `Rol`
--

INSERT INTO `Rol` (`id_rol`, `descripcion`, `id_estado`) VALUES
(1, 'Cajero', 1),
(2, 'Administrador', 1),
(3, 'Administrador general', 1);

-- --------------------------------------------------------

--
-- Table structure for table `Rol_Permiso`
--

CREATE TABLE `Rol_Permiso` (
  `id_permiso_rol` int(11) NOT NULL,
  `id_rol` int(11) NOT NULL,
  `id_permiso` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `Rol_Permiso`
--

INSERT INTO `Rol_Permiso` (`id_permiso_rol`, `id_rol`, `id_permiso`) VALUES
(3, 1, 2),
(13, 1, 7),
(1, 2, 1),
(4, 2, 2),
(2, 2, 3),
(5, 3, 1),
(6, 3, 2),
(7, 3, 3),
(8, 3, 4),
(11, 3, 5),
(12, 3, 6),
(10, 3, 7),
(9, 3, 8);

-- --------------------------------------------------------

--
-- Table structure for table `Tipo_documento`
--

CREATE TABLE `Tipo_documento` (
  `id_tipo_documento` int(11) NOT NULL,
  `descripcion` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `Tipo_documento`
--

INSERT INTO `Tipo_documento` (`id_tipo_documento`, `descripcion`) VALUES
(1, 'DNI');

-- --------------------------------------------------------

--
-- Table structure for table `Usuario`
--

CREATE TABLE `Usuario` (
  `id_usuario` int(11) NOT NULL,
  `nombre_usuario` varchar(60) NOT NULL DEFAULT 'user',
  `password` varchar(50) NOT NULL,
  `id_rol` int(11) NOT NULL,
  `id_estado` int(11) NOT NULL DEFAULT 1,
  `id_persona` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `Usuario`
--

INSERT INTO `Usuario` (`id_usuario`, `nombre_usuario`, `password`, `id_rol`, `id_estado`, `id_persona`) VALUES
(18, 'user', '1234', 3, 1, 30),
(19, 'gonza', '1234', 1, 1, 32),
(20, 'luciauser', '1234', 2, 1, 33);

-- --------------------------------------------------------

--
-- Table structure for table `Venta`
--

CREATE TABLE `Venta` (
  `id_venta` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `monto_total` decimal(10,2) NOT NULL DEFAULT 0.00,
  `id_usuario` int(11) NOT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `id_estado` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `Venta_medio_pago`
--

CREATE TABLE `Venta_medio_pago` (
  `id_venta_medio_pago` int(11) NOT NULL,
  `monto` decimal(10,2) UNSIGNED NOT NULL DEFAULT 0.00,
  `id_medio_pago` int(11) NOT NULL,
  `id_venta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Categoria`
--
ALTER TABLE `Categoria`
  ADD PRIMARY KEY (`id_categoria`),
  ADD KEY `id_estado` (`id_estado`);

--
-- Indexes for table `Cliente`
--
ALTER TABLE `Cliente`
  ADD PRIMARY KEY (`id_cliente`),
  ADD KEY `id_persona` (`id_persona`),
  ADD KEY `id_estado` (`id_estado`);

--
-- Indexes for table `Contacto`
--
ALTER TABLE `Contacto`
  ADD PRIMARY KEY (`id_contacto`);

--
-- Indexes for table `Detalle_venta`
--
ALTER TABLE `Detalle_venta`
  ADD PRIMARY KEY (`id_detalle_venta`),
  ADD KEY `id_producto` (`id_producto`,`id_venta`),
  ADD KEY `id_venta` (`id_venta`);

--
-- Indexes for table `Estado`
--
ALTER TABLE `Estado`
  ADD PRIMARY KEY (`id_estado`);

--
-- Indexes for table `Medio_pago`
--
ALTER TABLE `Medio_pago`
  ADD PRIMARY KEY (`id_medio_pago`);

--
-- Indexes for table `Permiso`
--
ALTER TABLE `Permiso`
  ADD PRIMARY KEY (`id_permiso`);

--
-- Indexes for table `Persona`
--
ALTER TABLE `Persona`
  ADD PRIMARY KEY (`id_persona`),
  ADD KEY `id_tipo_documento` (`id_tipo_documento`,`id_contacto`),
  ADD KEY `id_contacto` (`id_contacto`);

--
-- Indexes for table `Producto`
--
ALTER TABLE `Producto`
  ADD PRIMARY KEY (`id_producto`),
  ADD KEY `id_categoria` (`id_categoria`),
  ADD KEY `id_estado` (`id_estado`);

--
-- Indexes for table `Rol`
--
ALTER TABLE `Rol`
  ADD PRIMARY KEY (`id_rol`),
  ADD KEY `id_estado` (`id_estado`);

--
-- Indexes for table `Rol_Permiso`
--
ALTER TABLE `Rol_Permiso`
  ADD PRIMARY KEY (`id_permiso_rol`),
  ADD KEY `id_rol` (`id_rol`,`id_permiso`),
  ADD KEY `id_permiso` (`id_permiso`);

--
-- Indexes for table `Tipo_documento`
--
ALTER TABLE `Tipo_documento`
  ADD PRIMARY KEY (`id_tipo_documento`);

--
-- Indexes for table `Usuario`
--
ALTER TABLE `Usuario`
  ADD PRIMARY KEY (`id_usuario`),
  ADD KEY `id_perfil` (`id_rol`,`id_persona`),
  ADD KEY `id_persona` (`id_persona`),
  ADD KEY `id_estado` (`id_estado`);

--
-- Indexes for table `Venta`
--
ALTER TABLE `Venta`
  ADD PRIMARY KEY (`id_venta`),
  ADD KEY `id_usuario` (`id_usuario`),
  ADD KEY `id_estado` (`id_estado`),
  ADD KEY `id_cliente` (`id_cliente`);

--
-- Indexes for table `Venta_medio_pago`
--
ALTER TABLE `Venta_medio_pago`
  ADD PRIMARY KEY (`id_venta_medio_pago`),
  ADD KEY `id_medio_pago` (`id_medio_pago`,`id_venta`),
  ADD KEY `id_venta` (`id_venta`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Categoria`
--
ALTER TABLE `Categoria`
  MODIFY `id_categoria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `Cliente`
--
ALTER TABLE `Cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `Contacto`
--
ALTER TABLE `Contacto`
  MODIFY `id_contacto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;

--
-- AUTO_INCREMENT for table `Detalle_venta`
--
ALTER TABLE `Detalle_venta`
  MODIFY `id_detalle_venta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `Estado`
--
ALTER TABLE `Estado`
  MODIFY `id_estado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `Medio_pago`
--
ALTER TABLE `Medio_pago`
  MODIFY `id_medio_pago` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `Permiso`
--
ALTER TABLE `Permiso`
  MODIFY `id_permiso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `Persona`
--
ALTER TABLE `Persona`
  MODIFY `id_persona` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `Producto`
--
ALTER TABLE `Producto`
  MODIFY `id_producto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `Rol`
--
ALTER TABLE `Rol`
  MODIFY `id_rol` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `Rol_Permiso`
--
ALTER TABLE `Rol_Permiso`
  MODIFY `id_permiso_rol` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `Tipo_documento`
--
ALTER TABLE `Tipo_documento`
  MODIFY `id_tipo_documento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `Usuario`
--
ALTER TABLE `Usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `Venta`
--
ALTER TABLE `Venta`
  MODIFY `id_venta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT for table `Venta_medio_pago`
--
ALTER TABLE `Venta_medio_pago`
  MODIFY `id_venta_medio_pago` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Categoria`
--
ALTER TABLE `Categoria`
  ADD CONSTRAINT `Categoria_ibfk_1` FOREIGN KEY (`id_estado`) REFERENCES `Estado` (`id_estado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Cliente`
--
ALTER TABLE `Cliente`
  ADD CONSTRAINT `Cliente_ibfk_1` FOREIGN KEY (`id_persona`) REFERENCES `Persona` (`id_persona`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Cliente_ibfk_2` FOREIGN KEY (`id_estado`) REFERENCES `Estado` (`id_estado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Detalle_venta`
--
ALTER TABLE `Detalle_venta`
  ADD CONSTRAINT `Detalle_venta_ibfk_2` FOREIGN KEY (`id_venta`) REFERENCES `Venta` (`id_venta`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Detalle_venta_ibfk_4` FOREIGN KEY (`id_producto`) REFERENCES `Producto` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Persona`
--
ALTER TABLE `Persona`
  ADD CONSTRAINT `Persona_ibfk_1` FOREIGN KEY (`id_tipo_documento`) REFERENCES `Tipo_documento` (`id_tipo_documento`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Persona_ibfk_2` FOREIGN KEY (`id_contacto`) REFERENCES `Contacto` (`id_contacto`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Producto`
--
ALTER TABLE `Producto`
  ADD CONSTRAINT `Producto_ibfk_1` FOREIGN KEY (`id_categoria`) REFERENCES `Categoria` (`id_categoria`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Producto_ibfk_2` FOREIGN KEY (`id_estado`) REFERENCES `Estado` (`id_estado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Rol`
--
ALTER TABLE `Rol`
  ADD CONSTRAINT `Rol_ibfk_1` FOREIGN KEY (`id_estado`) REFERENCES `Estado` (`id_estado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Rol_Permiso`
--
ALTER TABLE `Rol_Permiso`
  ADD CONSTRAINT `Rol_Permiso_ibfk_1` FOREIGN KEY (`id_permiso`) REFERENCES `Permiso` (`id_permiso`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Rol_Permiso_ibfk_2` FOREIGN KEY (`id_rol`) REFERENCES `Rol` (`id_rol`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Usuario`
--
ALTER TABLE `Usuario`
  ADD CONSTRAINT `Usuario_ibfk_1` FOREIGN KEY (`id_rol`) REFERENCES `Rol` (`id_rol`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Usuario_ibfk_2` FOREIGN KEY (`id_persona`) REFERENCES `Persona` (`id_persona`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Usuario_ibfk_3` FOREIGN KEY (`id_estado`) REFERENCES `Estado` (`id_estado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Venta`
--
ALTER TABLE `Venta`
  ADD CONSTRAINT `Venta_ibfk_4` FOREIGN KEY (`id_cliente`) REFERENCES `Cliente` (`id_cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Venta_ibfk_5` FOREIGN KEY (`id_estado`) REFERENCES `Estado` (`id_estado`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Venta_ibfk_6` FOREIGN KEY (`id_usuario`) REFERENCES `Usuario` (`id_usuario`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Venta_medio_pago`
--
ALTER TABLE `Venta_medio_pago`
  ADD CONSTRAINT `Venta_medio_pago_ibfk_2` FOREIGN KEY (`id_medio_pago`) REFERENCES `Medio_pago` (`id_medio_pago`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
