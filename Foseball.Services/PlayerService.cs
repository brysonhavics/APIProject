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
            var entity = new Player() { Name = model.Name, Number = model.Number, NationalityId = model.InternationalId, Position = model.Position, TeamId = model.TeamId };

            using (var ctx = new FoseBallDbContext())
            {
                ctx.Players.Add(entity);
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
                    TeamId = entity.TeamId,
                    NationalityId = entity.NationalityId,
                };
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
                entity.NationalityId = player.NationalityId;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
