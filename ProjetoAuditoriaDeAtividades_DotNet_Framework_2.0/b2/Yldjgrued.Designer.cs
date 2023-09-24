namespace ProjetoAuditoriaDeAtividades2
{
    partial class Yldjgrued
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNomeEstudante = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.lblAvaliativa = new System.Windows.Forms.Label();
            this.txtNomeEstudante = new System.Windows.Forms.TextBox();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.cmbAvaliativa = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblLocal = new System.Windows.Forms.Label();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(202, 57);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(386, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Atividade";
            // 
            // lblNomeEstudante
            // 
            this.lblNomeEstudante.AutoSize = true;
            this.lblNomeEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEstudante.Location = new System.Drawing.Point(38, 148);
            this.lblNomeEstudante.Name = "lblNomeEstudante";
            this.lblNomeEstudante.Size = new System.Drawing.Size(252, 29);
            this.lblNomeEstudante.TabIndex = 1;
            this.lblNomeEstudante.Text = "Nome(s) Completo(s):";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.Location = new System.Drawing.Point(38, 216);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(89, 29);
            this.lblTurma.TabIndex = 2;
            this.lblTurma.Text = "Turma:";
            // 
            // lblAvaliativa
            // 
            this.lblAvaliativa.AutoSize = true;
            this.lblAvaliativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaliativa.Location = new System.Drawing.Point(38, 285);
            this.lblAvaliativa.Name = "lblAvaliativa";
            this.lblAvaliativa.Size = new System.Drawing.Size(119, 29);
            this.lblAvaliativa.TabIndex = 3;
            this.lblAvaliativa.Text = "Avaliativa:";
            // 
            // txtNomeEstudante
            // 
            this.txtNomeEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEstudante.Location = new System.Drawing.Point(296, 145);
            this.txtNomeEstudante.Name = "txtNomeEstudante";
            this.txtNomeEstudante.Size = new System.Drawing.Size(455, 34);
            this.txtNomeEstudante.TabIndex = 4;
            // 
            // cmbTurma
            // 
            this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Items.AddRange(new object[] {
            "3A",
            "3B",
            "3C",
            "M3"});
            this.cmbTurma.Location = new System.Drawing.Point(133, 213);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(167, 37);
            this.cmbTurma.TabIndex = 5;
            // 
            // cmbAvaliativa
            // 
            this.cmbAvaliativa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvaliativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAvaliativa.FormattingEnabled = true;
            this.cmbAvaliativa.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cmbAvaliativa.Location = new System.Drawing.Point(163, 282);
            this.cmbAvaliativa.Name = "cmbAvaliativa";
            this.cmbAvaliativa.Size = new System.Drawing.Size(137, 37);
            this.cmbAvaliativa.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(587, 407);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(164, 48);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(38, 359);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(77, 29);
            this.lblLocal.TabIndex = 8;
            this.lblLocal.Text = "Local:";
            // 
            // cmbLocal
            // 
            this.cmbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Items.AddRange(new object[] {
            "Laboratório de Informática",
            "Casa"});
            this.cmbLocal.Location = new System.Drawing.Point(121, 356);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(317, 37);
            this.cmbLocal.TabIndex = 9;
            // 
            // Yldjgrued
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.cmbLocal);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cmbAvaliativa);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.txtNomeEstudante);
            this.Controls.Add(this.lblAvaliativa);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.lblNomeEstudante);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.Name = "Yldjgrued";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema IFBA - Tela de Cadastro de Atividade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomeEstudante;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblAvaliativa;
        private System.Windows.Forms.TextBox txtNomeEstudante;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.ComboBox cmbAvaliativa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.ComboBox cmbLocal;
    }
}

