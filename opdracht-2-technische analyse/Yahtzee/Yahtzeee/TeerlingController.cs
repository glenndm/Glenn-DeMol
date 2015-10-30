using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzeee
{
    public class TeerlingController
    {
        public TeerlingView view;
        public TeerlingModel model;

        public TeerlingController()
        {
            //Maakt nieuwe instantie aan van view
            view = new TeerlingView( this );
            model = new TeerlingModel();
        }
        public TeerlingView getView()
        {
            return view;   
        }

        public void Werp()
        { 
            //vraagt aan model om aantal ogen te updaten
            Random random = new Random();
            int aantalOgen = random.Next(1, 7);

            model.AantalOgen = aantalOgen;
        }

        public void WerpAllen()
        {
            Werp();//updateUI
        }
    }
}
