using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzeee
{
    public partial class Yahtzee : Form
    {
        private TeerlingController controller;
        private int aantalTeerlingen = 3;

        public Yahtzee()
        {
            InitializeComponent();
            controller = new TeerlingController();
        }
        //telt aantal clicks en geeft door
        //doe iets en je kan da gebruike vor andere games
        
        private void Yahtzee_Load(object sender, EventArgs e)
        {
            List<TeerlingController> teerlingen = new List<TeerlingController>();

            //Teerlingen tonen
            for (int i = 0; i < aantalTeerlingen; i++)
            {
                //maakt instantie van teerlingcontroller
                TeerlingController tijdelijkeTeerling = new TeerlingController();
                teerlingen.Add(tijdelijkeTeerling);
            }

            //Teerlingen tonen
            for (int i = 0; i < aantalTeerlingen; i++)
            {
                //maakt instantie van teerlingcontroller
                TeerlingView teerlingView = teerlingen[i].getView();

                //Teerlingen naast elkaar plaatsen
                int horizontalPosition;
                horizontalPosition = i * teerlingView.Width;

                teerlingView.Location = new System.Drawing.Point(horizontalPosition, 0);
                Controls.Add(teerlingView);
            }         
        }

        private void btnWerpAll_Click(object sender, EventArgs e)
        {
            // loop through the lus en geeft call de functie aan
        }
    }
}
