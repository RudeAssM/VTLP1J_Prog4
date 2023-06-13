using System.Linq;
using VTLP1J_Prog4.Models;
using VTLP1J_Prog4.Repository.Database;
using VTLP1J_Prog4.Repository.GenericRepository;
using VTLP1J_Prog4.Repository.Interfaces;

namespace VTLP1J_Prog4.Repository.ModelRepositories
{
    public class MovieRepository : Repository<Movie>, IRepository<Movie>
    {
        public MovieRepository(MovieDbContext ctx) : base(ctx)
        {
        }

        public override Movie Read(int id)
        {
            return ctx.Movies.FirstOrDefault(t => t.MovieId == id);
        }

        public override void Update(Movie item)
        {
            var old = Read(item.MovieId);
            foreach (var prop in old.GetType().GetProperties())
            {
                prop.SetValue(old, prop.GetValue(item));
            }
            ctx.SaveChanges();
        }
    }
}
