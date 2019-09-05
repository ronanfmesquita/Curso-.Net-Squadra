using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Financeira
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor,rendimento,aux,montante;
            int meses;
            string sair;
            

            do
            {
                Console.WriteLine("Calculadora Financeira (Poupança)");
                Console.Write("Digite o Valor a ser Aplicado = ");
                valor = double.Parse(Console.ReadLine());
                Console.Write("Digite o rendimento mensal % = ");
                rendimento = double.Parse(Console.ReadLine());
                Console.Write("Digite os meses da aplicação = ");
                meses = int.Parse(Console.ReadLine());
                aux = rendimento / 100;
                montante = valor;
                for (int i = 0; i < meses; i++)
                {
                    montante *= (1 + aux);
                }

                Console.WriteLine("Retorno investido em {0} {1}", meses, " = R$" + montante.ToString("F"));
                Console.WriteLine("Deseja Fazer outra operação ?");
                sair = Console.ReadLine();
                Console.Clear();
            } while (sair != "n");

        }
    }
}
