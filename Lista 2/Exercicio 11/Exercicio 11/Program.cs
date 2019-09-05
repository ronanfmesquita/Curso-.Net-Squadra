using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,resultado;
            Console.Write("Digite o primeiro numero ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero ");
            num2 = int.Parse(Console.ReadLine());

            if (num2 != 0)
            {
                resultado = num1 % num2;
                Console.WriteLine("Qociente = {0}", resultado);
            }
            else
                Console.WriteLine("Divisão por 0");
        }
    }
}
