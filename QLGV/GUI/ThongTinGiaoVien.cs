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
    public partial class ThongTinGiaoVien : Form
    {
        TaiKhoan_DTO tk;
        public ThongTinGiaoVien(TaiKhoan_DTO _tk)
        {
            InitializeComponent();
            tk = _tk;
        }
        private void HienThiThongTin ()
        {
            if (tk != null)
            {
                GiaoVien_DTO gv = GiaoVien_BUS.LayThongTinGiaoVien(tk.taikhoan);
                txtName.Text = gv.name;
                cboGender.SelectedIndex = cboGender.FindStringExact(gv.gioitinh);
                if (gv.gioitinh.Trim() == "Nam")
                {
                    pictureAvatar.Image = Properties.Resources.male;
                }
                else
                {
                    pictureAvatar.Image = Properties.Resources.female;
                }
                dtNgaySinh.Value = DateTime.Parse(gv.ngaysinh.ToString());
                txtDiaChi.Text = gv.diachi;
                txtSoDienThoai.Text = gv.sodienthoai;
                txtTienLuong.Text = gv.luong.ToString();
                cboMonHoc.SelectedIndex = cboMonHoc.FindStringExact(gv.name_monhoc);


            }
        }

        private void HienThiCboMonHoc()
        {
            List<MonHoc_DTO> lstMonHoc = MonHoc_BUS.LayDSMonHoc();
            cboMonHoc.DataSource = lstMonHoc;
            cboMonHoc.DisplayMember = "name";
            cboMonHoc.ValueMember = "id";
        }
        private void ThongTinGiaoVien_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
            HienThiCboMonHoc();
        }

        private void btnUpdateInformation_Click(object sender, EventArgs e)
        {
            if (tk.taikhoan == "")
            {
                MessageBox.Show("Không thể cập nhật thông tin!", "Thông báo");
                return;
            }

            GiaoVien_DTO gv = new GiaoVien_DTO();
            gv.id = tk.taikhoan;
            gv.name = txtName.Text;
            gv.diachi = txtDiaChi.Text;
            gv.ngaysinh = DateTime.Parse(dtNgaySinh.Text);
            gv.gioitinh = cboGender.Text;
            gv.id_monhoc = cboMonHoc.SelectedValue.ToString();
            gv.sodienthoai = txtSoDienThoai.Text;

            if (GiaoVien_BUS.SuaGiaoVien(gv) == false)
            {
                MessageBox.Show("Không sửa được.", "Thông báo");
                return;
            }

            HienThiThongTin();
            MessageBox.Show("Đã sửa giáo viên.", "Thông báo");
        }
    }
}
