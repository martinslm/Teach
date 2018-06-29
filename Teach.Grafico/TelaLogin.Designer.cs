namespace Teach.Grafico
{
    partial class TelaLogin
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
            this.Teach = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.EsquecerSenha = new System.Windows.Forms.Label();
            this.NovoCadastro = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.btAcessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Teach
            // 
            this.Teach.AutoSize = true;
            this.Teach.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Teach.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teach.Location = new System.Drawing.Point(168, 39);
            this.Teach.Name = "Teach";
            this.Teach.Size = new System.Drawing.Size(133, 42);
            this.Teach.TabIndex = 0;
            this.Teach.Text = "Teach!";
            this.Teach.Click += new System.EventHandler(this.label1_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(96, 104);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(47, 17);
            this.Email.TabIndex = 1;
            this.Email.Text = "E-mail";
            this.Email.Click += new System.EventHandler(this.Login_Click);
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(96, 130);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(49, 17);
            this.Senha.TabIndex = 2;
            this.Senha.Text = "Senha";
            // 
            // EsquecerSenha
            // 
            this.EsquecerSenha.AutoSize = true;
            this.EsquecerSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EsquecerSenha.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EsquecerSenha.Location = new System.Drawing.Point(172, 153);
            this.EsquecerSenha.Name = "EsquecerSenha";
            this.EsquecerSenha.Size = new System.Drawing.Size(108, 13);
            this.EsquecerSenha.TabIndex = 3;
            this.EsquecerSenha.Text = "Esqueci minha senha";
            this.EsquecerSenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // NovoCadastro
            // 
            this.NovoCadastro.AutoSize = true;
            this.NovoCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoCadastro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NovoCadastro.Location = new System.Drawing.Point(172, 225);
            this.NovoCadastro.Name = "NovoCadastro";
            this.NovoCadastro.Size = new System.Drawing.Size(100, 13);
            this.NovoCadastro.TabIndex = 4;
            this.NovoCadastro.Text = "Quero me cadastrar";
            this.NovoCadastro.Click += new System.EventHandler(this.NovoCadastro_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(146, 104);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(170, 20);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(146, 130);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(170, 20);
            this.tbSenha.TabIndex = 6;
            this.tbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSenha_KeyDown);
            // 
            // btAcessar
            // 
            this.btAcessar.Location = new System.Drawing.Point(187, 181);
            this.btAcessar.Name = "btAcessar";
            this.btAcessar.Size = new System.Drawing.Size(75, 23);
            this.btAcessar.TabIndex = 7;
            this.btAcessar.Text = "Entrar";
            this.btAcessar.UseVisualStyleBackColor = true;
            this.btAcessar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 308);
            this.Controls.Add(this.btAcessar);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.NovoCadastro);
            this.Controls.Add(this.EsquecerSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Teach);
            this.MaximizeBox = false;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Teach;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label EsquecerSenha;
        private System.Windows.Forms.Label NovoCadastro;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button btAcessar;
    }
}

