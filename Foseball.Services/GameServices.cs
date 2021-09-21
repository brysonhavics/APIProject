using FoseBall.Data;
using FoseBall.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foseball.Services
{
    public class GameServices
    {
        public bool CreateGame(GameCreate model)
        {
            var entity = new Game() { HomeId = model.HomeId, AwayId = model.AwayId, Referee = model.Referee };

            using (var ctx = new FoseBallDbContext())
            {
                Team home = ctx.Teams.Single(e => e.TeamId == entity.HomeId);
                Team away = ctx.Teams.Single(e => e.TeamId == entity.AwayId);
                entity.HomeName = home.TeamName;
                entity.AwayName = away.TeamName;
                if (home.PowerRating > away.PowerRating)
                {
                    home.Wins++;
                    away.Losses++;
                    entity.Result = home.TeamName;
                }                
                else if (home.PowerRating < away.PowerRating)
                {
                    home.Losses++;
                    away.Wins++;
                    entity.Result = away.TeamName;
                }                
                else if (home.PowerRating == away.PowerRating)
                {
                    home.Draws++;
                    away.Draws++;
                    entity.Result = "Draw";
                }
               
                ctx.Games.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<GameListItem> GetGames()
        {
            using(var ctx = new FoseBallDbContext())
            {
                var gameList = ctx.Games.Select(e => new GameListItem
                {
                    GameId = e.GameId,
                    HomeName = e.HomeName,
                    AwayName = e.AwayName,
                    Referee = e.Referee,
                    Result = e.Result
                });
                return gameList.ToArray();
            }
        }


    }
}
