
namespace WindowsFormsApp_Animation_
{
    partial class CfmAnimation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlAnimation = new System.Windows.Forms.Panel();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.btnStartStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlAnimation
            // 
            this.pnlAnimation.Location = new System.Drawing.Point(8, 6);
            this.pnlAnimation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAnimation.Name = "pnlAnimation";
            this.pnlAnimation.Size = new System.Drawing.Size(375, 385);
            this.pnlAnimation.TabIndex = 0;
            // 
            // tmr
            // 
            this.tmr.Interval = 50;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(20, 402);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(112, 35);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // CfmAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 448);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.pnlAnimation);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CfmAnimation";
            this.Text = "ANIMATION";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAnimation;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Button btnStartStop;
    }
}

