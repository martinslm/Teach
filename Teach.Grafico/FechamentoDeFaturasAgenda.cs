using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teach.Negocio.Models;

namespace Teach.Grafico
{
    
    public partial class FechamentoDeFaturasAgenda : Form
    {
        public Aluno AlunoParaFechamento;
        public decimal ValorTotal=0;
        public List<Agenda> FuturaFatura = new List<Agenda>();
        public FechamentoDeFaturasAgenda()
        {
            InitializeComponent();
        }

        private void FechamentoDeFaturasAgenda_Load(object sender, EventArgs e)
        {
            CarregaDgAgnAbertos();
        }

        public void CarregaDgAgnAbertos()
        {
            dgAgnAbertos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAgnAbertos.MultiSelect = false;
            dgAgnAbertos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAgnAbertos.AutoGenerateColumns = false;
            dgAgnAbertos.DataSource = Program.Gerenciador.CarregaAgendamentosDeAlunos(AlunoParaFechamento);

        }

        public void CarregaDgFuturaFatura()
        {
            dgFuturaFatura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgFuturaFatura.MultiSelect = false;
            dgFuturaFatura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgFuturaFatura.AutoGenerateColumns = false;
            dgFuturaFatura.DataSource = FuturaFatura.ToList();
            dgFuturaFatura.Refresh();
        }

        private void CarregaTotal()
        {
            ValorTotal = 0;
            foreach(var ftr in FuturaFatura)
            {
                ValorTotal += ftr.Valor;
            }
            lbValor.Text = ValorTotal.ToString();
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Agenda Agendamento = (Agenda)dgAgnAbertos.SelectedRows[0].DataBoundItem;
                FuturaFatura.Add(Agendamento);
                CarregaDgFuturaFatura();
                CarregaTotal();
            }

            CarregaDgFuturaFatura();
            //ESTÁ ADICIONANDO NA LISTA, PORÉM O CARREGA DG NÃO ESTÁ FUNCIONANDO. 
        }

        private bool VerificarSelecao()
        {
            if (dgAgnAbertos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if(VerificarSelecao())
            {
                Agenda Remover = (Agenda)dgFuturaFatura.SelectedRows[0].DataBoundItem;
                FuturaFatura.Remove(Remover);
                CarregaDgFuturaFatura();
                CarregaTotal();
            }

            CarregaDgFuturaFatura();
        }
        //2º dg ta com problema, remove nao ta funcionando. 
        //CarregaAgendamentosDeAlunos - funcao do gerenciador, passar como parametro o aluno.
    }
}
