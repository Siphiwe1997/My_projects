using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabatomic_Interface
{
    abstract class CSubatomic
    {
        protected IChargeBehaviour chargeB { get; set; }
        protected IMassBehaviour massB { get; set; }
        protected ISpinBehavior spinB { get; set; }

        public void ChargeValue()
        {
            chargeB.Charge();
        }
        public void MassValue()
        {
            massB.Mass();
        }
        public void QuantumState()
        {
            spinB.Spin();
        }
    }
}
