namespace DecQuintApp.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        
        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // Este método pode ser selado
        // pois é um método sobrescrito.
        // basta colocar o "sealed" antes do modificador de acesso
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
