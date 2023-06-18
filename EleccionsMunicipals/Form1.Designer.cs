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
            PartitsPolítics = new ListBox();
            Candidats = new ListBox();
            btnAfegirPartitP = new Button();
            label1 = new Label();
            textBoxAfegirPartit = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBoxCandidat = new TextBox();
            btnAfegirCandidat = new Button();
            SuspendLayout();
            // 
            // btnCrearMunicipi
            // 
            btnCrearMunicipi.Location = new Point(798, 538);
            btnCrearMunicipi.Margin = new Padding(3, 4, 3, 4);
            btnCrearMunicipi.Name = "btnCrearMunicipi";
            btnCrearMunicipi.Size = new Size(131, 31);
            btnCrearMunicipi.TabIndex = 1;
            btnCrearMunicipi.Text = "CrearMunicipi";
            btnCrearMunicipi.UseVisualStyleBackColor = true;
            btnCrearMunicipi.UseWaitCursor = true;
            btnCrearMunicipi.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 27);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 3;
            label3.Text = "Nom del Municipi:";
            label3.UseWaitCursor = true;
            // 
            // textBoxNomMunicipi
            // 
            textBoxNomMunicipi.Location = new Point(211, 24);
            textBoxNomMunicipi.Name = "textBoxNomMunicipi";
            textBoxNomMunicipi.Size = new Size(142, 27);
            textBoxNomMunicipi.TabIndex = 4;
            textBoxNomMunicipi.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 27);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 5;
            label4.Text = "Número de Regidors:";
            label4.UseWaitCursor = true;
            // 
            // textBoxNumRegidors
            // 
            textBoxNumRegidors.Location = new Point(659, 24);
            textBoxNumRegidors.Name = "textBoxNumRegidors";
            textBoxNumRegidors.Size = new Size(142, 27);
            textBoxNumRegidors.TabIndex = 6;
            textBoxNumRegidors.UseWaitCursor = true;
            // 
            // PartitsPolítics
            // 
            PartitsPolítics.FormattingEnabled = true;
            PartitsPolítics.ItemHeight = 20;
            PartitsPolítics.Location = new Point(43, 77);
            PartitsPolítics.Name = "PartitsPolítics";
            PartitsPolítics.Size = new Size(271, 324);
            PartitsPolítics.TabIndex = 7;
            PartitsPolítics.UseWaitCursor = true;
            PartitsPolítics.SelectedIndexChanged += PartitsPolítics_SelectedIndexChanged;
            // 
            // Candidats
            // 
            Candidats.FormattingEnabled = true;
            Candidats.ItemHeight = 20;
            Candidats.Location = new Point(485, 77);
            Candidats.Name = "Candidats";
            Candidats.Size = new Size(246, 324);
            Candidats.TabIndex = 8;
            Candidats.UseWaitCursor = true;
            Candidats.SelectedIndexChanged += Candidats_SelectedIndexChanged;
            // 
            // btnAfegirPartitP
            // 
            btnAfegirPartitP.Location = new Point(659, 538);
            btnAfegirPartitP.Margin = new Padding(3, 4, 3, 4);
            btnAfegirPartitP.Name = "btnAfegirPartitP";
            btnAfegirPartitP.Size = new Size(131, 31);
            btnAfegirPartitP.TabIndex = 9;
            btnAfegirPartitP.Text = "Afegir Partit";
            btnAfegirPartitP.UseVisualStyleBackColor = true;
            btnAfegirPartitP.UseWaitCursor = true;
            btnAfegirPartitP.Click += btnAfegirPartitP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 77);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 10;
            label1.UseWaitCursor = true;
            // 
            // textBoxAfegirPartit
            // 
            textBoxAfegirPartit.Location = new Point(172, 423);
            textBoxAfegirPartit.Name = "textBoxAfegirPartit";
            textBoxAfegirPartit.Size = new Size(142, 27);
            textBoxAfegirPartit.TabIndex = 11;
            textBoxAfegirPartit.UseWaitCursor = true;
            textBoxAfegirPartit.TextChanged += textBoxAfegirPartit_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 430);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 12;
            label5.Text = "Nom Nou Partit:";
            label5.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(483, 430);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 14;
            label6.Text = "Nom Candidat:";
            label6.UseWaitCursor = true;
            // 
            // textBoxCandidat
            // 
            textBoxCandidat.Location = new Point(620, 423);
            textBoxCandidat.Name = "textBoxCandidat";
            textBoxCandidat.Size = new Size(142, 27);
            textBoxCandidat.TabIndex = 13;
            textBoxCandidat.UseWaitCursor = true;
            // 
            // btnAfegirCandidat
            // 
            btnAfegirCandidat.Location = new Point(537, 470);
            btnAfegirCandidat.Margin = new Padding(3, 4, 3, 4);
            btnAfegirCandidat.Name = "btnAfegirCandidat";
            btnAfegirCandidat.Size = new Size(131, 31);
            btnAfegirCandidat.TabIndex = 15;
            btnAfegirCandidat.Text = "Afegir Candidat";
            btnAfegirCandidat.UseVisualStyleBackColor = true;
            btnAfegirCandidat.UseWaitCursor = true;
            btnAfegirCandidat.Click += btnAfegirCandidat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 600);
            Controls.Add(btnAfegirCandidat);
            Controls.Add(label6);
            Controls.Add(textBoxCandidat);
            Controls.Add(label5);
            Controls.Add(textBoxAfegirPartit);
            Controls.Add(label1);
            Controls.Add(btnAfegirPartitP);
            Controls.Add(Candidats);
            Controls.Add(PartitsPolítics);
            Controls.Add(textBoxNumRegidors);
            Controls.Add(label4);
            Controls.Add(textBoxNomMunicipi);
            Controls.Add(label3);
            Controls.Add(btnCrearMunicipi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCrearMunicipi;
        private Label label3;
        private TextBox textBoxNomMunicipi;
        private Label label4;
        private TextBox textBoxNumRegidors;
        private ListBox PartitsPolítics;
        private ListBox Candidats;
        private Button btnAfegirPartitP;
        private Label label1;
        private TextBox textBoxAfegirPartit;
        private Label label5;
        private Label label6;
        private TextBox textBoxCandidat;
        private Button btnAfegirCandidat;
    }
}