﻿using System;
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
                    LeagueId = e.LeagueId,
                    Name = e.Name,
                    Nation = e.Nation,
                    NumberOfTeams = e.NumberOfTeams
                });

                return searchy.ToArray();
            }
        }
    }
}
