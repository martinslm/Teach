using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teach.Negocio.Models
{
    public class Professor
    {
        public String ID { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public String Telefone { get; set; }
        public List<Disciplina> Discplina { get; set; }

        public Professor()
        {
            this.Discplina = new List<Disciplina>();
        }
    }
}
