using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Services;

namespace Winform.Forms
{
    public partial class Accueil : Form
    {
        UserService userService = new UserService();
        public Accueil()
        {
            //Check connected

            InitializeComponent();
        }

        private void deco_Click(object sender, EventArgs e)
        {
            userService.logout();
            new Login().Show();
            this.Hide();
        }

        private void creationMatch_Click(object sender, EventArgs e)
        {
            new CreationMatch(null).Show();

        }
    }
}
