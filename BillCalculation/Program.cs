using System;

namespace BillCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double sodaPrice = 1.50;
            double sandwichPrice = 4.50;
            double chipsPrice = 1.25;
            double taxRate = 0.08;
            double tipRate = 0.15;

            double totalSodaPrice = sodaPrice + sodaPrice;

            double totalSandwichPrice = sandwichPrice + sandwichPrice;

            double subTotal = totalSandwichPrice + totalSodaPrice + chipsPrice;

            double tax = subTotal * taxRate;

            double tip = subTotal * tipRate;

            double total = subTotal + tax + tip;

            Console.WriteLine("Subtotal {0:C}" , subTotal);
            Console.WriteLine("Tax {0:C}" , tax);
            Console.WriteLine("Tip {0:C}" , tip);
            Console.WriteLine("Total {0:C}" , total);

        }
    }
}
