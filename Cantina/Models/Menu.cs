using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int QtdDisponivel { get; set; }
        public decimal PrecoEstudante { get; set; }
        public decimal PrecoProfessor { get; set; }
        public virtual ICollection<Prato> Pratos { get; set; }
        public virtual ICollection<Extra> Extras { get; set; }
    }
}
