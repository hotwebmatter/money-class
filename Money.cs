using System;
using System.Collections.Generic;
using System.Text;

namespace money_class
{
    class Money
    {
        // data members
        private int dollars,
                    cents;
        public int Dollars { get; set; }
        public int Cents { get; set; }
        // constructors
        public Money()
        {
            dollars = 46;
            cents = 50;
        }
        // accept single argument, per spec
        public Money (double dollarsAndCents)
        {
            dollars = (int)Math.Floor(dollarsAndCents);
            double centsRemaining = (dollarsAndCents - dollars) * 100;
            cents = (int)centsRemaining;
        }
        // accept two arguments, per spec
        public Money(int d, int c)
        {
            dollars = d;
            cents = c;
        }
        // instance methods
        public void IncrementMoney(int d, int c)
        {
            dollars += d;
            dollars += c / 100;
            cents += c % 100;
        }
        public void DecrementMoney(int d, int c)
        {
            dollars -= d;
            dollars -= c / 100;
            cents -= c % 100;
        }
        public string MakeChange()
        {
            int centsRemaining = cents;
            string result = String.Format("{0}: {1}\n", "Dollars", dollars);
            result += String.Format("{0}: {1}\n", "Quarters", centsRemaining / 25);
            centsRemaining %= 25;
            result += String.Format("{0}: {1}\n", "Dimes", centsRemaining / 10);
            centsRemaining %= 10;
            result += String.Format("{0}: {1}\n", "Nickels", centsRemaining / 5);
            centsRemaining %= 5;
            result += String.Format("{0}: {1}\n", "Pennies", centsRemaining);
            return result;
        }
        public override string ToString()
        {
            string result = String.Format("${0:N0}.{1}", dollars, cents);
            return result;
        }
    }
}
