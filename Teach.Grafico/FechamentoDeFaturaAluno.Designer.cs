namespace Teach.Grafico
{
    partial class FechamentoDeFaturaAluno
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
            this.components = new System.ComponentModel.Container();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgAlunos2 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btAvançar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Location = new System.Drawing.Point(12, 12);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(385, 20);
            this.tbPesquisa.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgAlunos2
            // 
            this.dgAlunos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlunos2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Disciplina,
            this.Situacao});
            this.dgAlunos2.Location = new System.Drawing.Point(12, 38);
            this.dgAlunos2.Name = "dgAlunos2";
            this.dgAlunos2.Size = new System.Drawing.Size(545, 363);
            this.dgAlunos2.TabIndex = 2;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Disciplina
            // 
            this.Disciplina.DataPropertyName = "Disciplina";
            this.Disciplina.HeaderText = "Disciplina";
            this.Disciplina.Name = "Disciplina";
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "SituacaoFinanceira";
            this.Situacao.HeaderText = "Situação Financeira";
            this.Situacao.Name = "Situacao";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(403, 12);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(154, 23);
            this.btPesquisar.TabIndex = 1;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btAvançar
            // 
            this.btAvançar.Location = new System.Drawing.Point(403, 407);
            this.btAvançar.Name = "btAvançar";
            this.btAvançar.Size = new System.Drawing.Size(154, 23);
            this.btAvançar.TabIndex = 3;
            this.btAvançar.Text = "Avançar";
            this.btAvançar.UseVisualStyleBackColor = true;
            this.btAvançar.Click += new System.EventHandler(this.btAvançar_Click);
            // 
            // FechamentoDeFaturaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 457);
            this.Controls.Add(this.btAvançar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.dgAlunos2);
            this.Controls.Add(this.tbPesquisa);
            this.Name = "FechamentoDeFaturaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechamento de Fatura Aluno";
            this.Load += new System.EventHandler(this.FechamentoDeFaturaAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgAlunos2;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btAvançar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
    }
}