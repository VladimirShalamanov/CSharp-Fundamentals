using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keybardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keybardCount = 0;

            bool headsetBroken = false;
            bool mouseBroken = false;

            double price = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                headsetCount++;
                mouseCount++;

                if (headsetCount == 2)
                {
                    headsetBroken = true;
                    headsetCount = 0;
                    price += headsetPrice;
                }
                else
                {
                    headsetBroken = false;
                }
                if (mouseCount == 3)
                {
                    mouseBroken = true;
                    mouseCount = 0;
                    price += mousePrice;
                }
                else
                {
                    mouseBroken= false;
                }
                if (headsetBroken && mouseBroken)
                {
                    headsetBroken = false;
                    mouseBroken = false;
                    keybardCount++;
                    price += keybardPrice;
                }
                if (keybardCount == 2)
                {
                    keybardCount = 0;
                    price += displayPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {price:f2} lv.");
        }
    }
}
