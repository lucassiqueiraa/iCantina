using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Importe este namespace para usar o atributo [Key]

namespace Cantina.Models
{
    public class Fatura
    {
        [Key] // Isto define IdFatura como a chave primária
        public int IdFatura { get; set; }
        public DateTime DataHora { get; set; }
        public decimal Total { get; set; }
        public virtual ICollection<ItemFatura> Itens { get; set; }
    }
}
