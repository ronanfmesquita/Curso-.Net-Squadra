using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string sair;


            do
            {


                Console.Write("Digite o primeiro numero ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo numero ");
                num2 = int.Parse(Console.ReadLine());
                Console.Write("Digite o terceiro numero ");
                num3 = int.Parse(Console.ReadLine());

                if ((num1 > num2) && (num1 > num3))
                {
                    Console.WriteLine(num1.ToString() + "-" + num2 + "-" + num3);
                    Console.WriteLine("Numero " + num1 + " é maior");
                }
                if ((num2 > num1) && (num2 > num3))
                {
                    Console.WriteLine(num1.ToString() + "-" + num2 + "-" + num3);
                    Console.WriteLine("Numero " + num2 + " é maior");

                }
                if ((num3 > num1) && (num3 > num2))
                {
                    Console.WriteLine(num1.ToString() + "-" + num2 + "-" + num3);
                    Console.WriteLine("Numero " + num3 + " é maior");
                }
                if ((num1 == num2) && (num1 > num3))
                {
                    Console.WriteLine(num1.ToString() + "-" + num2 + "-" + num3);
                    Console.WriteLine("Numero " + num1 + " é maior");
                }
                if ((num2 == num3) && (num2 > num1))
                {
                    Console.WriteLine(num1.ToString() + "-" + num2 + "-" + num3);
                    Console.WriteLine("Numero " + num2 + " é maior");

                }
                if ((num1 == num2) && (num1 == num3))
                {
                    Console.WriteLine(num1.ToString() + "-" + num2 + "-" + num3);
                    Console.WriteLine("Os numeros são iguais");

                }

                Console.Write("Deseja Continuar ");
                sair = Console.ReadLine();

            } while (sair != "n");

        }
    }
}