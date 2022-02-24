using System;

namespace Maior_Menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numero = new double[15];
            int i;
            double maior = 0, menor = 0;

            Console.WriteLine("Escreva 15 numeros!");
            for (i = 0; i < 15; i++)
            {
                numero[i] = double.Parse(Console.ReadLine());
            }
            maior = numero[0];
            for (i = 0; i < 15; i++)
            {
                if (numero[i] > maior)
                {
                    maior = numero[i];
                }
            }
            Console.WriteLine("O numero maior e! {0} ", maior);
            menor = numero[0];
            for (i = 0; i < 15; i++)
            {
                if(numero[i] < menor)
                {
                    menor = numero[i];
                }

            }
            Console.WriteLine("O numero menor e! {0} ", menor);
        }    

    }
}
