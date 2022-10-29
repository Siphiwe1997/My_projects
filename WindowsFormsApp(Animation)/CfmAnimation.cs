using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Animation_
{
    public partial class CfmAnimation : Form
    {
        Graphics g;
        int x = 0;
        int y = 0;
        public CfmAnimation()
        {
            InitializeComponent();
            g = pnlAnimation.CreateGraphics(); 
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            x += 2;
            y += 2;
            g.Clear(Color.White);

            g.FillEllipse(Brushes.Red, x, y, 15, 15);
            if (x >= pnlAnimation.Width-15 || y >= pnlAnimation.Height-15)
                x = y = 0;

        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (tmr.Enabled == false)
            { 
                tmr.Enabled = true;
                btnStartStop.Text = "Stop";
            }

            else
            {
                tmr.Enabled = false;
                btnStartStop.Text = "Start";
            }
                
        }
    }
}
