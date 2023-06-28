using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DecQuintApp.Entities
{
    // Esta é a superclasse
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // O método Withdraw agora pode ser sobrescrito
        // nas subclasses, o que permite isso, é o virtual.
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0 ;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
