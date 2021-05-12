using Fja.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fja.Repository
{ //Esse Repository Base vai receber um objeto generico(Cliente(TEntity) e pega o mesmo obj da interface e tem que ser uma class
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        //DbSet É resposável por ser uma entidade, ou seja qualquer entidade do banco que a gente mapeou 
        private DbSet<TEntity> _entidades;
        private readonly AppContext _context;
        public RepositoryBase(AppContext context)
        {
            _context = context;
            _entidades = context.Set<TEntity>(); //Dando vida a entidade(classe)
        }

        public TEntity Get(int id)
        {
            return _entidades.Find(id); //Montando o select atravez do id,(O EntityFrameworkCore Faz isso, vai em cada coluna ) ele retorna uma entidade definida por parametro (id)
        }

        public IEnumerable<TEntity> GetAll()
        {   // IQueryable é um link do .Net, ele transforma esse resultado em uma lista e devolve para o GetALl que é O Enumerable
            IQueryable<TEntity> query = _entidades;    //permite executar query dentro da variavel (sem filtro ) posso colocar um filtro
            return query.ToList();
        }

        public void Insert(TEntity entidade)
        {
            _entidades.Add(entidade);
            _context.SaveChanges(); //Salve as mudanças que fiz no meu contexto, depois disso ele vai e faz o comit no banco
        }

        public void Updade(TEntity entidade)
        {
            _entidades.Update(entidade);
            _context.SaveChanges();
        }

        public void Delete(TEntity entidade)
        {
            _entidades.Remove(entidade);
            _context.SaveChanges();

        }
    }
}
