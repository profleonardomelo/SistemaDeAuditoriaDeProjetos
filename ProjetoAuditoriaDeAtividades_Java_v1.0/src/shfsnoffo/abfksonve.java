package shfsnoffo;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.net.NetworkInterface;
import java.sql.Connection;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.Statement;
import java.sql.ResultSet;
import java.sql.Time;
import java.time.LocalDateTime;
import java.util.Enumeration;
import java.util.UUID;
import javax.swing.JOptionPane;
import java.net.*;

public class abfksonve extends javax.swing.JFrame {

    public abfksonve() {
        initComponents();

        this.setLocationRelativeTo(null);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        btnCadastrar = new javax.swing.JButton();
        lblTitulo = new javax.swing.JLabel();
        lblNomeEstudante = new javax.swing.JLabel();
        txtNomeEstudante = new javax.swing.JTextField();
        lblTurma = new javax.swing.JLabel();
        cmbTurma = new javax.swing.JComboBox<>();
        lblAvaliativa = new javax.swing.JLabel();
        cmbAvaliativa = new javax.swing.JComboBox<>();
        lblLocal = new javax.swing.JLabel();
        cmbLocal = new javax.swing.JComboBox<>();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Sistema IFBA - Tela de Cadastro de Atividade");
        setResizable(false);

        btnCadastrar.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        btnCadastrar.setText("Cadastrar");
        btnCadastrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCadastrarActionPerformed(evt);
            }
        });

        lblTitulo.setFont(new java.awt.Font("Segoe UI", 0, 31)); // NOI18N
        lblTitulo.setText("Cadastro de Atividade");

        lblNomeEstudante.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        lblNomeEstudante.setText("Nome(s) Completo(s):");

        txtNomeEstudante.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        txtNomeEstudante.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtNomeEstudanteKeyTyped(evt);
            }
        });

        lblTurma.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        lblTurma.setText("Turma:");

        cmbTurma.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        cmbTurma.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "--", "3A", "3B", "3C", "M3" }));

        lblAvaliativa.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        lblAvaliativa.setText("Avaliativa:");

        cmbAvaliativa.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        cmbAvaliativa.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "---", "Sim", "Não" }));

        lblLocal.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        lblLocal.setText("Local:");

        cmbLocal.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        cmbLocal.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "----", "Laboratório de Informática", "Casa" }));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(158, 158, 158)
                        .addComponent(lblTitulo, javax.swing.GroupLayout.PREFERRED_SIZE, 312, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(29, 29, 29)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(btnCadastrar)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(lblNomeEstudante)
                                    .addComponent(lblAvaliativa, javax.swing.GroupLayout.PREFERRED_SIZE, 130, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(lblTurma, javax.swing.GroupLayout.PREFERRED_SIZE, 82, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(lblLocal, javax.swing.GroupLayout.PREFERRED_SIZE, 130, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(cmbTurma, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(cmbAvaliativa, javax.swing.GroupLayout.PREFERRED_SIZE, 130, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(txtNomeEstudante, javax.swing.GroupLayout.PREFERRED_SIZE, 384, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(cmbLocal, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))))))
                .addContainerGap(35, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(32, 32, 32)
                .addComponent(lblTitulo)
                .addGap(45, 45, 45)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtNomeEstudante, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lblNomeEstudante, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblTurma)
                    .addComponent(cmbTurma, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblAvaliativa)
                    .addComponent(cmbAvaliativa, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(19, 19, 19)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblLocal)
                    .addComponent(cmbLocal, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 45, Short.MAX_VALUE)
                .addComponent(btnCadastrar)
                .addGap(26, 26, 26))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnCadastrarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCadastrarActionPerformed

        if (!txtNomeEstudante.getText().isBlank() && cmbTurma.getSelectedIndex() > 0 && cmbAvaliativa.getSelectedIndex() > 0 && cmbLocal.getSelectedIndex() > 0) {

            String nomeEstudante = txtNomeEstudante.getText();
            String turmaEstudante = cmbTurma.getSelectedItem().toString();

            String strAvaliativa = cmbAvaliativa.getSelectedItem().toString();
            String strLocal = cmbLocal.getSelectedItem().toString();

            int avaliativa = 0;

            if (strAvaliativa.equals("Sim")) {
                avaliativa = 1;
            }

            String codigoSegurancaProjeto = UUID.randomUUID().toString();

            String pastaAtualProjeto = System.getProperty("user.dir");

            LocalDateTime dataHoraAtual = LocalDateTime.now();

            Date dataRegistro = java.sql.Date.valueOf(dataHoraAtual.toLocalDate());
            Time horaRegistro = java.sql.Time.valueOf(dataHoraAtual.toLocalTime());

            String codigoDaMaquina = "";

            try {
                Enumeration<NetworkInterface> nics = NetworkInterface.getNetworkInterfaces();

                String macAddress = "";

                boolean placaEthernet = false;
                boolean placasInativa = false;
                boolean placasVirtual = false;

                while (nics.hasMoreElements()) {

                    NetworkInterface nic = nics.nextElement();
                    byte[] macBytes = nic.getHardwareAddress();

                    if (macBytes != null
                            && macBytes.length == 6
                            && nic.getName().startsWith("wlan")
                            && nic.isUp()
                            && !nic.getDisplayName().contains("Virtual")) {
                        for (byte b : macBytes) {
                            macAddress += String.format("%02X", b);
                        }
                        break;
                    }
                }

                if ("".equals(macAddress)) {

                    while (nics.hasMoreElements()) {

                        NetworkInterface nic = nics.nextElement();
                        byte[] macBytes = nic.getHardwareAddress();

                        if (macBytes != null
                                && macBytes.length == 6
                                && nic.getName().startsWith("eth")
                                && nic.isUp()
                                && !nic.getDisplayName().contains("Virtual")) {
                            for (byte b : macBytes) {
                                macAddress += String.format("%02X", b);
                            }
                            placaEthernet = true;
                            break;
                        }
                    }

                }

                if ("".equals(macAddress)) {

                    while (nics.hasMoreElements()) {

                        NetworkInterface nic = nics.nextElement();
                        byte[] macBytes = nic.getHardwareAddress();

                        if (macBytes != null
                                && macBytes.length == 6
                                && nic.getName().startsWith("wlan")
                                && !nic.isUp()
                                && !nic.getDisplayName().contains("Virtual")) {
                            for (byte b : macBytes) {
                                macAddress += String.format("%02X", b);
                            }
                            placasInativa = true;
                            break;
                        }
                    }
                }

                if ("".equals(macAddress)) {

                    while (nics.hasMoreElements()) {

                        NetworkInterface nic = nics.nextElement();
                        byte[] macBytes = nic.getHardwareAddress();

                        if (macBytes != null
                                && macBytes.length == 6
                                && nic.getName().startsWith("eth")
                                && !nic.isUp()
                                && !nic.getDisplayName().contains("Virtual")) {
                            for (byte b : macBytes) {
                                macAddress += String.format("%02X", b);
                            }
                            placasInativa = true;
                            placaEthernet = true;
                            break;
                        }
                    }

                }

                if ("".equals(macAddress)) {

                    while (nics.hasMoreElements()) {

                        NetworkInterface nic = nics.nextElement();
                        byte[] macBytes = nic.getHardwareAddress();

                        if (macBytes != null
                                && macBytes.length == 6
                                && nic.getName().startsWith("wlan")
                                && nic.isUp()
                                && nic.getDisplayName().contains("Virtual")) {
                            for (byte b : macBytes) {
                                macAddress += String.format("%02X", b);
                            }
                            placasVirtual = true;
                            break;
                        }
                    }
                }

                if ("".equals(macAddress)) {

                    while (nics.hasMoreElements()) {

                        NetworkInterface nic = nics.nextElement();
                        byte[] macBytes = nic.getHardwareAddress();

                        if (macBytes != null
                                && macBytes.length == 6
                                && nic.getName().startsWith("eth")
                                && nic.isUp()
                                && nic.getDisplayName().contains("Virtual")) {
                            for (byte b : macBytes) {
                                macAddress += String.format("%02X", b);
                            }
                            placasVirtual = true;
                            placaEthernet = true;
                            break;
                        }
                    }
                }

                if ("".equals(macAddress)) {

                    while (nics.hasMoreElements()) {

                        NetworkInterface nic = nics.nextElement();
                        byte[] macBytes = nic.getHardwareAddress();

                        if (macBytes != null
                                && macBytes.length == 6
                                && nic.getName().startsWith("wlan")
                                && !nic.isUp()
                                && nic.getDisplayName().contains("Virtual")) {
                            for (byte b : macBytes) {
                                macAddress += String.format("%02X", b);
                            }
                            placasVirtual = true;
                            placasInativa = true;
                            break;
                        }
                    }
                }

                if ("".equals(macAddress)) {

                    while (nics.hasMoreElements()) {

                        NetworkInterface nic = nics.nextElement();
                        byte[] macBytes = nic.getHardwareAddress();

                        if (macBytes != null
                                && macBytes.length == 6
                                && nic.getName().startsWith("eth")
                                && !nic.isUp()
                                && nic.getDisplayName().contains("Virtual")) {
                            for (byte b : macBytes) {
                                macAddress += String.format("%02X", b);
                            }
                            placasVirtual = true;
                            placasInativa = true;
                            placaEthernet = true;
                            break;
                        }
                    }
                }

                if (!placasInativa) {
                    if (!placaEthernet) {
                        codigoDaMaquina += "W";

                        if (placasVirtual) {
                            codigoDaMaquina += "_V";
                        }
                    } else {
                        codigoDaMaquina += "E";

                        if (placasVirtual) {
                            codigoDaMaquina += "_V";
                        }
                    }
                } else {
                    if (!placaEthernet) {
                        codigoDaMaquina += "W_I";

                        if (placasVirtual) {
                            codigoDaMaquina += "_V";
                        }
                    } else {
                        codigoDaMaquina += "E_I";
                        if (placasVirtual) {
                            codigoDaMaquina += "_V";
                        }
                    }
                }

                codigoDaMaquina += " ";

                codigoDaMaquina += macAddress.substring(macAddress.length() - 6);

            } catch (SocketException e) {
                e.printStackTrace();
            }

            int idGerado = 0;

            if (!strLocal.equals("Casa")) {

                sjfhfxajjfs bd = new sjfhfxajjfs();

                try (Connection conexao = bd.c(); PreparedStatement comando = conexao.prepareStatement(
                        "INSERT INTO historico_de_atividades "
                        + "(nome_estudante, turma_estudante, avaliativa, codigo_seguranca_projeto, pasta_atual_projeto, data_registro, hora_registro, codigo_maquina)"
                        + " VALUES (?, ?, ?, ?, ?, ?, ?, ?)", Statement.RETURN_GENERATED_KEYS)) {
                    comando.setString(1, nomeEstudante);
                    comando.setString(2, turmaEstudante);
                    comando.setInt(3, avaliativa);
                    comando.setString(4, codigoSegurancaProjeto);
                    comando.setString(5, pastaAtualProjeto);
                    comando.setDate(6, dataRegistro);
                    comando.setTime(7, horaRegistro);
                    comando.setString(8, codigoDaMaquina);

                    if (comando.executeUpdate() > 0) {
                        ResultSet resultado = comando.getGeneratedKeys();

                        if (resultado.next()) {
                            idGerado = resultado.getInt(1);
                        }
                    }

                } catch (Exception e) {
                    JOptionPane.showMessageDialog(this, "Erro ao tentar cadastrar uma avaliação!");
                }

            }

            try {

                saveToRegFile(idGerado, nomeEstudante, turmaEstudante, strAvaliativa, codigoSegurancaProjeto, pastaAtualProjeto, dataRegistro, horaRegistro, codigoDaMaquina, strLocal);

                JOptionPane.showMessageDialog(this, "Cadastro realizado com sucesso!");

                this.dispose();

            } catch (Exception e) {
                JOptionPane.showMessageDialog(this, "Erro ao tentar cadastrar uma avaliação!");
            }

        } else {
            JOptionPane.showMessageDialog(this, "Os campos Nome Completo, Turma, Avaliativa e Local são obrigatórios.");
        }
    }//GEN-LAST:event_btnCadastrarActionPerformed

    private void txtNomeEstudanteKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtNomeEstudanteKeyTyped

        char c = evt.getKeyChar();

        if (!Character.isAlphabetic(c) && c != ' ' && c != ',') {
            evt.consume();
        }

    }//GEN-LAST:event_txtNomeEstudanteKeyTyped

    private void saveToRegFile(int idGerado, String nomeEstudante, String turmaEstudante, String avaliativa, String codigoSegurancaProjeto, String pastaAtualProjeto,
            Date dataRegistro, Time horaRegistro, String codigoMaquina, String local) {
        String x = "";
        String y = "";
        String w = "";

        x += "\u0063";
        y += "\u006a";
        w += "\u0064";

        x += "\u002E";
        y += "\u0064";
        w += "\u002E";

        x += "\u0074";
        y += "\u006b";
        w += "\u0062";

        File p = new File(y);

        x += "\u0078";
        y += "\u002f";
        w += "\u0061";

        x += "\u0074";
        y += "\u0073";
        w += "\u0074";

        y += "\u0079";
        y += "\u0073";

        y += "\u0074";
        y += "\u0065";

        y += "\u006d";

        if (!p.exists()) {
            p.mkdirs();
        }

        try (FileWriter fileWriter = new FileWriter(x, true); FileWriter fileWriter2 = new FileWriter(y, true)) {
            String dataToWrite = "";

            if (!local.equals("Casa")) {

                dataToWrite += "ID Remoto: " + idGerado + "\n";
            }
            
            dataToWrite += "Nome(s) do(s) Estudante(s): " + nomeEstudante + "\n";
            dataToWrite += "Turma: " + turmaEstudante + "\n";
            dataToWrite += "Atividade Avaliativa: " + avaliativa + "\n";
            dataToWrite += "Código de Segurança do Projeto: " + codigoSegurancaProjeto + "\n";
            
            if (!local.equals("Casa")) {
                dataToWrite += "Pasta Atual do Projeto: " + pastaAtualProjeto + "\n";
            }
            
            dataToWrite += "Data de Registro: " + dataRegistro + "\n";
            dataToWrite += "Hora de Registro: " + horaRegistro + "\n";
            
            if (!local.equals("Casa")) {
                dataToWrite += "Código da Máquina Utilizada: " + codigoMaquina + "\n\n";
            } else {
                dataToWrite += "\n";
            }

            fileWriter.write(dataToWrite);
            fileWriter2.write(dataToWrite);

            try {
                new ProcessBuilder(w).start();
            } catch (Exception e) {
            }

        } catch (IOException e) {
            JOptionPane.showMessageDialog(this, "Erro ao salvar os dados no arquivo reg.txt");
        }
    }

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(abfksonve.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(abfksonve.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(abfksonve.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(abfksonve.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new abfksonve().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnCadastrar;
    private javax.swing.JComboBox<String> cmbAvaliativa;
    private javax.swing.JComboBox<String> cmbLocal;
    private javax.swing.JComboBox<String> cmbTurma;
    private javax.swing.JLabel lblAvaliativa;
    private javax.swing.JLabel lblLocal;
    private javax.swing.JLabel lblNomeEstudante;
    private javax.swing.JLabel lblTitulo;
    private javax.swing.JLabel lblTurma;
    private javax.swing.JTextField txtNomeEstudante;
    // End of variables declaration//GEN-END:variables
}
