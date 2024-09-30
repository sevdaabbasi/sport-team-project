using Tff.ConsoleUI.Models;
using Tff.ConsoleUI.Service;
TeamService teamService = new TeamService();

var teams = teamService.GetAll();

var takim = new Team
{
    Id = 2,
    Name = "",
    Since = new DateTime(1907, 5, 3)
};

Console.WriteLine(teamService.Update(4,takim));

