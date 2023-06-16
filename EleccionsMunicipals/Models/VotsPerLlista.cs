using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsMunicipals.Models
{
    public class VotsPerLlista
    {
        public long ID { get; set; }
        public int numeroVotsLlista { get; set; }

        public VotsPerLlista(int numeroVotsLlista) {
            this.numeroVotsLlista = numeroVotsLlista;
        }
    }
}
