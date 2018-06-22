using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teach.Grafico
{
    
    public partial class FechamentoDeFaturasAgenda : Form
    {
        TelaGestaoAlunos telaAnterior = new TelaGestaoAlunos();
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
            dgAgnAbertos.DataSource = Program.Gerenciador.CarregaAgendamentosDeAlunos(telaAnterior.AlunoSelecionado);

        }

        public void CarregaDgFuturaFatura()
        {

        }

        //CarregaAgendamentosDeAlunos - funcao do gerenciador, passar como parametro o aluno.
    }
}
