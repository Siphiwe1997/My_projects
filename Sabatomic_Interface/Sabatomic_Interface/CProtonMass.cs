using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabatomic_Interface
{
    class CProtonMass : IMassBehaviour
    {
        public void Mass()
        {
            Console.WriteLine("938,28 MeV/c^2");
        }
    }
}
