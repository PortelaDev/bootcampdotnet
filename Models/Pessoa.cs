using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_dotNet_e_C_.Models
{
    public class Pessoa{


        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;
        public string Nome 
        { 
            get => _nome.ToUpper();
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome nao pode ser vazio;");
                }

                _nome = value;
            } 
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade {
            get => _idade;

            set {
                if (value < 0){
                    throw new ArgumentException("A idade nao pode ser menor que 0");
                }

                _idade = value;
            } 
        }
        // public string NomeRepresentanteLegalDaPessoaFisica { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome é {NomeCompleto} e tenho {Idade} anos");
        }

    }
}