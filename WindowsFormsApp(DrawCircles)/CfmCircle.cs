using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp_DrawCircles_
{
    public partial class CfmCircle : Form
    {
        Graphics g;
        int iX, iY, iD;
        public CfmCircle()
        {
            InitializeComponent();
            g = pnlCircle.CreateGraphics();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                iX = int.Parse(txtX.Text);
                iY = int.Parse(txtY.Text);
                iD = int.Parse(txtDiameter.Text);

                if (radCircle.Checked == true)
                {
                    CheckForValidInputs();
                    g.Clear(Color.White);
                    g.FillEllipse(Brushes.Green, iX, iY, iD, iD);
                }
                else
                {
                    CheckForValidInputs();
                    g.Clear(Color.White);
                    Pen penGreen = new Pen(Color.Green, 4);
                    g.DrawEllipse(penGreen, iX, iY, iD, iD);
                }
            }
            catch(Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
        private void CheckForValidInputs()
        {
            if (iD > pnlCircle.Width || iD > pnlCircle.Height)
                iD = pnlCircle.Width / 2;

            if (iX > pnlCircle.Width)
                iX = pnlCircle.Width / 2;

            if (iY > pnlCircle.Height)
                iY = pnlCircle.Height / 2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }
    }
}
