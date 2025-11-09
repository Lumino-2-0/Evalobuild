namespace Evalobuild.Collège.Menu_Chaps
{
    partial class Menu_Géographie
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Chaps_Maths = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(415, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 60);
            this.button1.TabIndex = 15;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Chaps_Maths
            // 
            this.Chaps_Maths.CheckOnClick = true;
            this.Chaps_Maths.Cursor = System.Windows.Forms.Cursors.Help;
            this.Chaps_Maths.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chaps_Maths.FormattingEnabled = true;
            this.Chaps_Maths.Items.AddRange(new object[] {
            "Multiples, diviseurs, Nombres premiers",
            "Nombres relatifs et Fractions",
            "Théorème et Réciproque de Pythagore",
            "Proportionnalité, pourcentages, échelles",
            "Grandeurs simples et composées",
            "Tableur : écrire une formule",
            "Scratch",
            "Symétries axiales et centrales, translations, rotations",
            "Parallélogrammes, calculs d\'angles",
            "Triangles égaux, triangles semblables",
            "Théorème de Thalès, agrandissement, Réduction",
            "Trigonométrie",
            "Calcul littéral : développer, factoriser, réduire",
            "Equations",
            "Lecture graphique, repérage",
            "Fonctions : image, antécédent, tableaux, graphique",
            "Périmètres, aires, volumes, conversions"});
            this.Chaps_Maths.Location = new System.Drawing.Point(3, 3);
            this.Chaps_Maths.Name = "Chaps_Maths";
            this.Chaps_Maths.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Chaps_Maths.Size = new System.Drawing.Size(388, 382);
            this.Chaps_Maths.TabIndex = 14;
            this.Chaps_Maths.Tag = "Maths_Chaps";
            // 
            // Menu_Géographie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Chaps_Maths);
            this.Name = "Menu_Géographie";
            this.Size = new System.Drawing.Size(608, 387);
            this.Load += new System.EventHandler(this.Menu_Géographie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.CheckedListBox Chaps_Maths;
    }
}
