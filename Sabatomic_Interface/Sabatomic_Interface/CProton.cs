using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabatomic_Interface
{
    class CProton : CSubatomic
    {
        public CProton()
        {
            chargeB = new CProtonCharge();
            spinB = new CSpinUp();
            massB = new CProtonMass();
        }
    }
}
