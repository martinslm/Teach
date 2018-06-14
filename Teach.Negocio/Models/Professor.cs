using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teach.Negocio.Models
{
    [Table(name: "Professores")]
    public class Professor : Disciplina
    {
        public long Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public String Telefone { get; set; }
        public virtual ICollection<Disciplina> Disciplina { get; set; }

        public Professor()
        {
            this.Disciplina = new List<Disciplina>();
        }
    }
}
