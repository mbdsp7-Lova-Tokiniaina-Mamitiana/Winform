using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform.Model
{
    public class Pari
    {
        private String id;
        private String description;
        private Double cote;

        public string Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public double Cote { get => cote; set => cote = value; }
    }
}
