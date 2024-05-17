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
    public partial class DoiMatKhau : Form
    {
        TaiKhoan_DTO tk;
        public DoiMatKhau(TaiKhoan_DTO _tk)
        {
            InitializeComponent();
            tk = _tk;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //this.ReturnValue1 = "Something";
            //this.ReturnValue2 = DateTime.Now.ToString(); //example

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng mật khẩu đã nhập", "Thông báo");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo");
            }
            else if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập xác nhận mật khẩu", "Thông báo");
            }    
            else
            {
                tk.matkhau = txtPassword.Text;

                if (TaiKhoan_BUS.DoiMatKhau(tk) == false)
                {
                    MessageBox.Show("Đổi mật khẩu thất bại.", "Thông báo");
                    return;
                }

                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
            if (tk.chucvu_id.Trim() == "gvbm")
            {
                GiaoVien_DTO gv = GiaoVien_BUS.LayThongTinGiaoVien(tk.taikhoan);
                lbName.Text = String.Format(@"{0} ({1})", gv.name, tk.taikhoan);
            } else
            {
                lbName.Text = String.Format(@"{0}", tk.taikhoan);
            }


        }

        private void togglePwd_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !togglePwd.Checked;
        }

        private void toggleConfirmPwd_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = !toggleConfirmPwd.Checked;
        }
    }
}
