using System;
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
        public virtual List<Agenda> Descricao { get; set; }
        public Int64 ValorTotal { get; set; }
        public DateTime DataGeracao { get; set; }
        public String Situacao { get; set; }
    }
}
