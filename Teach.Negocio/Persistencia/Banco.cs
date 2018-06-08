using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teach.Negocio.Models;

namespace Teach.Negocio.Persistencia
{
    public class Banco : DbContext
    {
        public virtual DbSet<Professor> Prof { get; set; }
        public virtual DbSet<Aluno> Alunos { get; set; }
        public virtual DbSet<Agenda> Agendamentos { get; set; }
        public virtual DbSet<Disciplina> Disciplina { get; set; }
    }
}
