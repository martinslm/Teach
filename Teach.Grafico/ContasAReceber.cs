﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teach.Negocio.Models;
using Teach.Negocio.Persistencia;

namespace Teach.Grafico
{
    public partial class ContasAReceber : Form
    {
        public ContasAReceber()
        {
            InitializeComponent();
        }

        private void tbPesquisar_Click(object sender, EventArgs e)
        {
            dgContasReceber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgContasReceber.MultiSelect = false;
            dgContasReceber.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgContasReceber.AutoGenerateColumns = false;
            List<Fatura> Faturas = Program.Gerenciador.BuscaFaturaPorNome(tbPesquisa.Text);
            dgContasReceber.DataSource = Faturas;
        }

        private void CarregaFaturas()
        {
            dgContasReceber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgContasReceber.MultiSelect = false;
            dgContasReceber.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgContasReceber.AutoGenerateColumns = false;
            List<Fatura> Faturas = Program.Gerenciador.TodasAsFaturasDoProfessorLogado();
            dgContasReceber.DataSource = Faturas;
            dgContasReceber.Refresh();
        }

        private void ContasAReceber_Load(object sender, EventArgs e)
        {
            CarregaFaturas();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBaixa_Click(object sender, EventArgs e)
        {

            //BAIXA DE FATURA
            if(VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja receber esta fatura?", "Baixa de Fatura", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Banco banco = new Banco();
                    Fatura FaturaSelecionada = (Fatura)dgContasReceber.SelectedRows[0].DataBoundItem;
                    var FaturaDb = banco.Faturas.Where(p => p.Id == FaturaSelecionada.Id).FirstOrDefault();
                    FaturaDb.Situacao = "Fechado";
                    FaturaDb.DataBaixa = DateTime.Now;
                    var salvo = banco.SaveChanges();
                    

                }
                MessageBox.Show("Fatura baixada com sucesso");
                //this.Close();
                CarregaFaturas();
            }
        }

        private bool VerificarSelecao()
        {
            if (dgContasReceber.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void dgContasReceber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
