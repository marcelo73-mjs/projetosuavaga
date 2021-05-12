using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fja.Repository.Entity
{
    public class Cidade
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Estou dizendo que no banco ele é identity
        public int idCidade { get; set; }
        public string nome { get; set; }
        public char UF { get; set; }
    }
}
