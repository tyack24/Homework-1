using System;

namespace BillCalculation
{
    class Program
    {
         static void Main(string[] args)
       
        
        
        {
           

           
            
            

            Console.WriteLine("Enter number of sodas:");
            string numOfSodas = Console.ReadLine();
            Console.WriteLine("Number of sodas: " + numOfSodas);
            
            Console.WriteLine("Enter number of sandwiches:");
            string numOfSand = Console.ReadLine();
            Console.WriteLine("Number of sandwiches: " + numOfSand);
            
            Console.WriteLine("Enter number of chips:");
            string numOfChips = Console.ReadLine();
            Console.WriteLine("Number of chips: " + numOfChips);

            


            double sodaPrice = 1.50;
            double sandwichPrice = 4.50;
            double chipsPrice = 1.25;
            double taxRate = 0.08;
            double tipRate = 0.15;
            double totalNumOfSodas = double.Parse(numOfSodas);
            double totalNumOfSand = double.Parse(numOfSand);
            double totalNumOfChips = double.Parse(numOfChips);

            double totalSodaPrice = sodaPrice * totalNumOfSodas;

            double totalSandwichPrice = sandwichPrice * totalNumOfSand;

            double totalChipPrice = chipsPrice * totalNumOfChips;

            double subTotal = totalSandwichPrice + totalSodaPrice + chipsPrice;

            double tax = subTotal * taxRate;

            double tip = subTotal * tipRate;

            double total = subTotal + tax + tip;

            Console.WriteLine("Subtotal {0:C}", subTotal);
            Console.WriteLine("Tax {0:C}", tax);
            Console.WriteLine("Tip {0:C}", tip);
            Console.WriteLine("Total {0:C}", total);


        }
    }
}
