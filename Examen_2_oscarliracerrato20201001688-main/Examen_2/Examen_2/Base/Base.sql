-- MySQL Script generated by MySQL Workbench
-- Sat Nov  5 23:05:54 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Examen_2
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Examen_2
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Examen_2` DEFAULT CHARACTER SET utf8 ;
USE `Examen_2` ;

-- -----------------------------------------------------
-- Table `Examen_2`.`Login`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Examen_2`.`Login` (
  `idLogin` VARCHAR(45) NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Contraseña` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idLogin`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Examen_2`.`Cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Examen_2`.`Cliente` (
  `idCliente` INT NOT NULL AUTO_INCREMENT,
  `Nombre_del_cliente` VARCHAR(45) NULL,
  `Precio` DECIMAL(10) NULL,
  `Celular` VARCHAR(45) NULL,
  `Solicitud` VARCHAR(200) NULL,
  `Soporte` VARCHAR(45) NULL,
  `Respuesta` VARCHAR(200) NULL,
  `Fecha` DATETIME NULL,
  `Clientescol1` VARCHAR(45) NULL,
  PRIMARY KEY (`idCliente`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Examen_2`.`Tickets`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Examen_2`.`Tickets` (
  `idTickets` INT NOT NULL,
  `Codigo_del_Cliente` INT NOT NULL,
  `Login_idLogin` VARCHAR(45) NOT NULL,
  `Cliente_idCliente` INT NOT NULL,
  PRIMARY KEY (`idTickets`),
  INDEX `fk_Tickets_Login_idx` (`Login_idLogin` ASC) VISIBLE,
  INDEX `fk_Tickets_Cliente1_idx` (`Cliente_idCliente` ASC) VISIBLE,
  CONSTRAINT `fk_Tickets_Login`
    FOREIGN KEY (`Login_idLogin`)
    REFERENCES `Examen_2`.`Login` (`idLogin`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tickets_Cliente1`
    FOREIGN KEY (`Cliente_idCliente`)
    REFERENCES `Examen_2`.`Cliente` (`idCliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
