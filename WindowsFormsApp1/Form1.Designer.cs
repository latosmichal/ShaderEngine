namespace WindowsFormsApp1
{
    partial class Form1
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
            this.pSpace = new System.Windows.Forms.PictureBox();
            this.bRotateX = new System.Windows.Forms.Button();
            this.bRotateY = new System.Windows.Forms.Button();
            this.bRotateZ = new System.Windows.Forms.Button();
            this.bScaleUp = new System.Windows.Forms.Button();
            this.bUp = new System.Windows.Forms.Button();
            this.bDown = new System.Windows.Forms.Button();
            this.bRight = new System.Windows.Forms.Button();
            this.bLeft = new System.Windows.Forms.Button();
            this.bScaleDown = new System.Windows.Forms.Button();
            this.bLight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // pSpace
            // 
            this.pSpace.Location = new System.Drawing.Point(12, 12);
            this.pSpace.Name = "pSpace";
            this.pSpace.Size = new System.Drawing.Size(463, 426);
            this.pSpace.TabIndex = 0;
            this.pSpace.TabStop = false;
            // 
            // bRotateX
            // 
            this.bRotateX.Location = new System.Drawing.Point(517, 62);
            this.bRotateX.Name = "bRotateX";
            this.bRotateX.Size = new System.Drawing.Size(76, 69);
            this.bRotateX.TabIndex = 1;
            this.bRotateX.Text = "Obrót X";
            this.bRotateX.UseVisualStyleBackColor = true;
            this.bRotateX.Click += new System.EventHandler(this.BRotateX_Click);
            // 
            // bRotateY
            // 
            this.bRotateY.Location = new System.Drawing.Point(599, 62);
            this.bRotateY.Name = "bRotateY";
            this.bRotateY.Size = new System.Drawing.Size(76, 69);
            this.bRotateY.TabIndex = 2;
            this.bRotateY.Text = "Obrót Y";
            this.bRotateY.UseVisualStyleBackColor = true;
            this.bRotateY.Click += new System.EventHandler(this.BRotateY_Click);
            // 
            // bRotateZ
            // 
            this.bRotateZ.Location = new System.Drawing.Point(681, 62);
            this.bRotateZ.Name = "bRotateZ";
            this.bRotateZ.Size = new System.Drawing.Size(75, 69);
            this.bRotateZ.TabIndex = 3;
            this.bRotateZ.Text = "Obrót Z";
            this.bRotateZ.UseVisualStyleBackColor = true;
            this.bRotateZ.Click += new System.EventHandler(this.BRotateZ_Click);
            // 
            // bScaleUp
            // 
            this.bScaleUp.Location = new System.Drawing.Point(681, 137);
            this.bScaleUp.Name = "bScaleUp";
            this.bScaleUp.Size = new System.Drawing.Size(75, 72);
            this.bScaleUp.TabIndex = 6;
            this.bScaleUp.Text = "+";
            this.bScaleUp.UseVisualStyleBackColor = true;
            this.bScaleUp.Click += new System.EventHandler(this.BScaleUp_Click);
            // 
            // bUp
            // 
            this.bUp.Location = new System.Drawing.Point(599, 137);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(76, 72);
            this.bUp.TabIndex = 5;
            this.bUp.Text = "/\\\r\n";
            this.bUp.UseVisualStyleBackColor = true;
            this.bUp.Click += new System.EventHandler(this.BUp_Click);
            // 
            // bDown
            // 
            this.bDown.Location = new System.Drawing.Point(599, 215);
            this.bDown.Name = "bDown";
            this.bDown.Size = new System.Drawing.Size(76, 61);
            this.bDown.TabIndex = 4;
            this.bDown.Text = "\\/";
            this.bDown.UseVisualStyleBackColor = true;
            this.bDown.Click += new System.EventHandler(this.BDown_Click);
            // 
            // bRight
            // 
            this.bRight.Location = new System.Drawing.Point(681, 215);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(75, 61);
            this.bRight.TabIndex = 9;
            this.bRight.Text = ">";
            this.bRight.UseVisualStyleBackColor = true;
            this.bRight.Click += new System.EventHandler(this.BRight_Click);
            // 
            // bLeft
            // 
            this.bLeft.Location = new System.Drawing.Point(517, 215);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(76, 61);
            this.bLeft.TabIndex = 7;
            this.bLeft.Text = "<";
            this.bLeft.UseVisualStyleBackColor = true;
            this.bLeft.Click += new System.EventHandler(this.BLeft_Click);
            // 
            // bScaleDown
            // 
            this.bScaleDown.Location = new System.Drawing.Point(517, 137);
            this.bScaleDown.Name = "bScaleDown";
            this.bScaleDown.Size = new System.Drawing.Size(77, 72);
            this.bScaleDown.TabIndex = 10;
            this.bScaleDown.Text = "--";
            this.bScaleDown.UseVisualStyleBackColor = true;
            this.bScaleDown.Click += new System.EventHandler(this.BScaleDown_Click);
            // 
            // bLight
            // 
            this.bLight.Location = new System.Drawing.Point(517, 283);
            this.bLight.Name = "bLight";
            this.bLight.Size = new System.Drawing.Size(239, 71);
            this.bLight.TabIndex = 11;
            this.bLight.Text = "Przełącz światło";
            this.bLight.UseVisualStyleBackColor = true;
            this.bLight.Click += new System.EventHandler(this.BLight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bLight);
            this.Controls.Add(this.bScaleDown);
            this.Controls.Add(this.bRight);
            this.Controls.Add(this.bLeft);
            this.Controls.Add(this.bScaleUp);
            this.Controls.Add(this.bUp);
            this.Controls.Add(this.bDown);
            this.Controls.Add(this.bRotateZ);
            this.Controls.Add(this.bRotateY);
            this.Controls.Add(this.bRotateX);
            this.Controls.Add(this.pSpace);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pSpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pSpace;
        private System.Windows.Forms.Button bRotateX;
        private System.Windows.Forms.Button bRotateY;
        private System.Windows.Forms.Button bRotateZ;
        private System.Windows.Forms.Button bScaleUp;
        private System.Windows.Forms.Button bUp;
        private System.Windows.Forms.Button bDown;
        private System.Windows.Forms.Button bRight;
        private System.Windows.Forms.Button bLeft;
        private System.Windows.Forms.Button bScaleDown;
        private System.Windows.Forms.Button bLight;
    }
}

