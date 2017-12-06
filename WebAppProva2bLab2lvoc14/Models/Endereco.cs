using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2lvoc14.Models
{
    public class Endereco
    {
        
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
        public List<Pessoa> Pessoa { get; set; }


    }
}