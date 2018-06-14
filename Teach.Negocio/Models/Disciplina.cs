using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teach.Negocio.Models
{
    public class Disciplina
    {
        public long Id { get; set; }

        public long Idprofessor { get; set; }

        public String disciplina { get; set; }
    }
}
