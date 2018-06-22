namespace Teach.Grafico
{
    partial class FechamentoDeFaturasAgenda
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
            this.dgAgnAbertos = new System.Windows.Forms.DataGridView();
            this.dgFuturaFatura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btGerarFatura = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHorasIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgnAbertos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuturaFatura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAgnAbertos
            // 
            this.dgAgnAbertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgnAbertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.TotalHoras,
            this.Valor});
            this.dgAgnAbertos.Location = new System.Drawing.Point(12, 44);
            this.dgAgnAbertos.Name = "dgAgnAbertos";
            this.dgAgnAbertos.Size = new System.Drawing.Size(408, 150);
            this.dgAgnAbertos.TabIndex = 0;
            // 
            // dgFuturaFatura
            // 
            this.dgFuturaFatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuturaFatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataIC,
            this.TotalHorasIC,
            this.ValorIC});
            this.dgFuturaFatura.Location = new System.Drawing.Point(12, 255);
            this.dgFuturaFatura.Name = "dgFuturaFatura";
            this.dgFuturaFatura.Size = new System.Drawing.Size(408, 150);
            this.dgFuturaFatura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agendamentos em aberto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inclusos na fatura";
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(445, 91);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(96, 54);
            this.btIncluir.TabIndex = 4;
            this.btIncluir.Text = "Incluir na Fatura";
            this.btIncluir.UseVisualStyleBackColor = true;
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(445, 313);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(96, 54);
            this.btRemover.TabIndex = 5;
            this.btRemover.Text = "Remover da Fatura";
            this.btRemover.UseVisualStyleBackColor = true;
            // 
            // btGerarFatura
            // 
            this.btGerarFatura.Location = new System.Drawing.Point(378, 411);
            this.btGerarFatura.Name = "btGerarFatura";
            this.btGerarFatura.Size = new System.Drawing.Size(163, 38);
            this.btGerarFatura.TabIndex = 6;
            this.btGerarFatura.Text = "Gerar Fatura";
            this.btGerarFatura.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(209, 411);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(163, 38);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "DataAgendamento";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // TotalHoras
            // 
            this.TotalHoras.DataPropertyName = "TotalHoras";
            this.TotalHoras.HeaderText = "Total Horas";
            this.TotalHoras.Name = "TotalHoras";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // DataIC
            // 
            this.DataIC.DataPropertyName = "DataAgendamento";
            this.DataIC.HeaderText = "Data";
            this.DataIC.Name = "DataIC";
            // 
            // TotalHorasIC
            // 
            this.TotalHorasIC.DataPropertyName = "TotalHoras";
            this.TotalHorasIC.HeaderText = "Total Horas";
            this.TotalHorasIC.Name = "TotalHorasIC";
            // 
            // ValorIC
            // 
            this.ValorIC.DataPropertyName = "Valor";
            this.ValorIC.HeaderText = "Valor";
            this.ValorIC.Name = "ValorIC";
            // 
            // FechamentoDeFaturasAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 461);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGerarFatura);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgFuturaFatura);
            this.Controls.Add(this.dgAgnAbertos);
            this.Name = "FechamentoDeFaturasAgenda";
            this.Text = "FechamentoDeFaturasAgenda";
            this.Load += new System.EventHandler(this.FechamentoDeFaturasAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAgnAbertos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuturaFatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAgnAbertos;
        private System.Windows.Forms.DataGridView dgFuturaFatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btGerarFatura;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHorasIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorIC;
    }
}