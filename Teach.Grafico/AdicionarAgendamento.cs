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
        public AdicionarAgendamento()
        {
            InitializeComponent();
        }

        private void AdicionarAgendamento_Load(object sender, EventArgs e)
        {
            CarregaCB();
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
            Agenda NovoAgendamento = new Agenda();
            NovoAgendamento.HoraInicial = Convert.ToDateTime(tbInicio.Text);
            NovoAgendamento.HoraFinal = Convert.ToDateTime(tbFim.Text);
            NovoAgendamento.Aluno = cbAluno.SelectedItem as Aluno;
            NovoAgendamento.Endereco = tbLocal.Text;
            NovoAgendamento.Observacoes = tbObs.Text;
            NovoAgendamento.Professor = Program.Gerenciador.ProfessorLog();

            Validacao validacao = Program.Gerenciador.NovoAgendamento(NovoAgendamento);

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

            }

            this.Close();
            
        }
        
        private void CarregaCB()
        {
            List<Aluno> Aluno = Program.Gerenciador.TodosOsAlunosDoProfessorLogado();
            cbAluno.DisplayMember = "Nome";
            cbAluno.ValueMember = "Id";
            cbAluno.DataSource = Aluno;
        }
    }
}
