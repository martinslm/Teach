using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teach.Negocio;
using Teach.Negocio.Models;
using Teach.Negocio.Persistencia;

namespace Teach.Grafico
{
    public partial class CadastroProfessor : Form
    {
        Professor NovoCadastro = new Professor();
        private Banco banco = new Banco();
        public CadastroProfessor()
        {
            InitializeComponent();
            CarregaDG();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtDisciplina_Click(object sender, EventArgs e)
        {
            IncluirDisciplina tela = new IncluirDisciplina();
            tela.FormClosed += Tela_FormClosed;
            tela.professor = this.NovoCadastro;
            tela.Show();
            
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregaDG();
        }

        private bool VerificaSelecao()
        {
            if (dgDisciplinas.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        //não ta funcionando 
        private void btRemoverDisciplina_Click(object sender, EventArgs e)
        {
            if(VerificaSelecao())
            {
                Disciplina DisciplinaSelecionada = (Disciplina)dgDisciplinas.SelectedRows[0].DataBoundItem;
                if (Program.Gerenciador.TodosOsAlunosDoProfessorLogado().Any(t => t.DisciplinaCursada.Id == DisciplinaSelecionada.Id))
                {
                    MessageBox.Show("Você possui alunos cursando esta disciplina, portanto, não é possível removê-la");
                }
                else
                this.NovoCadastro.Disciplina.Remove(DisciplinaSelecionada);
                CarregaDG();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //QuatidadeMaximadeCaracteresPermitidos.
            tbSenha.MaxLength = 8;
            tbConfirmacao.MaxLength = 8;

            if (tbConfirmacao.TextLength > 8 || tbSenha.TextLength > 8)
            {
                MessageBox.Show("Sua senha não pode conter mais que 8 caracteres.");
            }
            else
            {
                NovoCadastro.Nome = tbNome.Text;
                NovoCadastro.Email = tbEmail.Text;
                NovoCadastro.Telefone = tbTelefone.Text;
                NovoCadastro.Senha = tbSenha.Text;
                String ConfirmacaoSenha = tbConfirmacao.Text;
                /*Ver como adicionar disciplina*/

                Validacao validacao;
                if (Program.Gerenciador.ProfessorLogado == 0)
                {
                    validacao = Program.Gerenciador.CadastroProfessor(NovoCadastro, ConfirmacaoSenha);
                }
                else
                {
                    validacao = Program.Gerenciador.MinhaConta(NovoCadastro, ConfirmacaoSenha);
                }

                if (validacao.Valido)
                {
                    MessageBox.Show("Cadastro realizado com sucesso.");
                    this.Close();
                }
                else
                {
                    String mensagemValidacao = " ";
                    foreach (var chave in validacao.Mensagens.Keys)
                    {
                        String msg = validacao.Mensagens[chave];
                        mensagemValidacao += msg;
                        mensagemValidacao += Environment.NewLine;
                    }
                    MessageBox.Show(mensagemValidacao);
                }
            }
        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            
        }        

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CarregaDG()
        {
            dgDisciplinas.MultiSelect = false;
            //DgDisciplinas.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgDisciplinas.AutoGenerateColumns = false;
            //List<Disciplina> Disciplinas = Program.Gerenciador.TodasAsDisciplina();
            dgDisciplinas.DataSource = this.NovoCadastro.Disciplina.ToList();
        }

        private void CadastroProfessor_Shown(object sender, EventArgs e)
        {
            if(Program.Gerenciador.ProfessorLogado != 0)
            {
                Professor DadosProfessor = Program.Gerenciador.BuscaProfessorPorID(Program.Gerenciador.ProfessorLogado);
                this.tbEmail.Text = DadosProfessor.Email.ToString();
                this.tbNome.Text = DadosProfessor.Nome.ToString();
                this.tbSenha.Text = DadosProfessor.Senha.ToString();
                this.tbTelefone.Text = DadosProfessor.Telefone.ToString();
                this.dgDisciplinas.DataSource = DadosProfessor.Disciplina.ToList();
                this.NovoCadastro.Disciplina = DadosProfessor.Disciplina.ToList();
            }
        }
    }
}
