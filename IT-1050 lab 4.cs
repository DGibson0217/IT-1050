using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            const double smallSoda = 3.50;
            const double largeSoda = 5.99;
            const double hotDog = 3.99;
            const double popCorn = 4.50;
            const double candy = 1.99;

            const double matineeChild = 3.99;
            const double matineeAdult = 5.99;
            const double matineeSenior = 4.50;

            const double eveningChild = 6.99;
            const double eveningAdult = 10.99;
            const double eveningSenior = 8.50;           

            bool isMatinee = false;
            double totalPrice = 0;
            double discountTotal = 0;
            double totalPriceDiscounted;
            int totalNumTickets;
            int addChild;
            int addAdult;
            int addSenior;
            int addsmallSoda;
            int addlargeSoda;
            int addhotDog;
            int addpopCorn;
            int addcandy;
            
            Console.WriteLine("Matinee or Evening?");
            string inputTime = Console.ReadLine();
            Console.WriteLine();

            if (inputTime == "Matinee")
            {
                Console.WriteLine("Welcome to the Matinee Show.");
                isMatinee = true;
            }
            else if (inputTime == "Evening") 
            {
                Console.WriteLine("Welcome to the Evening Show.");
            }
            else 
            {
                Console.WriteLine("We don't have any showing at that time.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("How many Children?");
            addChild = int.Parse(System.Console.ReadLine());
            Console.WriteLine("How many Adults?");
            addAdult = int.Parse(System.Console.ReadLine());
            Console.WriteLine("How many seniors?");
            addSenior = int.Parse(System.Console.ReadLine());

            if (isMatinee == true)
            {
                totalPrice += (matineeChild * addChild) + (matineeAdult * addAdult) + (matineeSenior * addSenior); 
            }
           else if (isMatinee == false)
            {
                totalPrice += (eveningChild * addChild) + (eveningAdult * addAdult) + (eveningSenior * addSenior);
            }
            totalNumTickets = addChild + addAdult + addSenior;
            #endregion
            #region Part 2
            Console.WriteLine("How many Small Sodas would you like?");
            addsmallSoda = int.Parse(System.Console.ReadLine());
            Console.WriteLine("How many large sodas would you like?");
            addlargeSoda = int.Parse(System.Console.ReadLine());
            Console.WriteLine("How many Hot Dogs would you like?");
            addhotDog = int.Parse(System.Console.ReadLine());
            Console.WriteLine("How many Bags of popcorn would you like?");
            addpopCorn = int.Parse(System.Console.ReadLine());
            Console.WriteLine("How many bags of candy would you like?");
            addcandy = int.Parse(System.Console.ReadLine());

            totalPrice += addlargeSoda * largeSoda;
            totalPrice += addsmallSoda * smallSoda;
            totalPrice += addhotDog * hotDog;
            totalPrice += addpopCorn * popCorn;
            totalPrice += addcandy * candy;

            Console.WriteLine("Total Price before discounts:" + totalPrice);
            Console.ReadLine();
            #endregion

            //Discounts
 
            if ((addcandy % 4) == 0)
            {
                discountTotal += (addcandy / 4) * candy;
            }

            if (addChild + addAdult + addSenior >= 3 && !isMatinee)
            {
                addpopCorn++;
                if (addpopCorn >= 1)
                {
                    discountTotal += popCorn;
                }
            }

            int min1 = System.Math.Min(addpopCorn, addlargeSoda);

            int min2 = System.Math.Min(min1, totalNumTickets);
            discountTotal += (min2 * 2.0);

            totalPriceDiscounted = totalPrice - discountTotal;
            Console.WriteLine("Your total price after discounts:" + totalPriceDiscounted);
            Console.ReadLine();

        }
    }
}
