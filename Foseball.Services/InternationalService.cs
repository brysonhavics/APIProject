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

        public bool CreateInternational(InternationalCreate model)
        {
            var entity = new International()
            {
                InternationalId = model.InternationalId,
                Coach = model.Coach,
                Ranking = model.Ranking,
                Name = model.Name, };

            using (var ctx = new FoseBallDbContext())
            {
                ctx.Internationals.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
