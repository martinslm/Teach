namespace Teach.Grafico
{
    partial class EsqueciMinhaSenha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.tbSalvar = new System.Windows.Forms.Button();
            this.tbCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(74, 41);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(232, 20);
            this.tbEmail.TabIndex = 0;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(74, 76);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(232, 20);
            this.tbSenha.TabIndex = 1;
            // 
            // tbConfirmacaoSenha
            // 
            this.tbConfirmacaoSenha.Location = new System.Drawing.Point(74, 112);
            this.tbConfirmacaoSenha.Name = "tbConfirmacaoSenha";
            this.tbConfirmacaoSenha.PasswordChar = '*';
            this.tbConfirmacaoSenha.Size = new System.Drawing.Size(232, 20);
            this.tbConfirmacaoSenha.TabIndex = 2;
            // 
            // tbSalvar
            // 
            this.tbSalvar.Location = new System.Drawing.Point(231, 150);
            this.tbSalvar.Name = "tbSalvar";
            this.tbSalvar.Size = new System.Drawing.Size(75, 23);
            this.tbSalvar.TabIndex = 3;
            this.tbSalvar.Text = "Salvar";
            this.tbSalvar.UseVisualStyleBackColor = true;
            this.tbSalvar.Click += new System.EventHandler(this.tbSalvar_Click);
            // 
            // tbCancelar
            // 
            this.tbCancelar.Location = new System.Drawing.Point(150, 150);
            this.tbCancelar.Name = "tbCancelar";
            this.tbCancelar.Size = new System.Drawing.Size(75, 23);
            this.tbCancelar.TabIndex = 4;
            this.tbCancelar.Text = "Cancelar";
            this.tbCancelar.UseVisualStyleBackColor = true;
            this.tbCancelar.Click += new System.EventHandler(this.tbCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nova Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Conf. Senha";
            // 
            // EsqueciMinhaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 199);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCancelar);
            this.Controls.Add(this.tbSalvar);
            this.Controls.Add(this.tbConfirmacaoSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbEmail);
            this.Name = "EsqueciMinhaSenha";
            this.Text = "Esqueci Minha Senha";
            this.Load += new System.EventHandler(this.EsqueciMinhaSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbConfirmacaoSenha;
        private System.Windows.Forms.Button tbSalvar;
        private System.Windows.Forms.Button tbCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}