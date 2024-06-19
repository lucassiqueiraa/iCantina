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

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

            }
        }
    }
