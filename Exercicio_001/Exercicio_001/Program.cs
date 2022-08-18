using System;
using System.Globalization;

namespace Exercicio_001
{
    class Exer
    {
        static void Main(string[] args)
        {

            //Criação da conta

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá algum deposito inicial (S / N): ");
            char check = char.Parse(Console.ReadLine());

            Banco acc = new Banco(conta, titular);

            if (check == 'S' || check == 's')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double depos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Depositar(depos);
            }

            //Apresentação dos dados da conta

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(acc);
            
            //Depositando
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            acc.Depositar(deposito);

            //Apresentação dos dados da conta

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(acc);

            //Sacando
            Console.WriteLine();
            Console.Write("Entre um valor para sacar: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            acc.Sacar(saque);

            //Apresentação dos dados da conta

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(acc);

        }
    }
}