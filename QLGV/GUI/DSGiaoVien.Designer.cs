namespace GUI
{
    partial class DSGiaoVien
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtGiaoVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnFindName = new System.Windows.Forms.Button();
            this.btnFindGender = new System.Windows.Forms.Button();
            this.btnFindSubject = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnWatchSchedule = new System.Windows.Forms.Button();
            this.btnFindCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(462, 456);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 42);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(278, 456);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(184, 42);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 456);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 42);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(239, 374);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 22);
            this.txtName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên giáo viên";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(42, 371);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(77, 22);
            this.txtID.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // dtGiaoVien
            // 
            this.dtGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGiaoVien.Location = new System.Drawing.Point(12, 59);
            this.dtGiaoVien.Name = "dtGiaoVien";
            this.dtGiaoVien.RowHeadersWidth = 51;
            this.dtGiaoVien.RowTemplate.Height = 24;
            this.dtGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGiaoVien.Size = new System.Drawing.Size(869, 291);
            this.dtGiaoVien.TabIndex = 11;
            this.dtGiaoVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGiaoVien_CellContentClick);
            this.dtGiaoVien.Click += new System.EventHandler(this.dtGiaoVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Giáo Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(696, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ngày sinh";
            // 
            // dateBirthday
            // 
            this.dateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirthday.Location = new System.Drawing.Point(564, 376);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(132, 22);
            this.dateBirthday.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Môn học";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(88, 413);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(118, 24);
            this.cboMonHoc.TabIndex = 24;
            this.cboMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMonHoc_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(276, 413);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(161, 22);
            this.txtDiaChi.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(702, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Giới tính";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(762, 373);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(119, 24);
            this.cboGioiTinh.TabIndex = 28;
            // 
            // btnFindName
            // 
            this.btnFindName.Location = new System.Drawing.Point(345, 504);
            this.btnFindName.Name = "btnFindName";
            this.btnFindName.Size = new System.Drawing.Size(176, 42);
            this.btnFindName.TabIndex = 29;
            this.btnFindName.Text = "Tìm kiếm theo tên";
            this.btnFindName.UseVisualStyleBackColor = true;
            this.btnFindName.Click += new System.EventHandler(this.btnFindName_Click);
            // 
            // btnFindGender
            // 
            this.btnFindGender.Location = new System.Drawing.Point(527, 504);
            this.btnFindGender.Name = "btnFindGender";
            this.btnFindGender.Size = new System.Drawing.Size(176, 42);
            this.btnFindGender.TabIndex = 30;
            this.btnFindGender.Text = "Tìm kiếm theo giới tính";
            this.btnFindGender.UseVisualStyleBackColor = true;
            this.btnFindGender.Click += new System.EventHandler(this.btnFindGender_Click);
            // 
            // btnFindSubject
            // 
            this.btnFindSubject.Location = new System.Drawing.Point(709, 504);
            this.btnFindSubject.Name = "btnFindSubject";
            this.btnFindSubject.Size = new System.Drawing.Size(176, 42);
            this.btnFindSubject.TabIndex = 31;
            this.btnFindSubject.Text = "Tìm kiếm theo môn học";
            this.btnFindSubject.UseVisualStyleBackColor = true;
            this.btnFindSubject.Click += new System.EventHandler(this.btnFindSubject_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(443, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Lương";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(493, 413);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(146, 22);
            this.txtLuong.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(645, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Số điện thoại";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(735, 413);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(146, 22);
            this.txtSoDienThoai.TabIndex = 36;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(12, 504);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(144, 42);
            this.btnShowAll.TabIndex = 37;
            this.btnShowAll.Text = "Hiển thị tất cả";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnWatchSchedule
            // 
            this.btnWatchSchedule.Location = new System.Drawing.Point(644, 456);
            this.btnWatchSchedule.Name = "btnWatchSchedule";
            this.btnWatchSchedule.Size = new System.Drawing.Size(176, 42);
            this.btnWatchSchedule.TabIndex = 38;
            this.btnWatchSchedule.Text = "Xem thời khóa biểu";
            this.btnWatchSchedule.UseVisualStyleBackColor = true;
            this.btnWatchSchedule.Click += new System.EventHandler(this.btnWatchSchedule_Click);
            // 
            // btnFindCode
            // 
            this.btnFindCode.Location = new System.Drawing.Point(162, 504);
            this.btnFindCode.Name = "btnFindCode";
            this.btnFindCode.Size = new System.Drawing.Size(176, 42);
            this.btnFindCode.TabIndex = 39;
            this.btnFindCode.Text = "Tìm kiếm theo mã";
            this.btnFindCode.UseVisualStyleBackColor = true;
            this.btnFindCode.Click += new System.EventHandler(this.btnFindCode_Click);
            // 
            // DSGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 560);
            this.Controls.Add(this.btnFindCode);
            this.Controls.Add(this.btnWatchSchedule);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnFindSubject);
            this.Controls.Add(this.btnFindGender);
            this.Controls.Add(this.btnFindName);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateBirthday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtGiaoVien);
            this.Controls.Add(this.label1);
            this.Name = "DSGiaoVien";
            this.Text = "Danh sách giáo viên";
            this.Load += new System.EventHandler(this.DSGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtGiaoVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Button btnFindName;
        private System.Windows.Forms.Button btnFindGender;
        private System.Windows.Forms.Button btnFindSubject;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnWatchSchedule;
        private System.Windows.Forms.Button btnFindCode;
    }
}