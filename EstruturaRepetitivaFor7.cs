using System;

namespace EstruturaRepetitivaFor7 
    //Fazer um programa para ler um número inteiro positivo N.
    //O programa deve então mostrar na tela N linhas,
    //começando de 1 até N. Para cada linha, mostrar o número da linha,
    //depois o quadrado e o cubo do valor, conforme exemplo.
{
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digtite um número N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write(i + " ");
                Console.Write(Math.Pow((i), 2) + " ");
                Console.WriteLine(Math.Pow((i), 3));
            }
        }
    }
}