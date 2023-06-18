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
            label2 = new Label();
            label3 = new Label();
            textBoxNomMunicipi = new TextBox();
            label4 = new Label();
            textBoxNumRegidors = new TextBox();
            PartitsPolítics = new ListBox();
            Candidats = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCrearMunicipi
            // 
            btnCrearMunicipi.Location = new Point(381, 490);
            btnCrearMunicipi.Margin = new Padding(3, 4, 3, 4);
            btnCrearMunicipi.Name = "btnCrearMunicipi";
            btnCrearMunicipi.Size = new Size(131, 31);
            btnCrearMunicipi.TabIndex = 1;
            btnCrearMunicipi.Text = "CrearMunicipi";
            btnCrearMunicipi.UseVisualStyleBackColor = true;
            btnCrearMunicipi.UseWaitCursor = true;
            btnCrearMunicipi.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 501);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 2;
            label2.Text = "Introdueixi les dades seguënts";
            label2.UseWaitCursor = true;
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
            PartitsPolítics.Location = new Point(37, 100);
            PartitsPolítics.Name = "PartitsPolítics";
            PartitsPolítics.Size = new Size(271, 324);
            PartitsPolítics.TabIndex = 7;
            PartitsPolítics.UseWaitCursor = true;
            // 
            // Candidats
            // 
            Candidats.FormattingEnabled = true;
            Candidats.ItemHeight = 20;
            Candidats.Location = new Point(485, 100);
            Candidats.Name = "Candidats";
            Candidats.Size = new Size(246, 324);
            Candidats.TabIndex = 8;
            Candidats.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(108, 440);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(131, 31);
            button1.TabIndex = 9;
            button1.Text = "Crear Partit";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 600);
            Controls.Add(button1);
            Controls.Add(Candidats);
            Controls.Add(PartitsPolítics);
            Controls.Add(textBoxNumRegidors);
            Controls.Add(label4);
            Controls.Add(textBoxNomMunicipi);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private TextBox textBoxNomMunicipi;
        private Label label4;
        private TextBox textBoxNumRegidors;
        private ListBox PartitsPolítics;
        private ListBox Candidats;
        private Button button1;
    }
}