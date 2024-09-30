using Tff.ConsoleUI.Models;
using Tff.ConsoleUI.Models.ReturnModels;

namespace Tff.ConsoleUI.Service;

public interface ITeamService
{
    ReturnModel<Team> GetById(int id);
    ReturnModel<List<Team>> GetAll();

    ReturnModel<Team> Update(int id,Team team);
}
