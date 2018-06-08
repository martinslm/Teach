using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teach.Negocio.Models
{
    [Table (name: "Agendas")]
    public class Agenda
    {
        public virtual List<Aluno> Aluno { get; set; }
        public String Endereco { get; set; } 
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public TimeSpan TotalHoras { get; set; }
        public String Observacoes { get; set; }

        public Agenda()
        {
            //Fazer essa parte
        }
        //public TimeSpan TotalHorasCalculo()
        //{
            //validacoes
          //  TimeSpan acalcular=0;
            //return acalcular;
        //}

    }
}
