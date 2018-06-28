namespace Teach.Grafico
{
    partial class Recibos
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
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.dgRecibos = new System.Windows.Forms.DataGridView();
            this.btInfAgn = new System.Windows.Forms.Button();
            this.DataBaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Location = new System.Drawing.Point(12, 12);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(594, 20);
            this.tbPesquisa.TabIndex = 0;
            // 
            // btPesquisa
            // 
            this.btPesquisa.Location = new System.Drawing.Point(612, 11);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(164, 23);
            this.btPesquisa.TabIndex = 1;
            this.btPesquisa.Text = "Pesquisar";
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // dgRecibos
            // 
            this.dgRecibos.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dgRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataBaixa,
            this.Aluno,
            this.Valor});
            this.dgRecibos.Location = new System.Drawing.Point(12, 40);
            this.dgRecibos.Name = "dgRecibos";
            this.dgRecibos.Size = new System.Drawing.Size(764, 357);
            this.dgRecibos.TabIndex = 2;
            // 
            // btInfAgn
            // 
            this.btInfAgn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInfAgn.Location = new System.Drawing.Point(636, 403);
            this.btInfAgn.Name = "btInfAgn";
            this.btInfAgn.Size = new System.Drawing.Size(140, 36);
            this.btInfAgn.TabIndex = 3;
            this.btInfAgn.Text = "Exibir Agendamentos";
            this.btInfAgn.UseVisualStyleBackColor = true;
            this.btInfAgn.Click += new System.EventHandler(this.btInfAgn_Click);
            // 
            // DataBaixa
            // 
            this.DataBaixa.DataPropertyName = "DataBaixa";
            this.DataBaixa.HeaderText = "Data Baixa ";
            this.DataBaixa.Name = "DataBaixa";
            // 
            // Aluno
            // 
            this.Aluno.DataPropertyName = "NomeAluno";
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "ValorTotal";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Recibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btInfAgn);
            this.Controls.Add(this.dgRecibos);
            this.Controls.Add(this.btPesquisa);
            this.Controls.Add(this.tbPesquisa);
            this.Name = "Recibos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Recibos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRecibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.DataGridView dgRecibos;
        private System.Windows.Forms.Button btInfAgn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataBaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}