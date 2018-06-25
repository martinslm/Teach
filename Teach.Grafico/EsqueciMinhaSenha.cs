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
    public partial class EsqueciMinhaSenha : Form
    {
        public EsqueciMinhaSenha()
        {
            InitializeComponent();
        }

        private void EsqueciMinhaSenha_Load(object sender, EventArgs e)
        {

        }

        private void tbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSalvar_Click(object sender, EventArgs e)
        {
            Professor Professor = new Professor();
            String ValidadorSenha;
            Professor.Email = tbEmail.Text;
            Professor.Senha = tbSenha.Text;
            ValidadorSenha = tbConfirmacaoSenha.Text;
            Validacao validacao = Program.Gerenciador.EsqueciMinhaSenha(Professor, ValidadorSenha);
            if(validacao.Valido)
            {
                MessageBox.Show("Alteração efetuada sucesso!");
                this.Close();
            }
        }
    }
}
