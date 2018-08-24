using Funcionarios.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Funcionarios.Controllers
{
    [RoutePrefix("api/funcionarios")]
    [AllowAnonymous]
    public class FuncionariosController : ApiController
    {
        public FuncionarioRepositorio Repositorio => new FuncionarioRepositorio();

        [Route("")]
        // GET: api/Funcionarios
        [HttpGet]
        public IEnumerable<Funcionario.Entities.Funcionario> Get()
        {
            return Repositorio.Listar();
        }

        [Route("{id}")]
        [HttpGet]
        // GET: api/Funcionarios/5
        public Funcionario.Entities.Funcionario Get(int id)
        {
            return Repositorio.BuscarPorId(id);
        }

        [Route("")]
        [HttpPost]
        // POST: api/Funcionarios
        public void Post([FromBody]Funcionario.Entities.Funcionario value)
        {
            Repositorio.Adicionar(value);
        }

        // PUT: api/Funcionarios/5
        public void Put(int id, [FromBody]string value)
        {
        }

        [Route("{id}")]
        [HttpDelete]
        // DELETE: api/Funcionarios/5
        public void Delete(int id)
        {
            var Func = Repositorio.BuscarPorId(id);
            Repositorio.Delete(Func);
        }
    }
}
