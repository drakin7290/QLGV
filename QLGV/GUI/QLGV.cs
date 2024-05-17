using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class QLGV : Form
    {
        TaiKhoan_DTO tk;
        DangNhap formDN;
        public QLGV(DangNhap _formDN)
        {
            InitializeComponent();
            
            formDN = _formDN;
        }

        private void infoTooltrip_Click(object sender, EventArgs e)
        {
            ThongTinGiaoVien thongtin = new ThongTinGiaoVien(tk);
            thongtin.ShowDialog();
        }

        private void subjectSubMenutrip_Click(object sender, EventArgs e)
        {
            FormMonHoc monHoc = new FormMonHoc();
            monHoc.ShowDialog();
        }

        private void teacherSubMenutrip_Click(object sender, EventArgs e)
        {
            DSGiaoVien dSGiaoVien = new DSGiaoVien();
            dSGiaoVien.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QLGV_Load(object sender, EventArgs e)
        {
            this.tk = GlobalVariable.tk;
            lblUsername.Text = this.tk.taikhoan;
            string id = this.tk.chucvu_id;
            lblChucVu.Text = ChucVu_BUS.LayChucVu(id).name;

            string role = this.tk.chucvu_id.Trim();

            switch (role) {
                case "gvbm":
                    infoTooltrip.Visible = true;
                    scheduleTooltripMenu.Visible = true;
                    break;
                case "admin":
                    manageTooltrip.Visible = true;
                    break;
            }
        }

        private void scheduleTooltripMenu_Click(object sender, EventArgs e)
        {
            GiaoVien_DTO gv = GiaoVien_BUS.LayThongTinGiaoVien(this.tk.taikhoan);
            FormThoiKhoaBieu tkb = new FormThoiKhoaBieu(gv);
            tkb.ShowDialog();
        }

        private void accountSubMenutrip_Click(object sender, EventArgs e)
        {
            DSTaiKhoan dstk = new DSTaiKhoan();
            dstk.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            formDN.Show();
            GlobalVariable.tk = null;
            this.Close();
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            DoiMatKhau formDMK = new DoiMatKhau(tk);
            formDMK.ShowDialog();
        }

        private void teacherReportSubTooltrip_Click(object sender, EventArgs e)
        {
            BCGiaoVien bc = new BCGiaoVien();
            bc.ShowDialog();
        }
    }
}
