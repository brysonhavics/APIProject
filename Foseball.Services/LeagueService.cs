using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoseBall.Data;
using FoseBall.Model;

namespace Foseball.Services
{
    public class LeagueService
    {
        public bool CreateLeague(LeagueCreate model)
        {

            var entity = new League()
            {
                Nation = model.Nation,
                Name = model.Name,
                NumberOfTeams = model.NumberOfTeams
            };

            using (var ctx = new FoseBallDbContext())
            {
                ctx.Leagues.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<LeagueListItem> GetLeagues()
        {
           using (var ctx = new FoseBallDbContext())
            {
                var searchy = ctx.Leagues.Select(e => new LeagueListItem
                {
                    Name = e.Name,
                    Nation = e.Nation,
                    NumberOfTeams = e.NumberOfTeams
                });

                return searchy.ToArray();
            }
        }

        public LeagueDetail GetLeagueByID(int id)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Leagues.Single(e => e.LeagueId == id);
                return new LeagueDetail
                {
                    Name = entity.Name,
                    NumberOfTeams = entity.NumberOfTeams,
                    Nation = entity.Nation
                };
            }
        }

        public LeagueDetail GetLeagueByNation(string nation)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Leagues.Single(e => e.Nation == nation);
                return new LeagueDetail
                {
                    Name = entity.Name,
                    NumberOfTeams= entity.NumberOfTeams,
                    Nation = entity.Nation
                };
            }
        }

        public bool UpdateLeague(LeagueEdit model)
        {
            using(var ctx = new FoseBallDbContext())
            {
                var thing = ctx.Leagues.Single(e => e.LeagueId == model.LeagueId);

                thing.Name = model.Name;
                thing.Nation = model.Nation;
                thing.NumberOfTeams = model.NumberOfTeams;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteLeague(int leagueId)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Leagues.Single(e => e.LeagueId == leagueId);

                ctx.Leagues.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
