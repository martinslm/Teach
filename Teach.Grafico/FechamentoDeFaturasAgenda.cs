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
using Teach.Negocio.Persistencia;

namespace Teach.Grafico
{
    
    public partial class FechamentoDeFaturasAgenda : Form
    {
        private Banco banco = new Banco();
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
            lbValor.Text = "R$" + (ValorTotal.ToString());
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

        private void btGerarFatura_Click(object sender, EventArgs e)
        {
            Fatura Fatura = new Fatura();
            using (Banco db = new Banco())
            {
                Fatura.DataGeracao = DateTime.Now;
                Fatura.ValorTotal = ValorTotal;
                Fatura.Professor = Program.Gerenciador.BuscaProfessorPorId(Program.Gerenciador.ProfessorLogado);
                Fatura.Situacao = "Aberto";
                Fatura.Aluno = AlunoParaFechamento;
                db.Entry(Fatura);
                db.SaveChanges();
            }

            foreach(var agn in FuturaFatura)
            {
                Program.Gerenciador.AtribuiIdFaturaGeradaAoAgendamento(agn, Fatura);
            }

            String vt = Convert.ToString(ValorTotal);

            MessageBox.Show($"Fatura gerada com sucesso.\n Aluno: {AlunoParaFechamento.Nome}\n Valor Total: R${vt}");
            this.Close();
        }
    }
}
