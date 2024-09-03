namespace TestePOO
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDtNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVisuCPF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVisuNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVisuDtNascimento = new System.Windows.Forms.TextBox();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.lblCPFNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(12, 100);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data de nascimento";
            // 
            // dtpDtNascimento
            // 
            this.dtpDtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNascimento.Location = new System.Drawing.Point(12, 162);
            this.dtpDtNascimento.Name = "dtpDtNascimento";
            this.dtpDtNascimento.Size = new System.Drawing.Size(102, 20);
            this.dtpDtNascimento.TabIndex = 6;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(12, 200);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(146, 200);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 15;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data de nascimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "CPF:";
            // 
            // txtVisuCPF
            // 
            this.txtVisuCPF.Location = new System.Drawing.Point(147, 100);
            this.txtVisuCPF.Name = "txtVisuCPF";
            this.txtVisuCPF.Size = new System.Drawing.Size(100, 20);
            this.txtVisuCPF.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 10;
            // 
            // txtVisuNome
            // 
            this.txtVisuNome.Location = new System.Drawing.Point(147, 45);
            this.txtVisuNome.Name = "txtVisuNome";
            this.txtVisuNome.Size = new System.Drawing.Size(100, 20);
            this.txtVisuNome.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nome:";
            // 
            // txtVisuDtNascimento
            // 
            this.txtVisuDtNascimento.Location = new System.Drawing.Point(146, 162);
            this.txtVisuDtNascimento.Name = "txtVisuDtNascimento";
            this.txtVisuDtNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtVisuDtNascimento.TabIndex = 16;
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.Location = new System.Drawing.Point(15, 242);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(66, 13);
            this.lblBoasVindas.TabIndex = 17;
            this.lblBoasVindas.Text = "Boas Vindas";
            // 
            // lblCPFNome
            // 
            this.lblCPFNome.AutoSize = true;
            this.lblCPFNome.Location = new System.Drawing.Point(15, 272);
            this.lblCPFNome.Name = "lblCPFNome";
            this.lblCPFNome.Size = new System.Drawing.Size(41, 13);
            this.lblCPFNome.TabIndex = 18;
            this.lblCPFNome.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 307);
            this.Controls.Add(this.lblCPFNome);
            this.Controls.Add(this.lblBoasVindas);
            this.Controls.Add(this.txtVisuDtNascimento);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVisuCPF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVisuNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.dtpDtNascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDtNascimento;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVisuCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVisuNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVisuDtNascimento;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Label lblCPFNome;
    }
}

