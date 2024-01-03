using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bootcamp_dotNet_e_C_.interfaces;

namespace Bootcamp_dotNet_e_C_.Models
{
    public class Calculadora : ICalculadora
    {
        public void somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void multiplicar(int x, int y){
            Console.WriteLine($"{x} X {y} = {x * y}");
        }
        public void dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void potencia (int x, int y){
            
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y}= {pot}");
        }

        public void seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }
        public void coseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(coseno, 4)}");
        }
        public void tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"tangente de {angulo} = {Math.Round(tangente, 4)}");
        }

        public void raizQ(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} = {raiz}");
        }

        public int soma(int num1, int num2)
        {
            return num1 + num2;
        }

        int ICalculadora.subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        int ICalculadora.multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        int ICalculadora.dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}