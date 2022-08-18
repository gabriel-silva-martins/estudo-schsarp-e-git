using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_001
{
    class Banco
    {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Banco(int conta, string nomeTitular)
        {
            Conta = conta;
            Titular = nomeTitular;
        }

        public Banco(int conta, string nomeTitular, double saldo)
        {
            Conta = conta;
            Titular = nomeTitular;
            Saldo = saldo;
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public void Sacar(double saque)
        {
            Saldo -= saque + 5.00;
        }

        public override string ToString()
        {
            return "Conta " + Conta + ", titular: " + Titular + ", saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
