using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_dotNet_e_C_.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos, sou um professor e ganho {Salario}");
        }
    }
}