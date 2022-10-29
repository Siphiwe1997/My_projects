
namespace WPF_Subatomic_v2_
{
    partial class CfmSabatomic
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
            this.chkHiggs = new System.Windows.Forms.CheckBox();
            this.btnMassRatio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkProton = new System.Windows.Forms.CheckBox();
            this.chkElectron = new System.Windows.Forms.CheckBox();
            this.txtHiggs = new System.Windows.Forms.TextBox();
            this.txtElectron = new System.Windows.Forms.TextBox();
            this.txtProton = new System.Windows.Forms.TextBox();
            this.lblAve = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkHiggs
            // 
            this.chkHiggs.AutoSize = true;
            this.chkHiggs.Location = new System.Drawing.Point(6, 20);
            this.chkHiggs.Name = "chkHiggs";
            this.chkHiggs.Size = new System.Drawing.Size(53, 17);
            this.chkHiggs.TabIndex = 0;
            this.chkHiggs.Text = "Higgs";
            this.chkHiggs.UseVisualStyleBackColor = true;
            // 
            // btnMassRatio
            // 
            this.btnMassRatio.Location = new System.Drawing.Point(17, 184);
            this.btnMassRatio.Name = "btnMassRatio";
            this.btnMassRatio.Size = new System.Drawing.Size(100, 23);
            this.btnMassRatio.TabIndex = 1;
            this.btnMassRatio.Text = "&Mass ratio";
            this.btnMassRatio.UseVisualStyleBackColor = true;
            this.btnMassRatio.Click += new System.EventHandler(this.btnMassRatio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Higgs mass (MeV)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Electron mass(MeV)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Proton mass (MeV)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkProton);
            this.groupBox1.Controls.Add(this.chkElectron);
            this.groupBox1.Controls.Add(this.chkHiggs);
            this.groupBox1.Location = new System.Drawing.Point(151, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Particles";
            // 
            // chkProton
            // 
            this.chkProton.AutoSize = true;
            this.chkProton.Location = new System.Drawing.Point(6, 66);
            this.chkProton.Name = "chkProton";
            this.chkProton.Size = new System.Drawing.Size(57, 17);
            this.chkProton.TabIndex = 2;
            this.chkProton.Text = "Proton";
            this.chkProton.UseVisualStyleBackColor = true;
            // 
            // chkElectron
            // 
            this.chkElectron.AutoSize = true;
            this.chkElectron.Location = new System.Drawing.Point(6, 43);
            this.chkElectron.Name = "chkElectron";
            this.chkElectron.Size = new System.Drawing.Size(65, 17);
            this.chkElectron.TabIndex = 1;
            this.chkElectron.Text = "Electron";
            this.chkElectron.UseVisualStyleBackColor = true;
            // 
            // txtHiggs
            // 
            this.txtHiggs.Location = new System.Drawing.Point(13, 36);
            this.txtHiggs.Name = "txtHiggs";
            this.txtHiggs.Size = new System.Drawing.Size(100, 20);
            this.txtHiggs.TabIndex = 6;
            // 
            // txtElectron
            // 
            this.txtElectron.Location = new System.Drawing.Point(13, 92);
            this.txtElectron.Name = "txtElectron";
            this.txtElectron.Size = new System.Drawing.Size(100, 20);
            this.txtElectron.TabIndex = 7;
            // 
            // txtProton
            // 
            this.txtProton.Location = new System.Drawing.Point(17, 142);
            this.txtProton.Name = "txtProton";
            this.txtProton.Size = new System.Drawing.Size(100, 20);
            this.txtProton.TabIndex = 8;
            // 
            // lblAve
            // 
            this.lblAve.AutoSize = true;
            this.lblAve.Location = new System.Drawing.Point(154, 142);
            this.lblAve.Name = "lblAve";
            this.lblAve.Size = new System.Drawing.Size(50, 13);
            this.lblAve.TabIndex = 10;
            this.lblAve.Text = "Average:";
            // 
            // CfmSabatomic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 232);
            this.Controls.Add(this.lblAve);
            this.Controls.Add(this.txtProton);
            this.Controls.Add(this.txtElectron);
            this.Controls.Add(this.txtHiggs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMassRatio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CfmSabatomic";
            this.Text = "SUBATOMIC PARTICLES";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkHiggs;
        private System.Windows.Forms.Button btnMassRatio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkProton;
        private System.Windows.Forms.CheckBox chkElectron;
        private System.Windows.Forms.TextBox txtHiggs;
        private System.Windows.Forms.TextBox txtElectron;
        private System.Windows.Forms.TextBox txtProton;
        private System.Windows.Forms.Label lblAve;
    }
}

