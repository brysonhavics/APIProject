using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluent.Infrastructure.FluentModel;
using FoseBall.Data;

namespace FoseBall.Model
{
    public class LeagueService
    {
        private FoseBallDbContext _context = new FoseBallDbContext();

        public bool CreateLeague(LeagueCreate model)
        {
            var entity = new League()
            {
                Name = model.Name,
                Nation = model.Nation,
                NumberOfTeams = model.NumberOfTeams
            };

            using (var ctx = new FoseBallDbContext())
            {
                ctx.Leagues.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<LeagueListItem> GetLeague()
        {
            using (var ctx = new FoseBallDbContext())
            {
                var search = ctx.Leagues.Select(e => new LeagueListItem
                {
                    LeagueId = e.LeagueId,
                    Name = e.Name,
                    Nation = e.Nation,
                    NumberOfTeams = e.NumberOfTeams
                });

                return search.ToArray();
            }
        }
    }
}
