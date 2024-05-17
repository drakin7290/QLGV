using DTO;
using BUS;
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
    public partial class ChiTietThoiKhoaBieu : Form
    {
        GiaoVien_DTO gv;
        DateTime ngayday;
        TaiKhoan_DTO tk;
        public ChiTietThoiKhoaBieu(GiaoVien_DTO _gv, DateTime _ngayday)
        {
            InitializeComponent();
            this.gv = _gv;
            this.ngayday = _ngayday;
        }

        private void HienThiCboMonHoc()
        {
            List<MonHoc_DTO> lstMonHoc = MonHoc_BUS.LayDSMonHoc();
            cboMonHoc.DataSource = lstMonHoc;
            cboMonHoc.DisplayMember = "name";
            cboMonHoc.ValueMember = "id";
        }

        private ThoiKhoaBieu_DTO LayThongTinThoiKhoaBieu (Boolean isSkipGetID = false)
        {
            if (txtID.Text == "" || !isSkipGetID)
            {
                MessageBox.Show("Vui lòng nhập id thời khóa biểu", "Thông báo");
                return null;
            }
            ThoiKhoaBieu_DTO tkb = new ThoiKhoaBieu_DTO();
            return tkb;
        }


        private void HienThiChiTietThoiKhoaBieu ()
        {
            List<ThoiKhoaBieu_DTO> lstThoiKhoaBieu = ThoiKhoaBieu_BUS.LayDSThoiKhoaBieu(this.gv.id, this.ngayday);
            if (lstThoiKhoaBieu != null && lstThoiKhoaBieu.Count() > 0)
            {
                dtThoiKhoaBieu.DataSource = lstThoiKhoaBieu;
                dtThoiKhoaBieu.Columns["id"].HeaderText = "Mã TKB";
                dtThoiKhoaBieu.Columns["ngayday"].HeaderText = "Ngày";
                dtThoiKhoaBieu.Columns["ten_monhoc"].HeaderText = "Dạy môn";
                dtThoiKhoaBieu.Columns["tietbatdau"].HeaderText = "Tiết bắt đầu";
                dtThoiKhoaBieu.Columns["tietketthuc"].HeaderText = "Tiết kết thúc";
                dtThoiKhoaBieu.Columns["ten_lop"].HeaderText = "Tên lớp";
                dtThoiKhoaBieu.Columns["ngayday"].HeaderText = "Ngày dạy";
                dtThoiKhoaBieu.Columns["id_giaovien"].Visible = false;
                dtThoiKhoaBieu.Columns["id_monhoc"].Visible = false;
            }
        }

        private void ChiTietThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            this.tk = GlobalVariable.tk;
            lbTenGiaoVien.Text = this.gv.name;
            lbNgayDay.Text = this.ngayday.ToShortDateString();

            if (tk.chucvu_id.Trim() == "admin")
            {
                btnAdd.Visible = true;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }

            HienThiChiTietThoiKhoaBieu();
            HienThiCboMonHoc();
        }

        private void dtThoiKhoaBieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dtThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtThoiKhoaBieu.SelectedRows[0];
            txtID.Text = r.Cells["id"].Value.ToString();
            txtTenLop.Text = r.Cells["ten_lop"].Value.ToString();
            numTietBatDau.Text = r.Cells["tietbatdau"].Value.ToString();
            numTietKetThuc.Text = r.Cells["tietketthuc"].Value.ToString();
            dateTeach.Text = r.Cells["ngayday"].Value.ToString();
            cboMonHoc.SelectedIndex = cboMonHoc.FindStringExact(r.Cells["ten_monhoc"].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThoiKhoaBieu_DTO tkb = LayThongTinThoiKhoaBieu(true);

        }
    }
}
