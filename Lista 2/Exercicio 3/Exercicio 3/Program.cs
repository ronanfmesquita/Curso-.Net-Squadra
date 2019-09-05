using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double resltado;
            Console.Write("Digite o primeiro numero ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo numero ");
            num2 = int.Parse(Console.ReadLine());

            resltado = num1 / num2;
            Console.WriteLine("Divisão entre {0} {1} {2} {3} {4} " ,num1, " e " ,num2, " = " , resltado);
        }
    }
}
