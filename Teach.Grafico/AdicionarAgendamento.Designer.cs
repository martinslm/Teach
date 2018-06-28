namespace Teach.Grafico
{
    partial class AdicionarAgendamento
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
            this.tbLocal = new System.Windows.Forms.TextBox();
            this.cbAluno = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tbObs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFim = new System.Windows.Forms.MaskedTextBox();
            this.tbInicio = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // tbLocal
            // 
            this.tbLocal.Location = new System.Drawing.Point(100, 108);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Size = new System.Drawing.Size(272, 20);
            this.tbLocal.TabIndex = 4;
            // 
            // cbAluno
            // 
            this.cbAluno.FormattingEnabled = true;
            this.cbAluno.Location = new System.Drawing.Point(100, 70);
            this.cbAluno.Name = "cbAluno";
            this.cbAluno.Size = new System.Drawing.Size(272, 21);
            this.cbAluno.TabIndex = 3;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(297, 179);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 28);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(216, 179);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 28);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tbObs
            // 
            this.tbObs.Location = new System.Drawing.Point(100, 144);
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(272, 20);
            this.tbObs.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Inicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Aluno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Local";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Conteúdo";
            // 
            // tbFim
            // 
            this.tbFim.Location = new System.Drawing.Point(251, 32);
            this.tbFim.Mask = "00/00/0000 00:00";
            this.tbFim.Name = "tbFim";
            this.tbFim.Size = new System.Drawing.Size(121, 20);
            this.tbFim.TabIndex = 2;
            // 
            // tbInicio
            // 
            this.tbInicio.Location = new System.Drawing.Point(100, 32);
            this.tbInicio.Mask = "00/00/0000 00:00";
            this.tbInicio.Name = "tbInicio";
            this.tbInicio.Size = new System.Drawing.Size(121, 20);
            this.tbInicio.TabIndex = 1;
            // 
            // AdicionarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 240);
            this.Controls.Add(this.tbInicio);
            this.Controls.Add(this.tbFim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbObs);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.cbAluno);
            this.Controls.Add(this.tbLocal);
            this.Name = "AdicionarAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.AdicionarAgendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbLocal;
        private System.Windows.Forms.ComboBox cbAluno;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox tbObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tbFim;
        private System.Windows.Forms.MaskedTextBox tbInicio;
    }
}