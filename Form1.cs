using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_JaugeClient_JAA
{
    public partial class FormJauge : Form
    {
        public FormJauge()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            int valeur;
            string str = this.textBoxPuissance.Text;
            bool isNum = int.TryParse(str, out valeur);
            if (str.Equals("") || !(isNum))
            {
                this.labelErreur.Text = "Valeur saissie invalide!";
                this.textBoxPuissance.Text = "";
            }
            else
            {
                this.labelErreur.Text = "";
                jaugeComposant1.Valeur = valeur;
            }
        }
    }
}
