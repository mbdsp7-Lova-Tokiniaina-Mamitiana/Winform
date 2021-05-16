using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform.Model
{
    class User
    {
        private string login, password, email, role;

        public User(string login, string password, string email, string role)
        {
            this.login = login;
            this.password = password;
            this.email = email;
            this.role = role;
        }


        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Role { get => role; set => role = value; }
    }
}
