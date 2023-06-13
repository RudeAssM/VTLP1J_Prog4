using System.Collections.Generic;
using System.Linq;
using VTLP1J_Prog4.Logic.Classes;
using VTLP1J_Prog4.Models;

namespace VTLP1J_Prog4.Logic.Interfaces
{
    public interface IMovieLogic
    {
        void Create(Movie item);
        void Delete(int id);
        double? GetAverageRatePerYear(int year);
        Movie Read(int id);
        IQueryable<Movie> ReadAll();
        void Update(Movie item);
        IEnumerable<MovieLogic.YearInfo> YearStatistics();
    }
}