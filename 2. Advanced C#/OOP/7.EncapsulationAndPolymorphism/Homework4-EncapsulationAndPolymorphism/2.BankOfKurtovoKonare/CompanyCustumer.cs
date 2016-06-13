using System;
using _2.BankOfKurtovoKonare.Account;

namespace _2.BankOfKurtovoKonare
{
    class CompanyCustumer : Custumer
    {
        private string bulstat;

        public CompanyCustumer(string name, string bulstat) 
            : base(name)
        {
            this.bulstat = bulstat;
        }

        public string Bulstat { get; set; }
    }
}
