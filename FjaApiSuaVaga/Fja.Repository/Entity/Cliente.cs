using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fja.Repository.Entity
{
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCliente { get; set; }
        public string  nome { get; set; }
        public string sobrenome { get; set; }
        public string  CPF { get; set; }
        public string  email { get; set; }
        public string  logradouro { get; set; }
        public string bairro { get; set; }
        public string CEP { get; set; }
        public Cidade cidade { get; set; }
        public int  numero { get; set; }
        public char bloco { get; set; }
        







    }
}
