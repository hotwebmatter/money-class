﻿using System;

namespace money_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Money aMoney = new Money();
            Money bMoney = new Money(3.25);
            Money cMoney = new Money(17, 75);
            Console.WriteLine("{0}: {1}\n", "aMoney", aMoney.ToString());
            aMoney.IncrementMoney(2, 17);
            Console.WriteLine("{0}: {1}\n", "aMoney.IncrementMoney(2, 17)", aMoney.ToString());
            Console.WriteLine(aMoney.MakeChange());
            aMoney.DecrementMoney(2, 17);
            Console.WriteLine("{0}: {1}\n", "aMoney.DecrementMoney(2, 17)", aMoney.ToString());
            Console.WriteLine("{0}: {1}\n", "bMoney", bMoney.ToString());
            bMoney.IncrementMoney(2, 17);
            Console.WriteLine("{0}: {1}\n", "bMoney.IncrementMoney(2, 17)", bMoney.ToString());
            Console.WriteLine(bMoney.MakeChange());
            bMoney.DecrementMoney(2, 17);
            Console.WriteLine("{0}: {1}\n", "bMoney.DecrementMoney(2, 17)", bMoney.ToString());
            Console.WriteLine("{0}: {1}\n", "cMoney", cMoney.ToString());
            cMoney.IncrementMoney(2, 17);
            Console.WriteLine("{0}: {1}\n", "cMoney.IncrementMoney(2, 17)", cMoney.ToString());
            Console.WriteLine(cMoney.MakeChange());
            cMoney.DecrementMoney(2, 17);
            Console.WriteLine("{0}: {1}\n", "cMoney.DecrementMoney(2, 17)", cMoney.ToString());
        }
    }
}
