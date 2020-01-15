using System;
using System.Collections.Generic;
using System.Text;

namespace money_class
{
    class Money
    {
        private int dollars,
                    cents;
        public int Dollars { get; set; }
        public int Cents { get; set; }
        // constructors
        public Money()
        {
            dollars = 46;
            cents = 75;
        }
        // accept single argument, per spec
        public Money (double dollarsAndCents)
        {
            dollars = Math.Floor(dollarsAndCents);
            cents = (dollarsAndCents - Math.Floor(dollarsAndCents)) * 100;
        }
    }
}
