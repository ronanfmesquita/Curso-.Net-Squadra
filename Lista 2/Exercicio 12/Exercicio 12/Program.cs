using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,cont,result=0;
            for (cont = 1; cont < 5; cont++)
            {
                Console.WriteLine("Digite o " + cont + " numero");
                num = int.Parse(Console.ReadLine());
                if (num % 2 ==0)
                {
                    result += num;
                }
            }
            Console.WriteLine("SOMA = " +result.ToString());

        }
    }
}
