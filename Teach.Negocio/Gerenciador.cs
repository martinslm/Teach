using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teach.Negocio.Models;

namespace Teach.Negocio
{
    public class Gerenciador
    {
        public List<Professor> Prof;
        public List<Aluno> Alunos;
        public List<Agenda> Agendamentos;


        public Gerenciador()
        {
            this.Prof = new List<Professor>();
            this.Alunos = new List<Aluno>();
            this.Agendamentos = new List<Agenda>();
        }

        public Validacao CadastroProfessor(Professor Usuario)
        {
            Validacao validacao = new Validacao();
            if (this.Prof.Where(c => c.Email == Usuario.Email).Any())
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
            if (String.IsNullOrEmpty(Usuario.ConfirmacaoSenha))
            {
                validacao.Mensagens.Add("Confirmação de Senha", "O preenchimento da confirmação de senha é obrigatória");
            }
            if (Usuario.Senha != Usuario.ConfirmacaoSenha)
            {
                validacao.Mensagens.Add("Senhas", "Os parâmetros de senha e Confirmação de senha são divergentes");
            }

            if(Usuario.Discplina.Count == 0)
            {
                validacao.Mensagens.Add("Disciplina", "Você deve incluir pelo menos uma disciplina");
            }
            foreach(var disc in Usuario.Discplina)
            {
                if (String.IsNullOrEmpty(disc.disciplina))
                {
                    validacao.Mensagens.Add("Disciplina", "Disciplina com nome inválido");
                }
            }

            if (validacao.Valido)
            {
                this.Prof.Add(Usuario);
            }
            return validacao;
        }

        public Validacao EfetuaLogin(String email, String senha)
        {
            Validacao validacao = new Validacao();
            /*
             * 
             * CODIGO FEITO PELO PROFESSOR 
             * var professorDb = this.banco.Professores.Where(p => p.Email == email).FirstOrDefault();
            if(professorDb == null)
            {
                validacao.Mensagens.Add("Email", "Não existe ninguém com esse email");
            }
            else
            {
                if(professorDb.Senha != senha)
                {
                    validacao.Mensagens.Add("Senha", "Senha inválida");
                }
            }



            FOR ME :D
            if (!this.Prof.Where(d =>d.Email == email.Email).Any())
            {
                validacao.Mensagens.Add("Email não cadastrado", "Não existe nenhuma conta cadastrada para este e-mail, crie uma nova conta para ter acesso ao sistema.");
            }
            else
            {
                if(senha.Senha != this.Prof)
            } */

            return validacao;
        }

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
            if(this.Alunos.Where(p => p.Email == AlunoAdicionado.Email).Any())
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
                this.Alunos.Add(AlunoAdicionado);
            }
            return validacao;
        }

        public Validacao NovoAgendamento (Aluno aluno)
        {
            Validacao validacao = new Validacao();
            //
            //
            //

            return validacao;
        }
    }
}
