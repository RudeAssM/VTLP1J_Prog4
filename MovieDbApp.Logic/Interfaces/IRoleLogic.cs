using System.Linq;
using VTLP1J_Prog4.Models;

namespace VTLP1J_Prog4.Logic.Interfaces
{
    public interface IRoleLogic
    {
        void Create(Role item);
        void Delete(int id);
        Role Read(int id);
        IQueryable<Role> ReadAll();
        void Update(Role item);
    }
}