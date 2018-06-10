using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teach.Negocio.Models;
using Teach.Negocio.Persistencia;

namespace Teach.Negocio
{
    public class Gerenciador
    {
        private Banco banco = new Banco();

        public Gerenciador()
        {
            Console.WriteLine(banco.Database.Connection.ConnectionString);
        }

        /* Tela Inicial */
        public Validacao CadastroProfessor(Professor Usuario, String ValidadorSenha)
        {
            Validacao validacao = new Validacao();
            if (this.banco.Prof.Where(c => c.Email == Usuario.Email).Any())
            {
                validacao.Mensagens.Add("E-mail já cadastrado", "Já existe uma conta com este endereço de e-mail");
            }
            //melhorar validação do E-mail.
            if (!Usuario.Email.Contains("@"))
            {
                validacao.Mensagens.Add("E-mail", "E-mail no formato inválido");
            }
            if (String.IsNullOrEmpty(Usuario.Email))
            {
                validacao.Mensagens.Add("Email", "Você deve preencher o e-mail");
            }
            if (String.IsNullOrEmpty(Usuario.Nome))
            {
                validacao.Mensagens.Add("Nome", "Você deve preencher o nome");
            }
            if (String.IsNullOrEmpty(Usuario.Senha))
            {
                validacao.Mensagens.Add("Senha", "Você deve preencher a senha");
            }
            if (String.IsNullOrEmpty(ValidadorSenha))
            {
                validacao.Mensagens.Add("Confirmação de Senha", "O preenchimento da confirmação de senha é obrigatória");
            }
            if (Usuario.Senha != ValidadorSenha)
            {
                validacao.Mensagens.Add("Senhas", "Os parâmetros de senha e Confirmação de senha são divergentes");
            }

            if(Usuario.Disciplina.Count==0)
            {
                validacao.Mensagens.Add("Disciplina", "Você deve incluir pelo menos uma disciplina");
            }
            /*     foreach(var disc in Usuario.Discplina)
            {
                if (String.IsNullOrEmpty(disc.disciplina))
                {
                    validacao.Mensagens.Add("Disciplina", "Disciplina com nome inválido");
                }
            }
            */

            if (validacao.Valido)
            {
                this.banco.Prof.Add(Usuario);
                this.banco.SaveChanges();
            }
            return validacao;
        }

        public Validacao EfetuaLogin(Professor Professor)
        {
            Validacao validacao = new Validacao();
            var professorDb = this.banco.Prof.Where(p => p.Email == Professor.Email).FirstOrDefault();
            if(professorDb == null)
            {
                validacao.Mensagens.Add("Email", "E-mail não cadastrado");
            }
            else
            {
                if(professorDb.Senha != Professor.Senha)
                {
                    validacao.Mensagens.Add("Senha", "Senha inválida");
                }
            }

            return validacao;
        }

        /* Tela Cadastros*/

        public Validacao CadastroAluno(Aluno AlunoAdicionado)
        {
            Validacao validacao = new Validacao();
            //celular
            if (String.IsNullOrEmpty(AlunoAdicionado.Nome))
            {
                validacao.Mensagens.Add("Nome", "O nome do aluno deve ser preenchido");
            }
            if(!AlunoAdicionado.Email.Contains('@'))
            {
                validacao.Mensagens.Add("Email", "O e-mail informado é inválido.");
            }
            if(this.banco.Alunos.Where(p => p.Email == AlunoAdicionado.Email).Any())
            {
                validacao.Mensagens.Add("Aluno/Email", "Já existe um aluno cadastrado com este e-mail.");
            }
            if(String.IsNullOrEmpty(AlunoAdicionado.DisciplinaCursada.disciplina))
            {
                validacao.Mensagens.Add("Disciplina", "Selecione uma disciplina");
            }
            if(AlunoAdicionado.CargaHoraria <= 0)
            {
                validacao.Mensagens.Add("CH","Você deve preencher uma carga horária máxima de aulas para este aluno");
            }
            if(String.IsNullOrEmpty(AlunoAdicionado.Rua)) 
            {
                validacao.Mensagens.Add("Rua", "O campo rua deve ser preenchido");
            }
            if(String.IsNullOrEmpty(AlunoAdicionado.Numero))
            {
                validacao.Mensagens.Add("Numero", "O campo numero deve ser preenchido");
            }

            if (String.IsNullOrEmpty(AlunoAdicionado.Bairro))
            {
                validacao.Mensagens.Add("Bairro", "O campo bairro deve ser preenchido");
            }

            if (String.IsNullOrEmpty(AlunoAdicionado.Cidade))
            {
                validacao.Mensagens.Add("Cidade", "O campo cidade deve ser preenchido");
            }

            if (String.IsNullOrEmpty(AlunoAdicionado.CEP))
            {
                validacao.Mensagens.Add("CEP", "O campo CEP deve ser preenchido");
            }

            if (AlunoAdicionado.ValorHoraAula <= 0)
            {
                validacao.Mensagens.Add("HoraAula", "Você deve preencher o valor por hora aula");
            }
            


            if(validacao.Valido)
            {
                this.banco.Alunos.Add(AlunoAdicionado);
            }
            return validacao;
        }

        /*Tela Agenda*/

        public Validacao NovoAgendamento (Agenda agendamento)
        {
            Validacao validacao = new Validacao();
            /* if (!(this.banco.Clientes.Where(x => x.Id == PedidoAdicionado.Cliente.Id).Any()))
            {
                validacao.Mensagens.Add("cliente", "Não existe nenhum cliente cadastrado com esse código idenfiticador");
            }*/
            if(!(this.banco.Alunos.Where(x => x.Id == agendamento.Aluno.Id).Any()))
            {
                validacao.Mensagens.Add("aluno", "Aluno Inválido");
            }
            
            //
            //
            //

            return validacao;
        }

        /* Tela Financeiro */

            /*Buscas por ID e Listas */

            public List<Aluno> TodosOsAlunos()
        {
            return this.banco.Alunos.ToList();
        }
        public List<Agenda> TodosOsAgendamentos()
        {
            return this.banco.Agendamentos.ToList();
        }
        public List<Fatura> TodasAsFaturas()
        {
            return this.banco.Faturas.ToList();
        }
        public Aluno BuscaAlunoPorID(long Id)
        {
            return this.banco.Alunos.Where(c => c.Id == Id).FirstOrDefault();
        }
        public Disciplina BuscaDisciplinaPorId(long Id)
        {
            return this.banco.Disciplina.Where(c => c.Id == Id).FirstOrDefault();
        }
        public Agenda BuscaAgendamentoPorId(long Id)
        {
            return this.banco.Agendamentos.Where(c => c.Id == Id).FirstOrDefault();
        }
        public Fatura BuscaFaturaPorId (long Id)
        {
            return this.banco.Faturas.Where(c => c.Id == Id).FirstOrDefault();
        }
    }
}
