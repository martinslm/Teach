﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teach.Negocio.Models
{
    [Table(name: "Faturas")]
    public class Fatura
    {
        public long Id { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataGeracao { get; set; }
        public DateTime DataBaixa { get; set; }
       // public virtual ICollection<Agenda> Agendamentos { get; set; }
        public String Situacao { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Aluno Aluno { get; set; }

        [NotMapped]
        public String NomeAluno
        {
        get{
                return Aluno.Nome;
            }
        }
    }
}
