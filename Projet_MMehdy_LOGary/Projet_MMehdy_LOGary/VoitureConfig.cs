using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_MMehdy_LOGary
{
    class VoitureConfig : Voiture
    {
        public int tailleJante { get; set; }
        public string typePhare { get; set; }
        public string kitCarrosserie { get; set; }

        public void AddVoitureHistorique()
        {
            //RequeteAjouteVoitureHistorique//
        }
    }
}
