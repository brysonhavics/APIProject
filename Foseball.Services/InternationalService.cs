using FoseBall.Data;
using FoseBall.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foseball.Services
{
    public class InternationalService
    {
        public InternationalService() { }

        public IEnumerable<InternationalListItem> GetAllInternational()
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity =
                    ctx
                    .Internationals
                    .Select(e => new InternationalListItem
                    {
                        InternationalId = e.InternationalId,
                        Coach = e.Coach,
                        Ranking = e.Ranking,
                        Name = e.Name,
                    });

                return entity.ToArray();
            }
        }
         public bool CreateInternational(InternationalCreate model)
        {
            var entity = new International()
            {
                Coach = model.Coach,
                Ranking = model.Ranking,
                Name = model.Name,
            };

            using (var ctx = new FoseBallDbContext())
            {
                ctx.Internationals.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }
        public InternationalDetail GetInternationalById(int id)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity =
                    ctx
                    .Internationals
                    .Single(e => e.InternationalId == id);
                return
                    new InternationalDetail
                    {
                        Coach = entity.Coach,
                        InternationalId = entity.InternationalId,
                        Ranking = entity.Ranking,
                        Name = entity.Name,
                    };
            }
        }
        public bool UpdateInternational(InternationalEdit model)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity =
                    ctx
                    .Internationals
                    .Single(e => e.InternationalId == model.InternationalId);
                entity.Coach = model.Coach;
                entity.Ranking = model.Ranking;
                entity.Name = model.Name;

                return ctx.SaveChanges() == 1;

            }

        }
        public bool DeleteInternational(int InternationalId)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity =
                    ctx
                    .Internationals
                    .Single(e => e.InternationalId == InternationalId);

                ctx.Internationals.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
