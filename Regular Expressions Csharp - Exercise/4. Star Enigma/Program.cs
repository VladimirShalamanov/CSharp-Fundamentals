using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string decriptPattern = "[star]{1}";
            string pattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:(\d+)[^\@\-\!\:\>]*?\!(?<attackType>A|D){1}\![^\@\-\!\:\>]*?\-\>(\d+)";

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string ecriptedMessage = Console.ReadLine();
                MatchCollection matches = Regex.Matches(ecriptedMessage, decriptPattern, RegexOptions.IgnoreCase);
                int countDecrip = matches.Count;

                StringBuilder decriptMessage = new StringBuilder();
                foreach (char currCh in ecriptedMessage)
                {
                    char decriptCh = (char)(currCh - countDecrip);
                    decriptMessage.Append(decriptCh);
                }

                string decriptMess = decriptMessage.ToString();

                Match info = Regex.Match(decriptMess, pattern);
                if (info.Success)
                {
                    string planet = info.Groups["planet"].Value;
                    string attackType = info.Groups["attackType"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (string name in attackedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {name}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (string name in destroyedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {name}");
            }
        }
    }
}
