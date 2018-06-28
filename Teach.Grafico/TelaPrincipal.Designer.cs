namespace Teach.Grafico
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhaContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarFaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.dgAgendamentos = new System.Windows.Forms.DataGridView();
            this.HorarioInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btneditarAgendamento = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(841, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.minhaContaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // minhaContaToolStripMenuItem
            // 
            this.minhaContaToolStripMenuItem.Name = "minhaContaToolStripMenuItem";
            this.minhaContaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.minhaContaToolStripMenuItem.Text = "Minha Conta";
            this.minhaContaToolStripMenuItem.Click += new System.EventHandler(this.minhaContaToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarFaturaToolStripMenuItem,
            this.contasAReceberToolStripMenuItem,
            this.recibosToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // gerarFaturaToolStripMenuItem
            // 
            this.gerarFaturaToolStripMenuItem.Name = "gerarFaturaToolStripMenuItem";
            this.gerarFaturaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.gerarFaturaToolStripMenuItem.Text = "Gerar Fatura";
            this.gerarFaturaToolStripMenuItem.Click += new System.EventHandler(this.gerarFaturaToolStripMenuItem_Click);
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.contasAReceberToolStripMenuItem.Text = "Contas a Receber";
            this.contasAReceberToolStripMenuItem.Click += new System.EventHandler(this.contasAReceberToolStripMenuItem_Click);
            // 
            // recibosToolStripMenuItem
            // 
            this.recibosToolStripMenuItem.Name = "recibosToolStripMenuItem";
            this.recibosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.recibosToolStripMenuItem.Text = "Recibos";
            this.recibosToolStripMenuItem.Click += new System.EventHandler(this.recibosToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 442);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(841, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(19, 98);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 0;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(19, 272);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(227, 49);
            this.btAdicionar.TabIndex = 1;
            this.btAdicionar.Text = "Adicionar agendamento";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(19, 381);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(227, 49);
            this.btRemover.TabIndex = 2;
            this.btRemover.Text = "Remover agendamento";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // dgAgendamentos
            // 
            this.dgAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgendamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HorarioInicial,
            this.HorarioFinal,
            this.Aluno,
            this.Endereco,
            this.Observacoes});
            this.dgAgendamentos.Location = new System.Drawing.Point(258, 46);
            this.dgAgendamentos.Name = "dgAgendamentos";
            this.dgAgendamentos.Size = new System.Drawing.Size(544, 351);
            this.dgAgendamentos.TabIndex = 8;
            this.dgAgendamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // HorarioInicial
            // 
            this.HorarioInicial.DataPropertyName = "HoraInicial";
            this.HorarioInicial.HeaderText = "Inicio";
            this.HorarioInicial.Name = "HorarioInicial";
            // 
            // HorarioFinal
            // 
            this.HorarioFinal.DataPropertyName = "HoraFinal";
            this.HorarioFinal.HeaderText = "Fim";
            this.HorarioFinal.Name = "HorarioFinal";
            // 
            // Aluno
            // 
            this.Aluno.DataPropertyName = "NomeAluno";
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco";
            this.Endereco.HeaderText = "Local";
            this.Endereco.Name = "Endereco";
            // 
            // Observacoes
            // 
            this.Observacoes.DataPropertyName = "Observacoes";
            this.Observacoes.HeaderText = "Observações";
            this.Observacoes.Name = "Observacoes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Agenda";
            // 
            // btneditarAgendamento
            // 
            this.btneditarAgendamento.Location = new System.Drawing.Point(19, 327);
            this.btneditarAgendamento.Name = "btneditarAgendamento";
            this.btneditarAgendamento.Size = new System.Drawing.Size(227, 49);
            this.btneditarAgendamento.TabIndex = 12;
            this.btneditarAgendamento.Text = "Editar agendamento";
            this.btneditarAgendamento.UseVisualStyleBackColor = true;
            this.btneditarAgendamento.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 464);
            this.Controls.Add(this.btneditarAgendamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgAgendamentos);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teach";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhaContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarFaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibosToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.DataGridView dgAgendamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneditarAgendamento;
    }
}



