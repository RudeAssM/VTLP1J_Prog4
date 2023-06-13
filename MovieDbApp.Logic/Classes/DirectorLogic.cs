using System.Linq;
using VTLP1J_Prog4.Logic.Interfaces;
using VTLP1J_Prog4.Models;
using VTLP1J_Prog4.Repository.Interfaces;

namespace VTLP1J_Prog4.Logic.Classes
{
    public class DirectorLogic : IDirectorLogic
    {
        IRepository<Director> repo;

        public DirectorLogic(IRepository<Director> repo)
        {
            this.repo = repo;
        }

        public void Create(Director item)
        {
            this.repo.Create(item);
        }

        public void Delete(int id)
        {
            this.repo.Delete(id);
        }

        public Director Read(int id)
        {
            return this.repo.Read(id);
        }

        public IQueryable<Director> ReadAll()
        {
            return this.repo.ReadAll();
        }

        public void Update(Director item)
        {
            this.repo.Update(item);
        }
    }
}
