using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string sair;


            do
            {
                Console.Write("Digite o primeiro numero ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o Segundo numero ");
                num2 = int.Parse(Console.ReadLine());


                if (num1 > num2)
                {
                    Console.WriteLine("Numero {0} {1} ", num1, " é maior");
                }
                if (num2 > num1)
                {
                    Console.WriteLine("Numero {0} {1}", num2, " é maior");
                }
                if (num2 == num1)
                {
                    Console.WriteLine("Numeros São iguais!");
                }

                Console.Write("Deseja continuar ? ");
                sair = Console.ReadLine();
            } while (sair != "n");
        }
    }
}
