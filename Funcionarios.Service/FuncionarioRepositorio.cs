using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funcionario.Entities;

namespace Funcionarios.Service
{
  public  class FuncionarioRepositorio : Repositorio<Funcionario.Entities.Funcionario>
    {
        public override Funcionario.Entities.Funcionario Adicionar(Funcionario.Entities.Funcionario objeto)
        {
            var repoContatos = new ContatosRepositorio();
            var contatos = new List<Contato>(); 
            foreach (var item in objeto.Contatos)
            {
               contatos.Add(repoContatos.Adicionar(item));
            }
            objeto.Contatos.Clear();
            objeto.Contatos.AddRange(contatos);
            return base.Adicionar(objeto);
        }

        public override Funcionario.Entities.Funcionario Edit(Funcionario.Entities.Funcionario objeto)
        {
            var repoContatos = new ContatosRepositorio();
            var contatos = new List<Contato>();
            foreach (var item in objeto.Contatos)
            {
                if (item.Id != 0) { 
                contatos.Add(repoContatos.Edit(item));
                }
                else
                {
                contatos.Add(repoContatos.Adicionar(item));
                }
            }
            objeto.Contatos.Clear();
            objeto.Contatos.AddRange(contatos);
            return base.Edit(objeto);
        }
    }
}
