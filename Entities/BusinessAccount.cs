using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecQuintApp.Entities
{
    // Esta é a subclasse
    // para dizermos que ela herda de uma superclasse, colocamos o : SuperClasse
    sealed class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        // Para reusarmos os construtores, podemos colocar o
        // ": base(variaveis locais do construtor da superclasse)"
        // E dentro, só chamará as props da subclasse
        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
        
    }
}
