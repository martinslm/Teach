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
    public partial class ExibirRegistros : Form
    {
        public Fatura ReciboSelecionado;
        public ExibirRegistros()
        {
            InitializeComponent();
        }
        private void CarregaDG()
        {
            dgRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgRegistros.MultiSelect = false;
            dgRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgRegistros.AutoGenerateColumns = false;
            List<Agenda> Registros = Program.Gerenciador.Registros(ReciboSelecionado);
            dgRegistros.DataSource = Registros;
        }
        private void ExibirRegistros_Load(object sender, EventArgs e)
        {
            CarregaDG();
        }
    }
}
