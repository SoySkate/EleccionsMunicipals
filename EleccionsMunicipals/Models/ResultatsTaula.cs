﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsMunicipals.Models
{
    public class ResultatsTaula
    {
        public long ID { get; set; }
        public int votsBlanc { get; set; }
        public int votsNul { get; set; }
        public List<VotsPerLlista> votsLlista { get; set; }
        public ResultatsTaula() { }
        public ResultatsTaula(int votsBlanc, int votsNul, List<VotsPerLlista> votsLlista)
        {
            this.votsBlanc = votsBlanc;
            this.votsNul = votsNul;
            this.votsLlista = votsLlista;
        }
        public string ImprimirResultatsTaula()
        {
            //imprimir la llista dels votsPartits i despres els blanc i els nul
            return "";
        }
    }
}
