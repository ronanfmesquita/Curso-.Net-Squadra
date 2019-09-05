using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,aux;
            Console.Write("Digite um numero ");
            num = int.Parse(Console.ReadLine());
            aux = num + 1;
            Console.WriteLine("Numero = {0} {1}"  ,num , aux);
        }
    }
}
