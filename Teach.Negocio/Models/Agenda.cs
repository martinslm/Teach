using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teach.Negocio.Models
{
    public class Agenda
    {
        public Aluno Aluno { get; set; }
        public Aluno Endereco { get; set; } //?????????? it's ok?
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public String Observacoes { get; set; }

    }
}
