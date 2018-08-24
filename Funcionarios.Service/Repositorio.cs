using Funcionarios.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.Service
{
    public abstract class Repositorio<T> where T : class
    {
        protected FuncionariosContext Context = new FuncionariosContext();
   
       

        public List<T> Listar()
        {
            return Context.Set<T>().ToList();
        }

        public List<T> Listar(Expression<Func<T,bool>> filtro)
        {
            return Context.Set<T>().Where(filtro).ToList();
        }

        public T BuscarPorId(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public virtual T Adicionar(T objeto)
        {
            Context.Entry<T>(objeto).State = EntityState.Added;
            Context.SaveChanges();
            return objeto;
        }

        public void Delete(T obj)
        {
            var value = BuscarPorId(((dynamic) obj).Id);
            Context.Set<T>().Remove(value);
            Context.SaveChanges();
        }

        public virtual T Edit(T obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
            Context.SaveChanges();

            return obj;
            
        }
    }
}
