using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolik_stála_cesta
{
    public partial class formKolikStalaCesta : Form
    {
        public formKolikStalaCesta()
        {
            InitializeComponent();
        }

        private void tlacitkoOProgramu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maturita z INFORMATIKY 2016\nPísemná práce - část č. 3");
        }

        private void tlacitkoVypocti_Click(object sender, EventArgs e)
        {
            try
            {
                double cena = Convert.ToDouble(poleCena.Text);
                double spotreba = Convert.ToDouble(poleSpotreba.Text);
                double vzdalenost = Convert.ToDouble(poleVzdalenost.Text);

                double vysledek = (vzdalenost / 100) * spotreba * cena;
                poleVysledek.Text = vysledek.ToString("F2");
            }
            catch 
            {
                MessageBox.Show("Chybně zadaný údaj");
            }

        }
    }
}
