namespace b2
{
    partial class Yldjgrued
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblNomeEstudante = new Label();
            txtNomeEstudante = new TextBox();
            lblTurma = new Label();
            cmbTurma = new ComboBox();
            cmbAvaliativa = new ComboBox();
            lblAvaliativa = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(210, 48);
            label1.Name = "label1";
            label1.Size = new Size(389, 50);
            label1.TabIndex = 0;
            label1.Text = "Cadastro De Atividade";
            // 
            // lblNomeEstudante
            // 
            lblNomeEstudante.AutoSize = true;
            lblNomeEstudante.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeEstudante.Location = new Point(63, 164);
            lblNomeEstudante.Name = "lblNomeEstudante";
            lblNomeEstudante.Size = new Size(235, 31);
            lblNomeEstudante.TabIndex = 1;
            lblNomeEstudante.Text = "Nome(s) Completo(s):";
            // 
            // txtNomeEstudante
            // 
            txtNomeEstudante.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeEstudante.Location = new Point(304, 161);
            txtNomeEstudante.Name = "txtNomeEstudante";
            txtNomeEstudante.Size = new Size(427, 38);
            txtNomeEstudante.TabIndex = 2;
            // 
            // lblTurma
            // 
            lblTurma.AutoSize = true;
            lblTurma.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurma.Location = new Point(63, 239);
            lblTurma.Name = "lblTurma";
            lblTurma.Size = new Size(84, 31);
            lblTurma.TabIndex = 3;
            lblTurma.Text = "Turma:";
            // 
            // cmbTurma
            // 
            cmbTurma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurma.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTurma.FormattingEnabled = true;
            cmbTurma.Items.AddRange(new object[] { "3A", "3B", "3C", "M3" });
            cmbTurma.Location = new Point(153, 236);
            cmbTurma.Name = "cmbTurma";
            cmbTurma.Size = new Size(154, 39);
            cmbTurma.TabIndex = 4;
            // 
            // cmbAvaliativa
            // 
            cmbAvaliativa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvaliativa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAvaliativa.FormattingEnabled = true;
            cmbAvaliativa.Items.AddRange(new object[] { "Sim", "Não" });
            cmbAvaliativa.Location = new Point(187, 305);
            cmbAvaliativa.Name = "cmbAvaliativa";
            cmbAvaliativa.Size = new Size(120, 39);
            cmbAvaliativa.TabIndex = 6;
            // 
            // lblAvaliativa
            // 
            lblAvaliativa.AutoSize = true;
            lblAvaliativa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvaliativa.Location = new Point(63, 308);
            lblAvaliativa.Name = "lblAvaliativa";
            lblAvaliativa.Size = new Size(118, 31);
            lblAvaliativa.TabIndex = 5;
            lblAvaliativa.Text = "Avaliativa:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(566, 377);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(165, 45);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(cmbAvaliativa);
            Controls.Add(lblAvaliativa);
            Controls.Add(cmbTurma);
            Controls.Add(lblTurma);
            Controls.Add(txtNomeEstudante);
            Controls.Add(lblNomeEstudante);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema IFBA - Tela de Cadastro de Atividade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNomeEstudante;
        private TextBox txtNomeEstudante;
        private Label lblTurma;
        private ComboBox cmbTurma;
        private ComboBox cmbAvaliativa;
        private Label lblAvaliativa;
        private Button btnCadastrar;
    }
}