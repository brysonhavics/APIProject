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

        public IEnumerable<TeamListItem> GetTeams()
        {
            using (var ctx= new FoseBallDbContext())
            {
                var query = ctx.Teams
                    .Select(
                    e =>
                    new TeamListItem
                    {
                        TeamId = e.TeamId,
                        TeamName = e.TeamName,
                        Rank = e.Rank
                    }
                );
                return query.ToArray();
            }
        }

        public IEnumerable<TeamListItem> GetTeamsByLeagueId(int id)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var query = ctx.Teams.Where(
                    e => e.LeagueId == id
                    ).Select(e => new TeamListItem
                    {
                        TeamId = e.TeamId,
                        TeamName = e.TeamName,
                        Rank = e.Rank,
                    }
                );

                return query.ToArray();
            }
        }

        public TeamShow GetTeamById(int id)
        {
            using(var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Teams.Single(e => e.TeamId == id);
                return new TeamShow
                {
                    TeamName = entity.TeamName,
                    LeagueId = entity.LeagueId,
                    Rank = entity.Rank,
                };
            }
        }

        public bool UpdateTeam(TeamEdit model)
        {
            using(var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Teams.Single(e => e.TeamId == model.TeamId);

                entity.TeamName = model.TeamName;
                entity.Rank = model.Rank;
                entity.LeagueId = model.LeagueId;
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteTeam(int teamId)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Teams.Single(e => e.TeamId == teamId);

                ctx.Teams.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}

