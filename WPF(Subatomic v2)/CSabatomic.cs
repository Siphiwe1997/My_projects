using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Subatomic_v2_
{
    class CSabatomic
    {
        public CSabatomic(double _dElectron, double _dHiggs, double _dProton)
        {
            Electron = _dElectron;
            Higgs = _dHiggs;
            Proton = _dProton;
        }


        private double dElectron, dProton, dHiggs;
        public double Electron
        {
            get
            {
                return dElectron;
            }
            set
            {
                if (value <= 0.5110)
                    dElectron = value;
                else
                    dElectron = 0.5110;
            }
        }
        public double Proton
        {
            get
            {
                return dProton;
            }
            set
            {
                if (value >= 938.272)
                    dProton = value;
                else
                    dProton = 938.272;
            }
        }

        public double Higgs { get => dHiggs; set => dHiggs = value; }
        //public static string Instrution()
        //{
        //   return  
        //}
    }
}
