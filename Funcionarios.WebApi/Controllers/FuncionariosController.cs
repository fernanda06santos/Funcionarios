using Funcionarios.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Funcionarios.WebApi.Controllers
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
        [HttpOptions]
        [HttpPost]
        // POST: api/Funcionarios
        public void Post([FromBody]Funcionario.Entities.Funcionario value)
        {
            if (value != null) 
            Repositorio.Adicionar(value);
        }
        [Route("{id}")]
        [HttpOptions]
        [HttpPut]
        // PUT: api/Funcionarios/5
        public void Put(int id, [FromBody]Funcionario.Entities.Funcionario value)
        {
            if (value != null)
            {
                value.Id = id;
                Repositorio.Edit(value);
            }
           
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
