using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Models
{
    public class ItemFatura : Fatura
    {
        public int IdItem { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int FaturaId { get; set; }
        public virtual Fatura Fatura { get; set; }
    }
}
