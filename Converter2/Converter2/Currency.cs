namespace Converter2
{
    public class Currency
    {
        private string name;
        private double _rate;
        public double Amount { get; set; }

        public Currency(string name, double rate)
        {
            this.name = name;
            this._rate = rate;
            this.Amount = 0;
        }

        public double AmountInBGN()
        {
            return Amount * _rate;
        }

        public void SetAmountFromBGN(double amount)
        {
            Amount = amount / _rate;
        }
    }
}