using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VTLP1J_Prog4.Logic.Interfaces;
using VTLP1J_Prog4.Models;

namespace VTLP1J_Prog4.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        IMovieLogic logic;

        public MovieController(IMovieLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public IEnumerable<Movie> ReadAll()
        {
            return this.logic.ReadAll();
        }

        [HttpGet("{id}")]
        public Movie Read(int id)
        {
            return this.logic.Read(id);
        }

        [HttpPost]
        public void Create([FromBody] Movie value)
        {
            this.logic.Create(value);
        }

        [HttpPut]
        public void Update([FromBody] Movie value)
        {
            this.logic.Update(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.logic.Delete(id);
        }
    }
}
