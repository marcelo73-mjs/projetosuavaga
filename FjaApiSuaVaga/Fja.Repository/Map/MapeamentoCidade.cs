using Fja.Repository.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fja.Repository.Map
{
    public class MapeamentoCidade 
    {
        public MapeamentoCidade(EntityTypeBuilder<Cidade> entityCidade)
        {
            entityCidade.HasKey(Cidade => Cidade.idCidade);
        }
    }
}
