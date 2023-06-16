using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsMunicipals.Models
{
    public class PartitPolitic
    {
        public long ID { get; set; }
        public string nomPartit { get; set; }
        public List<string> candidats { get; set; }

        public PartitPolitic(string nomPartit, List<string> candidats)
        {
            this.nomPartit = nomPartit;
            this.candidats = candidats;
        }
        //public string ImprimirCandidats()
        //{
            
        //    if (candidats.Count != 0) { 
        //        //MIRAR AQUESTA FUNCIO RARA
        //        foreach (var candidat in candidats)
        //        {
        //           candidat;
        //        }
        //    }
        //}
        public string ImprimirNomPartitPolitic()
        {
            return nomPartit;
        }
    }
}
