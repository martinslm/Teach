using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teach.Negocio.Models
{
    class Agenda
    {
        public Aluno aluno { get; set; }
        public Aluno endereco { get; set;  } //?????????? it's ok?
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public String observacoes { get; set; }

    }
}
