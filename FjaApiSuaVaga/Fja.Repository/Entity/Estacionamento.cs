using System;
using System.Collections.Generic;
using System.Text;

namespace Fja.Repository.Entity
{ 
    public class Estacionamento
    {
        public int idEstacionamento { get; set; }
        public string nome { get; set; }
        public string  email { get; set; }
        public string  logradouro { get; set; }
        public string  bairro { get; set; }
        public string  numero { get; set; }
        public string CEP { get; set; }
        public Cidade  cidade { get; set; }

    }
}
