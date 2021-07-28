using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Forms;
using Winform.Model;
using Winform.Services;

namespace Winform
{
    public partial class Login : Form
    {
        private UserService userService = new UserService();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = this.textLogin.Text;
            string password = this.textPassword.Text;
            try
            {
                User user = userService.login(login, password);
                if (this.checkBox1.Checked)
                {
                    userService.saveToken();
                    
                }
                new Accueil().Show();
                this.Hide();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
