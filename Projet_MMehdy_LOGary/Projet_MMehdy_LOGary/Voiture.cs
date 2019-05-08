using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_MMehdy_LOGary
{
    abstract class Voiture
    {
        public string peinture { get; set; }
        public string carburant { get; set; }
        public int cynlindre { get; set; }
        public string carosserie { get; set; }
        public float prix { get; set; }
        public int puissance { get; set; }
    }
}
