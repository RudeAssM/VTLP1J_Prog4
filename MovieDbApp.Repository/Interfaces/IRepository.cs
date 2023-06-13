using System.Linq;

namespace VTLP1J_Prog4.Repository.Interfaces
{
	public interface IRepository<T> where T : class
	{
		IQueryable<T> ReadAll();
		T Read(int id);
		void Create(T item);
		void Update(T item);
		void Delete(int id);
	}

}
