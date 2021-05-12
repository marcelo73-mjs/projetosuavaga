using Fja.Repository.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fja.Repository.Map
{
    public class MapeamentoCliente
    {
        public MapeamentoCliente(EntityTypeBuilder<Cliente> entitycliente) //Faz a associação da dos atributos da classe pessoa para os atributos do banco
        {
            entitycliente.HasKey(Cliente => Cliente.idCliente); // dizendo que ele possui uma chave
            
        }
    }
};
