using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoseBall.Data;
using FoseBall.Model;

namespace Foseball.Services
{
    public class CoachService
    {
        public bool CreateCoach(CoachCreate model)
        {

            var entity = new Coach()
            {
                Nationality = model.Nationality,
                Name = model.Name,
                TeamId = model.TeamId,
                InternationalId = model.InternationalId
            };

            using (var ctx = new FoseBallDbContext())
            {
                ctx.Coaches.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CoachListItem> GetCoach()
        {
            using (var ctx = new FoseBallDbContext())
            {
                var searchy = ctx.Coaches.Select(e => new CoachListItem
                {
                    CoachId = e.CoachId,
                    Name = e.Name,
                    Nationality = e.Nationality,
                    TeamId = e.TeamId,
                    InternationalId = e.InternationalId
                });

                return searchy.ToArray();
            }
        }

        public CoachDetail GetCoachByID(int id)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Coaches.Single(e => e.CoachId == id);
                return new CoachDetail
                {
                    CoachId = entity.CoachId,
                    Name = entity.Name,
                    Nationality = entity.Nationality,
                    TeamId = entity.TeamId,
                    InternationalId = entity.InternationalId
                };
            }
        }

        public CoachDetail GetCoachByNationality(string nationality)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Coaches.Single(e => e.Nationality == nationality);
                return new CoachDetail
                {
                    CoachId = entity.CoachId,
                    Name = entity.Name,
                    Nationality = entity.Nationality,
                    TeamId = entity.TeamId,
                    InternationalId = entity.InternationalId
                };
            }
        }

        public bool UpdateCoach(CoachEdit model)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var thing = ctx.Coaches.Single(e => e.CoachId == model.CoachId);

                thing.Name = model.Name;
                thing.Nationality = model.Nationality;
                thing.TeamId = model.TeamId;
                thing.InternationalId = model.InternationalId;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCoach(int coachId)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Coaches.Single(e => e.CoachId == coachId);

                ctx.Coaches.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}

