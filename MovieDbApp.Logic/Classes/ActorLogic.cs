using System.Linq;
using VTLP1J_Prog4.Logic.Interfaces;
using VTLP1J_Prog4.Models;
using VTLP1J_Prog4.Repository.Interfaces;

namespace VTLP1J_Prog4.Logic.Classes
{
    public class ActorLogic : IActorLogic
    {
        IRepository<Actor> repo;

        public ActorLogic(IRepository<Actor> repo)
        {
            this.repo = repo;
        }

        public void Create(Actor item)
        {
            this.repo.Create(item);
        }

        public void Delete(int id)
        {
            this.repo.Delete(id);
        }

        public Actor Read(int id)
        {
            return this.repo.Read(id);
        }

        public IQueryable<Actor> ReadAll()
        {
            return this.repo.ReadAll();
        }

        public void Update(Actor item)
        {
            this.repo.Update(item);
        }
    }
}
