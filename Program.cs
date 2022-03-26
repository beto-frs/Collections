using System;
using System.Collections.Generic;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtd = 20;
            int[] Numeral = new int[qtd];
            Random r = new Random();
            for (int i = 0; i < Numeral.Length; i++) Numeral[i] = r.Next(1, 100);
            Console.WriteLine("A Array preenchida é: ");
            Console.Write("{");
            foreach (var item in Numeral)
            {
                Console.Write($" {item} ");
            }
            Console.Write("}\n");
            Console.WriteLine("Mostrando as Arrays de acordo com a solicitação: ");
            int[] Par = new int[qtd];
            int[] Impar = new int[qtd];
            int IndicePar = 0, IndiceImpar = 0;

            foreach (var item in Numeral)
            {
                if (item % 2 == 0)
                {
                    Par[IndicePar] = item;
                    IndicePar++;
                }
                else
                {
                    Impar[IndiceImpar] = item;
                    IndiceImpar++;
                }
            }
            Console.WriteLine("Mostrando as Arrays:");
            Console.Write("Array Par: {");

            foreach (var item in Par)
            {
                if (item != 0) Console.Write($" {item} ");
            }
            Console.Write("}\n\nArray Impar: {");

            foreach (var item in Impar)
            {
                if (item != 0) Console.Write($" {item} ");
            }
            Console.Write("}\n\n");
            Console.WriteLine("Finalizando a exibição");
            ListaNumeral();

        }

        static void ListaNumeral()
        {
            Console.Clear();
            int qtd = 20;
            List<int> Numeral = new List<int>();
            List<int> Par = new List<int>();
            List<int> Impar = new List<int>();
            Random r = new Random();
            for (int i = 0; i < qtd; i++)
            {
                int randomico = r.Next(1, 100);
                Numeral.Add(randomico);

                if (randomico%2==0)
                {
                    Par.Add(randomico);
                }
                else
                {
                    Impar.Add(randomico);
                }
               
            }
            Console.WriteLine("Mostrando as Arrays:");
            Console.Write("Array Par: {");

            foreach (var item in Par)
            {
               Console.Write($" {item} ");
            }
            Console.Write("}\n\nArray Impar: {");

            foreach (var item in Impar)
            {
                 Console.Write($" {item} ");
            }
            Console.Write("}\n\n");
            Console.WriteLine("Finalizando a exibição");
        }

    }

    
}
