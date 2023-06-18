using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsMunicipals.Models
{
    public class LlistaPartitMunicipi
    {
        public long ID { get; set; }
        public string nomPartit { get; set; }
        public List<Candidat> candidats { get; set; }
        //Poner el municipio aqui creo que no porque al crear el onjeto este debo crear otro municipio y no tiene sentido...
        //public Municipi municipi { get; set; }  
        public LlistaPartitMunicipi() { }
        public LlistaPartitMunicipi(string nomPartit, List<Candidat> candidats)
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
        //public string ImprimirNomPartitPolitic()
        //{
        //    return nomPartit;
        //}
    }
}
