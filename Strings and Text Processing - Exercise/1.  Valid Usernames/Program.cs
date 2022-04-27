using System;
using System.Linq;

namespace _1.__Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int word = 0; word < names.Length; word++)
            {
                string currName = names[word];

                if (currName.Length >= 3 && currName.Length <= 16)
                {
                    bool isValid = true;
                    for (int letter = 0; letter < currName.Length; letter++)
                    {
                        char a = currName[letter];
                        if (char.IsLetterOrDigit(a) || a == '-' || a == '_')
                        {
                            continue;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid == true)
                    {
                        Console.WriteLine(currName);
                    }
                }
            }
        }
    }
}
