using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _5._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Regex.Split(Console.ReadLine(), @" *,{1} *");

            Regex healthRegex = new Regex(@"[^+\-*/.\d]");

            Regex dmgRegex = new Regex(@"((|-)\d+\.\d+|(|-)\d+)");

            var demonData = new Dictionary<string, KeyValuePair<int, double>>(demons.Length - 1);

            foreach(var demon in demons.OrderBy(x => x))
            {
                int health = 0;

                var sumChar = healthRegex.Matches(demon).ToArray();

                foreach (var ch in sumChar)
                {
                    health += char.Parse(ch.Value);
                }

                double damage = 0;

                var dmg = dmgRegex.Matches(demon).ToArray();

                foreach (var num in dmg)
                {
                    damage += double.Parse(num.Value);
                }

                var matchSym = Regex.Matches(demon, @"[\*\/]").ToArray();

                foreach (var sym in matchSym)
                {
                    var mathOperation = sym.Value == "*" ? damage *= 2 : damage /= 2;
                }

                demonData[demon] = new KeyValuePair<int, double>(health, damage);
            }

            foreach (var demon in demonData)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value.Key} health, {demon.Value.Value:F2} damage");
            }
        }
    }
}
