using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Ronan";
            string nome2;
            Console.Write("Digite um nome ");
            nome2 = Console.ReadLine();
            String.Equals(nome, nome2);

            if (nome == nome2)
            {
                Console.WriteLine("Nome Correto");
            }
            else
                Console.WriteLine("Nome incorreto");
        }
    }
}
