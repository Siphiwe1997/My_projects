using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabatomic_Interface
{
    class CElectronCharge : IChargeBehaviour
    {
        public void Charge()
        {
            Console.WriteLine("-1,602x10^-19 C");
        }
    }
}
