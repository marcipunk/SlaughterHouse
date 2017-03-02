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
    public partial class SlaughterForm : Form
    {
        Simulator vagohid;

        public SlaughterForm()
        {
            InitializeComponent();

        }

        private void animalBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void SlaughterForm_Shown(object sender, EventArgs e)
        {
            vagohid = new Simulator(20, this);

            dGAnimals.DataSource = vagohid.Allatoklistaja;
            dGPart.DataSource = vagohid.Hentes.ButcherFridge;
            System.Diagnostics.Debug.Print("hello");
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            vagohid.STARTFeed();
        }
    }
}
