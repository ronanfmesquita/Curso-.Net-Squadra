using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2,soma,divisao = 0,mult;
            string sair;
            do
            {
                Console.Clear();
                Console.Write("Digite o primeiro numero ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o Segundo numero ");
                num2 = double.Parse(Console.ReadLine());





                 soma = num1 + num2;

                 mult = num1 * num2;
                if ( num2 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Não pode ser dividido por zero");
                    Console.WriteLine();
                }
                else
                {
                    divisao = num1 / num2;
                }


                Console.WriteLine();
                 Console.WriteLine("        RESPOSTAS       ");
                 Console.WriteLine("________________________");
                 Console.WriteLine("A soma = {0}" ,soma);
                 Console.WriteLine("A divisão = {0}" ,divisao);
                 Console.WriteLine("A multiplicação = {0}" ,mult);
                Console.WriteLine("Deseja Continuar ?");
                sair = Console.ReadLine();

            } while (sair != "n");
        }
    }
}
