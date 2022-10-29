using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_Subatomic_v2_
{
    public partial class CfmSabatomic : Form
    {
        public CfmSabatomic()
        {
            InitializeComponent();
            chkHiggs.Checked = true;
        }

        private void btnMassRatio_Click(object sender, EventArgs e)
        {
            try
            {
                CSabatomic saba = new CSabatomic(double.Parse(txtElectron.Text), double.Parse(txtHiggs.Text), 
                    double.Parse(txtProton.Text));
                if (chkElectron.Checked)
                {
                    MessageBox.Show("Mass Ratio between E & H is " + saba.Electron / saba.Higgs + 
                        "\nMass Ratio between E & P is " + saba.Electron / saba.Proton);
                }
                else if (chkHiggs.Checked)
                {
                    MessageBox.Show("Mass Ratio between H & E is " + saba.Higgs / saba.Electron + 
                        "\nMass Ratio between H & P is " + saba.Higgs / saba.Proton);
                }
                else
                {
                    MessageBox.Show("Mass Ratio between P & E is " + saba.Proton / saba.Electron + 
                        "\nMass Ratio between P & H is " + saba.Proton / saba.Higgs);
                }

                double dAve = (double.Parse(txtElectron.Text) + double.Parse(txtHiggs.Text) + double.Parse(txtProton.Text)) / 3;
                lblAve.Text = "Average: " + dAve.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }  
    }
}
