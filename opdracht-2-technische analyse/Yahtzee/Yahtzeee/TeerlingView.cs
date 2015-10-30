using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzeee
{
    
    public partial class TeerlingView : UserControl
    {
        public int count = 0;

        private TeerlingController controller;
        public TeerlingView( TeerlingController c)
        {
            InitializeComponent();

            controller = c;
        }

        private void btnWerpen_Click(object sender, EventArgs e)
        {
            controller.Werp();
            int nieuwAantalOgen = controller.model.AantalOgen;
            lblTeerlingView1.Text = Convert.ToString(nieuwAantalOgen);
            
        }

        private void lblTeerlingView1_Click(object sender, EventArgs e)
        {
            count++;

            if (count % 2 == 0)
            {
                lblTeerlingView1.BackColor = Color.LightGray;
                btnWerpen.Enabled = true;
            }
            else
            {
                lblTeerlingView1.BackColor = Color.Red;
                btnWerpen.Enabled = false;
            }
        }

    }
}
