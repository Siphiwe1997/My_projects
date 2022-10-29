using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabatomic_Interface
{
    class CElectronMass : IMassBehaviour
    {
        public void Mass()
        {
            Console.WriteLine("0.5110 MeV");
        }
    }
}
