using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string creatorName = arr[0];
                string teamName = arr[1];

                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(x => x.CreatorName == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(teamName, creatorName);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "end of assignment")
            {
                string[] data = Console.ReadLine()
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string joinName = data[0];
                string joinTeam = data[1];

                Team searchTeam = teams.FirstOrDefault(x => x.TeamName == joinTeam);

                if (searchTeam == null)
                {
                    Console.WriteLine($"Team {joinName} does not exist!");
                    continue;
                }
                if (teams.Any(x => x.Members.Contains(joinName)))
                {
                    Console.WriteLine($"Member {joinName} cannot join team {joinTeam}!");
                    continue;
                }
                if (teams.Any(x => x.CreatorName == joinName))
                {
                    Console.WriteLine($"Member {joinName} cannot join team {joinTeam}!");
                    continue;
                }

                searchTeam.AddMember(joinName);
            }

            List<Team> withMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();
            List<Team> disband = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            foreach (Team vTeam in withMembers)
            {
                Console.WriteLine($"{vTeam.TeamName}");
                Console.WriteLine($"- {vTeam.CreatorName}");

                foreach (string member in vTeam.Members.OrderBy(member => member))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team inTeam in disband)
            {
                Console.WriteLine($"{inTeam.TeamName}");
            }
        }

        class Team
        {
            public Team(string teamName, string creatorName)
            {
                this.TeamName = teamName;
                this.CreatorName = creatorName;
                this.Members = new List<string>();
            }

            public string CreatorName { get; set; }
            public string TeamName { get; set; }
            public List<string> Members { get; set; }

            public void AddMember(string member)
            {
                this.Members.Add(member);
            }
        }
    }
}
