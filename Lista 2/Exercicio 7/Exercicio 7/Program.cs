using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double  nota1, nota2, nota3, media;
            Console.Write("Digite a primeira NOTA ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a Segunda NOTA ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a Terceira NOTA ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine();

            if (media >= 6)
            {
                Console.WriteLine("Media {0}{1} ",media," Aprovado");
            }
            else
            {

                Console.WriteLine("Media {0}{1} ", media, " Reprovado");
            }
        }
    }
}
