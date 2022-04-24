using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();

            string cmd;
            while((cmd = Console.ReadLine()) != "End")
            {
                string[] arr = cmd.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string currCompany = arr[0];
                string id = arr[1];

                if (!company.ContainsKey(currCompany))
                {
                    company[currCompany] = new List<string>() { id };
                    continue;
                }

                else if (!company[currCompany].Any(x => x == id))
                {
                    company[currCompany].Add(id);
                }
            }

            foreach (var item in company)
            {
                Console.WriteLine(item.Key);
                foreach (var employee in item.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
