using EleccionsMunicipals.Models;
using Microsoft.VisualBasic;

namespace EleccionsMunicipals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EleccionsContext ContextEleccions = new EleccionsContext();
        //Aquestes llistes poden ser remplaçades per la del dbcontext.
        public List<Candidat> LlistaCandidats = new List<Candidat>();
        public List<PartitMunicipi> LlistaPartits = new List<PartitMunicipi>();
        public List<TaulaElectoral> LlistaTaulesElectorals = new List<TaulaElectoral>();
        public List<Municipi> LlistaMunicipis = new List<Municipi>();
        //Si faig un MunicipiStatic i li cambio el valor cada cop que apreti el crear un nou municipi?
        //I per guardar les dades tinc un boto on guardara les dades que hi han alla al municipistatic 

        static Municipi MainMunicipi;

        private void label1_Click(object sender, EventArgs e)
        {

        }






        //________________________________________________________________________________________________________
        public bool ValidarCampsCrearPartit()
        {
            bool validar = false;
            int regidors;

            if (textBoxNomMunicipi.Text != "")
            {
                if (textBoxNumRegidors.Text != "")
                {
                    int num;
                    try
                    {
                        num = int.Parse(textBoxNumRegidors.Text);
                        regidors = num;
                        if (textBoxAfegirPartit.Text != "")
                        {
                            int num2 = 0;
                            try
                            {
                                num2 = int.Parse(textBoxAfegirPartit.Text);
                                if (num2 > 0)
                                {
                                    MessageBox.Show("El nom del Partit no poden ser números."); return validar;
                                }
                            }
                            catch
                            {
                                if (regidors == Candidats.Items.Count) { return validar = true; }
                                else
                                {
                                    MessageBox.Show("Han d'haver tants candidats com número de regidors."); return validar;
                                }
                            }

                        }
                        else { MessageBox.Show("Has d'introduir un nom al camp (Nou Partit)"); }
                    }
                    catch
                    {
                        num = 0; MessageBox.Show("Has d'introduïr un número enter al Número de Regidors!"); return validar = false;
                    }

                }
                else { MessageBox.Show("Has d'introduïr el número de Regidors del Municipi!"); }
            }
            else { MessageBox.Show("Has d'introduïr el nom del Municipi!"); }
            return validar;

        }
        public bool ValidarCampsCrearTaula()
        {
            bool final = false;
            //bool comprobar1 = false;
            bool comprobar2 = false;
            int cens;

            //bool comprobarstring;
            //int option;
            //comprobarstring = int.TryParse(textBoxNomTaula.Text, out option);

            //TODO: NomTaula. El nom Taula pot ser amb numeros i lletres.
            try { cens = int.Parse(textBoxCensTaula.Text); comprobar2 = true; }
            catch
            {
                cens = 0;
                MessageBox.Show("Has d'introduïr un número enter per el camp (Cens)");
            }
            if (comprobar2 == true)
            {
                final = true;
                return final;
            }
            return final;
        }
        public void PartitsPolítics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void EntrarDadesDBMunicipi(Municipi nouMunicipi)
        {
            ContextEleccions.Municipis.Add(nouMunicipi);
            ContextEleccions.SaveChanges();
        }
        public void CrearCandidat()
        {
            Candidat nouCandidat = new Candidat();
            string textCandidat = textBoxCandidat.Text;
            bool comprobar;
            int option;
            comprobar = int.TryParse(textCandidat, out option);


            if (textCandidat != "" && comprobar == false)
            {
                nouCandidat.nomCandidat = textBoxCandidat.Text;
                Candidats.Items.Add("- " + nouCandidat.ImprimirCandidat());
                LlistaCandidats.Add(nouCandidat);
                textBoxCandidat.Text = "";
            }
            else { MessageBox.Show("El text és buit o has introduit un número en comptes de lletres!"); }
        }
        //Li passo el boolean de la funció validar per veure si l ha de crear o no el PartitPolític
        public void CrearPartitP(List<Candidat> LlistaCandidats, bool validar)
        {
            string nomLlista;
            PartitMunicipi NouPartitPolitic = new PartitMunicipi();
            if (validar == true)
            {
                nomLlista = textBoxAfegirPartit.Text;
                NouPartitPolitic.nomPartit = nomLlista;
                PartitsPolítics.Items.Add("- " + nomLlista);
                //afegir data a la class (emmagatzemada de forma independent)
                NouPartitPolitic.candidats = LlistaCandidats;
                //Esborrar data per tornar a utilitzar les llistes
                textBoxAfegirPartit.Text = "";
                Candidats.Items.Clear();
                LlistaCandidats.Clear();

                LlistaPartits.Add(NouPartitPolitic);

                //TODO: Falta meter el objeto en el dataset(queda en memoria demomento) y al finalizar el municipio
                //Si meteria ya el municipio con todos estos objetos en el dataset.
            }
        }
        public void CrearTaulaMunicipi(bool validar)
        {
            if (validar == true)
            {
                string nomT = textBoxNomTaula.Text;
                int cens = int.Parse(textBoxCensTaula.Text);
                TaulaElectoral novaTaula = new TaulaElectoral();
                novaTaula.nomTaula = nomT;
                novaTaula.censTaula = cens;
                //afegir dades taula a la llista i a la listbox
                LlistaTaulesElectorals.Add(novaTaula);
                Taules.Items.Add(novaTaula.ImprimirNomICensTaula());
                //removeDades dels textBox
                textBoxNomTaula.Text = "";
                textBoxCensTaula.Text = "";
            }
        }

        public Municipi crearMunicipi()
        {
            Municipi nouMunicipi = new Municipi();
            nouMunicipi.nomMunicipi = textBoxNomMunicipi.Text;
            nouMunicipi.numeroRegidors = int.Parse(textBoxNumRegidors.Text);
            nouMunicipi.llistaPartits = LlistaPartits;
            nouMunicipi.taulesElectorals = LlistaTaulesElectorals;
            //un cop afegides les dades a la class ho posem el municipi a la listbox i borrem les dades
            //de les llistes anteriors per poder reutilitzar-les. I de les altre listbox excepte la del municipi.
            LlistaMunicipis.Add(nouMunicipi);
            Municipis.Items.Add(nouMunicipi.ImprimirDatosMunicipio());
            //TODO:CLEAR dades de lo que es tornarà a utilitzar
            //removeDatosDe les listbox i les public lists d'adalts excepte la de municipi
            //lisbox Clear()
            Taules.Items.Clear();
            PartitsPolítics.Items.Clear();
            textBoxNomMunicipi.Text = "";
            textBoxNumRegidors.Text = "";
            //LlistaCandidats,LlistaPartits, LlistaTaulesElectorals .Clear()
            LlistaCandidats.Clear();
            LlistaPartits.Clear();
            LlistaTaulesElectorals.Clear();
            return nouMunicipi;
        }

        public void MostrarPanels()
        {
            panelGeneral.Show();
            panelSuperior.Show();
            panelInferior.Show();

        }

        //al crear el municipi he d'esborrar totes les dades visuals excepte la del municipi i les de les
        //llistes publiques que utilitzo.
        public void EliminarCandidatLlista()
        {
            int index = Candidats.SelectedIndex;
            Candidats.Items.RemoveAt(index);
            LlistaCandidats.RemoveAt(index);
        }
        public void EliminarPartitLlista()
        {
            int index = PartitsPolítics.SelectedIndex;
            PartitsPolítics.Items.RemoveAt(index);
            LlistaPartits.RemoveAt(index);
        }
        public void EliminarTaulaLlista()
        {
            int index = Taules.SelectedIndex;
            Taules.Items.RemoveAt(index);
            LlistaTaulesElectorals.RemoveAt(index);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarPanels();

        }

        private void textBoxAfegirPartit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Candidats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAfegirCandidat_Click(object sender, EventArgs e)
        {

        }
        private void btnAfegirPartitP_Click(object sender, EventArgs e)
        {
            //ValidarCampsCrearPartit() em torna un bool per saber si es pot crear o no el Partit.
            CrearPartitP(LlistaCandidats, ValidarCampsCrearPartit());
        }

        private void textBoxNomMunicipi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarCandidat_Click(object sender, EventArgs e)
        {
    
        }

        private void btnEliminarPartit_Click(object sender, EventArgs e)
        {
            EliminarPartitLlista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAfegirTaula_Click(object sender, EventArgs e)
        {
            CrearTaulaMunicipi(ValidarCampsCrearTaula());
        }

        private void btnEliminarTaula_Click(object sender, EventArgs e)
        {
            EliminarTaulaLlista();
        }

        private void panelGeneral_Paint(object sender, PaintEventArgs e)
        {

        }
        public void CreacioMunicipi()
        {//TODO: LLEGIR!!! Estaba pensant de fer el mateix pero la estructura ha de ser diferent perque
            //ho he fet bé pero del reves osigui que estic intentant canviar l'estructura. 
            //Aquesta funcio crida les altres per crear un municipi. ESTA A MITGES TOTTT ;))))
            //---sE M HAN DUPLICAT ELS BOTONS AIXI QUE TENE NOMS DIFERENETS PER AIXO NO M HO AGAFA.
            //EN COMPTES DE CREAR DE SUBCLASE A SUPER CLASS 
            //CREAR SUPER CLASS I ANAR POSANT DADES DE SUBCLASES CREADES
            AfegirNomMunicipi();
            AfegirRegidorsMunicipi();
        }
        public void AfegirNomMunicipi()
        {
            try { MainMunicipi.nomMunicipi = textBoxNomMunicipi.Text;
               
            }
            catch { MessageBox.Show("Has dintroduir el nom del Municipi."); }
        }
        public void AfegirRegidorsMunicipi()
        {
            try { MainMunicipi.numeroRegidors = int.Parse(textBoxNumRegidors.Text); } catch { MessageBox.Show("Valor incorrecte de Regidors (Recordi: numeros enters)"); }
        }
        public void crearMainMunicipi()
        {
            MainMunicipi = new Municipi();
        }
        public void CarregarDadesMunicipi()
        {
            foreach (Municipi municipi in ContextEleccions.Municipis)
            {
                Municipis.Items.Add(municipi.nomMunicipi);
            }
        }

        private void btnCarregarDades_Click(object sender, EventArgs e)
        {
            panelMunicipis.Show();
            CarregarDadesMunicipi();
        }

        private void btnGuardarDades_Click(object sender, EventArgs e)
        {
            EntrarDadesDBMunicipi(crearMunicipi());
        }

        private void panelInferior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAfegirCandidat_Click_1(object sender, EventArgs e)
        {
            CrearCandidat();
        }

        private void btnEliminarCandidat_Click_1(object sender, EventArgs e)
        {
            EliminarCandidatLlista();
        }
    }
}