using System.Linq;
using VTLP1J_Prog4.Models;

namespace VTLP1J_Prog4.Logic.Interfaces
{
    public interface IDirectorLogic
    {
        void Create(Director item);
        void Delete(int id);
        Director Read(int id);
        IQueryable<Director> ReadAll();
        void Update(Director item);
    }
}