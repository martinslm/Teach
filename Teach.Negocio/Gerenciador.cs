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

        public Validacao CadastroProfessor (Professor Usuario)
            {
            Validacao validacao = new Validacao();
            //VERIFICAR DISCIPLINAS.
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
                validacao.Mensagens.Add("Email", "O e-mail não pode ser nulo ou vazio");
            }
           if(String.IsNullOrEmpty(Usuario.Nome))
                {
                validacao.Mensagens.Add("Nome", "O nome não pode ser nulo ou vazio");
                }
           if(String.IsNullOrEmpty(Usuario.Senha))
            {
                validacao.Mensagens.Add("Senha", "Você deve preencher a senha");
            }
           if(String.IsNullOrEmpty(Usuario.ConfirmacaoSenha))
            {
                validacao.Mensagens.Add("Confirmação de Senha", "O preenchimento da confirmação de senha é obrigatória");
            }
           if(Usuario.Senha != Usuario.ConfirmacaoSenha)
            {
                validacao.Mensagens.Add("Senhas", "Os parâmetros senha e ConfirmaçãoSenha são divergentes");
            }

           if(validacao.Valido)
            {
                this.Prof.Add(Usuario);
            }
            return validacao;
        }

        public Validacao cadastroAluno (Aluno AlunoAdicionado)
        {
           
        }
    }
}
