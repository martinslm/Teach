using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teach.Negocio.Models
{
    [Table(name: "Alunos")]
    public class Aluno
    {
        //Neste cadastro deve constar o nome do aluno, e-mail, celular, disciplina, carga horária máxima por semestre, endereço, contrato (opcional), situação financeira e valor por hora aula.   
        public long Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Celular { get; set; }
        public Disciplina DisciplinaCursada { get; set; }
        public Int32 CargaHoraria { get; set; }
        public decimal ValorHoraAula { get; set; }
        public String Rua { get; set; }
        public String Numero { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String CEP { get; set; }

        //verificar contrato

        public String SituacaoFinanceira()
        {
            //validacoes
            return String.Format("");
        }
    }
}
