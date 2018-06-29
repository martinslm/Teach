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
    public partial class AdicionarAgendamento : Form
    {
        public Agenda Agendamentoselecionado { get; internal set; }

        public AdicionarAgendamento()
        {
            InitializeComponent();

            CarregaCB();

        }

        private void AdicionarAgendamento_Load(object sender, EventArgs e)
        {
            CarregaCB();

            if (Agendamentoselecionado != null)
            {
                tbInicio.Text = Agendamentoselecionado.HoraInicial.ToString();
                tbFim.Text = Agendamentoselecionado.HoraFinal.ToString();
                cbAluno.SelectedValue = Agendamentoselecionado.Aluno.Id;
                tbLocal.Text = Agendamentoselecionado.Endereco.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (tbInicio.Text == "" || tbFim.Text == "" || tbLocal.Text == "" )
            {
                MessageBox.Show("Você deve preencher todos os campos obrigatórios. São eles: Inicio e Fim e Local");
            }
            else
            {
                Agenda NovoAgendamento;
                if (Agendamentoselecionado != null)
                    NovoAgendamento = Agendamentoselecionado;
                else
                    NovoAgendamento = new Agenda();

                NovoAgendamento.HoraInicial = DateTime.Parse(tbInicio.Text);
                NovoAgendamento.HoraFinal = DateTime.Parse(tbFim.Text);
                NovoAgendamento.Aluno = cbAluno.SelectedItem as Aluno;
                NovoAgendamento.Endereco = tbLocal.Text;
                NovoAgendamento.Observacoes = tbObs.Text;
                NovoAgendamento.Professor = Program.Gerenciador.ProfessorLog();
                TimeSpan TotalHoras = NovoAgendamento.HoraFinal - NovoAgendamento.HoraInicial;
                NovoAgendamento.Valor = Convert.ToDecimal(TotalHoras.Hours + (TotalHoras.Minutes / 60)) * NovoAgendamento.Aluno.ValorHoraAula;
                Validacao validacao;
                if (Agendamentoselecionado != null)
                    validacao = Program.Gerenciador.EditarAgendamento(NovoAgendamento);
                else
                    validacao = Program.Gerenciador.NovoAgendamento(NovoAgendamento);

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
                    MessageBox.Show("Agendamento cadastrado com sucesso");
                    this.Close();
                }

                
            }
        }
        
        private void CarregaCB()
        {
            List<Aluno> Aluno = Program.Gerenciador.TodosOsAlunosDoProfessorLogado();
            cbAluno.DisplayMember = "Nome";
            cbAluno.ValueMember = "Id";
            cbAluno.DataSource = Aluno;
        }

        private void tbLocal_Leave(object sender, EventArgs e)
        {
            
        }

        private void AdicionarAgendamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            if (Application.OpenForms[telaPrincipal.Name] == null)
            {
                telaPrincipal.Show();
            }
            else
            {
                telaPrincipal.CarregaDG();
                //telaPrincipal.Focus();
            }
        }
    }
}
