using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VTLP1J_Prog4.Logic.Interfaces;
using VTLP1J_Prog4.Models;

namespace VTLP1J_Prog4.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        IRoleLogic logic;
        public RoleController(IRoleLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public IEnumerable<Role> ReadAll()
        {
            return this.logic.ReadAll();
        }

        [HttpGet("{id}")]
        public Role Read(int id)
        {
            return this.logic.Read(id);
        }

        [HttpPost]
        public void Create([FromBody] Role value)
        {
            this.logic.Create(value);
        }

        [HttpPut]
        public void Put([FromBody] Role value)
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
