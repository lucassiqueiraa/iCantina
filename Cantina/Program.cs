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
                    var extra = new Extra { Id = 1, Descricao = "Sopa Espinafre", Preco = 0.50M , Ativo = true };
                    db.Extras.Add(extra);
                    db.SaveChanges();
                }


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
            

            
            }
        }
    }
