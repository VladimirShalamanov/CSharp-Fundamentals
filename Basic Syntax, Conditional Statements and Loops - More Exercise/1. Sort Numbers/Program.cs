using System;

namespace _1._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int conteiner1 = int.MinValue;
            int conteiner2 = int.MinValue;
            int conteiner3 = int.MinValue;

            for (int i = 1; i <= 3; i++)
            {
                int numberToChek = int.Parse(Console.ReadLine());
                if (numberToChek > conteiner1)
                {
                    conteiner3 = conteiner2;
                    conteiner2 = conteiner1;
                    conteiner1 = numberToChek;
                }
                else if (numberToChek > conteiner2)
                {
                    conteiner3 = conteiner2;
                    conteiner2 = numberToChek;
                }
                else if (numberToChek > conteiner3)
                {
                    conteiner3 = numberToChek;
                }
            }

            Console.WriteLine(conteiner1);
            Console.WriteLine(conteiner2);
            Console.WriteLine(conteiner3);
        }
    }
}
