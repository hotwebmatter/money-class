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
            Console.WriteLine("Hello World!");
        }
    }
}
