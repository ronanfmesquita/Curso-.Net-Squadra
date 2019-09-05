using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, aux,soma;
            Console.Write("Digite o primeira numero ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo numero ");
            num2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o Terceiro numero ");
            num3 = double.Parse(Console.ReadLine());
            soma = num2 + num3;
            Console.WriteLine();
            if (num1 > soma)
            {
                Console.WriteLine(num1+ " é maior que " + soma);
            }
            else
                Console.WriteLine(soma + " é maior que " + num1);
        }
    }
}
