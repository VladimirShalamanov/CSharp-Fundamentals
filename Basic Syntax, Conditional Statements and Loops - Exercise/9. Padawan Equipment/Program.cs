using System;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double sabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double sabersPrice = Math.Ceiling((countStudents * 0.1) + countStudents);
            double robesPrice = robes * countStudents;
            double beltsPrice = countStudents / 6;

            double totalPrice = (sabersPrice * sabers) + ((countStudents - beltsPrice) * belts) + robesPrice;

            if (totalPrice <= amountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else if (amountMoney < totalPrice)
            {
                Console.WriteLine($" John will need {totalPrice-amountMoney:f2}lv more.");
            }
        }
    }
}
