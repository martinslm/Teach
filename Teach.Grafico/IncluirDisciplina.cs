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
    public partial class IncluirDisciplina : Form
    {
        public Professor professor;

        public Disciplina novaDisciplina;
        private Banco banco = new Banco();
        public IncluirDisciplina()
        {
            InitializeComponent();
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
            /*novaDisciplina = new Disciplina();
            novaDisciplina.disciplina = tbDisciplina.Text;
            */
            
            Disciplina novaDisciplina = new Disciplina();
            novaDisciplina.disciplina = tbDisciplina.Text;

            professor.Disciplina.Add(novaDisciplina);

            this.Close();
        }

        private void IncluirDisciplina_Load(object sender, EventArgs e)
        {

        }
    }
}
