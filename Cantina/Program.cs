    using Cantina.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
    using System.Data.Entity;
    using Cantina.Data;


    namespace Cantina
    {
        internal static class Program
        {
       
            [STAThread]
            static void Main()
            {
                using (var db = new CantinaContext())
                {
                    var funcionario = new Funcionario { Id = 1, Nome = "Lucas Siqueira", NIF = 292692315, Username = "lucas" };
                    db.Funcionarios.Add(funcionario);
                    var prato = new Prato { Id = 1, Descricao = "Bacalhau á brás", Tipo = "Peixe", Ativo = true };
                    db.Pratos.Add(prato);
                    db.SaveChanges();
                }


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
            

            
            }
        }
    }
