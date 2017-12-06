using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2lvoc14.Models
{
    public class Conta
    {
        public int ContaId { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public bool Situacao { get; set; }
        public List<Movimentacao> Movimentacoes { get; set; }
        public List<Pessoa> Pessoas { get; set; }
        public List<TipoConta>TiposConta { get; set; }
    }
}