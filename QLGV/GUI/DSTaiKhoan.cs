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
    public partial class DSTaiKhoan : Form
    {
        public DSTaiKhoan()
        {
            InitializeComponent();
        }

        private void HienThiCboChucVu ()
        {
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayDSChucVu();
            cboRole.DataSource = lstChucVu;
            cboRole.DisplayMember = "name";
            cboRole.ValueMember = "id";
        }

        private void HienThiDSTaiKhoan()
        {
            List<TaiKhoan_DTO> lstTaiKhoan = TaiKhoan_BUS.LayDSTaiKhoan();
            dtTaiKhoan.DataSource = lstTaiKhoan;
            dtTaiKhoan.Columns["id"].HeaderText = "Mã tài khoản";
            dtTaiKhoan.Columns["taikhoan"].HeaderText = "Tên tài khoản";
            dtTaiKhoan.Columns["ten_chucvu"].HeaderText = "Chức vụ";
            dtTaiKhoan.Columns["matkhau"].Visible = false;
            dtTaiKhoan.Columns["chucvu_id"].Visible = false;
        }


        private void DSTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiCboChucVu();
            HienThiDSTaiKhoan();
        }

        private void dtTaiKhoan_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtTaiKhoan.SelectedRows[0];
            txtID.Text = r.Cells["id"].Value.ToString();
            txtName.Text = r.Cells["taikhoan"].Value.ToString();
            cboRole.SelectedIndex = cboRole.FindStringExact(r.Cells["ten_chucvu"].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo");
                return;
            }

            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.taikhoan = txtName.Text;
            tk.chucvu_id = cboRole.SelectedValue.ToString();

            if (TaiKhoan_BUS.ThemTaiKhoan(tk) == false)
            {
                MessageBox.Show("Không thêm được.", "Thông báo");
                return;
            }

            HienThiDSTaiKhoan();
            MessageBox.Show("Đã thêm tài khoản với mật khẩu mặc định là 123456.", "Thông báo");
            txtID.Text = "";
            txtID.Name = "";
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.taikhoan = txtName.Text;
            tk.chucvu_id = cboRole.SelectedValue.ToString();
            tk.id = txtID.Text;
            DoiMatKhau formDMK = new DoiMatKhau(tk);
            formDMK.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.id = txtID.Text;
            tk.taikhoan = txtName.Text;
            tk.chucvu_id = cboRole.SelectedValue.ToString();

            if (TaiKhoan_BUS.SuaTaiKhoan(tk) == false)
            {
                MessageBox.Show("Không sửa được.", "Thông báo");
                return;
            }

            HienThiDSTaiKhoan();
            MessageBox.Show("Đã sửa tài khoản.", "Thông báo");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản!", "Thông báo");
                return;
            }

            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.id = txtID.Text;
            tk.taikhoan = txtName.Text;

            DialogResult confirm = MessageBox.Show(String.Format(@"Bạn có chắc muốn xóa tài khoản {0}", tk.taikhoan), "Xác nhận xóa", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (confirm == DialogResult.Yes)
            {
                if (TaiKhoan_BUS.XoaTaiKhoan(tk) == false)
                {
                    MessageBox.Show("Không xóa được.", "Thông báo");
                    return;
                }

                HienThiDSTaiKhoan();
                MessageBox.Show(String.Format(@"Đã xóa tài khoản {0}", tk.taikhoan), "Thông báo");
                txtID.Text = "";
                txtID.Name = "";
            }
        }
    }
}
