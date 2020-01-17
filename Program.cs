using System;

namespace money_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Money aMoney = new Money();
            Money bMoney = new Money(3.27);
            Money cMoney = new Money(17, 48);
            Console.WriteLine("{0}: {1}\n", "aMoney", aMoney.ToString());
            Console.WriteLine(aMoney.MakeChange());
            Console.WriteLine("{0}: {1}\n", "bMoney", bMoney.ToString());
            Console.WriteLine(bMoney.MakeChange());
            Console.WriteLine("{0}: {1}\n", "cMoney", cMoney.ToString());
            Console.WriteLine(cMoney.MakeChange());
        }
    }
}
