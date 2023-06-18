using EleccionsMunicipals.Models;

namespace EleccionsMunicipals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void CrearTaules()
        {

        }
        public void PartitsPolítics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public List<Candidat> CrearCandidat()
        {
            Candidat nouCandidat = new Candidat();
            List<Candidat> LlistaCandidats = new List<Candidat>();
            if (textBoxCandidat != null)
            {
                nouCandidat.nomCandidat = textBoxCandidat.Text;
                Candidats.Items.Add(nouCandidat);
                LlistaCandidats.Add(nouCandidat);
                textBoxCandidat.Text = "";
                return LlistaCandidats;
            }

            return LlistaCandidats;
        }
        public void CrearPartitP(List<Candidat> LlistaCandidats)
        {
            string nomLlista;
            PartitMunicipi NouPartitPolitic = new PartitMunicipi();
            nomLlista = textBoxAfegirPartit.Text;
            NouPartitPolitic.nomPartit = nomLlista;
            PartitsPolítics.Items.Add(nomLlista);
            NouPartitPolitic.candidats = LlistaCandidats;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAfegirPartit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Candidats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAfegirPartitP_Click(object sender, EventArgs e)
        {
            CrearPartitP();
        }

        private void btnAfegirCandidat_Click(object sender, EventArgs e)
        {
            CrearCandidat();
        }
    }
}