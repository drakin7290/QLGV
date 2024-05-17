namespace GUI
{
    partial class ChiTietThoiKhoaBieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNgayDay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTenGiaoVien = new System.Windows.Forms.Label();
            this.dtThoiKhoaBieu = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTeach = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numTietBatDau = new System.Windows.Forms.NumericUpDown();
            this.numTietKetThuc = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtThoiKhoaBieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietBatDau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietKetThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời khóa biểu, ngày ";
            // 
            // lbNgayDay
            // 
            this.lbNgayDay.AutoSize = true;
            this.lbNgayDay.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayDay.Location = new System.Drawing.Point(220, 18);
            this.lbNgayDay.Name = "lbNgayDay";
            this.lbNgayDay.Size = new System.Drawing.Size(40, 23);
            this.lbNgayDay.TabIndex = 1;
            this.lbNgayDay.Text = "xxx";
            this.lbNgayDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "của";
            // 
            // lbTenGiaoVien
            // 
            this.lbTenGiaoVien.AutoSize = true;
            this.lbTenGiaoVien.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenGiaoVien.Location = new System.Drawing.Point(51, 50);
            this.lbTenGiaoVien.Name = "lbTenGiaoVien";
            this.lbTenGiaoVien.Size = new System.Drawing.Size(40, 23);
            this.lbTenGiaoVien.TabIndex = 3;
            this.lbTenGiaoVien.Text = "yyy";
            // 
            // dtThoiKhoaBieu
            // 
            this.dtThoiKhoaBieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtThoiKhoaBieu.Location = new System.Drawing.Point(12, 91);
            this.dtThoiKhoaBieu.Name = "dtThoiKhoaBieu";
            this.dtThoiKhoaBieu.RowHeadersWidth = 51;
            this.dtThoiKhoaBieu.RowTemplate.Height = 24;
            this.dtThoiKhoaBieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtThoiKhoaBieu.Size = new System.Drawing.Size(780, 310);
            this.dtThoiKhoaBieu.TabIndex = 4;
            this.dtThoiKhoaBieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtThoiKhoaBieu_CellContentClick);
            this.dtThoiKhoaBieu.Click += new System.EventHandler(this.dtThoiKhoaBieu_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(146, 493);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 49);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm tiết";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(319, 493);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(167, 49);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa tiết";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(492, 493);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 49);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa tiết";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Tiết bắt đầu";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(161, 458);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(118, 24);
            this.cboMonHoc.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Môn học";
            // 
            // dateTeach
            // 
            this.dateTeach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTeach.Location = new System.Drawing.Point(605, 421);
            this.dateTeach.Name = "dateTeach";
            this.dateTeach.Size = new System.Drawing.Size(132, 22);
            this.dateTeach.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(696, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Ngày dạy";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(387, 419);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(120, 22);
            this.txtTenLop.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tên lớp";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(161, 424);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(118, 22);
            this.txtID.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(93, 424);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "ID";
            // 
            // numTietBatDau
            // 
            this.numTietBatDau.Location = new System.Drawing.Point(387, 458);
            this.numTietBatDau.Name = "numTietBatDau";
            this.numTietBatDau.Size = new System.Drawing.Size(120, 22);
            this.numTietBatDau.TabIndex = 48;
            // 
            // numTietKetThuc
            // 
            this.numTietKetThuc.Location = new System.Drawing.Point(617, 460);
            this.numTietKetThuc.Name = "numTietKetThuc";
            this.numTietKetThuc.Size = new System.Drawing.Size(120, 22);
            this.numTietKetThuc.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 49;
            this.label9.Text = "Tiết kết thúc";
            // 
            // ChiTietThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 551);
            this.Controls.Add(this.numTietKetThuc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numTietBatDau);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTeach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtThoiKhoaBieu);
            this.Controls.Add(this.lbTenGiaoVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNgayDay);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietThoiKhoaBieu";
            this.Text = "Chi tiết thời khóa biểu";
            this.Load += new System.EventHandler(this.ChiTietThoiKhoaBieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtThoiKhoaBieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietBatDau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietKetThuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNgayDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTenGiaoVien;
        private System.Windows.Forms.DataGridView dtThoiKhoaBieu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTeach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numTietBatDau;
        private System.Windows.Forms.NumericUpDown numTietKetThuc;
        private System.Windows.Forms.Label label9;
    }
}