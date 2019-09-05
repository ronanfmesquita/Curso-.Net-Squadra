using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinanceira3
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, rendapoupanca, montante1, montante2, aux1, juros, impostorenda;
            int meses;
            double rendafixa, aux2;
            string sair;

            do
            {

                Console.WriteLine("Calculadora financeira (Imposto para Renda fixa) ");
                Console.Write("Digite o Valor a ser Aplicado = ");
                valor = double.Parse(Console.ReadLine());
                Console.Write("Digite o rendimento da Poupança % = ");
                rendapoupanca = double.Parse(Console.ReadLine());
                Console.Write("Digite o rendimendo da Renda Fixa % = ");
                rendafixa = double.Parse(Console.ReadLine());
                Console.Write("Digite os meses da aplicação = ");
                meses = int.Parse(Console.ReadLine());

                montante1 = valor;
                montante2 = valor;
                aux1 = rendapoupanca / 100;
                aux2 = rendafixa / 100;

                //Calculo para Poupança
                for (int i = 0; i < meses; i++)
                {
                    montante1 *= (1 + aux1);
                }

                //Calculo para Renda Fixa
                for (int c = 0; c < meses; c++)
                {
                    montante2 *= (1 + aux2);

                }
                
                if (meses <= 12)
                {
                    juros = montante2 - valor;
                    impostorenda = juros * 0.25;
                    montante2 -= impostorenda;

                }
                if (meses >= 13 && meses <= 24)
                {
                    juros = montante2 - valor;
                    impostorenda = juros * 0.15;
                    montante2 -= impostorenda;
                }
                if (meses >= 25 && meses <= 36)
                {
                    juros = montante2 - valor;
                    impostorenda = juros * 0.05;
                    montante2 -= impostorenda;
                }
                if (meses > 36)
                {
                    juros = montante2 - valor;
                    impostorenda = juros * 0.01;
                    montante2 -= impostorenda;

                }

                Console.WriteLine("Retorno do Valor investido na Poupança {0} {1}", meses, "Meses = R$" + montante1.ToString());
                Console.WriteLine();
                Console.WriteLine("Retorno do Valor investido na Renda Fixa {0} {1}", meses, "Meses = R$" + montante2.ToString());
                Console.WriteLine();


                if (montante1 > montante2)
                {
                    Console.WriteLine("O rendimento em Poupança é melhor");
                }
                if (montante1 < montante2)
                {
                    Console.WriteLine("Rendimento em Renda Fixa é melhor");
                }
                if (montante1 == montante2)
                {
                    Console.WriteLine("O rendimentos iguais para as duas opções !");
                }
                Console.WriteLine();

                Console.WriteLine("Deseja fazer outra operação ?");
                sair = Console.ReadLine();
                Console.Clear();
            } while (sair != "n");
        }
    }
}
