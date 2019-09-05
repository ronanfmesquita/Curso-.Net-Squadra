using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 365,aux,fuma,quantidade;
            double preco,resultado;
            Console.Write("Numero de Anos que Fuma ");
            fuma = int.Parse(Console.ReadLine());
            Console.Write("Numero de Cigarros por dia ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Preço do Cigarro ");
            preco = double.Parse(Console.ReadLine());
            aux = quantidade * fuma;
            resultado = aux * preco * ano;

            //Console.WriteLine("Anos Fumando = {0}" , aux , "Dias");
            Console.WriteLine("Voce consome " + quantidade.ToString() + " Cigarros por dia e ja gastou R$ " + resultado.ToString() + " em " + fuma.ToString() + " Anos" );


        }
    }
}
