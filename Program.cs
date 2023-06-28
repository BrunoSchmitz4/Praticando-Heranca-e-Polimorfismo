using DecQuintApp.Entities;
using System;
using System.Globalization;

namespace DecQuintApp
{
    class Program
    {
        // Classes e métodos selados omaga :0
        // Classes:
        // Evita que a classe seja herdada, contudo,
        // ainda é possível extender suas funcionalidades usando "extension methods
        // Métodos:
        // evita que um método sobreposto possa ser sobreposto novamente
        // Só poderá ser aplicado à metodos sobrepostos
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingsAccount(1002, "Maria", 500, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine("Saldo da conta 1: " + acc1.Balance);
            Console.WriteLine("Saldo da conta 2: " + acc2.Balance);
        }
    }
}