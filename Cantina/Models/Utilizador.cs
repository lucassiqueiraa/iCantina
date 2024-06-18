    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Models
{
    public abstract class Utilizador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NIF { get; set; }
        public bool Ativo { get; set; } = true; //Padrão do campo será sempre ativo  
    }
}
