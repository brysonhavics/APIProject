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

        public TransferListItem GetTransferById(int id)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Transfers.Single(e => e.Id == id);

                return new TransferListItem
                {
                    Fee = entity.Fee,
                    PlayerId = entity.PlayerId,
                    OldTeam = entity.OldTeam,
                    NewTeam = entity.NewTeam,
                };
            }
        }

        public IEnumerable<TransferListItem> GetAllTransfers()
        {
            using (var ctx = new FoseBallDbContext())
            {
                var playerList = ctx.Transfers.Select(e => new TransferListItem
                {
                    Fee = e.Fee,
                    PlayerId = e.PlayerId,
                    OldTeam = e.OldTeam,
                    NewTeam = e.NewTeam,
                });

                return playerList.ToArray();
            }
        }
    }
}
