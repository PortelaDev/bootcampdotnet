using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_dotNet_e_C_.interfaces
{
    public interface ICalculadora
    {
        int soma(int num1, int num2);
        int subtrair(int num1, int num2);
        int multiplicar(int num1, int num2);
        int dividir(int num1, int num2);
    }
}