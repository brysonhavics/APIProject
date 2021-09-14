﻿using FoseBall.Data;
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
    }
}

