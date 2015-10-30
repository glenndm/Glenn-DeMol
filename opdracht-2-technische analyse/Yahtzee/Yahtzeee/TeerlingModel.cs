using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzeee
{
    
    public class TeerlingModel
    {
        private int aantalOgen;

	    public int AantalOgen
	    {
		get { return aantalOgen;}
		set { aantalOgen = value;}
	    }

        private bool isvast = false;

        public bool IsVast
        {
            get { return isvast; }
            set { isvast = value; }
        }


        public void VastEnLosVeranderen()
        {
            if(isvast) { isvast = false; }
            else { isvast = true; }
        }


    }
}
