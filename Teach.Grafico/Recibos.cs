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
    public partial class Recibos : Form
    {
        public Recibos()
        {
            InitializeComponent();
        }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
            dgRecibos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgRecibos.MultiSelect = false;
            dgRecibos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgRecibos.AutoGenerateColumns = false;
            List<Fatura> Faturas = Program.Gerenciador.BuscaReciboPorNome(tbPesquisa.Text);
            dgRecibos.DataSource = Faturas;
        }
        private void CarregaRecibos()
        {
            dgRecibos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgRecibos.MultiSelect = false;
            dgRecibos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgRecibos.AutoGenerateColumns = false;
            List<Fatura> Recibos = Program.Gerenciador.TodosOsRecibosDoProfessorLogado();
            dgRecibos.DataSource = Recibos;
            dgRecibos.Refresh();
        }

        private void Recibos_Load(object sender, EventArgs e)
        {
            CarregaRecibos();
        }

        private void btInfAgn_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Fatura ReciboSelecionado = (Fatura)dgRecibos.SelectedRows[0].DataBoundItem;
                ExibirRegistros tela = new ExibirRegistros();
                tela.ReciboSelecionado = ReciboSelecionado;
                tela.Show();
            }

        }

        private bool VerificarSelecao()
        {
            if (dgRecibos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void dgRecibos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
