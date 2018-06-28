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
    public partial class TelaGestaoAlunos : Form
    {
        public Aluno AlunoSelecionado;
        public TelaGestaoAlunos()
        {
            InitializeComponent();
        }

        private void TelaGestaoAlunos_Load(object sender, EventArgs e)
        {
            CarregaAlunos();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Cadastro_Aluno tela = new Cadastro_Aluno();
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void dgAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregaAlunos()
        {
            dgAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAlunos.MultiSelect = false;
            dgAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAlunos.AutoGenerateColumns = false;
            List<Aluno> Alunos = Program.Gerenciador.TodosOsAlunosDoProfessorLogado();
            dgAlunos.DataSource = Alunos;
            dgAlunos.Refresh();
            
        }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
            dgAlunos.DataSource = null;
            dgAlunos.Rows.Clear();
            dgAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAlunos.MultiSelect = false;
            dgAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAlunos.AutoGenerateColumns = false;
            List<Aluno> Alunos = Program.Gerenciador.PesquisaAlunosPorNome(tbPesquisa.Text);
            dgAlunos.DataSource = Alunos;
            dgAlunos.Refresh();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if(VerificarSelecao())
            {
                Aluno AlunoSelecionado = (Aluno)dgAlunos.SelectedRows[0].DataBoundItem;
                Cadastro_Aluno tela = new Cadastro_Aluno();
                tela.MdiParent = this.MdiParent;
                tela.AlunoSelecionado = AlunoSelecionado;
                tela.FormClosed += Tela_FormClosed;
                tela.Show();
            }
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregaAlunos();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("","Tem certeza que deseja remover este aluno?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    AlunoSelecionado = (Aluno)dgAlunos.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverAluno(AlunoSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Aluno removido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Não é possível remover o aluno selecionado, pois já existem registros de agendamentos com o mesmo");
                    }
                    CarregaAlunos();
                }

            }
        }

        private bool VerificarSelecao()
        {
            if (dgAlunos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;

        }
    }
}
