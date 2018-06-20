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
    public partial class TelaPrincipal : Form
    {
        private int childFormNumber = 0;
        private Professor ProfessorSelecionado {get;set;}

        public TelaPrincipal()
        {
            InitializeComponent();
        }
        private void ListaAlunos_Load(object sender, EventArgs e)
        {
            CarregaDG();
        }

        private void CarregaDG()
        {
            dgAgendamentos.MultiSelect = false;
            dgAgendamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAgendamentos.AutoGenerateColumns = false;
            List<Agenda> Agendamentos = Program.Gerenciador.TodosAgendamentosDoProfessorLogado();
            dgAgendamentos.DataSource = Agendamentos;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void minhaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProfessor tela = new CadastroProfessor();
            tela.Show();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaGestaoAlunos tela = new TelaGestaoAlunos();
            tela.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Calendario.DateSelected 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarAgendamento tela = new AdicionarAgendamento();
            tela.Show();
            
        }

        private bool VerificaSelecao()
        {
            if(dgAgendamentos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");

                return false;
            }
            return true;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            /*if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Remover Aluno", "Tem certeza que deseja remover este aluno?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Aluno AlunoSelecionado = (Aluno)dgAlunos.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverAluno(AlunoSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Cliente removido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover o cliente");
                    }
                    CarregaAlunos();
                }
                }

                */

            if(VerificaSelecao())
            {
                DialogResult resultado = MessageBox.Show("Remover agendamento", "Tem certeza que deseja remover este agendamento?", MessageBoxButtons.OKCancel);
                if(resultado == DialogResult.OK)
                {
                    Agenda AgendamentoSelecionado = (Agenda)dgAgendamentos.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoveAgendamento(AgendamentoSelecionado);
                    if(validacao.Valido)
                    {
                        MessageBox.Show("Agendamento removido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover o agendamento");
                    }
                    CarregaDG();
                }

            }
        }
    }
}
