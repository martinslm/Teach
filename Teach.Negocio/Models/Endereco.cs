using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teach.Negocio.Models
{
    class Endereco
    {
        public String Rua { get; set; }
        public String Numero { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set;}
        public String Cidade { get; set; }
        public int CEP { get; set; }
    }
}
