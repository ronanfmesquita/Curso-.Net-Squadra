using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinanceira2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, rendapoupanca, aux1, montante1,montante2;
            int meses;
            double rendafixa,aux2;
            string sair;
            do
            {


                Console.WriteLine(" Calculadora Financeira (Renda Fixa) ");
                Console.Write(" Digite o Valor a ser Aplicado = ");
                valor = double.Parse(Console.ReadLine());
                Console.Write(" Digite o rendimento da Poupança % = ");
                rendapoupanca = double.Parse(Console.ReadLine());
                Console.Write(" Digite o rendimendo da Renda Fixa % = ");
                rendafixa = double.Parse(Console.ReadLine());
                Console.Write(" Digite os meses da aplicação = ");
                meses = int.Parse(Console.ReadLine());

                montante1 = valor;
                montante2 = valor;
                aux1 = rendapoupanca / 100;
                aux2 = rendafixa / 100;


                double Poupanca()
                {

                    for (int i = 0; i < meses; i++)
                    {
                        montante1 *= (1 + aux1);
                    }
                    return montante1;
                }

                double RendaFixa()
                {
                    for (int c = 0; c < meses; c++)
                    {
                        montante2 *= (1 + aux2);
                    }
                    return montante2;
                }



                Console.WriteLine("Retorno do Valor investido na Poupança {0} {1}", meses, "Meses = R$" + Poupanca().ToString("F"));
                Console.WriteLine("Retorno do Valor investido na Renda Fixa {0} {1}", meses, "Meses = R$" + RendaFixa().ToString("F"));

                if (Poupanca() > RendaFixa())
                {
                    Console.WriteLine("O rendimento em Poupança é melhor");
                }
                else
                    Console.WriteLine("Aplicação em Renda Fixa é melhor");
                Console.WriteLine("Deseja Fazer outra operação ?");
                sair = Console.ReadLine();
                Console.Clear();
            } while (sair != "n");
        }
    }
}
           

