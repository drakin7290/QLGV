using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class FormMonHoc : Form
    {
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void HienThiMonHoc ()
        {
            List<MonHoc_DTO> lstMonHoc = MonHoc_BUS.LayDSMonHoc();
            if (lstMonHoc != null && lstMonHoc.Count() > 0)
            {
                dtMonHoc.DataSource = lstMonHoc;

                dtMonHoc.Columns["id"].HeaderText = "Mã môn học";
                dtMonHoc.Columns["name"].HeaderText = "Tên môn học";
            }
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            HienThiMonHoc();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên môn học!", "Thông báo");
                return;
            }

            MonHoc_DTO mh = new MonHoc_DTO();
            mh.name = txtName.Text;

            if (MonHoc_BUS.ThemMonHoc(mh) == false)
            {
                MessageBox.Show("Không thêm được.", "Thông báo");
                return;
            }

            HienThiMonHoc();
            MessageBox.Show("Đã thêm môn học.", "Thông báo");
            txtID.Text = "";
            txtID.Name = "";
        }

        private void dtMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtMonHoc.SelectedRows[0];
            txtID.Text = r.Cells["id"].Value.ToString();
            txtName.Text = r.Cells["name"].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            MonHoc_DTO mh = new MonHoc_DTO();
            mh.id = txtID.Text;
            mh.name = txtName.Text;

            if (MonHoc_BUS.SuaMonHoc(mh) == false)
            {
                MessageBox.Show("Không sửa được.", "Thông báo");
                return;
            }

            HienThiMonHoc();
            MessageBox.Show("Đã sửa môn học.", "Thông báo");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn môn học!", "Thông báo");
                return;
            }

            MonHoc_DTO mh = new MonHoc_DTO();
            mh.id = txtID.Text;
            mh.name = txtName.Text;

            DialogResult confirm = MessageBox.Show(String.Format(@"Bạn có chắc muốn xóa môn {0}", mh.name), "Xác nhận xóa", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (confirm == DialogResult.Yes)
            {
                if (MonHoc_BUS.XoaMonHoc(mh) == false)
                {
                    MessageBox.Show("Không xóa được.", "Thông báo");
                    return;
                }

                HienThiMonHoc();
                MessageBox.Show(String.Format(@"Đã xóa môn học {0}", mh.name), "Thông báo");
                txtID.Text = "";
                txtID.Name = "";
            }
        }
    }
}
