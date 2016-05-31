using System;

namespace _2.BankOfKurtovoKonare.Account
{
    public abstract class Custumer
    {
        private string name;

        public Custumer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            set {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Custumet cannot be empty !");
                }
                this.name = value;
            }
        }
    }
}
