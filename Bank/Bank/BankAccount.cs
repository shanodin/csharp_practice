namespace Bank
{
    internal class BankAccount
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Type { get; set; }

        public BankAccount(string name, int amount, string type)
        {
            this.Name = name;
            this.Amount = amount;
            this.Type = type;
        }

        public void Deposit(int depositAmount)
        {
            this.Amount += depositAmount;
        }

        public void PayFee()
        {
            if (this.Type.Equals("business"))
            {
                this.Amount -= 50;
            }
            else if (this.Type.Equals("personal"))
            {
                this.Amount -= 10;
            }
        }
    }
}