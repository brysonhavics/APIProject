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
            var entity = new Transfer() { TeamId1 = transfer.TeamId1, Fee = transfer.Fee, PlayerId = transfer.PlayerId };

            using (var ctx = new FoseBallDbContext())
            {
                Player player = ctx.Players.Single(e => e.Id == entity.PlayerId);
                entity.TeamId1 = player.TeamId;
                ctx.Transfers.Add(entity);
                player.TeamId = entity.TeamId2;
                return ctx.SaveChanges() == 1;
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
                    TeamId1 = entity.TeamId1,
                    TeamId2 = entity.TeamId2,
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
                    TeamId1 = e.TeamId1,
                    TeamId2 = e.TeamId2,
                });

                return playerList;
            }
        }
    }
}
