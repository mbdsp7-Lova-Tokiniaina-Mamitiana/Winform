using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform.Model
{
    class Equipe
    {
        private string id,nom, avatar;

        public string Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Avatar { get => avatar; set => avatar = value; }
    }
}
