using Fja.Repository.Entity;
using Fja.Repository.Map;
using Microsoft.EntityFrameworkCore;


//Classe de contexto do repositorio para toda entidade que for criada registrar aqui
namespace Fja.Repository
{
    public class AppContext:DbContext
    {
        public AppContext(DbContextOptions<AppContext> opction)//opções do context
        {
        }
            protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            new MapeamentoCliente(model.Entity<Cliente>());
        }
        
    }
}
