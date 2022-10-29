
namespace WindowsFormsApp_DrawCircles_
{
    partial class CfmCircle
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
            this.pnlCircle = new System.Windows.Forms.Panel();
            this.radDisc = new System.Windows.Forms.RadioButton();
            this.radCircle = new System.Windows.Forms.RadioButton();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlCircle
            // 
            this.pnlCircle.BackColor = System.Drawing.Color.White;
            this.pnlCircle.Location = new System.Drawing.Point(12, 12);
            this.pnlCircle.Name = "pnlCircle";
            this.pnlCircle.Size = new System.Drawing.Size(200, 200);
            this.pnlCircle.TabIndex = 0;
            // 
            // radDisc
            // 
            this.radDisc.AutoSize = true;
            this.radDisc.Location = new System.Drawing.Point(12, 218);
            this.radDisc.Name = "radDisc";
            this.radDisc.Size = new System.Drawing.Size(46, 17);
            this.radDisc.TabIndex = 1;
            this.radDisc.TabStop = true;
            this.radDisc.Text = "Disc";
            this.radDisc.UseVisualStyleBackColor = true;
            // 
            // radCircle
            // 
            this.radCircle.AutoSize = true;
            this.radCircle.Location = new System.Drawing.Point(74, 218);
            this.radCircle.Name = "radCircle";
            this.radCircle.Size = new System.Drawing.Size(51, 17);
            this.radCircle.TabIndex = 2;
            this.radCircle.TabStop = true;
            this.radCircle.Text = "Circle";
            this.radCircle.UseVisualStyleBackColor = true;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(218, 43);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Position";
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Location = new System.Drawing.Point(218, 95);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(49, 13);
            this.lblDiameter.TabIndex = 4;
            this.lblDiameter.Text = "Diameter";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(272, 27);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 5;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(333, 27);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 6;
            this.lblY.Text = "Y";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(221, 173);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(55, 23);
            this.btnDraw.TabIndex = 7;
            this.btnDraw.Text = "&Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(301, 173);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(268, 43);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(36, 20);
            this.txtX.TabIndex = 9;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(327, 43);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(36, 20);
            this.txtY.TabIndex = 10;
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(268, 95);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(36, 20);
            this.txtDiameter.TabIndex = 11;
            // 
            // CfmCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 239);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.radCircle);
            this.Controls.Add(this.radDisc);
            this.Controls.Add(this.pnlCircle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CfmCircle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCircle;
        private System.Windows.Forms.RadioButton radDisc;
        private System.Windows.Forms.RadioButton radCircle;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtDiameter;
    }
}

