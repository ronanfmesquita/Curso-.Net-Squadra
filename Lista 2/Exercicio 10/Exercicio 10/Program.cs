using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.Write("Digite o primeiro numero ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero ");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " è maior");
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num2 + " è maior");
            }
            else 
                Console.WriteLine(num1 + " = " +num2);

        }
    }
}
