﻿using System;
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
using Teach.Negocio.Persistencia;

namespace Teach.Grafico
{
    public partial class CadastroProfessor : Form
    {
        Professor NovoCadastro = new Professor();
        private Banco banco = new Banco();
        public CadastroProfessor()
        {
            InitializeComponent();
            CarregaDG();
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
            tela.FormClosed += Tela_FormClosed;
            tela.professor = this.NovoCadastro;
            tela.Show();
            
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregaDG();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            
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
                this.Close();
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
            //Teste essa função, para verificar se esta retornando o id cadastrado no banco
            long idProfessor = NovoCadastro.Id;

            /*foreach (Disciplina item in ListaDisciplina)
            {
                item.Idprofessor = idProfessor;
                this.banco.Disciplina.Add(item);
                this.banco.SaveChanges();
            }*/
        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            
        }        

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CarregaDG()
        {
            dgDisciplinas.MultiSelect = false;
            //DgDisciplinas.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgDisciplinas.AutoGenerateColumns = false;
            //List<Disciplina> Disciplinas = Program.Gerenciador.TodasAsDisciplina();
            dgDisciplinas.DataSource = this.NovoCadastro.Disciplina.ToList();
        }
    }
}
