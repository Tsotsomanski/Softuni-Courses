using System;
using _2.BankOfKurtovoKonare.Account;

namespace _2.BankOfKurtovoKonare
{
    class IndividualCustumer : Custumer
    {
        private string egn;
        public IndividualCustumer(string name, string egn) : base(name)
        {
            this.Egn = egn;
        }

        public string Egn
        {
            get { return this.egn; }
            set
            {
                if (value.Length < 10 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException(value, "The lenght of the EGN must be exact 10 numbers !");
                }
                this.egn = value;
            }
        }
    }
}
