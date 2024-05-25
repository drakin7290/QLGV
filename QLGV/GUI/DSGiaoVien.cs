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
    public partial class DSGiaoVien : Form
    {
        string filterName = "";
        string filterValue = "";
        string filterMessage = "";
        public DSGiaoVien()
        {
            InitializeComponent();
        }

        private void HienThiCboMonHoc ()
        {
            List<MonHoc_DTO> lstMonHoc = MonHoc_BUS.LayDSMonHoc();
            cboMonHoc.DataSource = lstMonHoc;
            cboMonHoc.DisplayMember = "name";
            cboMonHoc.ValueMember = "id";
        }

        private GiaoVien_DTO LayThongTinGiaoVien (Boolean isAdd = false)
        {
            
            if ((txtName.Text == "" || txtLuong.Text == "") && isAdd)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return null;
            }
            if (txtID.Text == "" && !isAdd)
            {
                MessageBox.Show("Vui lòng nhập id giáo viên");
                return null;
            }
            GiaoVien_DTO gv = new GiaoVien_DTO();
            gv.id = txtID.Text;
            gv.name = txtName.Text;
            gv.diachi = txtDiaChi.Text;
            gv.ngaysinh = DateTime.Parse(dateBirthday.Text);
            gv.gioitinh = cboGioiTinh.Text;
            gv.id_monhoc = cboMonHoc.SelectedValue.ToString();
            gv.luong = int.Parse(txtLuong.Text);
            gv.sodienthoai = txtSoDienThoai.Text;
            return gv;
        }

        private void HienThiDanhSachGiaoVien()
        {
            List<GiaoVien_DTO> lstGiaoVien = GiaoVien_BUS.LayDSGiaoVien(this.filterName, this.filterValue);
            if (lstGiaoVien != null && lstGiaoVien.Count() > 0 )
            {
                dtGiaoVien.DataSource = lstGiaoVien;

                dtGiaoVien.Columns["id"].HeaderText = "Mã giáo viên";
                dtGiaoVien.Columns["name"].HeaderText = "Tên giáo viên";
                dtGiaoVien.Columns["gioitinh"].HeaderText = "Giới tính";
                dtGiaoVien.Columns["diachi"].HeaderText = "Địa chỉ";
                dtGiaoVien.Columns["sodienthoai"].HeaderText = "Số điện thoại";
                dtGiaoVien.Columns["luong"].HeaderText = "Lương";
                dtGiaoVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                dtGiaoVien.Columns["id_monhoc"].Visible = false;
                dtGiaoVien.Columns["name_monhoc"].HeaderText = "Môn học";
            }

            if (this.filterName != "" && this.filterValue != "" && (lstGiaoVien == null || lstGiaoVien.Count() == 0))
            {
                MessageBox.Show(filterMessage, "Tìm kiếm thất bại");
            }
        }
        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DSGiaoVien_Load(object sender, EventArgs e)
        {
            HienThiCboMonHoc();
            HienThiDanhSachGiaoVien();
        }

        private void dtGiaoVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtGiaoVien.SelectedRows[0];
            txtID.Text = r.Cells["id"].Value.ToString();
            txtName.Text = r.Cells["name"].Value.ToString();
            txtDiaChi.Text = r.Cells["diachi"].Value.ToString();
            txtLuong.Text = r.Cells["luong"].Value.ToString();
            txtSoDienThoai.Text = r.Cells["sodienthoai"].Value.ToString();
            dateBirthday.Text = r.Cells["ngaysinh"].Value.ToString();
            cboMonHoc.SelectedIndex = cboMonHoc.FindStringExact(r.Cells["name_monhoc"].Value.ToString());
            cboGioiTinh.SelectedIndex = cboGioiTinh.FindStringExact(r.Cells["gioitinh"].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giáo viên!", "Thông báo");
                return;
            }

            GiaoVien_DTO gv = new GiaoVien_DTO();
            gv.id = txtID.Text;
            gv.name = txtName.Text;

            DialogResult confirm = MessageBox.Show(String.Format(@"Bạn có chắc muốn xóa giáo viên {0}", gv.name), "Xác nhận xóa", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (confirm == DialogResult.Yes)
            {
                if (GiaoVien_BUS.XoaGiaoVien(gv) == false)
                {
                    MessageBox.Show("Không xóa được.", "Thông báo");
                    return;
                }

                HienThiDanhSachGiaoVien();
                MessageBox.Show(String.Format(@"Đã xóa giáo viên {0}", gv.name), "Thông báo");
                txtID.Text = "";
            }
        }



        private void btnFindName_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên giáo viên", "Thông báo");
                return;
            }
            this.filterName = "name";
            this.filterValue = txtName.Text;
            this.filterMessage = string.Format(@"Không thể tìm kiếm giáo viên tên {0}", filterValue);
            HienThiDanhSachGiaoVien();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.filterName = "";
            this.filterValue = "";
            HienThiDanhSachGiaoVien();
        }



        private void btnFindGender_Click(object sender, EventArgs e)
        {
            if (cboGioiTinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo");
                return;
            }
            filterName = "gioitinh";
            filterValue = cboGioiTinh.Text;
            filterMessage = string.Format(@"Không thể tìm kiếm giáo viên giới tính {0}", filterValue);
            HienThiDanhSachGiaoVien();
        }

        private void btnFindSubject_Click(object sender, EventArgs e)
        {
            string idMonHoc = cboMonHoc.SelectedValue.ToString();
            if (idMonHoc == "")
            {
                MessageBox.Show("Vui lòng chọn môn học", "Thông báo");
                return;
            }
            filterName = "id_monhoc";
            filterValue = cboMonHoc.SelectedValue.ToString();
            filterMessage = string.Format(@"Không thể tìm kiếm giáo viên dạy môn {0}", cboMonHoc.Text);
            HienThiDanhSachGiaoVien();
        }

        private void btnWatchSchedule_Click(object sender, EventArgs e)
        {
            GiaoVien_DTO gv = LayThongTinGiaoVien();
            if (gv != null)
            {
                FormThoiKhoaBieu tkb = new FormThoiKhoaBieu(gv);
                tkb.ShowDialog();
            }
        }

        private void dtGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFindCode_Click(object sender, EventArgs e)
        {
            string idGiaoVien = txtID.Text;
            if (idGiaoVien == "")
            {
                MessageBox.Show("Vui lòng nhập id giáo viên", "Thông báo");
                return;
            }
            filterName = "id";
            filterValue = idGiaoVien;
            filterMessage = string.Format(@"Không thể tìm kiếm giáo viên có mã {0}", idGiaoVien);
            HienThiDanhSachGiaoVien();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giáo viên!", "Thông báo");
                return;
            }

            GiaoVien_DTO gv = LayThongTinGiaoVien();

            if (GiaoVien_BUS.SuaGiaoVien(gv) == false)
            {
                MessageBox.Show("Không sửa được.", "Thông báo");
                return;
            }

            HienThiDanhSachGiaoVien();
            MessageBox.Show("Đã sửa giáo viên.", "Thông báo");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            GiaoVien_DTO gv = LayThongTinGiaoVien();

            if (GiaoVien_BUS.ThemGiaoVien(gv) == false)
            {
                MessageBox.Show("Không thêm được.", "Thông báo");
                return;
            }

            HienThiDanhSachGiaoVien();
            MessageBox.Show("Đã thêm giáo viên", "Thông báo");
            txtID.Text = "";
        }
    }
}
