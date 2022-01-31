using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Double valor1, valor2, soma, sub, mult, div;

            Console.Write("Digite o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            soma = valor1 + valor2;
            sub = valor1 - valor2;
            mult = valor1 * valor2;
            div = valor1 / valor2;

            Console.WriteLine("Resultado da soma: " + valor1 + " + " + valor2 + " = " + soma + "\n"
                + "Resultado da subtração: " + valor1 + " - " + valor2 + " = " + sub + "\n"
                + "Resultado da multiplicação: " + valor1 + " * " + valor2 + " = " + mult + "\n"
                + "Resultado da divisão: " + valor1 + " / " + valor2 + " = " + div);

            Console.ReadLine();

        }
    }
}
