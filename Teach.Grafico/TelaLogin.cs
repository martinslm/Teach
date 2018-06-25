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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            EsqueciMinhaSenha tela = new EsqueciMinhaSenha();
            tela.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbSenha.Text == "")
            {
                MessageBox.Show("Você deve preencher a senha");
            }
            if (tbEmail.Text == "")
            {
                MessageBox.Show("O campo e-mail deve ser preenchido");
            }
            else
            {
                Login();
            }
        }

        private void Login()
        {
            Professor LoginProfessor = new Professor();
            LoginProfessor.Email = tbEmail.Text;
            LoginProfessor.Senha = tbSenha.Text;

            Validacao validacao = Program.Gerenciador.EfetuaLogin(LoginProfessor);

            if (validacao.Valido)
            {
                TelaPrincipal tela = new TelaPrincipal();
                tela.Show();

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
        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void NovoCadastro_Click(object sender, EventArgs e)
        {
            CadastroProfessor telaCadastro = new CadastroProfessor();
            telaCadastro.Show();
        }

        private void tbSenha_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Login();
            }
        }
    }
}
