namespace Teach.Grafico
{
    partial class CadastroProfessor
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbConfirmacao = new System.Windows.Forms.TextBox();
            this.BtDisciplina = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dgDisciplinas = new System.Windows.Forms.DataGridView();
            this.Disciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemoverDisciplina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(158, 31);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(225, 20);
            this.tbNome.TabIndex = 0;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(158, 57);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(225, 20);
            this.tbEmail.TabIndex = 1;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(158, 109);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(225, 20);
            this.tbSenha.TabIndex = 3;
            // 
            // tbConfirmacao
            // 
            this.tbConfirmacao.Location = new System.Drawing.Point(158, 135);
            this.tbConfirmacao.Name = "tbConfirmacao";
            this.tbConfirmacao.PasswordChar = '*';
            this.tbConfirmacao.Size = new System.Drawing.Size(225, 20);
            this.tbConfirmacao.TabIndex = 4;
            // 
            // BtDisciplina
            // 
            this.BtDisciplina.Location = new System.Drawing.Point(65, 175);
            this.BtDisciplina.Name = "BtDisciplina";
            this.BtDisciplina.Size = new System.Drawing.Size(75, 36);
            this.BtDisciplina.TabIndex = 5;
            this.BtDisciplina.Text = "Incluir Disicplina";
            this.BtDisciplina.UseVisualStyleBackColor = true;
            this.BtDisciplina.Click += new System.EventHandler(this.BtDisciplina_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(227, 271);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 28);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(308, 271);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 28);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Senha ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Confirmação  Senha";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(158, 83);
            this.tbTelefone.Mask = "00000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(224, 20);
            this.tbTelefone.TabIndex = 2;
            this.tbTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // dgDisciplinas
            // 
            this.dgDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisciplinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Disciplina});
            this.dgDisciplinas.Location = new System.Drawing.Point(158, 169);
            this.dgDisciplinas.Name = "dgDisciplinas";
            this.dgDisciplinas.Size = new System.Drawing.Size(225, 96);
            this.dgDisciplinas.TabIndex = 14;
            // 
            // Disciplina
            // 
            this.Disciplina.DataPropertyName = "disciplina";
            this.Disciplina.HeaderText = "Disciplina";
            this.Disciplina.Name = "Disciplina";
            // 
            // btRemoverDisciplina
            // 
            this.btRemoverDisciplina.Location = new System.Drawing.Point(65, 217);
            this.btRemoverDisciplina.Name = "btRemoverDisciplina";
            this.btRemoverDisciplina.Size = new System.Drawing.Size(75, 36);
            this.btRemoverDisciplina.TabIndex = 6;
            this.btRemoverDisciplina.Text = "Remover Disicplina";
            this.btRemoverDisciplina.UseVisualStyleBackColor = true;
            this.btRemoverDisciplina.Click += new System.EventHandler(this.btRemoverDisciplina_Click);
            // 
            // CadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 331);
            this.Controls.Add(this.btRemoverDisciplina);
            this.Controls.Add(this.dgDisciplinas);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.BtDisciplina);
            this.Controls.Add(this.tbConfirmacao);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNome);
            this.MaximizeBox = false;
            this.Name = "CadastroProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Professor";
            this.Load += new System.EventHandler(this.CadastroProfessor_Load);
            this.Shown += new System.EventHandler(this.CadastroProfessor_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgDisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbConfirmacao;
        private System.Windows.Forms.Button BtDisciplina;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
        private System.Windows.Forms.DataGridView dgDisciplinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disciplina;
        private System.Windows.Forms.Button btRemoverDisciplina;
    }
}