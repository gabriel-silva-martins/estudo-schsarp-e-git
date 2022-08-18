using System;
using System.Globalization;

namespace Exercicio_002
{
    class Exer
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Rooms[] vet = new Rooms[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string email = Console.ReadLine();
                int room = int.Parse(Console.ReadLine());

                vet[i] = new Rooms { Name = name, Email = email, Room = room };
            }

            for (int i = 0; i < n; i++)
            {
                if (vet[i] != null)
                    Console.WriteLine("NOME: " + vet[i].Name + " \nEmail: " + vet[i].Email + " \nQuarto: " + vet[i].Room);
            }

        }
    }
}