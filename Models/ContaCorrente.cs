using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_dotNet_e_C_.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor)
        {   
            if(saldo >= valor)
            {
            saldo -= valor;
            }
            else
            {
                Console.WriteLine("Valor maior que saldo");
            }
        } 

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponivel é:" + saldo);
        }
          
    }
}