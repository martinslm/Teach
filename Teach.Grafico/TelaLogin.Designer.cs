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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Acessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Teach
            // 
            this.Teach.AutoSize = true;
            this.Teach.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Teach.Font = new System.Drawing.Font("Fontastique", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teach.Location = new System.Drawing.Point(83, 19);
            this.Teach.Name = "Teach";
            this.Teach.Size = new System.Drawing.Size(122, 45);
            this.Teach.TabIndex = 0;
            this.Teach.Text = "Teach!";
            this.Teach.Click += new System.EventHandler(this.label1_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(28, 99);
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
            this.Senha.Location = new System.Drawing.Point(28, 125);
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
            this.EsquecerSenha.Location = new System.Drawing.Point(140, 148);
            this.EsquecerSenha.Name = "EsquecerSenha";
            this.EsquecerSenha.Size = new System.Drawing.Size(108, 13);
            this.EsquecerSenha.TabIndex = 3;
            this.EsquecerSenha.Text = "Esqueci minha senha";
            this.EsquecerSenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // NovoCadastro
            // 
            this.NovoCadastro.AutoSize = true;
            this.NovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoCadastro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NovoCadastro.Location = new System.Drawing.Point(172, 239);
            this.NovoCadastro.Name = "NovoCadastro";
            this.NovoCadastro.Size = new System.Drawing.Size(100, 13);
            this.NovoCadastro.TabIndex = 4;
            this.NovoCadastro.Text = "Quero me cadastrar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 6;
            // 
            // Acessar
            // 
            this.Acessar.Location = new System.Drawing.Point(91, 181);
            this.Acessar.Name = "Acessar";
            this.Acessar.Size = new System.Drawing.Size(75, 23);
            this.Acessar.TabIndex = 7;
            this.Acessar.Text = "Acessar";
            this.Acessar.UseVisualStyleBackColor = true;
            this.Acessar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Acessar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NovoCadastro);
            this.Controls.Add(this.EsquecerSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Teach);
            this.Name = "TelaLogin";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Acessar;
    }
}

