using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabatomic_Interface
{
    class CElectron : CSubatomic
    {
        public CElectron()
        {
            chargeB = new CElectronCharge();
            spinB = new CSpinDown();
            massB = new CElectronMass();
        }
    }
}
