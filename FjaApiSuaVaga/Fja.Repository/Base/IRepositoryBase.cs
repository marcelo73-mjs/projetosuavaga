using System.Collections.Generic;

namespace Fja.Repository.Base
{  //Interface base(tipado gereniramente) para todas as entidades do banco
    public interface IRepositoryBase<TEntidade>
    {
        TEntidade Get(int id);

        //Herda linkedList, mais leve e podemos fazer muitas operacoes de consulta, permite que todos os membros sejam numerados
        IEnumerable<TEntidade> GetAll();
        void Insert(TEntidade entidade); //Monta sem precisar inserir um insert de ddl
        void Updade(TEntidade entidade);
        void Delete(TEntidade entidade);
    }
}
