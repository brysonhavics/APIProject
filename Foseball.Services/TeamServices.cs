using FoseBall.Data;
using FoseBall.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foseball.Services
{
    public class TeamServices
    {
        public TeamServices() { }

        public bool CreateTeam(TeamCreate model)
        {
            var entity = new Team() { TeamName = model.TeamName, LeagueId = model.LeagueId, Rank = model.Rank};

            using (var ctx = new FoseBallDbContext())
            {
                ctx.Teams.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}

