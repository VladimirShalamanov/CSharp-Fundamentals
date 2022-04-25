using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bookshelf = new Dictionary<string, Dictionary<string, int>>();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Season end")
            {
                string[] separatingStrings = { " -> ", " vs " };
                string[] arr = cmd.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (arr.Length == 3)
                {
                    string player = arr[0];
                    string position = arr[1];
                    int skill = int.Parse(arr[2]);

                    if (bookshelf.ContainsKey(player))
                    {
                        if (bookshelf[player].ContainsKey(position))
                        {
                            if (bookshelf[player][position] < skill)
                            {
                                bookshelf[player][position] = skill;
                            }
                        }
                        else
                        {
                            bookshelf[player][position] = skill;
                        }
                    }
                    else
                    {
                        var info = new Dictionary<string, int>();
                        info.Add(position, skill);
                        bookshelf[player] = info;
                    }
                }
                else if (arr.Length == 2)
                {
                    string player1 = arr[0];
                    string player2 = arr[1];

                    if (bookshelf.ContainsKey(player1) && bookshelf.ContainsKey(player2))
                    {
                        string playerToRemove = string.Empty;
                        foreach (var role in bookshelf[player1])
                        {
                            foreach (var pos in bookshelf[player2])
                            {
                                if (role.Key == pos.Key)
                                {
                                    if (bookshelf[player1].Values.Sum() > bookshelf[player2].Values.Sum())
                                    {
                                        playerToRemove = player2;
                                    }
                                    else if (bookshelf[player1].Values.Sum() < bookshelf[player2].Values.Sum())
                                    {
                                        playerToRemove = player1;
                                    }
                                }
                            }
                        }

                        bookshelf.Remove(playerToRemove);
                    }
                }
            }

            foreach (var pla in bookshelf.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pla.Key}: {pla.Value.Values.Sum()} skill");
                foreach (var pair in pla.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {pair.Key} <::> {pair.Value}");
                }
            }
        }
    }
}
