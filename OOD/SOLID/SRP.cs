using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class SRP
    {
    }

    public class Team
    {
        //some props
    }

    #region Rough
    //class TeamService
    //{
    //    public void Create(Team team) { }
    //    public void Update(int id, Team team) { }
    //    public void Delete(int id) { }
    //    public void AddToCompetition(int teamId, int competitionId) { }
    //}
    #endregion

    #region Implementation
    class TeamService
    {
        public void Create(Team team) { }
        public void Update(int id, Team team) { }
        public void Delete(int id) { }
    }

    class CompetitionService
    {
        public void AddToCompetition(int teamId, int competitionId) { }
    }
    #endregion
}
