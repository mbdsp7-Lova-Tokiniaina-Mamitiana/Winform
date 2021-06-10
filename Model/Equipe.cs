using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform.Model
{
    class Equipe
    {
        private string name, description, url_image;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Url_image { get => url_image; set => url_image = value; }
    }
}
