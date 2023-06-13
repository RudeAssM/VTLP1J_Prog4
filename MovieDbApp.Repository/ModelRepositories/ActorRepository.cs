using System;
using System.Linq;
using VTLP1J_Prog4.Models;
using VTLP1J_Prog4.Repository.Database;
using VTLP1J_Prog4.Repository.GenericRepository;
using VTLP1J_Prog4.Repository.Interfaces;

namespace VTLP1J_Prog4.Repository.ModelRepositories
{
    public class ActorRepository : Repository<Actor>, IRepository<Actor>
    {
        public ActorRepository(MovieDbContext ctx) : base(ctx)
        {
        }

        public override Actor Read(int id)
        {
            return ctx.Actors.FirstOrDefault(t => t.ActorId == id);
        }

        public override void Update(Actor item)
        {
            var old = Read(item.ActorId);
            if (old == null)
            {
                throw new ArgumentException("Item not exist..");
            }
            foreach (var prop in old.GetType().GetProperties())
            {
                if (prop.GetAccessors().FirstOrDefault(t => t.IsVirtual) == null)
                {
                    prop.SetValue(old, prop.GetValue(item));
                }
            }
            ctx.SaveChanges();
        }
    }
}
