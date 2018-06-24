using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teach.Negocio.Models
{
    [Table(name: "Agendas")]
    public class Agenda
    {
        public long Id { get; set; }
        public virtual Aluno Aluno { get; set; }
        public String Endereco { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public TimeSpan TotalHoras { get { return HoraFinal - HoraInicial; } set { } }
        public decimal Valor { get { return Convert.ToDecimal(this.TotalHoras.Hours + (this.TotalHoras.Minutes/60)) * this.Aluno.ValorHoraAula; } set { } }
        public String Observacoes { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Fatura Fatura { get; set; }
        

        public Agenda()
        {
        }
         public TimeSpan HorasCalculo()
        {
            this.TotalHoras = HoraFinal - HoraInicial;
            return TotalHoras;
        }

        [NotMapped]
        public String NomeAluno
        {
            get
            {
                return Aluno.Nome;
            }
        }

        [NotMapped]
        public DateTime DataAgendamento
        {
            get
            {
                return HoraInicial.Date;
            }
        }
    }
}
