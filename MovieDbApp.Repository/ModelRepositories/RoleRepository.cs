using System.Linq;
using VTLP1J_Prog4.Models;
using VTLP1J_Prog4.Repository.Database;
using VTLP1J_Prog4.Repository.GenericRepository;
using VTLP1J_Prog4.Repository.Interfaces;

namespace VTLP1J_Prog4.Repository.ModelRepositories
{
    public class RoleRepository : Repository<Role>, IRepository<Role>
    {
        public RoleRepository(MovieDbContext ctx) : base(ctx)
        {
        }

        public override Role Read(int id)
        {
            return ctx.Roles.FirstOrDefault(t => t.RoleId == id);
        }

        public override void Update(Role item)
        {
            var old = Read(item.RoleId);
            foreach (var prop in old.GetType().GetProperties())
            {
                prop.SetValue(old, prop.GetValue(item));
            }
            ctx.SaveChanges();
        }
    }
}
