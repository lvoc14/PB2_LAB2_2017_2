using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2lvoc14.Models
{
    public class Movimentacao
    {
        public int MovimentacaoId { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public decimal Valor { get; set; }
        public Conta Contas { get; set; }
    }
}