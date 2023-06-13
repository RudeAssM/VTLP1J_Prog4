using System.Linq;
using VTLP1J_Prog4.Logic.Interfaces;
using VTLP1J_Prog4.Models;
using VTLP1J_Prog4.Repository.Interfaces;

namespace VTLP1J_Prog4.Logic.Classes
{
    public class RoleLogic : IRoleLogic
    {
        IRepository<Role> repo;

        public RoleLogic(IRepository<Role> repo)
        {
            this.repo = repo;
        }

        public void Create(Role item)
        {
            this.repo.Create(item);
        }

        public void Delete(int id)
        {
            this.repo.Delete(id);
        }

        public Role Read(int id)
        {
            return this.repo.Read(id);
        }

        public IQueryable<Role> ReadAll()
        {
            return this.repo.ReadAll();
        }

        public void Update(Role item)
        {
            this.repo.Update(item);
        }
    }
}
