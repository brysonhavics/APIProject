using FoseBall.Data;
using FoseBall.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foseball.Services
{
    public class TransferService
    {
        public TransferService() { }

        public bool CreateTransfer(TransferCreate transfer)
        {
            var entity = new Transfer() { NewTeam = transfer.NewTeam, Fee = transfer.Fee, PlayerId = transfer.PlayerId };

            using (var ctx = new FoseBallDbContext())
            {
                Player player = ctx.Players.Single(e => e.Id == entity.PlayerId);
                entity.OldTeam = player.TeamId;
                ctx.Transfers.Add(entity);
                player.TeamId = entity.NewTeam;
                return ctx.SaveChanges() == 2;
            }
        }

        public TransferDetail GetTransferById(int id)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Transfers.Single(e => e.Id == id);
                var oldTeam = ctx.Teams.Single(e => e.TeamId == entity.OldTeam);
                var newTeam = ctx.Teams.Single(e => e.TeamId == entity.NewTeam);
                var player = ctx.Players.Single(e => e.Id == entity.PlayerId);
                return new TransferDetail
                {
                    Fee = entity.Fee,
                    Player = player.Name,
                    OldTeam = oldTeam.TeamName,
                    NewTeam = newTeam.TeamName,
                };
            }
        }

        public IEnumerable<TransferListItem> GetAllTransfers()
        {
            using (var ctx = new FoseBallDbContext())
            {
                var query = ctx.Transfers.Select(
                    e =>
                    new TransferListItem
                    {
                        Fee = e.Fee,
                        PlayerId = e.PlayerId,
                        TransferId = e.Id,
                    });

                return query.ToArray();
            }
        }
    }
}
