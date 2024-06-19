using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Models
{
    public   class Cliente : Utilizador
    {
        public decimal Saldo { get; set; }
    
        public void AdicionarCredito(decimal valor)
        {
            Saldo += valor;
        }
        public bool DeduzirCredito(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false; // Se saldo insuficiente
        }

    }
}
