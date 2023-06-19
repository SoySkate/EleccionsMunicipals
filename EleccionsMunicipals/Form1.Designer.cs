namespace EleccionsMunicipals
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCrearMunicipi = new Button();
            label3 = new Label();
            textBoxNomMunicipi = new TextBox();
            label4 = new Label();
            textBoxNumRegidors = new TextBox();
            label1 = new Label();
            Municipis = new ListBox();
            labelMunicipis = new Label();
            btnCarregarDades = new Button();
            panelSuperior = new Panel();
            btnGuardarDades = new Button();
            panelMunicipis = new Panel();
            panelGeneral = new Panel();
            labelCandidats = new Label();
            PartitsPolítics = new ListBox();
            Candidats = new ListBox();
            Taules = new ListBox();
            labelTaules = new Label();
            labelPartits = new Label();
            btnEliminarTaula = new Button();
            btnAfegirTaula = new Button();
            labelCensTaula = new Label();
            textBoxCensTaula = new TextBox();
            btnAfegirPartitP = new Button();
            labelNomTaula = new Label();
            textBoxAfegirPartit = new TextBox();
            textBoxNomTaula = new TextBox();
            label5 = new Label();
            textBoxCandidat = new TextBox();
            label6 = new Label();
            btnAfegirCandidat = new Button();
            btnEliminarCandidat = new Button();
            btnEliminarPartit = new Button();
            panelInferior = new Panel();
            panelSuperior.SuspendLayout();
            panelMunicipis.SuspendLayout();
            panelGeneral.SuspendLayout();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrearMunicipi
            // 
            btnCrearMunicipi.Location = new Point(81, 317);
            btnCrearMunicipi.Name = "btnCrearMunicipi";
            btnCrearMunicipi.Size = new Size(100, 23);
            btnCrearMunicipi.TabIndex = 1;
            btnCrearMunicipi.Text = "CrearMunicipi";
            btnCrearMunicipi.UseVisualStyleBackColor = true;
            btnCrearMunicipi.UseWaitCursor = true;
            btnCrearMunicipi.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 15);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 3;
            label3.Text = "Nom del Municipi:";
            label3.UseWaitCursor = true;
            // 
            // textBoxNomMunicipi
            // 
            textBoxNomMunicipi.Location = new Point(136, 12);
            textBoxNomMunicipi.Margin = new Padding(3, 2, 3, 2);
            textBoxNomMunicipi.Name = "textBoxNomMunicipi";
            textBoxNomMunicipi.Size = new Size(160, 23);
            textBoxNomMunicipi.TabIndex = 4;
            textBoxNomMunicipi.UseWaitCursor = true;
            textBoxNomMunicipi.TextChanged += textBoxNomMunicipi_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 15);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 5;
            label4.Text = "Número de Regidors:";
            label4.UseWaitCursor = true;
            // 
            // textBoxNumRegidors
            // 
            textBoxNumRegidors.Location = new Point(427, 12);
            textBoxNumRegidors.Margin = new Padding(3, 2, 3, 2);
            textBoxNumRegidors.Name = "textBoxNumRegidors";
            textBoxNumRegidors.Size = new Size(71, 23);
            textBoxNumRegidors.TabIndex = 6;
            textBoxNumRegidors.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 75);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 10;
            label1.UseWaitCursor = true;
            // 
            // Municipis
            // 
            Municipis.FormattingEnabled = true;
            Municipis.ItemHeight = 15;
            Municipis.Location = new Point(19, 23);
            Municipis.Margin = new Padding(3, 2, 3, 2);
            Municipis.Name = "Municipis";
            Municipis.Size = new Size(221, 289);
            Municipis.TabIndex = 18;
            Municipis.UseWaitCursor = true;
            // 
            // labelMunicipis
            // 
            labelMunicipis.AutoSize = true;
            labelMunicipis.Location = new Point(100, 0);
            labelMunicipis.Name = "labelMunicipis";
            labelMunicipis.Size = new Size(59, 15);
            labelMunicipis.TabIndex = 22;
            labelMunicipis.Text = "Municipis";
            labelMunicipis.UseWaitCursor = true;
            // 
            // btnCarregarDades
            // 
            btnCarregarDades.Location = new Point(826, 21);
            btnCarregarDades.Name = "btnCarregarDades";
            btnCarregarDades.Size = new Size(100, 23);
            btnCarregarDades.TabIndex = 31;
            btnCarregarDades.Text = "CarregarDades";
            btnCarregarDades.UseVisualStyleBackColor = true;
            btnCarregarDades.UseWaitCursor = true;
            btnCarregarDades.Click += btnCarregarDades_Click;
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(btnGuardarDades);
            panelSuperior.Controls.Add(label4);
            panelSuperior.Controls.Add(label3);
            panelSuperior.Controls.Add(textBoxNomMunicipi);
            panelSuperior.Controls.Add(textBoxNumRegidors);
            panelSuperior.Location = new Point(12, 14);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(727, 55);
            panelSuperior.TabIndex = 33;
            panelSuperior.UseWaitCursor = true;
            panelSuperior.Visible = false;
            // 
            // btnGuardarDades
            // 
            btnGuardarDades.BackColor = Color.LimeGreen;
            btnGuardarDades.ForeColor = SystemColors.Desktop;
            btnGuardarDades.Location = new Point(573, 15);
            btnGuardarDades.Name = "btnGuardarDades";
            btnGuardarDades.Size = new Size(100, 23);
            btnGuardarDades.TabIndex = 36;
            btnGuardarDades.Text = "GuardarDades";
            btnGuardarDades.UseVisualStyleBackColor = false;
            btnGuardarDades.UseWaitCursor = true;
            btnGuardarDades.Click += btnGuardarDades_Click;
            // 
            // panelMunicipis
            // 
            panelMunicipis.Controls.Add(Municipis);
            panelMunicipis.Controls.Add(btnCrearMunicipi);
            panelMunicipis.Controls.Add(labelMunicipis);
            panelMunicipis.Location = new Point(767, 75);
            panelMunicipis.Name = "panelMunicipis";
            panelMunicipis.Size = new Size(255, 355);
            panelMunicipis.TabIndex = 34;
            panelMunicipis.UseWaitCursor = true;
            panelMunicipis.Visible = false;
            // 
            // panelGeneral
            // 
            panelGeneral.Controls.Add(labelCandidats);
            panelGeneral.Controls.Add(PartitsPolítics);
            panelGeneral.Controls.Add(Candidats);
            panelGeneral.Controls.Add(Taules);
            panelGeneral.Controls.Add(labelTaules);
            panelGeneral.Controls.Add(labelPartits);
            panelGeneral.Location = new Point(12, 75);
            panelGeneral.Name = "panelGeneral";
            panelGeneral.Size = new Size(749, 277);
            panelGeneral.TabIndex = 35;
            panelGeneral.UseWaitCursor = true;
            panelGeneral.Visible = false;
            panelGeneral.Paint += panelGeneral_Paint;
            // 
            // labelCandidats
            // 
            labelCandidats.AutoSize = true;
            labelCandidats.Location = new Point(74, 0);
            labelCandidats.Name = "labelCandidats";
            labelCandidats.Size = new Size(60, 15);
            labelCandidats.TabIndex = 19;
            labelCandidats.Text = "Candidats";
            labelCandidats.UseWaitCursor = true;
            // 
            // PartitsPolítics
            // 
            PartitsPolítics.FormattingEnabled = true;
            PartitsPolítics.ItemHeight = 15;
            PartitsPolítics.Location = new Point(261, 23);
            PartitsPolítics.Margin = new Padding(3, 2, 3, 2);
            PartitsPolítics.Name = "PartitsPolítics";
            PartitsPolítics.Size = new Size(186, 244);
            PartitsPolítics.TabIndex = 7;
            PartitsPolítics.UseWaitCursor = true;
            // 
            // Candidats
            // 
            Candidats.FormattingEnabled = true;
            Candidats.ItemHeight = 15;
            Candidats.Location = new Point(0, 23);
            Candidats.Margin = new Padding(3, 2, 3, 2);
            Candidats.Name = "Candidats";
            Candidats.Size = new Size(196, 244);
            Candidats.TabIndex = 8;
            Candidats.UseWaitCursor = true;
            // 
            // Taules
            // 
            Taules.FormattingEnabled = true;
            Taules.ItemHeight = 15;
            Taules.Location = new Point(527, 23);
            Taules.Margin = new Padding(3, 2, 3, 2);
            Taules.Name = "Taules";
            Taules.Size = new Size(182, 244);
            Taules.TabIndex = 23;
            Taules.UseWaitCursor = true;
            // 
            // labelTaules
            // 
            labelTaules.AutoSize = true;
            labelTaules.Location = new Point(601, 0);
            labelTaules.Name = "labelTaules";
            labelTaules.Size = new Size(39, 15);
            labelTaules.TabIndex = 21;
            labelTaules.Text = "Taules";
            labelTaules.UseWaitCursor = true;
            // 
            // labelPartits
            // 
            labelPartits.AutoSize = true;
            labelPartits.Location = new Point(334, 0);
            labelPartits.Name = "labelPartits";
            labelPartits.Size = new Size(40, 15);
            labelPartits.TabIndex = 20;
            labelPartits.Text = "Partits";
            labelPartits.UseWaitCursor = true;
            // 
            // btnEliminarTaula
            // 
            btnEliminarTaula.Location = new Point(643, 63);
            btnEliminarTaula.Name = "btnEliminarTaula";
            btnEliminarTaula.Size = new Size(105, 23);
            btnEliminarTaula.TabIndex = 27;
            btnEliminarTaula.Text = "Eliminar Taula";
            btnEliminarTaula.UseVisualStyleBackColor = true;
            btnEliminarTaula.UseWaitCursor = true;
            // 
            // btnAfegirTaula
            // 
            btnAfegirTaula.Location = new Point(548, 63);
            btnAfegirTaula.Name = "btnAfegirTaula";
            btnAfegirTaula.Size = new Size(89, 23);
            btnAfegirTaula.TabIndex = 24;
            btnAfegirTaula.Text = "Afegir Taula";
            btnAfegirTaula.UseVisualStyleBackColor = true;
            btnAfegirTaula.UseWaitCursor = true;
            // 
            // labelCensTaula
            // 
            labelCensTaula.AutoSize = true;
            labelCensTaula.Location = new Point(533, 39);
            labelCensTaula.Name = "labelCensTaula";
            labelCensTaula.Size = new Size(66, 15);
            labelCensTaula.TabIndex = 29;
            labelCensTaula.Text = "Cens Taula:";
            labelCensTaula.UseWaitCursor = true;
            // 
            // textBoxCensTaula
            // 
            textBoxCensTaula.Location = new Point(626, 31);
            textBoxCensTaula.Margin = new Padding(3, 2, 3, 2);
            textBoxCensTaula.Name = "textBoxCensTaula";
            textBoxCensTaula.Size = new Size(92, 23);
            textBoxCensTaula.TabIndex = 28;
            textBoxCensTaula.UseWaitCursor = true;
            // 
            // btnAfegirPartitP
            // 
            btnAfegirPartitP.Location = new Point(274, 50);
            btnAfegirPartitP.Name = "btnAfegirPartitP";
            btnAfegirPartitP.Size = new Size(89, 23);
            btnAfegirPartitP.TabIndex = 9;
            btnAfegirPartitP.Text = "Afegir Partit";
            btnAfegirPartitP.UseVisualStyleBackColor = true;
            btnAfegirPartitP.UseWaitCursor = true;
            // 
            // labelNomTaula
            // 
            labelNomTaula.AutoSize = true;
            labelNomTaula.Location = new Point(533, 12);
            labelNomTaula.Name = "labelNomTaula";
            labelNomTaula.Size = new Size(67, 15);
            labelNomTaula.TabIndex = 26;
            labelNomTaula.Text = "Nom Taula:";
            labelNomTaula.UseWaitCursor = true;
            // 
            // textBoxAfegirPartit
            // 
            textBoxAfegirPartit.Location = new Point(358, 4);
            textBoxAfegirPartit.Margin = new Padding(3, 2, 3, 2);
            textBoxAfegirPartit.Name = "textBoxAfegirPartit";
            textBoxAfegirPartit.Size = new Size(125, 23);
            textBoxAfegirPartit.TabIndex = 11;
            textBoxAfegirPartit.UseWaitCursor = true;
            // 
            // textBoxNomTaula
            // 
            textBoxNomTaula.Location = new Point(606, 4);
            textBoxNomTaula.Margin = new Padding(3, 2, 3, 2);
            textBoxNomTaula.Name = "textBoxNomTaula";
            textBoxNomTaula.Size = new Size(112, 23);
            textBoxNomTaula.TabIndex = 25;
            textBoxNomTaula.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 12);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 12;
            label5.Text = "Nom Partit:";
            label5.UseWaitCursor = true;
            // 
            // textBoxCandidat
            // 
            textBoxCandidat.Location = new Point(97, 4);
            textBoxCandidat.Margin = new Padding(3, 2, 3, 2);
            textBoxCandidat.Name = "textBoxCandidat";
            textBoxCandidat.Size = new Size(125, 23);
            textBoxCandidat.TabIndex = 13;
            textBoxCandidat.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 12);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 14;
            label6.Text = "Nom Candidat:";
            label6.UseWaitCursor = true;
            // 
            // btnAfegirCandidat
            // 
            btnAfegirCandidat.Location = new Point(5, 50);
            btnAfegirCandidat.Name = "btnAfegirCandidat";
            btnAfegirCandidat.Size = new Size(115, 23);
            btnAfegirCandidat.TabIndex = 15;
            btnAfegirCandidat.Text = "Afegir Candidat";
            btnAfegirCandidat.UseVisualStyleBackColor = true;
            btnAfegirCandidat.UseWaitCursor = true;
            btnAfegirCandidat.Click += btnAfegirCandidat_Click_1;
            // 
            // btnEliminarCandidat
            // 
            btnEliminarCandidat.Location = new Point(126, 50);
            btnEliminarCandidat.Name = "btnEliminarCandidat";
            btnEliminarCandidat.Size = new Size(115, 23);
            btnEliminarCandidat.TabIndex = 16;
            btnEliminarCandidat.Text = "Eliminar Candidat";
            btnEliminarCandidat.UseVisualStyleBackColor = true;
            btnEliminarCandidat.UseWaitCursor = true;
            btnEliminarCandidat.Click += btnEliminarCandidat_Click_1;
            // 
            // btnEliminarPartit
            // 
            btnEliminarPartit.Location = new Point(378, 50);
            btnEliminarPartit.Name = "btnEliminarPartit";
            btnEliminarPartit.Size = new Size(105, 23);
            btnEliminarPartit.TabIndex = 17;
            btnEliminarPartit.Text = "Eliminar Partit";
            btnEliminarPartit.UseVisualStyleBackColor = true;
            btnEliminarPartit.UseWaitCursor = true;
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(textBoxAfegirPartit);
            panelInferior.Controls.Add(btnEliminarTaula);
            panelInferior.Controls.Add(btnEliminarPartit);
            panelInferior.Controls.Add(btnAfegirTaula);
            panelInferior.Controls.Add(btnEliminarCandidat);
            panelInferior.Controls.Add(labelCensTaula);
            panelInferior.Controls.Add(btnAfegirCandidat);
            panelInferior.Controls.Add(label6);
            panelInferior.Controls.Add(textBoxCensTaula);
            panelInferior.Controls.Add(textBoxCandidat);
            panelInferior.Controls.Add(label5);
            panelInferior.Controls.Add(btnAfegirPartitP);
            panelInferior.Controls.Add(textBoxNomTaula);
            panelInferior.Controls.Add(labelNomTaula);
            panelInferior.Location = new Point(12, 358);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(749, 90);
            panelInferior.TabIndex = 36;
            panelInferior.UseWaitCursor = true;
            panelInferior.Visible = false;
            panelInferior.Paint += panelInferior_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 450);
            Controls.Add(panelInferior);
            Controls.Add(panelGeneral);
            Controls.Add(panelMunicipis);
            Controls.Add(panelSuperior);
            Controls.Add(btnCarregarDades);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            UseWaitCursor = true;
            Load += Form1_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelMunicipis.ResumeLayout(false);
            panelMunicipis.PerformLayout();
            panelGeneral.ResumeLayout(false);
            panelGeneral.PerformLayout();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCrearMunicipi;
        private Label label3;
        private TextBox textBoxNomMunicipi;
        private Label label4;
        private TextBox textBoxNumRegidors;
        private Label label1;
        private ListBox Municipis;
        private Label labelMunicipis;
        private Button btnCarregarDades;
        private Button btnPanelCrear;
        private Panel panelSuperior;
        private Panel panelMunicipis;
        private Panel panelGeneral;
        private Label labelCandidats;
        private Button btnEliminarTaula;
        private Button btnAfegirTaula;
        private Label labelCensTaula;
        private ListBox PartitsPolítics;
        private TextBox textBoxCensTaula;
        private ListBox Candidats;
        private Button btnAfegirPartitP;
        private Label labelNomTaula;
        private TextBox textBoxAfegirPartit;
        private TextBox textBoxNomTaula;
        private Label label5;
        private TextBox textBoxCandidat;
        private ListBox Taules;
        private Label label6;
        private Button btnAfegirCandidat;
        private Label labelTaules;
        private Button btnEliminarCandidat;
        private Label labelPartits;
        private Button btnEliminarPartit;
        private Button btnGuardarDades;
        private Panel panelInferior;
    }
}