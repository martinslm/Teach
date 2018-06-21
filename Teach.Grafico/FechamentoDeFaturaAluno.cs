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
    public partial class FechamentoDeFaturaAluno : Form
    {
        public Aluno AlunoParaFechamento;
        public FechamentoDeFaturaAluno()
        {
            InitializeComponent();
        }

        private void FechamentoDeFaturaAluno_Load(object sender, EventArgs e)
        {
            CarregaAlunos();
        }

        private void CarregaAlunos()
        {
            dgAlunos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAlunos2.MultiSelect = false;
            dgAlunos2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAlunos2.AutoGenerateColumns = false;
            List<Aluno> Alunos = Program.Gerenciador.TodosOsAlunosDoProfessorLogado();
            dgAlunos2.DataSource = Alunos;

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            dgAlunos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAlunos2.MultiSelect = false;
            dgAlunos2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAlunos2.AutoGenerateColumns = false;
            List<Aluno> Alunos = Program.Gerenciador.PesquisaAlunosPorNome(tbPesquisa.Text);
            dgAlunos2.DataSource = Alunos;
        }

        private bool VerificarSelecao()
        {
            if (dgAlunos2.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;

        }

        private void btAvançar_Click(object sender, EventArgs e)
        {
            if(VerificarSelecao())
            {
                AlunoParaFechamento = (Aluno)dgAlunos2.SelectedRows[0].DataBoundItem;
                FechamentoDeFaturasAgenda tela = new FechamentoDeFaturasAgenda();
                tela.Show();
            }
        }
    }
}
