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

namespace GUI
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }


        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }


        private void txtPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string taikhoan = txtUsername.Text;
            string matkhau = txtPassword.Text;

            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk = TaiKhoan_BUS.LayTaiKhoan(taikhoan, matkhau);

            if (tk != null )
            {
                QLGV qLGV = new QLGV(this);
                GlobalVariable.tk = tk;
                qLGV.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo");
            }
        }

        private void togglePwd_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !togglePwd.Checked;
        }
    }
}
