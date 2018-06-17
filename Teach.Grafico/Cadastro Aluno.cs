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

namespace Teach.Grafico
{
    public partial class Cadastro_Aluno : Form
    {
        public Aluno AlunoSelecionado { get; set; }
        public Cadastro_Aluno()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Aluno_Load(object sender, EventArgs e)
        {
            CarregaCB();
        }

        private void Cadastro_Aluno_Shown(object sender, EventArgs e)
        {
            if(AlunoSelecionado != null)
            {
                this.tbNome.Text = AlunoSelecionado.Nome.ToString();
                this.tbEmail.Text = AlunoSelecionado.Email.ToString();
                this.tbCelular.Text = AlunoSelecionado.Celular.ToString();
                this.tbCh.Text = AlunoSelecionado.CargaHoraria.ToString();
                this.tbVha.Text = AlunoSelecionado.ValorHoraAula.ToString();
                this.tbRua.Text = AlunoSelecionado.Rua.ToString();
                this.tbNumero.Text = AlunoSelecionado.Numero.ToString();
                this.tbComp.Text = AlunoSelecionado.Complemento.ToString();
                this.tbBairro.Text = AlunoSelecionado.Bairro.ToString();
                this.tbCEP.Text = AlunoSelecionado.CEP.ToString();
                this.tbCidade.Text = AlunoSelecionado.Cidade.ToString();
                this.cbDisciplina.SelectedItem = AlunoSelecionado.DisciplinaCursada;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Aluno NovoCadastro = new Aluno();
            NovoCadastro.Nome = tbNome.Text;
            NovoCadastro.Email = tbEmail.Text;
            NovoCadastro.Celular = tbCelular.Text;
            NovoCadastro.CargaHoraria = Convert.ToInt32(tbCh.Text);
            NovoCadastro.ValorHoraAula = Convert.ToDecimal(tbVha.Text);
            NovoCadastro.Rua = tbRua.Text;
            NovoCadastro.Numero = tbNumero.Text;
            NovoCadastro.Complemento = tbComp.Text;
            NovoCadastro.Bairro = tbBairro.Text;
            NovoCadastro.CEP = tbCEP.Text;
            NovoCadastro.Cidade = tbCidade.Text;
            NovoCadastro.DisciplinaCursada = cbDisciplina.SelectedItem as Disciplina;
            NovoCadastro.Professor = Program.Gerenciador.ProfessorLog();
            Validacao validacao;
            if (AlunoSelecionado == null)
            {
                validacao = Program.Gerenciador.CadastroAluno(NovoCadastro);
            }
            else
            {
                //Não apagar esta linha do ID. 
                NovoCadastro.Id = AlunoSelecionado.Id;
                validacao = Program.Gerenciador.EditarAluno(NovoCadastro);
            }
            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach (var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }

                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Aluno cadastrado com sucesso");

            }

            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaCB()
        {
            List<Disciplina> Disciplina = Program.Gerenciador.TodasAsDisciplinaDoProfessorLogado();
            cbDisciplina.DisplayMember = "disciplina";
            cbDisciplina.ValueMember = "Id";
            cbDisciplina.DataSource = Disciplina;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
