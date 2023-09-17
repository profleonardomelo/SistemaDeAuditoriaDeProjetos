CREATE SCHEMA IF NOT EXISTS `bancoabc`;

USE `bancoabc` ;

CREATE TABLE IF NOT EXISTS `conta` (
  `id` int NOT NULL AUTO_INCREMENT,
  `numero` int NOT NULL,
  `saldo` double NOT NULL,
  `limite` double NOT NULL,
  PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `cliente` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `cpf` bigint NOT NULL,
  `email` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
);
