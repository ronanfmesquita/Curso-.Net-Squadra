using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Digite o primeiro numero ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro numero ");
            num3 = int.Parse(Console.ReadLine());

            if ((num1 > num2) & (num1 > num3))
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num1.ToString() + num2 + num3);
                }
                else
                {
                    Console.WriteLine(num1.ToString() + num3 + num2);
                }
                    
            }
            if ((num2 > num1) & (num2 > num3))
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num2.ToString() + num1 + num3);
                }
                else
                {
                    Console.WriteLine(num2.ToString() + num3 + num1);
                }

            }
            if ((num3 > num1) & (num3 > num2))
            {
                if (num2 > num1)
                {
                    Console.WriteLine(num3.ToString() + num2 + num1);
                }
                else
                {
                    Console.WriteLine(num3.ToString() + num1 + num2);
                }

            }
        }
    }
}
