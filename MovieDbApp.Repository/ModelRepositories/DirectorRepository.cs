using System.Linq;
using VTLP1J_Prog4.Models;
using VTLP1J_Prog4.Repository.Database;
using VTLP1J_Prog4.Repository.GenericRepository;
using VTLP1J_Prog4.Repository.Interfaces;

namespace VTLP1J_Prog4.Repository.ModelRepositories
{
    public class DirectorRepository : Repository<Director>, IRepository<Director>
    {
        public DirectorRepository(MovieDbContext ctx) : base(ctx)
        {
        }

        public override Director Read(int id)
        {
            return ctx.Directors.FirstOrDefault(t => t.DirectorId == id);
        }

        public override void Update(Director item)
        {
            var old = Read(item.DirectorId);
            foreach (var prop in old.GetType().GetProperties())
            {
                prop.SetValue(old, prop.GetValue(item));
            }
            ctx.SaveChanges();
        }
    }
}
