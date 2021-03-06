﻿using System;
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
        public long ProfessorLogado;
        private Banco banco = new Banco();

        public Gerenciador()
        {
            Console.WriteLine(banco.Database.Connection.ConnectionString);
        }

        /* Tela Inicial */
        public Validacao CadastroProfessor(Professor Usuario, String ValidadorSenha)
        {
            Validacao validacao = new Validacao();
            //melhorar validação do E-mail.
            if (String.IsNullOrEmpty(Usuario.Email))
            {
                validacao.Mensagens.Add("Email", "Você deve preencher o e-mail");
            }
            if (!Usuario.Email.Contains("@"))
            {
                validacao.Mensagens.Add("E-mail", "E-mail no formato inválido");
            }
            if (this.banco.Prof.Where(c => c.Email == Usuario.Email).Any())
            {
                validacao.Mensagens.Add("E-mail já cadastrado", "Já existe uma conta com este endereço de e-mail");
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

            if (Usuario.Disciplina.Count == 0)
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
            if (professorDb == null)
            {
                validacao.Mensagens.Add("Email", "O e-mail informado está incorreto ou não possui cadastro.");
            }
            else
            {
                ProfessorLogado = professorDb.Id;
                if (professorDb.Senha != Professor.Senha)
                {
                    validacao.Mensagens.Add("Senha", "Senha inválida");
                }
            }

            return validacao;
        }
        public Validacao EsqueciMinhaSenha(Professor Professor, String ValidadorSenha)
        {
            Validacao validacao = new Validacao();
            var professorDb = this.banco.Prof.Where(p => p.Email == Professor.Email).FirstOrDefault();
            if (professorDb == null)
            {
                validacao.Mensagens.Add("Email", "E-mail não encontrado");
            }
            else
            {
                if (Professor.Senha != ValidadorSenha)
                {
                    validacao.Mensagens.Add("Senhas", "Senhas não conferem. Gentileza verificar.");
                }
                else
                {
                    professorDb.Senha = Professor.Senha;
                    this.banco.SaveChanges();
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
            if (!AlunoAdicionado.Email.Contains('@'))
            {
                validacao.Mensagens.Add("Email", "O e-mail informado é inválido.");
            }
            //veja se vai funcionar quando o campo for nulo
            if (AlunoAdicionado.CargaHoraria <= 0 || AlunoAdicionado.CargaHoraria > 300)
            {
                validacao.Mensagens.Add("CH", "Carga Horária: É necessário preencher esse campo com um valor maior que 0 e menor que 300");
            }
            if (AlunoAdicionado.ValorHoraAula < 10 || AlunoAdicionado.CargaHoraria > 999)
            {
                validacao.Mensagens.Add("VHA", "Valor Hora Aula: É necessário informar um valor entre 10 e 999");
            }
            if (this.banco.Alunos.Where(p => p.Email == AlunoAdicionado.Email).Any())
            {
                validacao.Mensagens.Add("Aluno/Email", "Já existe um aluno cadastrado com este e-mail.");
            }
            if (String.IsNullOrEmpty(AlunoAdicionado.DisciplinaCursada.disciplina))
            {
                validacao.Mensagens.Add("Disciplina", "Selecione uma disciplina");
            }
            if (String.IsNullOrEmpty(AlunoAdicionado.Rua))
            {
                validacao.Mensagens.Add("Rua", "O campo rua deve ser preenchido");
            }
            if (String.IsNullOrEmpty(AlunoAdicionado.Numero))
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



            if (validacao.Valido)
            {
                this.banco.Alunos.Add(AlunoAdicionado);
                this.banco.SaveChanges();
            }
            return validacao;
        }
        public Validacao EditarAluno(Aluno Aluno)
        {
            Validacao validacao = new Validacao();
            Aluno AlunoBanco = BuscaAlunoPorID(Aluno.Id);
            AlunoBanco.Nome = Aluno.Nome;
            AlunoBanco.Email = Aluno.Email;
            AlunoBanco.Celular = Aluno.Celular;
            AlunoBanco.DisciplinaCursada = Aluno.DisciplinaCursada;
            AlunoBanco.CargaHoraria = Aluno.CargaHoraria;
            AlunoBanco.ValorHoraAula = Aluno.ValorHoraAula;
            AlunoBanco.Rua = Aluno.Rua;
            AlunoBanco.Numero = Aluno.Numero;
            AlunoBanco.Complemento = Aluno.Complemento;
            AlunoBanco.Bairro = Aluno.Bairro;
            AlunoBanco.Cidade = Aluno.Cidade;
            AlunoBanco.CEP = Aluno.CEP;
            this.banco.SaveChanges();
            return validacao;
        }
        public Validacao RemoverAluno(Aluno AlunoRemover)
        {
            Validacao validacao = new Validacao();
            //if (Program.Gerenciador.TodosOsAlunosDoProfessorLogado().Any(t => t.DisciplinaCursada.Id == DisciplinaSelecionada.Id))
            if (TodosAgendamentosDoProfessorLogado().Any(t => t.Aluno.Id == AlunoRemover.Id))
            {
                validacao.Mensagens.Add("Aluno", "Não é possível remover o aluno selecionado, pois já existem registros de agendamentos com o mesmo");
            }
            if (validacao.Valido)
            {
                banco.Alunos.Remove(AlunoRemover);
                banco.SaveChanges();
            }
            return validacao;
        }
        public Validacao MinhaConta(Professor Usuario, String ValidadorSenha)
        {
            Validacao validacao = new Validacao();
            Professor ProfessorBanco = BuscaProfessorPorID(ProfessorLogado);
            ProfessorBanco.Nome = Usuario.Nome;
            ProfessorBanco.Email = Usuario.Email;
            ProfessorBanco.Senha = Usuario.Senha;
            ProfessorBanco.Telefone = Usuario.Telefone;
            ProfessorBanco.Disciplina = Usuario.Disciplina;
            this.banco.SaveChanges();
            return validacao;
        }

        /*Tela Agenda*/

        public Validacao NovoAgendamento(Agenda agendamento)
        {
            Validacao validacao = new Validacao();
            if (!(this.banco.Alunos.Where(x => x.Id == agendamento.Aluno.Id).Any()))
            {
                validacao.Mensagens.Add("aluno", "Aluno Inválido");
            }
            if (String.IsNullOrEmpty(agendamento.Endereco))
            {
                validacao.Mensagens.Add("end", "Por favor, inclua um endereço para esta aula");
            }
            if (agendamento.HoraFinal <= agendamento.HoraInicial)
            {
                validacao.Mensagens.Add("Horario", "O horário inicial da aula é maior que o horário final da aula.");
            }

            //É valido realizarmos uma validação para o professor não conseguir cadastrar nada dentro do periodo 
            //de um agendamento já existente? Visando que um professor pode marcar uma aula com dois alunos diferentes no mesmo horário.
            var AgendamentoInicialDb = this.banco.Agendamentos.Where(v => v.HoraInicial <= agendamento.HoraInicial &&
                                                                          agendamento.HoraInicial < v.HoraFinal &&
                                                                          v.Professor.Id == agendamento.Professor.Id).FirstOrDefault();
            if (AgendamentoInicialDb != null)
            {
                validacao.Mensagens.Add("AgendamentoHoraInicial", $" A hora inicial informada {agendamento.HoraInicial} já possui o agendamento das {AgendamentoInicialDb.HoraInicial} até {AgendamentoInicialDb.HoraFinal}");
            }

            var AgendamentoFinalDb = this.banco.Agendamentos.Where(v => v.HoraInicial < agendamento.HoraFinal &&
                                                                        agendamento.HoraFinal < v.HoraFinal &&
                                                                        v.Professor.Id == agendamento.Professor.Id).FirstOrDefault();
            if (AgendamentoFinalDb != null)
            {
                validacao.Mensagens.Add("AgendamentoHoraFinal", $"A hora final informada {agendamento.HoraFinal} já possui o agendamento das {AgendamentoFinalDb.HoraInicial} até {AgendamentoFinalDb.HoraFinal}");
            }

            if (validacao.Valido)
            {
                this.banco.Agendamentos.Add(agendamento);
                this.banco.SaveChanges();
            }
            return validacao;

        }
        public Validacao EditarAgendamento(Agenda novasInformacoes)
        {
            Validacao validacao = new Validacao();
            Agenda AgendaBanco = BuscaAgendamentoPorId(novasInformacoes.Id);
            AgendaBanco.Aluno = BuscaAlunoPorID(novasInformacoes.Aluno.Id);
            AgendaBanco.Endereco = novasInformacoes.Endereco;
            AgendaBanco.HoraInicial = novasInformacoes.HoraInicial;
            AgendaBanco.HoraFinal = novasInformacoes.HoraFinal;
            AgendaBanco.Observacoes = novasInformacoes.Observacoes;
            this.banco.SaveChanges();
            return validacao;
        }
        public Validacao RemoveAgendamento(Agenda AgendamentoAremover)
        {
            Validacao validacao = new Validacao();
            Agenda AgendaBanco = BuscaAgendamentoPorId(AgendamentoAremover.Id);
            if (AgendaBanco.Fatura != null)
                validacao.Mensagens.Add("validacao", "Não é possível remover o agendamento, pois já existe uma fatura referente ao mesmo");
            else
            {
                banco.Agendamentos.Remove(AgendamentoAremover);
                banco.SaveChanges();
            }
            return validacao;

        }
        public Validacao RemoveDisciplina(Disciplina DisciplinaRemover)
        {
            Validacao validacao = new Validacao();

            if (TodosOsAlunosDoProfessorLogado().Any(t => t.DisciplinaCursada.Id == DisciplinaRemover.Id))
            {
                validacao.Mensagens.Add("validacao", "Você possui alunos cursando esta disciplina, portanto, não é possível removê-la");
            }
            else
            {
                banco.Disciplina.Remove(DisciplinaRemover);
                banco.SaveChanges();
            }
            return validacao;
        }
        public List<Agenda> CarregaAgendamentosDia(DateTime data)
        {
            Validacao validacao = new Validacao();
            List<Agenda> Agendamentos = new List<Agenda>();
            if (this.banco.Agendamentos.Count() > 0)
            {
                using (var banco = new Banco())
                {
                    Agendamentos = banco.Agendamentos.Include("Aluno").Where(o => o.Professor.Id == ProfessorLogado &&
                                                                                  o.HoraInicial.Day == data.Day &&
                                                                                  o.HoraInicial.Month == data.Month &&
                                                                                  o.HoraInicial.Year == data.Year).ToList();
                }
                //foreach (Agenda agendamento in banco.Agendamentos)
                //{
                //    if (agendamento.HoraInicial.Date == data.Date)
                //    {
                //        if (agendamento.Aluno.Professor.Id == ProfessorLogado)
                //        {
                //            Agendamentos.Add(agendamento);
                //        }
                //    }
                //}
                return Agendamentos;
               
            }
            
            if (Agendamentos == null)
                validacao.Mensagens.Add("Agendamento", string.Format("Não foi possível localizar nenhum agendamento com a data informada ({0})", data.Date));

            return Agendamentos;
        }
        /* Tela Financeiro */
        public List<Agenda> Registros(Fatura FaturaVisualizada)
        {
            Validacao validacao = new Validacao();
            List<Agenda> Registros = new List<Agenda>();
            foreach (var agn in this.banco.Agendamentos)
            {
                if (agn.Fatura != null && agn.Fatura.Id == FaturaVisualizada.Id)
                    Registros.Add(agn);
            }

            return Registros.ToList();
        }
        public List<Agenda> CarregaAgendamentosDeAlunos(Aluno AlunoSelecionado)
        {
            Validacao validacao = new Validacao();
            List<Agenda> Agendamentos = new List<Agenda>();
            foreach (var agn in this.banco.Agendamentos)
            {
                if (agn.Aluno.Nome == AlunoSelecionado.Nome)
                {
                    if (agn.Fatura == null)
                    {
                        Agendamentos.Add(agn);
                    }
                }
            }

            if (Agendamentos == null)
            {
                validacao.Mensagens.Add("Agendamento", "Não foi possível localizar nenhum agendamento com os parâmetros informados");

            }
            return Agendamentos.ToList();
        }
        public Validacao AtribuiIdFaturaGeradaAoAgendamento(Agenda Agendamento, Fatura Fatura)
        {
            Validacao validacao = new Validacao();
            Agenda AgendamentoBanco = BuscaAgendamentoPorId(Agendamento.Id);
            AgendamentoBanco.Fatura = Fatura;
            AgendamentoBanco.Aluno = AgendamentoBanco.Aluno;
            Agendamento.Endereco = Agendamento.Endereco;
            AgendamentoBanco.HoraFinal = AgendamentoBanco.HoraFinal;
            AgendamentoBanco.HoraInicial = AgendamentoBanco.HoraInicial;
            AgendamentoBanco.TotalHoras = AgendamentoBanco.TotalHoras;
            AgendamentoBanco.Valor = AgendamentoBanco.Valor;
            AgendamentoBanco.Observacoes = AgendamentoBanco.Observacoes;
            AgendamentoBanco.Professor = AgendamentoBanco.Professor;
            AgendamentoBanco.Id = AgendamentoBanco.Id;
            this.banco.SaveChanges();
            return validacao;
        }
        public List<Fatura> BuscaReciboPorNome(String Nome)
        {
            Validacao validacao = new Validacao();
            List<Fatura> Faturas = new List<Fatura>();
            if (Nome == "")
            {
                Faturas = TodasAsFaturasDoProfessorLogado();
            }
            else
            {
                foreach (var ftr in this.banco.Faturas)
                {
                    if (ftr.Aluno.Nome.ToUpper().Contains(Nome.ToUpper()))
                    {
                        if (ftr.Situacao == "Fechado")
                        {
                            Faturas.Add(ftr);
                        }
                    }
                }

                if (Faturas == null)
                {
                    validacao.Mensagens.Add("FaturasBusca", "Não foi possível localizar nenhuma fatura com os critérios encontrados.");
                }
            }
            return Faturas.ToList();
        }

        public List<Fatura> BuscaFaturaPorNome(String Nome)
        {
            Validacao validacao = new Validacao();
            List<Fatura> Faturas = new List<Fatura>();
            if (Nome == "")
            {
                Faturas = TodasAsFaturasDoProfessorLogado();
            }
            else
            {
                foreach (var ftr in this.banco.Faturas)
                {
                    if (ftr.Aluno.Nome.ToUpper().Contains(Nome.ToUpper()))
                    {
                        if (ftr.Situacao == "Aberto")
                        {
                            Faturas.Add(ftr);
                        }
                    }
                }

                if (Faturas == null)
                {
                    validacao.Mensagens.Add("FaturasBusca", "Não foi possível localizar nenhuma fatura com os critérios encontrados.");
                }
            }
            return Faturas.ToList();
        }

        public Validacao ContasAReceber()
        {
            Validacao validacao = new Validacao();
            return validacao;
        }
        public Validacao Recibos()
        {
            Validacao validacao = new Validacao();
            return validacao;
        }
        /*Buscas por ID e Listas */

        public Aluno BuscaAlunoPorID(long Id)
        {
            return this.banco.Alunos.Where(c => c.Id == Id).FirstOrDefault();
        }
        public Professor BuscaProfessorPorID(long Id)
        {
            return this.banco.Prof.Where(c => c.Id == Id).FirstOrDefault();
        }
        public Disciplina BuscaDisciplinaPorId(long Id)
        {
            return this.banco.Disciplina.Where(c => c.Id == Id).FirstOrDefault();
        }
        public Agenda BuscaAgendamentoPorId(long Id)
        {
            return this.banco.Agendamentos.Where(c => c.Id == Id).FirstOrDefault();
        }

        public Fatura BuscaFaturaPorId(long Id)
        {
            return this.banco.Faturas.Where(c => c.Id == Id).FirstOrDefault();
        }
        public Professor BuscaProfessorPorId(long Id)
        {
            return this.banco.Prof.Where(c => c.Id == Id).FirstOrDefault();
        }
        public List<Aluno> PesquisaAlunosPorNome(String AlunoPesquisado)
        {
            Validacao validacao = new Validacao();
            List<Aluno> ResultadoBusca2 = new List<Aluno>();

            using (var banco = new Banco())
            {
                ResultadoBusca2 = banco.Alunos.Where(o => o.Professor.Id == ProfessorLogado &&
                                                          (string.IsNullOrEmpty(AlunoPesquisado) || o.Nome.ToUpper().Contains(AlunoPesquisado.ToUpper()))).ToList();
            }
            //foreach (var alunos in this.banco.Alunos)
            //{

            //    if (alunos.Professor.Id == ProfessorLogado)
            //    {

            //        if (alunos.Nome.ToUpper().Contains(AlunoPesquisado.ToUpper()))
            //        {
            //            ResultadoBusca2.Add(alunos);
            //        }

            //    }
            //}
            
            if (!ResultadoBusca2.Any())
            {
                validacao.Mensagens.Add("Aluno", "Não foi possível localizar nenhum aluno com o nome informado");
            }

            return ResultadoBusca2;
        }

        public List<Disciplina> TodasAsDisciplinaDoProfessorLogado()
        {
            List<Disciplina> ResultadoBusca = new List<Disciplina>();
            foreach (var disc in this.banco.Disciplina)
            {

                if (disc.Professor != null && disc.Professor.Id == ProfessorLogado)
                {
                    ResultadoBusca.Add(disc);
                }
            }
            return ResultadoBusca.ToList();
        }
        /// <summary>
        /// / DIAGRAMA DE CLASSES. CONTINUAR A PARTIR DAQUI!
        /// Depois que terminar o gerenciador, fazer dos models ( e validacao, pois é um tipo de retorno e classe). 
        /// </summary>
        /// <returns></returns>
        public List<Aluno> TodosOsAlunosDoProfessorLogado()
        {
            List<Aluno> ResultadoBusca = new List<Aluno>();
            using (var banco = new Banco())
            {
                ResultadoBusca = banco.Alunos.Include("DisciplinaCursada").Where(o => o.Professor.Id == ProfessorLogado).ToList();
            }
            //foreach (var alunos in this.banco.Alunos)
            //{
            //    if (alunos.Professor.Id == ProfessorLogado)
            //    {
            //        ResultadoBusca.Add(alunos);
            //    }
            //}
            return ResultadoBusca;
        }

        public List<Agenda> TodosAgendamentosDoProfessorLogado()
        {
            List<Agenda> ResultadoBusca = new List<Agenda>();
            foreach (var agn in this.banco.Agendamentos)
            {
                if (agn.Professor.Id == ProfessorLogado)
                {
                    ResultadoBusca.Add(agn);
                }
            }

            return ResultadoBusca.ToList();
        }
        public List<Fatura> TodosOsRecibosDoProfessorLogado()
        {
            List<Fatura> ResultadoBusca = new List<Fatura>();
            using (var banco = new Banco())
            {
                ResultadoBusca = banco.Faturas.Include("Aluno")
                                              .Where(o => o.Professor.Id == ProfessorLogado &&
                                                          o.Situacao == "Fechado").ToList();
                //foreach (var fat in this.banco.Faturas)
                //{
                //    if (fat.Professor.Id == ProfessorLogado)
                //    {
                //        if (fat.Situacao == "Fechado")
                //        {
                //            ResultadoBusca.Add(fat);
                //        }
                //    }
                //}
            }

            return ResultadoBusca;


            return ResultadoBusca.ToList();
        }
        public List<Fatura> TodasAsFaturasDoProfessorLogado()
        {
            List<Fatura> ResultadoBusca = new List<Fatura>();
            using (var banco = new Banco())
            {
                ResultadoBusca = banco.Faturas.Include("Aluno")
                                              .Where(o => o.Professor.Id == ProfessorLogado &&
                                                          o.Situacao == "Aberto").ToList();
                //foreach (var fat in this.banco.Faturas)
                //{
                //    if (fat.Professor.Id == ProfessorLogado)
                //    {
                //        if (fat.Situacao == "Aberto")
                //        {
                //            ResultadoBusca.Add(fat);
                //        }
                //    }
                //}
            }

            return ResultadoBusca;
        }

        public Professor ProfessorLog()
        {

            return BuscaProfessorPorID(ProfessorLogado);
        }
    }
}
