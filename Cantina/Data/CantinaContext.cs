    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Cantina.Models;

namespace Cantina.Data
{
    public class CantinaContext : DbContext
    {
        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Multa> Multas { get; set; }
        public DbSet<Fatura> Faturas { get; set; }
        public DbSet<ItemFatura> ItensFatura { get; set; }
        public DbSet<MenuDiario> MenusDiarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

            // Adicione esta configuração para a propriedade DataHora
            modelBuilder.Entity<Menu>()
                .Property(m => m.DataHora)
                .HasColumnType("datetime2");

            // Outras configurações...

            base.OnModelCreating(modelBuilder);
        }


    }

}
