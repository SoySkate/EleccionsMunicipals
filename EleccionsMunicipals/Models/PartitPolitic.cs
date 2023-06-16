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
        public List<Candidat> candidats { get; set; }
        public PartitPolitic() { }
        public PartitPolitic(string nomPartit, List<Candidat> candidats)
        {
            this.nomPartit = nomPartit;
            this.candidats = candidats;
        }
        //TODO: Se debe hacer en otro sitio la impresion de la lista.No en la funcion de aqui.
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
