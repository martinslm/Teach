using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teach.Negocio.Models
{
    public class Fatura
    {
        public List<Agenda> Descricao { get; set; }
        public Int64 ValorTotal { get; set; }
        public DateTime DataGeracao { get; set; }
    }
}
