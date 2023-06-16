using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsMunicipals.Models
{
    public class Candidat
    {
        public long ID { get; set; }
        public string nomCandidat { get; set; }
        public Candidat() { }
        public Candidat(string nomCandidat)
        {
            this.nomCandidat = nomCandidat;
        }
    }
}
