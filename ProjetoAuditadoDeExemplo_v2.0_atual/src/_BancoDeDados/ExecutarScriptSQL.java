package _BancoDeDados;

import Principal.GerenciadorBD;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

public class ExecutarScriptSQL {

    public static void main(String[] args) throws Exception {

        ExecutarScriptSQL.executarScript();
    }

    public static void executarScript() throws Exception {
        GerenciadorBD bd = new GerenciadorBD();
        bd.banco = "";

        try (Connection conexao = bd.conectar()) {

            String criarBancoSQL = "CREATE DATABASE IF NOT EXISTS `bancoabc`;";

            try (PreparedStatement comandoCriarBanco = conexao.prepareStatement(criarBancoSQL)) {
                comandoCriarBanco.execute();
            }

            String usarBancoSQL = "USE `bancoabc`;";

            try (PreparedStatement comandoUsarBanco = conexao.prepareStatement(usarBancoSQL)) {
                comandoUsarBanco.execute();
            }

            String criarTabelaSQL1 = "CREATE TABLE IF NOT EXISTS `conta` ("
                    + "`id` int NOT NULL AUTO_INCREMENT,"
                    + "`numero` int NOT NULL,"
                    + "`saldo` double NOT NULL,"
                    + "`limite` double NOT NULL,"
                    + "PRIMARY KEY (`id`)"
                    + ");";

            try (PreparedStatement comandoCriarTabela = conexao.prepareStatement(criarTabelaSQL1)) {
                comandoCriarTabela.execute();
            }

            String criarTabelaSQL2 = "CREATE TABLE IF NOT EXISTS `cliente` ("
                    + "`id` int NOT NULL AUTO_INCREMENT,"
                    + "`nome` varchar(50) NOT NULL,"
                    + "`cpf` bigint NOT NULL,"
                    + "`email` varchar(45) NOT NULL,"
                    + "PRIMARY KEY (`id`)"
                    + ");";

            try (PreparedStatement comandoCriarTabela = conexao.prepareStatement(criarTabelaSQL2)) {
                comandoCriarTabela.execute();
            }

            String criarTabelaSQL3 = "CREATE TABLE IF NOT EXISTS `produto` ("
                    + "`id` int NOT NULL AUTO_INCREMENT,"
                    + "`nome` varchar(50) NOT NULL,"
                    + "`descricao` varchar(300) NOT NULL,"
                    + "`preco` double NOT NULL,"
                    + "`quantidade` int NOT NULL,"
                    + "PRIMARY KEY (`id`)"
                    + ");";

            try (PreparedStatement comandoCriarTabela = conexao.prepareStatement(criarTabelaSQL3)) {
                comandoCriarTabela.execute();
            }

            System.out.println("Banco de Dados e Tabelas criados com sucesso!");

        } catch (SQLException e) {
            System.out.println("Erro ao tentar criar ou recriar um banco de dados! " + e.getSQLState());
        }
    }
}
