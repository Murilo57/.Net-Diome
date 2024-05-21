using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            double resultado = Math.Pow(x, y);
            Console.WriteLine($"Potencia {x} {y} = {resultado}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double resultado = Math.Sin(radiano);
            Console.WriteLine($"Potencia {angulo} = {resultado}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz Quadrada de {x} é:  {raiz}");
        }
    }
}