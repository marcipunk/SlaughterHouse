using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlaughterHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Simulator vagohid = new Simulator(20);

            dGAnimals.DataSource = vagohid.Allatoklistaja;

        }

        private void animalBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
