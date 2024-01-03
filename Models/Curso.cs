using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_dotNet_e_C_.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa Aluno){
            Alunos.Add(Aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados(){
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno){
           return Alunos.Remove(aluno);
        }

        public void ListarAlunos(){

            Console.WriteLine($"Alunos do curso de {Nome}");

            for (int count=0; count < Alunos.Count; count++){

                // string texto = "N - " + numero + " - " + Alunos[count].NomeCompleto;
                // string texto = $"N {count+1} - {Alunos[count].NomeCompleto}";
                // Console.WriteLine(texto);
            }
            
        }
    }
}