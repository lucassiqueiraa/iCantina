using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Models
{
    public abstract class Cliente : Utilizador
    {
        public decimal Saldo { get; set; }
        ///<summary>
        ///Aqui será logo implementado a lógica para a base de dados.
        /// </summary>
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
