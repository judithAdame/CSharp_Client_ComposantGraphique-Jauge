namespace TP1_JaugeClient_JAA
{
    partial class FormJauge
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJauge));
            this.jaugeComposant1 = new boutonuser_control_2015.JaugeComposant();
            this.labelErreur = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxPuissance = new System.Windows.Forms.TextBox();
            this.labelPuissance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jaugeComposant1
            // 
            this.jaugeComposant1.DialColor = System.Drawing.Color.PaleTurquoise;
            this.jaugeComposant1.DialText = "Ma belle jauge";
            this.jaugeComposant1.Location = new System.Drawing.Point(13, 13);
            this.jaugeComposant1.Margin = new System.Windows.Forms.Padding(4);
            this.jaugeComposant1.Max = 100F;
            this.jaugeComposant1.Min = 0F;
            this.jaugeComposant1.Name = "jaugeComposant1";
            this.jaugeComposant1.NoOfDivisions = 5;
            this.jaugeComposant1.NoOfSubDivisions = 5;
            this.jaugeComposant1.Size = new System.Drawing.Size(832, 455);
            this.jaugeComposant1.TabIndex = 0;
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.Location = new System.Drawing.Point(253, 510);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(0, 17);
            this.labelErreur.TabIndex = 8;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(449, 466);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 32);
            this.buttonGo.TabIndex = 7;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // textBoxPuissance
            // 
            this.textBoxPuissance.Location = new System.Drawing.Point(373, 469);
            this.textBoxPuissance.MaxLength = 5;
            this.textBoxPuissance.Name = "textBoxPuissance";
            this.textBoxPuissance.Size = new System.Drawing.Size(70, 22);
            this.textBoxPuissance.TabIndex = 6;
            this.textBoxPuissance.Text = "[0-Max]";
            // 
            // labelPuissance
            // 
            this.labelPuissance.AutoSize = true;
            this.labelPuissance.Location = new System.Drawing.Point(215, 472);
            this.labelPuissance.Name = "labelPuissance";
            this.labelPuissance.Size = new System.Drawing.Size(152, 17);
            this.labelPuissance.TabIndex = 5;
            this.labelPuissance.Text = "Valeur de la puissance";
            // 
            // FormJauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 589);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textBoxPuissance);
            this.Controls.Add(this.labelPuissance);
            this.Controls.Add(this.jaugeComposant1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJauge";
            this.Text = "Ma belle jauge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private boutonuser_control_2015.JaugeComposant jaugeComposant1;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBoxPuissance;
        private System.Windows.Forms.Label labelPuissance;
    }
}

