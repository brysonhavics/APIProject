using FoseBall.Data;
using FoseBall.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foseball.Services
{
    public class PlayerService
    {
        public PlayerService() { }

        public bool CreatePlayer(PlayerCreate model)
        {
            var entity = new Player() { Name = model.Name, Number = model.Number, InternationalId = model.InternationalId, Position = model.Position, TeamId = model.TeamId, Defending = model.Defending, Passing = model.Passing, Shooting = model.Shooting, OverallScore = ((model.Defending+model.Passing+model.Shooting)/3) };

            using (var ctx = new FoseBallDbContext())
            {
                ctx.Players.Add(entity);
                Team team = ctx.Teams.Single(e => e.TeamId == model.TeamId);
                team.PowerRating += entity.OverallScore;
                team.Roster++;
                return ctx.SaveChanges() == 1;
            }
        }

        public PlayerDetail GetPlayerById(int id)
        {
            using(var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Players.Single(e => e.Id == id);

                return new PlayerDetail
                {
                    Name = entity.Name,
                    Number = entity.Number,
                    Position = entity.Position,
                    TeamName = entity.Team.TeamName,
                    InternationalTeam = entity.International.Name,
                    Passing = entity.Passing,
                    Shooting = entity.Shooting,
                    Defending = entity.Defending,
                    OverallScore = entity.OverallScore,
                };
            }
        }

        public IEnumerable<PlayerListItem> GetAllPlayers()
        {
            using (var ctx = new FoseBallDbContext())
            {
                var playerList = ctx.Players.Select(e => new PlayerListItem
                {
                    Name = e.Name,
                    Number = e.Number,
                    Position = e.Position,
                    PlayerId = e.Id,
                    OverallScore = e.OverallScore,
                });
                return playerList.ToArray();
            }
        }

        public IEnumerable<PlayerListItem> GetPlayersByTeam(int teamId)
        {
            using(var ctx = new FoseBallDbContext())
            {
                var playerList = ctx.Players.Where(p => p.TeamId == teamId).Select(e => new PlayerListItem
                {
                    Name = e.Name,
                    Number = e.Number,
                    Position = e.Position,
                    PlayerId = e.Id,
                });
                return playerList.ToArray();
            }
        }

        public IEnumerable<PlayerListItem> GetPlayersByPostition(string position)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var playerList = ctx.Players.Where(p => p.Position == position).Select(e => new PlayerListItem
                {
                    Name = e.Name,
                    Number = e.Number,
                    Position = e.Position,
                    PlayerId = e.Id,
                });
                return playerList.ToArray();
            }
        }

        public bool PlayerEdit(PlayerEdit player)
        {
            using(var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Players.Single(e => e.Id == player.PlayerId);

                entity.Name = player.Name;
                entity.Number = player.Number;
                entity.Position = player.Position;
                entity.TeamId = player.TeamId;
                entity.InternationalId = player.InternationalId;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeletePlayer(int playerId)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Players.Single(e => e.Id == playerId);

                ctx.Players.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
