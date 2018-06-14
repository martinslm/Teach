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
    public partial class Cadastro_Aluno : Form
    {
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

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Aluno NovoCadastro = new Aluno();
            NovoCadastro.Nome = tbNome.Text;
            NovoCadastro.Email = tbEmail.Text;
            NovoCadastro.Celular = tbEmail.Text;
            //NovoCadastro.DisciplinaCursada = 
            //NovoCadastro.CargaHoraria = ;
            //NovoCadastro.ValorHoraAula =
            //NovoCadastro.Rua = 
            //NovoCadastro.Numero = 
            //NovoCadastro.Complemento =
            //NovoCadastro.Bairro =
            //NovoCadastro.Cidade = 
            //NovoCadastro.CEP = 
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
