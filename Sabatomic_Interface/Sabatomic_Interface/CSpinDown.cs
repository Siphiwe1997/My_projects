using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabatomic_Interface
{
    class CSpinDown : ISpinBehavior
    {
        public void Spin()
        {
            Console.WriteLine("Spin Down");
        }
    }
}
