namespace GUI
{
    partial class QLGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLGV));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoTooltrip = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTooltrip = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectSubMenutrip = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherSubMenutrip = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSubMenutrip = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleTooltripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherReportSubTooltrip = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoTooltrip,
            this.manageTooltrip,
            this.scheduleTooltripMenu,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoTooltrip
            // 
            this.infoTooltrip.Name = "infoTooltrip";
            this.infoTooltrip.Size = new System.Drawing.Size(84, 24);
            this.infoTooltrip.Text = "Thông tin";
            this.infoTooltrip.Visible = false;
            this.infoTooltrip.Click += new System.EventHandler(this.infoTooltrip_Click);
            // 
            // manageTooltrip
            // 
            this.manageTooltrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subjectSubMenutrip,
            this.teacherSubMenutrip,
            this.accountSubMenutrip});
            this.manageTooltrip.Name = "manageTooltrip";
            this.manageTooltrip.Size = new System.Drawing.Size(71, 24);
            this.manageTooltrip.Text = "Quản lý";
            this.manageTooltrip.Visible = false;
            // 
            // subjectSubMenutrip
            // 
            this.subjectSubMenutrip.Name = "subjectSubMenutrip";
            this.subjectSubMenutrip.Size = new System.Drawing.Size(146, 26);
            this.subjectSubMenutrip.Text = "Môn học";
            this.subjectSubMenutrip.Click += new System.EventHandler(this.subjectSubMenutrip_Click);
            // 
            // teacherSubMenutrip
            // 
            this.teacherSubMenutrip.Name = "teacherSubMenutrip";
            this.teacherSubMenutrip.Size = new System.Drawing.Size(146, 26);
            this.teacherSubMenutrip.Text = "Giáo viên";
            this.teacherSubMenutrip.Click += new System.EventHandler(this.teacherSubMenutrip_Click);
            // 
            // accountSubMenutrip
            // 
            this.accountSubMenutrip.Name = "accountSubMenutrip";
            this.accountSubMenutrip.Size = new System.Drawing.Size(146, 26);
            this.accountSubMenutrip.Text = "Tài khoản";
            this.accountSubMenutrip.Click += new System.EventHandler(this.accountSubMenutrip_Click);
            // 
            // scheduleTooltripMenu
            // 
            this.scheduleTooltripMenu.Name = "scheduleTooltripMenu";
            this.scheduleTooltripMenu.Size = new System.Drawing.Size(119, 24);
            this.scheduleTooltripMenu.Text = "Thời khóa biểu";
            this.scheduleTooltripMenu.Visible = false;
            this.scheduleTooltripMenu.Click += new System.EventHandler(this.scheduleTooltripMenu_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherReportSubTooltrip});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // teacherReportSubTooltrip
            // 
            this.teacherReportSubTooltrip.Name = "teacherReportSubTooltrip";
            this.teacherReportSubTooltrip.Size = new System.Drawing.Size(279, 26);
            this.teacherReportSubTooltrip.Text = "Báo cáo giáo viên theo tháng";
            this.teacherReportSubTooltrip.Click += new System.EventHandler(this.teacherReportSubTooltrip_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnChangePwd);
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.lblChucVu);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(532, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.ForeColor = System.Drawing.Color.Black;
            this.btnChangePwd.Location = new System.Drawing.Point(11, 87);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(146, 41);
            this.btnChangePwd.TabIndex = 5;
            this.btnChangePwd.Text = "Đổi mật khẩu";
            this.btnChangePwd.UseVisualStyleBackColor = true;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(165, 87);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(146, 41);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChucVu.Location = new System.Drawing.Point(88, 49);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(30, 20);
            this.lblChucVu.TabIndex = 3;
            this.lblChucVu.Text = "---";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsername.Location = new System.Drawing.Point(127, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(30, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // QLGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(861, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLGV";
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.QLGV_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoTooltrip;
        private System.Windows.Forms.ToolStripMenuItem manageTooltrip;
        private System.Windows.Forms.ToolStripMenuItem subjectSubMenutrip;
        private System.Windows.Forms.ToolStripMenuItem teacherSubMenutrip;
        private System.Windows.Forms.ToolStripMenuItem scheduleTooltripMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.ToolStripMenuItem accountSubMenutrip;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherReportSubTooltrip;
    }
}