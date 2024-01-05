using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("leia a hora inicia e final do jogo");
            string[] vet = Console.ReadLine().Split(' ');
            int inicio = int.Parse(vet[0]);
            int fim = int.Parse(vet[1]);

            int saida = 0;
            if (inicio > fim) {
                saida = (24 - inicio) + fim;
            }
            else if (inicio == fim) {
                saida = 24; 
            }
            else {
                saida = fim - inicio;
            }

            Console.WriteLine("O jogo durou " + saida + " horas(s)");
        }
    }
}