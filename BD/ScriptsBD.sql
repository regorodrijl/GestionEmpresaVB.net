-- MySQL Script generated by MySQL Workbench
-- 03/06/15 10:20:40
-- Model: New Model    Version: 1.0
SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema A11JoseLuisRR
-- -----------------------------------------------------
-- CREATE SCHEMA IF NOT EXISTS `A11JoseLuisRR` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `A11JoseLuisRR` ;

-- -----------------------------------------------------
-- Table `A11JoseLuisRR`.`Cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `A11JoseLuisRR`.`Cliente` (
  `idCliente` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `apellidos` VARCHAR(100) NULL,
  `nif` VARCHAR(9) NULL,
  `telefono` VARCHAR(15) NULL,
  `direccion` VARCHAR(100) NULL,
  PRIMARY KEY (`idCliente`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `A11JoseLuisRR`.`Pedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `A11JoseLuisRR`.`Pedido` (
  `idPedido` INT NOT NULL AUTO_INCREMENT,
  `fecha` DATETIME NOT NULL,
  `estado` ENUM('Registrado','Montado','Servido') NULL,
  `precio` DECIMAL NULL,
  `Cliente_idCliente` INT NOT NULL,
  PRIMARY KEY (`idPedido`, `fecha`),
  INDEX `fk_Pedido_Cliente_idx` (`Cliente_idCliente` ASC),
  CONSTRAINT `fk_Pedido_Cliente`
    FOREIGN KEY (`Cliente_idCliente`)
    REFERENCES `A11JoseLuisRR`.`Cliente` (`idCliente`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `A11JoseLuisRR`.`Producto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `A11JoseLuisRR`.`Producto` (
  `idProducto` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `cantidad` INT NULL,
  `precio` DECIMAL NULL,
  PRIMARY KEY (`idProducto`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `A11JoseLuisRR`.`Linea_Pedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `A11JoseLuisRR`.`Linea_Pedido` (
  `idLinea_Pedido` INT NOT NULL AUTO_INCREMENT,
  `fecha` DATETIME NOT NULL,
  `estado` ENUM('Registrado','Montado','Servido') NULL,
  `cantidad` INT NULL,
  `Producto_idProducto` INT NOT NULL,
  `Pedido_idPedido` INT NOT NULL,
  `Pedido_fecha` DATETIME NOT NULL,
  PRIMARY KEY (`idLinea_Pedido`, `fecha`),
  INDEX `fk_Linea_Pedido_Producto1_idx` (`Producto_idProducto` ASC),
  INDEX `fk_Linea_Pedido_Pedido1_idx` (`Pedido_idPedido` ASC, `Pedido_fecha` ASC),
  CONSTRAINT `fk_Linea_Pedido_Producto1`
    FOREIGN KEY (`Producto_idProducto`)
    REFERENCES `A11JoseLuisRR`.`Producto` (`idProducto`)
    ON DELETE CASCADE
    ON UPDATE  CASCADE,
  CONSTRAINT `fk_Linea_Pedido_Pedido1`
    FOREIGN KEY (`Pedido_idPedido` , `Pedido_fecha`)
    REFERENCES `A11JoseLuisRR`.`Pedido` (`idPedido` , `fecha`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `A11JoseLuisRR`.`Componente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `A11JoseLuisRR`.`Componente` (
  `idComponente` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `fabricante` VARCHAR(45) NULL,
  `cantidad` INT NULL,
  PRIMARY KEY (`idComponente`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `A11JoseLuisRR`.`Proveedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `A11JoseLuisRR`.`Proveedor` (
  `idProveedor` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `nif` VARCHAR(10) NULL,
  PRIMARY KEY (`idProveedor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `A11JoseLuisRR`.`Pedido_Proveedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `A11JoseLuisRR`.`Pedido_Proveedor` (
  `idPedido_Proveedor` INT NOT NULL AUTO_INCREMENT,
  `fecha` DATETIME NOT NULL,
  `estado` ENUM('Registrado','Montado','Servido') NULL,
  `Proveedor_idProveedor` INT NOT NULL,
  `Componente_idComponente` INT NOT NULL,
  PRIMARY KEY (`idPedido_Proveedor`, `fecha`),
  INDEX `fk_Pedido_Proveedor_Proveedor1_idx` (`Proveedor_idProveedor` ASC),
  INDEX `fk_Pedido_Proveedor_Componente1_idx` (`Componente_idComponente` ASC),
  CONSTRAINT `fk_Pedido_Proveedor_Proveedor1`
    FOREIGN KEY (`Proveedor_idProveedor`)
    REFERENCES `A11JoseLuisRR`.`Proveedor` (`idProveedor`)
    ON DELETE CASCADE
    ON UPDATE  CASCADE,
  CONSTRAINT `fk_Pedido_Proveedor_Componente1`
    FOREIGN KEY (`Componente_idComponente`)
    REFERENCES `A11JoseLuisRR`.`Componente` (`idComponente`)
    ON DELETE  CASCADE
    ON UPDATE  CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `A11JoseLuisRR`.`Producto_has_Componente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `A11JoseLuisRR`.`Producto_has_Componente` (
  `Producto_idProducto` INT NOT NULL,
  `Componente_idComponente` INT NOT NULL,
  PRIMARY KEY (`Producto_idProducto`, `Componente_idComponente`),
  INDEX `fk_Producto_has_Componente_Componente1_idx` (`Componente_idComponente` ASC),
  INDEX `fk_Producto_has_Componente_Producto1_idx` (`Producto_idProducto` ASC),
  CONSTRAINT `fk_Producto_has_Componente_Producto1`
    FOREIGN KEY (`Producto_idProducto`)
    REFERENCES `A11JoseLuisRR`.`Producto` (`idProducto`)
    ON DELETE  CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_Producto_has_Componente_Componente1`
    FOREIGN KEY (`Componente_idComponente`)
    REFERENCES `A11JoseLuisRR`.`Componente` (`idComponente`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;