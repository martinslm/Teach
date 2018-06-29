namespace Teach.Grafico
{
    partial class ContasAReceber
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
            this.tbPesquisar = new System.Windows.Forms.Button();
            this.dgContasReceber = new System.Windows.Forms.DataGridView();
            this.DataGeracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBaixa = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgContasReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Location = new System.Drawing.Point(12, 12);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(278, 20);
            this.tbPesquisa.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Location = new System.Drawing.Point(304, 10);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(153, 23);
            this.tbPesquisar.TabIndex = 2;
            this.tbPesquisar.Text = "Pesquisar";
            this.tbPesquisar.UseVisualStyleBackColor = true;
            this.tbPesquisar.Click += new System.EventHandler(this.tbPesquisar_Click);
            // 
            // dgContasReceber
            // 
            this.dgContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContasReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGeracao,
            this.Aluno,
            this.Valor});
            this.dgContasReceber.Location = new System.Drawing.Point(12, 38);
            this.dgContasReceber.Name = "dgContasReceber";
            this.dgContasReceber.Size = new System.Drawing.Size(495, 345);
            this.dgContasReceber.TabIndex = 3;
            this.dgContasReceber.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContasReceber_CellContentClick);
            // 
            // DataGeracao
            // 
            this.DataGeracao.DataPropertyName = "DataGeracao";
            this.DataGeracao.HeaderText = "Data Geração";
            this.DataGeracao.Name = "DataGeracao";
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
            this.Valor.HeaderText = "Valor Total";
            this.Valor.Name = "Valor";
            // 
            // btBaixa
            // 
            this.btBaixa.Location = new System.Drawing.Point(354, 389);
            this.btBaixa.Name = "btBaixa";
            this.btBaixa.Size = new System.Drawing.Size(153, 36);
            this.btBaixa.TabIndex = 4;
            this.btBaixa.Text = "Baixar Fatura";
            this.btBaixa.UseVisualStyleBackColor = true;
            this.btBaixa.Click += new System.EventHandler(this.btBaixa_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(195, 389);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(153, 36);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // ContasAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 454);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btBaixa);
            this.Controls.Add(this.dgContasReceber);
            this.Controls.Add(this.tbPesquisar);
            this.Controls.Add(this.tbPesquisa);
            this.MaximizeBox = false;
            this.Name = "ContasAReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.ContasAReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgContasReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button tbPesquisar;
        private System.Windows.Forms.DataGridView dgContasReceber;
        private System.Windows.Forms.Button btBaixa;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGeracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}