CREATE SCHEMA IF NOT EXISTS `auditoria`;

USE `auditoria` ;

CREATE TABLE historico_de_atividades (
  id int NOT NULL AUTO_INCREMENT,
  nome_estudante varchar(45) NOT NULL,
  turma_estudante varchar(2) NOT NULL,
  avaliativa int NOT NULL,
  codigo_seguranca_projeto varchar(100) NOT NULL,
  pasta_atual_projeto varchar(200) NOT NULL,
  data_registro date NOT NULL,
  hora_registro time NOT NULL,
  date_hora_sgbd TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  codigo_maquina varchar(20) NOT NULL,
  PRIMARY KEY (id)
);
