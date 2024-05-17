namespace GUI
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDays = new System.Windows.Forms.Label();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.btnControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.BackColor = System.Drawing.Color.Transparent;
            this.lbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDays.Location = new System.Drawing.Point(13, 10);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(34, 25);
            this.lbDays.TabIndex = 0;
            this.lbDays.Text = "00";
            this.lbDays.Click += new System.EventHandler(this.lbDays_Click);
            // 
            // lbPeriod
            // 
            this.lbPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lbPeriod.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeriod.ForeColor = System.Drawing.Color.White;
            this.lbPeriod.Location = new System.Drawing.Point(41, 10);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(111, 74);
            this.lbPeriod.TabIndex = 1;
            this.lbPeriod.Text = "0";
            this.lbPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPeriod.Visible = false;
            this.lbPeriod.Click += new System.EventHandler(this.lbPeriod_Click);
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.Transparent;
            this.btnControl.Location = new System.Drawing.Point(0, 0);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(167, 100);
            this.btnControl.TabIndex = 2;
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbPeriod);
            this.Controls.Add(this.lbDays);
            this.Controls.Add(this.btnControl);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(167, 100);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Label lbPeriod;
        private System.Windows.Forms.Button btnControl;
    }
}
