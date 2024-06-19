using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Models
{
    public class Prato
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
