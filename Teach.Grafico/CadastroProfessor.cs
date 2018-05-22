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
    public partial class CadastroProfessor : Form
    {
        public CadastroProfessor()
        {
            InitializeComponent();
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
            tela.Show();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Professor NovoCadastro = new Professor();
            NovoCadastro.Nome = tbNome.Text;
            NovoCadastro.Email = tbEmail.Text;
            NovoCadastro.Telefone = tbTelefone.Text;
            NovoCadastro.Senha = tbSenha.Text;
            String ConfirmacaoSenha = tbConfirmacao.Text;

            /*Ver como adicionar disciplina*/

            Validacao validacao = Program.Gerenciador.CadastroProfessor(NovoCadastro, ConfirmacaoSenha);

            if (validacao.Valido)
            {
                MessageBox.Show("Cadastro realizado com sucesso.");
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
}
