using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabatomic_Interface
{
    class Program
    {
        static CSubatomic saba;
        static void Main(string[] args)
        {
            Console.WriteLine("\n");

            Console.WriteLine("=======\nELETRON\n=======");
            saba = new CElectron();
            saba.ChargeValue();
            saba.MassValue();
            saba.QuantumState();

            Console.WriteLine("\n");

            Console.WriteLine("======\nPROTON\n======");
            saba = new CProton();
            saba.ChargeValue();
            saba.MassValue();
            saba.QuantumState();

            Console.ReadKey();
        }
    }
}
