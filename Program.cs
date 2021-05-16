using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Forms;
using Winform.Services;

namespace Winform
{
    static class Program
    {
        static UserService userService = new UserService();

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            String token = userService.getStorageToken();
            if (!string.IsNullOrEmpty(token))
            {
                UserService.token = token;
                
                Application.Run(new Accueil());

            }
            else
            {
                if (UserService.token != null)
                {
                    Application.Run(new Accueil());
                }
                else
                {
                    Application.Run(new Login());
                }
            }

        }
    }
}
