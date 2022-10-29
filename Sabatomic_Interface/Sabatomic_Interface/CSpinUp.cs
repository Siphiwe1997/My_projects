using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabatomic_Interface
{
    class CSpinUp : ISpinBehavior
    {
        public void Spin()
        {
            Console.WriteLine("Spin Up");
        }
    }
}
