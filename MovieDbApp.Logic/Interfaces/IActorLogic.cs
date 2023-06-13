using System.Linq;
using VTLP1J_Prog4.Models;

namespace VTLP1J_Prog4.Logic.Interfaces
{
    public interface IActorLogic
    {
        void Create(Actor item);
        void Delete(int id);
        Actor Read(int id);
        IQueryable<Actor> ReadAll();
        void Update(Actor item);
    }
}