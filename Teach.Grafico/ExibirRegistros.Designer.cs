namespace Teach.Grafico
{
    partial class ExibirRegistros
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
            this.dgRegistros = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRegistros
            // 
            this.dgRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.TotalHoras,
            this.Valor});
            this.dgRegistros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgRegistros.Location = new System.Drawing.Point(0, 5);
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.Size = new System.Drawing.Size(431, 447);
            this.dgRegistros.TabIndex = 0;
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
            // ExibirRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 452);
            this.Controls.Add(this.dgRegistros);
            this.MaximizeBox = false;
            this.Name = "ExibirRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExibirRegistros";
            this.Load += new System.EventHandler(this.ExibirRegistros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}