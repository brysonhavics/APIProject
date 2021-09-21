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
            var entity = new Team() { TeamName = model.TeamName, LeagueId = model.LeagueId, Rank = model.Rank, PowerRating = 0, Draws=0,Wins=0,Losses=0};

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
                        Rank = e.Rank,
                        Roster = e.Roster,
                        PowerRating = e.PowerRating/e.Roster,
                        Wins = e.Wins,
                        Losses = e.Losses,
                        Draws = e.Draws,
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
                        Roster = e.Roster,
                        PowerRating = e.PowerRating/e.Roster,
                        Wins = e.Wins,
                        Losses = e.Losses,
                        Draws = e.Draws,
                    }
                );

                return query.ToArray();
            }
        }

        public IEnumerable<TeamListItem> GetTeamsByLeagueRankSort(int id)
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
                        Roster = e.Roster,
                        PowerRating = e.PowerRating/e.Roster,
                        Wins = e.Wins,
                        Losses = e.Losses,
                        Draws = e.Draws,
                    }
                );
                var ordered = query.OrderBy(e => e.Rank);
                return ordered.ToArray();
            }
        }

        public TeamDetail GetTeamById(int id)
        {
            using(var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Teams.Single(e => e.TeamId == id);
                return new TeamDetail
                {
                    TeamName = entity.TeamName,
                    LeagueId = entity.LeagueId,
                    Rank = entity.Rank,
                    Roster = entity.Roster,
                    PowerRanking = entity.PowerRating/entity.Roster,
                    Wins = entity.Wins,
                    Losses = entity.Losses,
                    Draws = entity.Draws,
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

