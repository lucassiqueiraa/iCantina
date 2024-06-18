using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int MenuId { get; set; }
        public virtual Menu Menu { get; set; }
        public bool Utilizada { get; set; }
        public virtual ICollection<Multa> Multas { get; set; }
    }
}
