-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema balancetesimples
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema balancetesimples
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `balancetesimples` DEFAULT CHARACTER SET utf8 ;
USE `balancetesimples` ;

-- -----------------------------------------------------
-- Table `balancetesimples`.`natureza_operacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `balancetesimples`.`natureza_operacao` (
  `id_natureza` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `tipo` VARCHAR(5) NULL DEFAULT NULL,
  PRIMARY KEY (`id_natureza`))
ENGINE = InnoDB
AUTO_INCREMENT = 13
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `balancetesimples`.`contas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `balancetesimples`.`contas` (
  `id_conta` INT(11) NOT NULL AUTO_INCREMENT,
  `descricao_conta` VARCHAR(100) NOT NULL,
  `id_natureza` INT(11) NOT NULL,
  `tipo_conta` VARCHAR(45) NOT NULL,
  `data_lancamento` DATE NULL DEFAULT NULL,
  `valor_total` DOUBLE NULL DEFAULT NULL,
  `acrescimo` DOUBLE NULL DEFAULT NULL,
  `desconto` DOUBLE NULL DEFAULT NULL,
  PRIMARY KEY (`id_conta`),
  INDEX `fk_contas_natureza_operacao_idx` (`id_natureza` ASC),
  CONSTRAINT `fk_contas_natureza_operacao`
    FOREIGN KEY (`id_natureza`)
    REFERENCES `balancetesimples`.`natureza_operacao` (`id_natureza`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 18
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

INSERT INTO `balancetesimples`.`natureza_operacao`
(`id_natureza`,`nome`,`tipo`) VALUES(1,"Débito","S");

INSERT INTO `balancetesimples`.`natureza_operacao`
(`id_natureza`,`nome`,`tipo`)VALUES(2,"Crédito","E");

INSERT INTO `balancetesimples`.`natureza_operacao`
(`id_natureza`,`nome`,`tipo`)VALUES(3,"Fiado","E");

INSERT INTO `balancetesimples`.`contas`
(`id_conta`,
`descricao_conta`,
`id_natureza`,
`tipo_conta`,
`data_lancamento`,
`valor_total`,
`acrescimo`,
`desconto`)
VALUES
(1,"Salário",1,"Poupança", "2018-01-01","100.00","0.5","2.5");

INSERT INTO `balancetesimples`.`contas`
(`id_conta`,
`descricao_conta`,
`id_natureza`,
`tipo_conta`,
`data_lancamento`,
`valor_total`,
`acrescimo`,
`desconto`)
VALUES
(2,"Nubank",2,"Corrente", "2018-12-01","500.00","20","15.50");



